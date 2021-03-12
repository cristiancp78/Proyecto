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
               
            }
            catch(Exception exception)
            {

            }
        }
    }
}
