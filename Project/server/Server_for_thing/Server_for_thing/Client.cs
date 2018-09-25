using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using ProfForTest;
using System.Text.RegularExpressions;

namespace BackupServer
{
    public class Client
    {
        private Stream strLocal;
        private NetworkStream strRemote;
        private string FileName;
        //сериализованный объект с информацией
        private Request sh = new Request();

        /*при старте нового клиента первым делом десериализуется объект с информацией. 
         В зависимости от полученной информации (permission) или запускается процесс получения данных с БД (GetInfo)
         или выполняется команда в зависимости от сигнала (trigger)
         для работы с клиентом класс Request должен содержать permission - trueБ что значит, что он смог подключиться к базе и доказать свою подлинность.
         * */
        public Client(TcpClient tclServer)
        {
            try
            {
                strRemote = tclServer.GetStream();
                sh = (Request)new BinaryFormatter().Deserialize(strRemote);                
                if (!sh.permission)
                {
                    GetInfo(strRemote);                    
                }
                else
                {
                    switch(sh.trigger)
                    {
                        case 1:
                            GetFile(tclServer, DBController.backupAdress.ToString() + @"\" +sh.login + @"\");
                            break;
                        case 2:
                            SendBackup(tclServer, strRemote, DBController.backupAdress.ToString() + @"\" + sh.login, "backup");
                            break;
                        case 3:
                            DBController.addnewUnit(sh.login, sh.password, sh.access_value);
                            break;
                        case 4:
                            DBController.ChangePassword(sh.login, sh.password);
                            break;
                        case 5:
                            DBController.ChangePermission(sh.login, sh.access_value);
                            break;
                        default:
                            Server.ServerLog("Попытка произвести несуществующую операцию");
                            break;
                    }
                }
                
            }  
            catch (Exception ex)
            {
                Server.ServerLog("Ошибка:" + ex.Message);
            }
            finally
            {
                tclServer.Close();
                strRemote.Close();
                try { Thread.CurrentThread.Abort(); }
                catch{}
                
            }

        }
        //получение бэкапа с сервера с последующей его разархивацией
        private void GetFile(TcpClient tclServer, string path)
        {
            if (path != null)
            {
                try
                {
                    int bytesSize = 0;
                    byte[] downBuffer = new byte[2048];
                    bytesSize = strRemote.Read(downBuffer, 0, 2048);
                    FileName = Encoding.ASCII.GetString(downBuffer, 0, bytesSize);
                    strLocal = new FileStream(path + FileName, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                    downBuffer = new byte[2048];
                    bytesSize = strRemote.Read(downBuffer, 0, 2048);
                    Server.ServerLog("Получение архива: \t" + FileName + "\r");
                    downBuffer = new byte[2048];
                    while ((bytesSize = strRemote.Read(downBuffer, 0, downBuffer.Length)) > 0)
                    {
                        strLocal.Write(downBuffer, 0, bytesSize);
                    }
                    strLocal.Close();
                    Server.ServerLog("Архив получен \t\t" + FileName);
                    Thread.Sleep(1000);
                    try
                    {
                        Compression.DeCompressionFolder(path + FileName, path);
                        Server.ServerLog("Архив разархивирован: \t" + FileName);
                        Thread.Sleep(1000);
                        File.Delete(path + FileName);
                    }
                    catch (Exception ex)
                    {
                        Server.ServerLog("Error:" + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    Server.ServerLog("Error:" + ex.Message);
                }
            }
        }
        //подключение к БД с целью авторизации клиента и заполнения сериализованного объекта данными в случае успеха.
        public void GetInfo(NetworkStream strRemote)
        {    
            try 
            {
                Server.ServerLog("Попытка получения информации с  " + sh.ipadress.ToString() + " о пользователе " + sh.login.ToString());
                if (DBController.CheckLogin(Regex.Escape(sh.login))) 
                {
                    if(DBController.CheckPassword(Regex.Escape(sh.login), Regex.Escape(sh.password)))
                    {
                        sh.permission = true;
                        DBController.returnInfo(sh);
                        Server.ServerLog("Авторизация успешна");
                    }
                    else 
                    {
                        sh.exception = "Неверный логин или пароль";
                        Server.ServerLog("Неверный логин или пароль");
                    }
                }
                else
                {
                    sh.exception = "Неверный логин или пароль";
                    Server.ServerLog("Неверный логин или пароль");
                }
            }
            catch (Exception ex)
            {
                Server.ServerLog("Error:" + ex.Message);
                sh.exception = ex.Message;
            }
            BinaryFormatter binaryFmt = new BinaryFormatter();
            binaryFmt.Serialize(strRemote, sh);        
        }
        private void SendBackup(TcpClient tclServer, NetworkStream strRemote, string path, string name)
        {
            System.Threading.Thread.CurrentThread.IsBackground = true;
            Server.ServerLog("Архивация бэкапа пользователя " + sh.login);
            Compression.CompressionFolder(path, name);
            Server.ServerLog("Бэкап заархивирован");
            string file =path + "\\" + name + ".zip";

            try
                {
                    Server.ServerLog("Отправка бэкапа пользователю " + sh.login + " на ip: "+ sh.ipadress);

                    byte[] byteSend = new byte[2048];
                    var fstFile = new FileStream(file, FileMode.Open, FileAccess.Read);
                    BinaryReader binFile = new BinaryReader(fstFile);
                    FileInfo fInfo = new FileInfo(file);
                    string fileName = fInfo.Name;
                    byte[] ByteFileName = new byte[2048];

                    ByteFileName = Encoding.ASCII.GetBytes(fileName.ToCharArray());
                    strRemote.Write(ByteFileName, 0, ByteFileName.Length);

                    long FileSize = fInfo.Length;
                    byte[] ByteFileSize = new byte[2048];
                    ByteFileSize = Encoding.ASCII.GetBytes(FileSize.ToString().ToCharArray());
                    strRemote.Write(ByteFileSize, 0, ByteFileSize.Length);
                    System.Threading.Thread.Sleep(100);

                    int bytesSize = 0;
                    byte[] downBuffer = new byte[2048];
                    while ((bytesSize = fstFile.Read(downBuffer, 0, downBuffer.Length)) > 0)
                    {
                        strRemote.Write(downBuffer, 0, bytesSize);
                    }
                    System.Threading.Thread.Sleep(500);
                    fstFile.Close();
                    File.Delete(file);
                    Server.ServerLog("Бэкап отправлен");
                }
                catch (Exception ex)
                {
                    Server.ServerLog("Ошибка");
                }
                finally
                {
                    System.Threading.Thread.Sleep(1000);
                 }
        }
    }

    }
