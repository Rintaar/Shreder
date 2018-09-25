using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NonameThing_1
{
    class User
    {
        string name;
        int permission;
        //string folder;
        string password;

        public User(string name, string password, int permission)
        {
            this.name = name;
            this.password = password;
            this.permission = permission;
            //this.folder = folder;
        }

        public string get_Name()
        {
            return name;
        }

        public string get_Password()
        {
            return password;
        }

        public int get_Prmisssion()
        {
            return permission;
        }

        public string get_Folder()
        {
            return "";
        }

    }
}
