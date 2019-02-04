using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server_Thread
{
    class Stock_Server
    {
        public void Server()
        {
            Dictionary<string, Stock> stockDictionary = new Dictionary<string, Stock>();
            stockDictionary.Add("Goog", new Stock("Goog", "Google Inc.", 621.76));
            stockDictionary.Add("A", new Stock("A", "AT&T", 543.24));
            stockDictionary.Add("Hoo", new Stock("Hoo", "Yahoo", 333.33));
            stockDictionary.Add("NFL", new Stock("NFL", "NFL", 555.55));
            stockDictionary.Add("HP", new Stock("HP", "Hewlett Packard", 364.45));


            TcpListener listener = new TcpListener(IPAddress.Any, 51111);
            listener.Start();
            using (TcpClient c = listener.AcceptTcpClient())
            using (NetworkStream n = c.GetStream())
            {
                string msg = new BinaryReader(n).ReadString();
                BinaryWriter w = new BinaryWriter(n);
                //stockDictionary[msg].StockInfo();
                string info = stockDictionary[msg].StockInfo();
                w.Write(info);
                Console.WriteLine(DateTime.Now);
                Timer tmr = new Timer(Info, info, 15000, 15000);
                w.Flush();
            }
            listener.Stop();
        }

        static void Info(object data)
        {
            Console.WriteLine(data);
            Console.WriteLine(DateTime.Now);
        }
    }
}
