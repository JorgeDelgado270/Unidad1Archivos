using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            num = int.Parse(textBox1.Text);

            if (num % 2 == 0) MessageBox.Show(" EL NUMERO ES IMPAR ");
            else
                if (num % 3 == 0) MessageBox.Show(" EL NUEMRO ES IMPAR Y ES DIVISIBLE POR 3");
            else MessageBox.Show("EL NUMERO ES IMPAR ES NO DIVISIBLE POR 3");
        }
    }
}
