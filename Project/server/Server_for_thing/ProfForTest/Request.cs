using System;


namespace ProfForTest
{

        [Serializable]
        public class Request
    {
            public bool permission = false;
            public int access_value = 0;
            public string login = "";
            public string password = "";
            public string exception = "";
            public int port = 2112;
            public string ipadress = "";
            public int trigger = 0;
        public string info = "";
            public Request(string log, string pwd, int acc)
            {
                login = log;
                password = pwd;
                access_value = acc;
            }
            public Request()
            { }
            public Request(bool perm)
            {
                permission = perm;
            }
            public Request(bool perm, string exs)
            {
                permission = perm;
                exception = exs;
            }
            public Request(string log, string pwd)
            {
                login = log;
                password = pwd;
            }
            public Request(string log,  int trig, bool perm)
            {
                login = log;
                trigger = trig;
                permission = perm;
            }
            public Request(string log, string ip, int trig, bool perm)
            {
                login = log;
                ipadress = ip;
                trigger = trig;
                permission = perm;
            }
        public Request(string log, string pwd, int acc, bool perm, string exs)
            {
                login = log;
                password = pwd;
                access_value = acc;
                permission = perm;
                exception = exs;
            }
            public void testPrint()
            {
                Console.WriteLine(login.ToString());
                Console.WriteLine(password.ToString());
                Console.WriteLine(access_value.ToString());
                Console.WriteLine(permission.ToString());
                Console.WriteLine(exception.ToString());
            }
        }
    }
