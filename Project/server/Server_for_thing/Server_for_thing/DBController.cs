using System;
using System.Data.SqlClient;
using System.IO;
using ProfForTest;
using System.Text;
using System.Security.Cryptography;

namespace BackupServer
{
    public class DBController
    {
        public static string serverName = Properties.Settings.Default.Server_Path.ToString();
        public static string backupAdress = Properties.Settings.Default.Backup_Path.ToString();
        public string _adr;
        public string _path;
        private static SqlConnection conn;
        
        public DBController()
        {
        }
        
        public static void setBackupAdress(string adress)
        {

            Properties.Settings.Default.Backup_Path = adress;
            Properties.Settings.Default.Save();
            backupAdress = adress;
        }
        public static void setServeradress(string adress)
        {
            Properties.Settings.Default.Server_Path = adress;
            Properties.Settings.Default.Save();
            serverName = adress;
        }
        public static void setMainPort(string adress)
        {
            Properties.Settings.Default.Main_Port = adress;
            Properties.Settings.Default.Save();
        }
        public void getData() {
            _path = serverName;
            _adr = backupAdress;
        }
        public static void openBase()
        {
            try
            {
                conn = new SqlConnection(serverName);
                conn.Open();
                Server.ServerLog("ServerVersion: " + conn.ServerVersion);
                Server.ServerLog("State: "+ conn.State);
            }
            catch
            {
                Server.ServerLog("Нет подключения / Неверные данные");
            }
        }
        public static void closeBase()
        {
            try
            {
                conn.Close();
                Server.ServerLog("Подключение закрыто");
            }
            catch
            {
                Server.ServerLog("Нет подключения / Неверные данные");
            }
        }
        public static void addnewUnit(string login, string pwd, int perm)
        {
            string path = backupAdress + "\\" + login;
            if (!CheckLogin(login))
            {
                using (conn = new SqlConnection(serverName))
                    openBase();
                    Server.ServerLog("Добавление пользователя " + login);
                    string query = "INSERT INTO users (login, password, permission, adress, info)  VALUES('" + login + "', '" + pwd + "', " + perm + ", '" + login + "', '" + 123 + "');";
                    var cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    Directory.CreateDirectory(path);
            }
            else Server.ServerLog("ОШИБКА. Такой логин уже используется");
        }
        public static void changeBackupAdress(string new_adress)
        {
            try
            {
                Directory.Move(backupAdress, new_adress);
                setBackupAdress(new_adress);
            }
            catch (Exception ex)
            {
                Server.ServerLog("Error:" + ex.Message);
            }
        }
        public static bool CheckLogin(string user)
        {
            if (user.Contains("'"))
                return false;
            else
            {
                using (conn = new SqlConnection(serverName))
                    try
                    {
                        conn.Open();
                        string query = "SELECT login FROM users WHERE login = '" + user + "' ";
                        var cmd = new SqlCommand(query, conn);
                        var rdr = cmd.ExecuteReader();
                        if (rdr.HasRows)
                            return true;
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        Server.ServerLog("Error:" + ex.Message);
                        return false;
                    }
                return false;
            }
        }
        public static bool CheckPassword(string user, string password)
        {
                using (conn = new SqlConnection(serverName))
                    try
                    {
                        conn.Open();
                        string query = "SELECT password FROM users WHERE login = '" + user + "'  AND password = '" + MD5_password(password) + "'";
                        var cmd = new SqlCommand(query, conn);
                        var rdr = cmd.ExecuteReader();
                        if (rdr.HasRows)
                            return true;
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        Server.ServerLog("Error:" + ex.Message);
                        return false;
                    }
                return false;
        }
        public static string returnBackupAdress(string user)
        {
            if (CheckLogin(user))
            {
                Directory.CreateDirectory(backupAdress + "\\" + user + "\\");
                return backupAdress + "\\" + user + "\\";
            }                
            else
                return null;
        }
        public static void ChangePermission(string login, int new_perm)
        {
            using (conn = new SqlConnection(serverName))
                try
                {
                    conn.Open();
                    string query = "UPDATE users SET permission = '" + new_perm + "' WHERE login = '" + login + "'";
                    var cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    Server.ServerLog("Разрешение сменили");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Server.ServerLog("Error:" + ex.Message);
                }
        }

        public static void CheckDir(string user)
        {
            if (CheckLogin(user))
                try { Directory.CreateDirectory(backupAdress + @"\" + user + @"\"); }
                catch { }
        }
        public static void returnInfo(Request info)
        {
            using (conn = new SqlConnection(serverName))
                try
                {
                    conn.Open();
                    string query = "SELECT permission, info FROM users WHERE login = '" + info.login + "'  AND password = '" + info.password + "'";
                    var cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    try
                    {
                        while (reader.Read())
                        {
                            info.access_value = Convert.ToInt32(reader["permission"].ToString());
                            info.info = reader["info"].ToString();
                        }
                    }
                    finally { reader.Close();}
                }
                catch (Exception ex)
                {
                    Server.ServerLog("Error:" + ex.Message);
                }
        }
        public static void ChangePassword(string user, string password)
        {
            using (conn = new SqlConnection(serverName))
                try
                {
                    conn.Open();
                    string query = "UPDATE users SET password = '" + MD5_password(password) + "' WHERE login = '" + user + "'";
                    var cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    Server.ServerLog("Разрешение сменили");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Server.ServerLog("Error:" + ex.Message);
                }
        }

         public static string MD5_password(string pwd)
        {
            byte[] hash = Encoding.ASCII.GetBytes(pwd);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] hashenc = md5.ComputeHash(hash);
            string result = "";
            foreach (var b in hashenc)
            {
                result += b.ToString("x2");
            }
            return result;
        }
    }

}

