using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using server.FlightSimulator.Model;

namespace FlightSimulator.Model
{
    public class Client
    {

        Server server;
        
        public Client()
        {
            server = new Server();
        }
        TcpClient client;
        public void connectClient()
        {
            server.connectServer();

            /**
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5402);
            client = new TcpClient();
            client.Connect(ep);

            String message = "set /controls/engines/rudder 0.9/n";
            using (NetworkStream stream = new NetworkStream(client.Client, false))
            using (BinaryWriter writer = new BinaryWriter(stream))
            {
                byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
                Console.WriteLine(message);
                writer.Write(data);
                writer.Flush();
            }
            client.Close();
            **/


        }

        //to fixxxxxxxxxxxxxxxxxxxxxxxxxxx



        public void toSimo(string commandToWrite)
        {
            //חשובה ממש
        }

        public void setInfo(string path, double val)
        {
            //needs to check if te
            /**
            byte[] byteTime = Encoding.ASCII.GetBytes(DateTime.Now.ToString(path));

            try
            {
                String message = "set /controls/engines/rudder 0.9/n";
                using (NetworkStream stream = new NetworkStream(client.Client, false))
                using (BinaryWriter writer = new BinaryWriter(stream))
                {
                    byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
                    Console.WriteLine(message);
                    writer.Write(data);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            */
        }

    }

    /**
    IPEndPoint ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5402);
    TcpClient client = new TcpClient();
    client.Connect(ep);
    Console.WriteLine("You are connected");
    using (NetworkStream stream = client.GetStream())
    {
        // Send data to server
        Console.Write("Please enter a number: ");
       // int num = int.Parse(Console.ReadLine());
       // writer.Write(num);
        // Get result from server
       // int result = reader.ReadInt32();
        Console.WriteLine("Sent: {0}", "set /controls/flight/rudder 0.9/r/n");
    }
    client.Close();

    **/

    /**
    try
    {
        // Create a TcpClient.
        // Note, for this client to work you need to have a TcpServer 
        // connected to the same address as specified by the server, port
        // combination.
        IPEndPoint ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5402);
        client = new TcpClient();
        client.Connect(ep);
        Console.WriteLine("You are connected");
        String message = "set /controls/flight/rudder 0.9/r/n";
        //message = message.ToUpper();
        // Translate the passed message into ASCII and store it as a Byte array.
        Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

        // Get a client stream for reading and writing.
        //  Stream stream = client.GetStream();

        NetworkStream stream = client.GetStream();
        Console.WriteLine(data);
        // Send the message to the connected TcpServer. 
        stream.Write(data, 0, data.Length);

        Console.WriteLine("Sent: {0}", message);

        // Receive the TcpServer.response.

        // Buffer to store the response bytes.
        data = new Byte[256];

        // String to store the response ASCII representation.
        String responseData = String.Empty;

        // Read the first batch of the TcpServer response bytes.
        //Int32 bytes = stream.Read(data, 0, data.Length);
       // responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
        //Console.WriteLine("Received: {0}", responseData);

        // Close everything.
        stream.Close();
        client.Close();
    }
    catch (ArgumentNullException e)
    {
        Console.WriteLine("ArgumentNullException: {0}", e);
    }
    catch (SocketException e)
    {
        Console.WriteLine("SocketException: {0}", e);
    }

    Console.WriteLine("\n Press Enter to continue...");
    Console.Read();
    
}**/

    //{
    //    bool done = false;
    //
    // Int32 port = 5400;
    // IPAddress localAddr = IPAddress.Parse("127.0.0.1");

    //client1 = new TcpListener(port);
    // client1 = new TcpListener(localAddr, port);

    //  listener.Start();

    //  while (!done)
    //  {
    //   Console.Write("Waiting for connection...");
    //   TcpClient client = listener.AcceptTcpClient();
    //   this.client1 = client;

    //  Console.WriteLine("Connection accepted.");
    //   NetworkStream ns = client.GetStream();
    //  this.clientStream = ns;
    //  }

    //  listener.Stop();

    //  return;
    // }
    /**
            public void setInfo(string path)
            {
                byte[] byteTime = Encoding.ASCII.GetBytes(DateTime.Now.ToString(path));

                try
                {
                    this.clientStream.Write(byteTime, 0, byteTime.Length);
                    this.clientStream.Close();
                    this.client.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }**/
}