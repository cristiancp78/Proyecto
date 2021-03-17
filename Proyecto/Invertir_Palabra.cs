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
                    String palabra = txtPalabra.Text;
                    if (isNumeric(palabra))
                    {
                        String invertida = "";
                        foreach (char letra in palabra)
                        {
                            invertida = letra + invertida;
                        }


                        labelInvertir.Text = "" + invertida;
                    }
                    else
                    {
                        MessageBox.Show("No se pueden escribir numeros");
                    }
                   
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


        public static bool isNumeric(String palabra)
        {

            bool resultado;

            try
            {
                Convert.ToInt32(palabra);
                resultado = false;
            }
            catch (Exception excepcion)
            {
                resultado = true;
            }

            return resultado;
        }



    }
}
