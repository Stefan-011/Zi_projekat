using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZI_projekat
{
    public partial class ChatForm : Form
    {
        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string recieve;
        public string TextToSend;
        public ChatForm()
        {
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());

            foreach (IPAddress adress in localIP)
            {
                if (adress.AddressFamily == AddressFamily.InterNetwork)
                {
                    IP_srv_text.Text = adress.ToString();
                }
            }

        }

        private void Server()
        {
            int port = int.Parse(Port_srv_text.Text);
            TcpListener listener = new TcpListener(IPAddress.Any, port);
            listener.Start();
            client = listener.AcceptTcpClient();
            Console.WriteLine("Connected!");
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            STW.AutoFlush = true;
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;           
        }

        private void Client()
        {
            string IP = IP_cli_text.Text;
            int port = int.Parse(Port_cli_text.Text);
            client = new TcpClient();
            IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(IP), port);
            try
            {
                ChatScreenBox.AppendText("Connect to Sever" + "\n");
                STR = new StreamReader(client.GetStream());
                STW = new StreamWriter(client.GetStream());
                STW.AutoFlush = true;
                backgroundWorker1.RunWorkerAsync();
                backgroundWorker2.WorkerSupportsCancellation = true;          
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(Port_srv_text.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            Console.WriteLine("Connected!");
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            STW.AutoFlush = true;
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;
        }

        private void Connect_btn_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(IP_cli_text.Text), int.Parse(Port_cli_text.Text));
            try
            {
                ChatScreenBox.AppendText("Connect to Sever" + "\n");
                STR = new StreamReader(client.GetStream());
                STW = new StreamWriter(client.GetStream());
                STW.AutoFlush = true;
                backgroundWorker1.RunWorkerAsync();
                backgroundWorker2.WorkerSupportsCancellation = true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while(client.Connected)
            {
                try
                {
                    recieve = STR.ReadLine();
                    this.ChatScreenBox.Invoke(new MethodInvoker(delegate()
                        {
                        ChatScreenBox.AppendText("You:" + recieve + "\n");
                    }));
                    recieve = "";
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    STW.WriteLine(TextToSend);
                    this.ChatScreenBox.Invoke(new MethodInvoker(delegate ()
                    {
                        ChatScreenBox.AppendText("Me:" + TextToSend + "\n");
                    }));
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Sending failed :(");
                }
                backgroundWorker2.CancelAsync();
            }
        }

        private void Send_btn_Click(object sender, EventArgs e)
        {
            if(MessagetextBox.Text != "")
            {
                TextToSend = MessagetextBox.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            MessagetextBox.Text = "";
        }
    }
    }
