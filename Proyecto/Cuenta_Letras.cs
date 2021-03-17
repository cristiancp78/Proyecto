using System;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Cuenta_Letras : Form
    {
        public Cuenta_Letras()
        {
            InitializeComponent();
        }

        private void btn_Contar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_Frase.Text != "" && tb_Letra.Text != "")
                {
                    String Palabra = tb_Frase.Text;
                    String Letra = tb_Letra.Text;
                    int index = Palabra.ToLower().IndexOf(Letra);
                    int cont = 0;

                    while (index != -1)
                    {
                        cont++;
                        index = Palabra.IndexOf(Letra, index + 1);
                    }


                    lb_NumeroVeces.Text = "El número de veces de la letra " + tb_Letra.Text + " es: " + cont;

                  
                }
                else
                {
                    MessageBox.Show("Debe agregar texto");
                }
            }

            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error");
            }

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_VolverMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F = new Form1();
            F.Show();
        }

        private void tb_Frase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <=64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void tb_Letra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }
    }
}
