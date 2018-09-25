using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NonameThing_1
{
    public class SysInfo
    {
        private User user;
        private string ServerIP;
        private int ServerPort;
        private int LocalPort;
        private string LocalIP;


        public SysInfo()
        {

        }

        public SysInfo(string login, string password, int permission, string ServerIP, int ServerPort, string LocalIP, int LocalPort)
        {
            user = new User(login, password, permission);
            this.ServerIP = ServerIP;
            this.LocalIP = LocalIP;
            this.LocalPort = LocalPort;
            this.ServerPort = ServerPort;
        }

        public string GetUserName()
        {
            return user.get_Name();
        }

        public string GetUserPas()
        {
            return user.get_Password();
        }

        public string GetServerIP()
        {
            return ServerIP;
        }

        public int GetServerPort()
        {
            return ServerPort;
        }

        public string GetLocalIP()
        {
            return LocalIP;
        }

        public int GetLocalPort()
        {
            return LocalPort;
        }

        public int GetPermission()
        {
            return user.get_Prmisssion();
        }

        public string BuDir { get; set; }

        public string LocalBuDir { get; set; }

        public string UserFIO { get; set; }
    }
}
