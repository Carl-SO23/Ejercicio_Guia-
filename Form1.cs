using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Text;
using System.Drawing;
using System.Net;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Socket server;
        Thread atender;

        public Form1()
        {
            InitializeComponent();
        }

        private void AtenderServidor()
        {
            while (true)
            {
                byte[] msg2 = new byte[512];
                int n = server.Receive(msg2);
                if (n <= 0) return;
                string mensaje = Encoding.ASCII.GetString(msg2, 0, n);
                MessageBox.Show(mensaje);
            }
        }

        private void buttonConectar_Click(object sender, EventArgs e)
        {
            IPAddress direc = IPAddress.Parse("192.168.56.102");
            IPEndPoint ipep = new IPEndPoint(direc, 50000);

            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                server.Connect(ipep);
                this.BackColor = Color.Green;
                MessageBox.Show("Conectado");

                ThreadStart ts = delegate { AtenderServidor(); };
                atender = new Thread(ts);
                atender.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No he podido conectar con el servidor: " + ex.Message);
            }
        }

        private void buttonBonito_Click(object sender, EventArgs e)
        {
            string mensaje = "1/" + textBoxNombre.Text;
            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }

        private void buttonLongitud_Click(object sender, EventArgs e)
        {
            string mensaje = "2/" + textBoxNombre.Text;
            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }

        private void buttonAltura_Click(object sender, EventArgs e)
        {
            string mensaje = "3/" + textBoxNombre.Text + "/" + textBoxAltura.Text;
            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }

        private void buttonPalindromo_Click(object sender, EventArgs e)
        {
            string mensaje = "4/" + textBoxNombre.Text;
            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }

        private void buttonMayusculas_Click(object sender, EventArgs e)
        {
            string mensaje = "5/" + textBoxNombre.Text;
            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (server != null && server.Connected)
                {
                    string mensaje = "0/";
                    byte[] msg = Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);
                    server.Shutdown(SocketShutdown.Both);
                    server.Close();
                }
            }
            catch { }
        }
    }
}
