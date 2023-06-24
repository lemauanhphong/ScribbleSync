using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
namespace ScribbleSyncClient
{
    class Connects
    {
        public static string HOST = "trust-authority.duckdns.org";
        public static int PORT = 8028;
        public static string token= "";
        public static string username = "";
        public static string password = "";

        public static string SendAndReceiveServer(string msg)
        {
            //TcpClient client = new TcpClient(HOST, PORT);
            //IPAddress ipAddress = Dns.GetHostEntry(HOST).AddressList[0];
            //IPEndPoint remoteEP = new IPEndPoint( ipAddress, PORT);

            // Create a TCP/IP  socket.
            //Socket client = new Socket(ipAddress.AddressFamily,
            //    SocketType.Stream, ProtocolType.Tcp);
            TcpClient client = new TcpClient(HOST, PORT);
            //Stream sslStream = client.GetStream();
            SslStream sslStream = new SslStream(client.GetStream());
            try
            {
                sslStream.AuthenticateAsClient(HOST);
            }
            catch (AuthenticationException e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
                if (e.InnerException != null)
                {
                    Console.WriteLine("Inner exception: {0}", e.InnerException.Message);
                }
                Console.WriteLine("Authentication failed - closing the connection.");
                client.Close();
            }

            int byteCount = Encoding.UTF8.GetByteCount(msg);
            byte[] sendData = new byte[byteCount];
            sendData = Encoding.UTF8.GetBytes(msg + '\n');
            //client.Send(sendData);
            sslStream.Write(sendData,0, byteCount + 1);
            sslStream.Flush();
            string rtnMsg = "";
            while (true)
            {
                byte[] receiveData = new byte[1024*5120];
                int bytesRead = sslStream.Read(receiveData, 0, receiveData.Length);
                if (bytesRead == 0)
                    break;
                rtnMsg += Encoding.UTF8.GetString(receiveData, 0, bytesRead);
            }
            client.Close();

             return rtnMsg;
        }
    }
}
