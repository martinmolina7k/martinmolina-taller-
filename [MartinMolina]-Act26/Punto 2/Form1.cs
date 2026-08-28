using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int numero;
            if (int.TryParse(textBox1.Text, out numero) && int.TryParse(textBox2.Text, out int numero2))
            {
                int resta = numero - numero2;
                Text = resta.ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int numero; 
            if(int.TryParse(textBox1. Text , out numero ) && int.TryParse(textBox2.Text , out int numero1))
            {
                int suma = numero + numero1;
                Text = suma.ToString(); 
            }
        }
    }
}
