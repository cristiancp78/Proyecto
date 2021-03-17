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
    public partial class Suma_Dificil : Form
    {
        public Suma_Dificil()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 volver = new Form1();
            volver.Visible = true;
            this.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtNumeros.Text != "")
                {
                    string numeros = txtNumeros.Text;
                    float suma=0;

                    while (numeros.Contains("  ")) //recorre toda la cadena de numeros y devuleve apenas encrente mas de 2 espacios
                    {
                        numeros = numeros.Replace("  ", " ");//remplaza o elimina los espacios cuando son mas de 2 y deja solo 1 
                    }

                    string[] valores = numeros.Split(' ');//Almaceno la cadena en un array separandolos al momento que se encuentre un espacio

                    

                    float[] Valores_numeros = new float[valores.Length];
                    for (int i = 0; i < valores.Length; i++)
                    {
                        Valores_numeros[i] = float.Parse(valores[i]);
                    }

                    for(int x=0; x < Valores_numeros.Length; x++)
                    {
                        suma = suma + Valores_numeros[x];
                    }

                    labelSuma.Text = "" + suma;
                }
                else
                {
                    MessageBox.Show("Falta escribir los numeros");
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
                txtNumeros.Clear();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNumeros.Clear();
            labelSuma.Text = "";
        }
    }
}
