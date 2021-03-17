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
    public partial class Mayor_dos_Numeros : Form
    {
        public Mayor_dos_Numeros()
        {
            InitializeComponent();
        }

        private void btn_MayorN_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (tb_PrimerN.Text == "" && tb_SegundoN.Text == "")
                {
                    MessageBox.Show("Debe ingresar los dos números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int num1 = Convert.ToInt32(tb_PrimerN.Text);
                    int num2 = Convert.ToInt32(tb_SegundoN.Text);

                    if (num1 > num2)
                    {
                        lbl_MayorN.Text = "Número mayor es: " + Convert.ToString(num1);
                    }
                    else if(num1 < num2)
                    {
                        lbl_MayorN.Text = "Número mayor es: " + Convert.ToString(num2);
                    }
                    else
                    {
                        MessageBox.Show("Los dos números son iguales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error");
            }

            tb_PrimerN.Text = "";
            tb_SegundoN.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_PrimerN.Text = "";
            tb_SegundoN.Text = "";
            lbl_MayorN.Text = "Número mayor es:";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_VolverMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F = new Form1();
            F.Show();
        }
    }
}
