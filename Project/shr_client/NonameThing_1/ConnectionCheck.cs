using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Text;

namespace NonameThing_1
{
    public class ConnectionCheck
    {
        public enum ConnectionStatus
        {
            NotConnected,
            LimitedAccess,
            Connected
        }

        public static ConnectionStatus CheckInternet()
        {
            // Проверить подключение к dns.msftncsi.com
            try
            {
                IPHostEntry entry = Dns.GetHostEntry("dns.msftncsi.com");
                if (entry.AddressList.Length == 0)
                    return ConnectionStatus.NotConnected;
                else
                    if (!entry.AddressList[0].ToString().Equals("131.107.255.255"))
                        return ConnectionStatus.LimitedAccess;
            }
            catch
            {
                return ConnectionStatus.NotConnected;
            }

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("https://www.microsoft.com");
            try
            {
                HttpWebResponse responce = (HttpWebResponse)request.GetResponse();

                if (responce.StatusCode != HttpStatusCode.OK)
                    return ConnectionStatus.LimitedAccess;
                using (StreamReader sr = new StreamReader(responce.GetResponseStream()))
                {
                    if (sr.ReadToEnd().Equals("Microsoft NCSI"))
                    {
                        return ConnectionStatus.Connected;
                    }
                    else
                    {
                        return ConnectionStatus.LimitedAccess;
                    }
                }
            }
            catch
            {
                return ConnectionStatus.NotConnected;
            }
        }
    }
}
