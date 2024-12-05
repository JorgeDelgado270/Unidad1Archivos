using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARDUINO1BUENO
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort Arduino;
        public Form1()
        {
            InitializeComponent();
            Arduino = new System.IO.Ports.SerialPort();
            Arduino = new SerialPort("COM3", 9600); // Asegúrate de que el puerto COM sea correcto
            Arduino.Open();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Arduino.Write("E"); // Enviar señal para encender e
        }

        private void OFF_Click(object sender, EventArgs e)
        {
            Arduino.Write("F"); // Enviar señal para apagar
        }
    }
}
