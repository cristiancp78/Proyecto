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
    public partial class Pangramas : Form
    {
        public Pangramas()
        {
            InitializeComponent();
        }

        private void btn_Verificar_Click(object sender, EventArgs e)
        {
            String[] array = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o"
            , "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
            String pPalabra = tb_PrimeraF.Text;
            String sPalabra = tb_SegundaF.Text;
            bool verificarP; 
            bool verificarS;

            for (int i = 0; i < array.Length; i++)
            {
               verificarP = pPalabra.ToLower().Contains(array[i]);

                if (verificarP)
                {
                    lb_PrimeraF.Text = "SI";

                }
                else
                {
                    lb_PrimeraF.Text = "NO";

                }

                verificarS = sPalabra.ToLower().Contains(array[i]);

                if (verificarS)
                {

                    lb_SegundaF.Text = "SI";
                }
                else
                {

                    lb_SegundaF.Text = "NO";
                }
            }

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_VolverM_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F = new Form1();
            F.Show();
        }
    }
}
