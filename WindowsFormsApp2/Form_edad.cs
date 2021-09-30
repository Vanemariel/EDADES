using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form_edad : Form
    {
        public Form_edad()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int edad_usuario;
           

            
            for (int i = 0; i <= 10; i++)
            {
                edad_usuario = System.Convert.ToInt32(TxtAños.Text);
                if (edad_usuario >= 18)
                {
                    LBLresultado.Text = "puede ingresar al sistema...continue";
                }
                else if (edad_usuario >= 1 && edad_usuario < 18)
                {
                    LBLresultado.Text = "no puede ingresar al sistema...";
                }
                textBox1.Text = "";
                TxtAños.Text = "0";
            }
   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
