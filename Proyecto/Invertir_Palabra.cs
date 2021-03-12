using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Invertir_Palabra : Form
    {
        public Invertir_Palabra()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 volver = new Form1();
            volver.Visible = true;
            this.Visible = false;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
               if(txtPalabra.Text != "")
                {
                    String f1 = txtPalabra.Text;
                    String f2 ="";
                     foreach(char letra in f1)
                    {
                        f2 = letra + f2;
                    }
                   

                    labelInvertir.Text = "" +f2;
                }
                else
                {
                    MessageBox.Show("Falta Escribir la palabra ");
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtPalabra.Clear();
            labelInvertir.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
