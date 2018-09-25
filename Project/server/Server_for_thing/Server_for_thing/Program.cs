using System;
using System.IO;
using System.Net;

namespace BackupServer
{
    public static class MainProg
    {
        
        public static string serverName;
        public static string backupAdress;
        public static string mainport;
        public static int choise = 0;

        public static void Head()
        {
            Console.WriteLine("Backup Server [Version " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() + "]");
            Console.WriteLine("(c) Компания ElisHelper \n ");            
        }
        public static void Main(string[] args)
        {
            
            while (true)
            {
                serverName = Properties.Settings.Default.Server_Path.ToString();
                backupAdress = Properties.Settings.Default.Backup_Path.ToString();
                mainport = Properties.Settings.Default.Main_Port.ToString();
                Head();
                Console.WriteLine(" Выберите действие: \n 1. Запустить сервер \n 2. Изменить порт \n 3. Изменить адрес бэкапа \n 4. Показать информацию \n 5. Выключить программу \n");
                try
                {
                    choise = Convert.ToInt32(Console.ReadLine());
                    switch (choise)
                    {
                        case 1:
                            try
                            {
                                Console.Clear();
                                Head();
                                Console.WriteLine("Адрес сервера: \t" + Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString());
                                Console.WriteLine("Порт сервера:  \t" + mainport);
                                Console.WriteLine("Адрес бэкапа:  \t" + backupAdress);
                                Console.WriteLine("Сервер запущен...");
                                new Server(Convert.ToInt32(mainport));
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Ошибка:" + ex.Message);
                            }
                            break;
                        case 2:
                            try
                            {
                                Console.Clear();
                                Head();
                                Console.WriteLine("Текущий порт сервера:  \t" + mainport + "\nВведите новый порт:");
                                try
                                {
                                    int newport = Convert.ToInt32(Console.ReadLine());
                                    DBController.setMainPort(newport.ToString());
                                    Console.WriteLine("Выполнено успешно \nНовый порт: " + newport);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Ошибка:" + ex.Message);
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Ошибка:" + ex.Message);
                            }
                            break;
                        case 3:
                            try
                            {
                                Console.Clear();
                                Head();
                                Console.WriteLine("Текущий адрес бэкапа:  \t" + backupAdress + "\nВведите новый адрес:");
                                string backup = Console.ReadLine() + @"\Backup\";

                                try {
                                    Directory.Move(DBController.backupAdress, backup);
                                    DBController.setBackupAdress(backup);
                                    Console.WriteLine("Выполнено успешно \nНовый адрес: " + BackupServer.Properties.Settings.Default.Backup_Path.ToString());
                                }
                                catch { Console.WriteLine("Не удалось сменить адрес бэкапа. Введены недопустимые значения"); }

   
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Ошибка:" + ex.Message);
                            }
                            break;
                        case 4:
                            Console.Clear();
                            Head();
                            Server.ServerLog("Адрес сервера: \t" + Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString());
                            Server.ServerLog("Порт сервера:  \t" + mainport);
                            Server.ServerLog("Адрес бэкапа:  \t" + backupAdress);
                            Server.ServerLog("Адрес БД:  \t" + Directory.GetCurrentDirectory() + @"\Database\SH_Server.mdf");
                            break;
                        case 5:
                            return;
                            break;
                        case 2486:
                            DBController.setServeradress(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=" + Directory.GetCurrentDirectory() + @"\Database\SH_Server.mdf; Integrated Security=SSPI; User ID=DBAdmin;Password=10438F25; Connect Timeout=30");
                            try { Directory.Move(DBController.backupAdress, @"C:\Temp\Backup"); }
                            catch { Directory.CreateDirectory(@"C:\Temp\Backup"); }
                            DBController.setBackupAdress(@"C:\Temp\Backup");
                            DBController.setMainPort("2112");
                            break;
                        default:
                            Console.WriteLine("Варианта" + choise + "не существует");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Введены неправильные символы. Допустимы долько цифры.");
                }
                Console.WriteLine("Нажмите любую клавишу для продолжения...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}