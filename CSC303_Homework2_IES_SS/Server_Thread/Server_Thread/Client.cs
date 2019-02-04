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
    class Client
    {

        public void loadClient()
        {
            Stock_Server server = new Stock_Server();
            Thread t = new Thread(server.Server);
            t.Start();

            using (TcpClient client = new TcpClient("localhost", 51111))
            using (NetworkStream n = client.GetStream())
            {
                BinaryWriter w = new BinaryWriter(n);
                Console.WriteLine("Please pick one of the following symbols: 'Goog', 'A', 'Hoo', 'NFL', 'HP'");
                string symbol = Console.ReadLine();
                w.Write(symbol);
                w.Flush();
                Console.WriteLine(new BinaryReader(n).ReadString());
            }
        }


    }
}
