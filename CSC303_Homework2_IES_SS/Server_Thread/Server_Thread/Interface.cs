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
    //Created for Sullivan Universities Winter 2011 Operating Systems class 
    //Ivan Starbuck and Sabrina Shiner
    class Interface
    {
        static void Main(string[] args)
        {
            Client myClient = new Client();
            Client myClient2 = new Client();
            Client myClient3 = new Client();
            Client myClient4 = new Client();
            Client myClient5 = new Client();

            myClient.loadClient();
            myClient2.loadClient();
            myClient3.loadClient();
            myClient4.loadClient();
            myClient5.loadClient();
            Console.WriteLine("The server only supports 5 connections.");
            Console.ReadLine();
        }
    }
}
