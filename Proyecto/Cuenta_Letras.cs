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

            String Palabra = tb_Frase.Text;
            Palabra.ToLower();
            String Letra = tb_Letra.Text;
            int index = Palabra.IndexOf(Letra);
            int cont = 0;

            while (index != -1)
            {
                cont++;
                index = Palabra.IndexOf(Letra, index+1);
            }
            

            lb_NumeroVeces.Text = "El número de veces de la letra " + tb_Letra.Text + " es: " + cont;

            tb_Frase.Text = "" ;
            tb_Letra.Text = "";
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
    }
}
