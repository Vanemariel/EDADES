using programex2021;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programex2021
{
    
    public partial class FrmCapacitacion : Form
    {
        public void Programex2021()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void Bpresione_Click(object sender, EventArgs e)
        {
            int edad_usuario;

            for (int i = 0; i <= 100 ; i++)
            {
                edad_usuario = System.Convert.ToInt32(txtedad.Text);
                if (edad_usuario >= 18)
                {
                    LBLresultado.Text = "puede ingresar a la capacitacion...continue";
                }
                else if (edad_usuario >= 1 && edad_usuario < 18)
                {
                    LBLresultado.Text = "no puede ingresar a la capacitacion...";
                }
                txtnombre.Text = "";
                txtedad.Text = "0";
            }



        }

        private void Bcargar_Click(object sender, EventArgs e)
        {
            Integrantes integrantesacargar = new Integrantes();


            integrantesacargar.Nombre = txtnombre.Text;
            integrantesacargar.Apellido = txtapellido.Text;
            integrantesacargar.Correo = txtcorreo.Text;
            integrantesacargar.edad = System.Convert.ToInt32(txtedad.Text);

            integrantesacargar = null;
            integrantesacargar = new Integrantes();



        }

        public void Blista_Click(object sender, EventArgs e)
        {
            lbllista.Text = Integranteslista NombreCompletoyCorreoedad;
        }

        private void Bpresione_Click_1(object sender, EventArgs e)
        {

        }
    }
    
}
