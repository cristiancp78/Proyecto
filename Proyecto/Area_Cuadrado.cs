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
    public partial class Area_Cuadrado : Form
    {
        public Area_Cuadrado()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

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
                if (Vacio())
                {
                    int base_cuadrado = Convert.ToInt32(txtBase.Text);
                    int altura = Convert.ToInt32(txtAltura.Text);
                    int area = base_cuadrado * altura;

                    labelArea.Text = "" + area;

                }
                else
                {
                    MessageBox.Show("Faltan datos por llenar ");
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }

        public bool Vacio()
        {
            if (txtBase.Text != "" && txtAltura.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtBase.Clear();
            txtAltura.Clear();
            labelArea.Text="";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
