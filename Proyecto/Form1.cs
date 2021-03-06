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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnM2_Click(object sender, EventArgs e)
        {
            Area_Cuadrado area = new Area_Cuadrado();
            area.Visible = true;
            this.Visible = false;
        }

        private void btnM4_Click(object sender, EventArgs e)
        {
            Invertir_Palabra invertir = new Invertir_Palabra();
            invertir.Visible = true;
            this.Visible = false;
        }

        private void btnM6_Click(object sender, EventArgs e)
        {
            Suma_Dificil suma = new Suma_Dificil();
            suma.Visible = true;
            this.Visible = false;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnM1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mayor_dos_Numeros MN = new Mayor_dos_Numeros();
            MN.Show();
        }

        private void btnM3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cuenta_Letras CL = new Cuenta_Letras();
            CL.Show();
        }

        private void btnM5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pangramas Pg = new Pangramas();
            Pg.Show();
        }
    }
}
