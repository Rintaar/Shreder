using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace BackupServer
{
    //Класс запускающий прослушиватель сервера. Пока сервер поднят - он прослушивает входящие синалы и создает новые потоки по приходу оных
    public class Server
    {
        TcpListener Listener; 
        public Server(int Port)
        {
            Listener = new TcpListener(IPAddress.Any, Port); 
            Listener.Start();
            while (true)
            {               
                TcpClient Client = Listener.AcceptTcpClient();
                Thread Thread = new Thread(new ParameterizedThreadStart(ClientThread));
                Thread.Start(Client);
            }
        }

        static void ClientThread(object StateInfo)
        {
            new Client((TcpClient)StateInfo);
        }

        ~Server()
        {
            if (Listener != null)
                Listener.Stop();
        }

        public static void ServerLog(string info)
        {
            try
            {
                string res = DateTime.Now.ToString() + " || " + info;
                Console.WriteLine(res);
                using (StreamWriter file = new StreamWriter(Directory.GetCurrentDirectory() + @"/Log.txt", true))
                {
                    file.WriteLine(res);
                    file.Flush();
                }
            }
            catch { }
        }
       
    }
}
