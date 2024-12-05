using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TYH2
{
    public partial class Form1 : Form
    {
        SerialPort serialPort;
        bool puertoCerrado = false;
        public Form1()
        {
            InitializeComponent();
            serialPort = new SerialPort();
            //serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            serialPort.PortName = "COM3"; //Cambia esto segun tu configuracion
            serialPort.BaudRate = 9600;
            //serialPort.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
        private void coenectar()
        {
            try
            {
                puertoCerrado = true;
                serialPort.Open();
                botonConectar.Text = "DESCONECTAR";
                botonCerrado.BackColor = Color.Black;
                serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler)

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
        catch (Exception Error)
            {
            

        
    }
}
