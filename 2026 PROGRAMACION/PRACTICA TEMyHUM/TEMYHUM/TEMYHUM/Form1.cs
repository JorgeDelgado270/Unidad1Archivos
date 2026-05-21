using System;
using System.Drawing; 
using System.IO.Ports;
using System.Windows.Forms;

namespace HyT
{
    public partial class Form1 : Form
    {
        SerialPort serialPort;
        bool puertoCerrado = false;

        public Form1()
        {
            InitializeComponent();
            serialPort = new SerialPort();
            serialPort.PortName = "COM3"; 
            serialPort.BaudRate = 9600;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (puertoCerrado == false)
            {
                conectar();
            }
            else
            {
                noConectado();
            }
        }

        private void conectar()
        {
            try
            {
                puertoCerrado = true;
                serialPort.Open();
                botonConectar.Text = "DESCONECTAR";
                botonConectar.BackColor = Color.Black;
                serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void noConectado()
        {
            try
            {
                puertoCerrado = false;
                serialPort.Close();
                botonConectar.Text = "CONECTAR";
                botonConectar.BackColor = Color.Blue;
                listBox1.Items.Clear();
                temperaturaLabel.Text = "TEMPERATURA °C";
                humedadLabel.Text = "HUMEDAD %";
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine();
            this.Invoke(new MethodInvoker(delegate
            {
                string[] values = data.Split('\t');
                if (values.Length == 2)
                {
                    temperaturaLabel.Text = values[1];
                    humedadLabel.Text = values[0];
                    listBox1.Items.Add(values[1] + "   " + values[0]);
                }
            }));
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Evento vacío de la imagen 2
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Evento vacío de la imagen 2
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
