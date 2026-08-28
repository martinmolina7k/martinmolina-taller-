using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_1
{   
    //1. Disponer tres objetos de la clase CheckBox con nombres de navegadores web.
    //Cuando se presione un botón mostrar en el título del Form los programas
    //seleccionados.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Text = "";
            if(checkBox1.Checked == true)
            {
                Text = Text + "(google)";
            }
            if (checkBox2.Checked == true)
            {
                Text = Text + "(firefox)";
            }
            if (checkBox3.Checked == true)
            {
                Text = Text + "(edge)";
            }
        }
    }
}
