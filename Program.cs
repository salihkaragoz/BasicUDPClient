using System;
using System.Text;
using System.Net;
using System.Net.Sockets;


namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is the old type of catch the UDP data packets. 
            /*    try { 
                Socket s = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.IP);
                s.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"),600));
                s.Listen(9);
                Socket client = s.Accept();
                NetworkStream ns = new NetworkStream(client);
                StreamReader sr = new StreamReader(ns);
                Console.WriteLine(sr.ReadToEnd());
                sr.Close();
                ns.Close();
                //   s.Close();   // This shutdown can cause difficulties during any data exchange.
                s.Shutdown(SocketShutdown.Receive);
                client.Shutdown(SocketShutdown.Receive);
                }
                catch(SocketException exc)
                {

                    Console.WriteLine("Error occured");
                    Console.ReadLine();

        }*/
            byte[] data = new byte[1024];
            // IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 600);
            Console.WriteLine("Please enter the UDP Listen Port :");
            int port = Int32.Parse(Console.ReadLine());
           IPEndPoint ipep = new IPEndPoint(IPAddress.Any, port);
            UdpClient newsock = new UdpClient(ipep);

            Console.WriteLine("Waiting for UDP packets...");
        
         
            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);

            data = newsock.Receive(ref sender);

            Console.WriteLine("Message received from {0}:", sender.ToString());
            Console.WriteLine(Encoding.ASCII.GetString(data, 0, data.Length));



          //  string welcome = "Welcome to my test server";
         //   data = Encoding.ASCII.GetBytes(welcome);
            //newsock.Send(data, data.Length, sender);


            // If you want to get data only specific IP address like "192.168.85.1" you can open this part. 
         //--------------------------------------------------------------------------------
         /*   int serino = 1;
            int serino2 = 1;
            while (true)
            {
                data = newsock.Receive(ref sender);
                string[] words = Encoding.ASCII.GetString(data, 0, data.Length).Split(',');
                if (serino.ToString()== words[0] && words[1]=="192.168.85.1")
                { Console.WriteLine("Errorrrrrrrrrrrrrrrrrrrrrrrrrrrrrr");
                    serino++;

                }
                if(serino2.ToString()==words[0] && words[1] == "192.168.1.61")
                {
                    serino2++;
                    Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                }*/
               //  Console.WriteLine(Encoding.ASCII.GetString(data, 0, data.Length));
             //   Console.WriteLine(words[0]);
               // newsock.Send(data, data.Length, sender);
         //---------------------------------------------------------------------------------       
                
            }

        }  


    }
}
