using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DarkComet_Fucker
{
    class Utils
    {
        //APIs
        [DllImport("kernel32.dll")]
        public static extern IntPtr LoadLibrary(string dllToLoad);

        [DllImport("kernel32.dll")]
        public static extern IntPtr LockResource(IntPtr hResData);

        [DllImport("kernel32.dll")]
        public static extern IntPtr LoadResource(IntPtr hInstance, IntPtr hResInfo);

        [DllImport("kernel32.dll")]
        public static extern uint SizeofResource(IntPtr hInstance, IntPtr hResInfo);

        [DllImport("Kernel32.dll", EntryPoint = "FindResourceW", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern IntPtr FindResource(IntPtr hModule, string pName, string pType);

        public static string versionPassword;
        public static string serverPassword;
        public static string serverIP;
        public static int serverPort;

        public static string getVersion(string sfile)
        {
            string ret = "Unknown";
            string content = File.ReadAllText(sfile);
            String[] versions = {"2", "3", "4", "42", "42F", "5", "51"};
            foreach (String version in versions) {
                if (content.Contains("#KCMDDC" + version+"#"))
                {
                    versionPassword = "#KCMDDC"+version + "#-890";
                    ret = version;
                    break;
                }
            }
            return ret;
        }

        public static string GetConfig(string sFile)
        {
            IntPtr hExe = LoadLibrary(sFile);
            IntPtr hRes = FindResource(hExe, "DCDATA", "#10");
            IntPtr hResLoad = LoadResource(hExe, hRes);
            IntPtr lpResLock = LockResource(hResLoad);
            uint hSize = SizeofResource(hExe, hRes);
            byte[] y = new byte[hSize];
            Marshal.Copy(lpResLock, y, 0, (int)hSize);
            return System.Text.Encoding.UTF8.GetString(y);
        }

        public static string encrypt(string str)
        {
            return hexify(RC4(str, versionPassword + serverPassword)).ToUpper();
        }

        public static string decrypt(string str)
        {
 
            return RC4(unhexlify(str), versionPassword + serverPassword);
        }

        public static string hexify(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                int v = Convert.ToInt32(str[i]);
                sb.Append(string.Format("{0:X2}", v));
            }
            return sb.ToString();
        }

        public static string unhexlify(string hexStr)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hexStr.Length; i += 2)
            {
                int n = Convert.ToInt32(hexStr.Substring(i, 2), 16);
                sb.Append(Convert.ToChar(n));
            }
            return sb.ToString();
        }

        public static string RC4(string text, string password)
        {
            int N = 256;
            int[] sbox;
            sbox = new int[N];
            int[] key = new int[N];
            int n = password.Length;
            for (int a = 0; a < N; a++)
            {
                key[a] = (int)password[a % n];
                sbox[a] = a;
            }

            int b = 0;
            for (int a = 0; a < N; a++)
            {
                b = (b + sbox[a] + key[a]) % N;
                int tempSwap = sbox[a];
                sbox[a] = sbox[b];
                sbox[b] = tempSwap;
            }
            int i = 0, j = 0, k = 0;
            StringBuilder cipher = new StringBuilder();
            for (int a = 0; a < text.Length; a++)
            {
                i = (i + 1) % N;
                j = (j + sbox[i]) % N;
                int tempSwap = sbox[i];
                sbox[i] = sbox[j];
                sbox[j] = tempSwap;

                k = sbox[(sbox[i] + sbox[j]) % N];
                int cipherBy = ((int)text[a]) ^ k;
                cipher.Append(Convert.ToChar(cipherBy));
            }
            return cipher.ToString();
        }

        public static void AppendAllBytes(string path, byte[] bytes)
        {
            using (var stream = new FileStream(path, FileMode.Append))
            {
                stream.Write(bytes, 0, bytes.Length);
            }
        }
    }
}
