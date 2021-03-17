
namespace Proyecto
{
    partial class Cuenta_Letras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Contar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Frase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Letra = new System.Windows.Forms.TextBox();
            this.lb_NumeroVeces = new System.Windows.Forms.Label();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_VolverMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Contar
            // 
            this.btn_Contar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Contar.Location = new System.Drawing.Point(125, 202);
            this.btn_Contar.Name = "btn_Contar";
            this.btn_Contar.Size = new System.Drawing.Size(83, 29);
            this.btn_Contar.TabIndex = 0;
            this.btn_Contar.Text = "Contar";
            this.btn_Contar.UseVisualStyleBackColor = true;
            this.btn_Contar.Click += new System.EventHandler(this.btn_Contar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(230, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cuenta de Letras";
            // 
            // tb_Frase
            // 
            this.tb_Frase.Location = new System.Drawing.Point(350, 103);
            this.tb_Frase.Name = "tb_Frase";
            this.tb_Frase.Size = new System.Drawing.Size(169, 20);
            this.tb_Frase.TabIndex = 2;
            this.tb_Frase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Frase_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(104, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Introduzca una frase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(104, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Introduzca la letra a contar";
            // 
            // tb_Letra
            // 
            this.tb_Letra.Location = new System.Drawing.Point(350, 142);
            this.tb_Letra.Name = "tb_Letra";
            this.tb_Letra.Size = new System.Drawing.Size(169, 20);
            this.tb_Letra.TabIndex = 5;
            this.tb_Letra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Letra_KeyPress);
            // 
            // lb_NumeroVeces
            // 
            this.lb_NumeroVeces.AutoSize = true;
            this.lb_NumeroVeces.BackColor = System.Drawing.Color.Transparent;
            this.lb_NumeroVeces.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NumeroVeces.ForeColor = System.Drawing.Color.White;
            this.lb_NumeroVeces.Location = new System.Drawing.Point(249, 206);
            this.lb_NumeroVeces.Name = "lb_NumeroVeces";
            this.lb_NumeroVeces.Size = new System.Drawing.Size(283, 18);
            this.lb_NumeroVeces.TabIndex = 6;
            this.lb_NumeroVeces.Text = "El número de veces de la letra   es:";
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cerrar.Location = new System.Drawing.Point(584, 253);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(72, 44);
            this.btn_Cerrar.TabIndex = 7;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_VolverMenu
            // 
            this.btn_VolverMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VolverMenu.Location = new System.Drawing.Point(506, 253);
            this.btn_VolverMenu.Name = "btn_VolverMenu";
            this.btn_VolverMenu.Size = new System.Drawing.Size(72, 44);
            this.btn_VolverMenu.TabIndex = 8;
            this.btn_VolverMenu.Text = "Volver al Menu";
            this.btn_VolverMenu.UseVisualStyleBackColor = true;
            this.btn_VolverMenu.Click += new System.EventHandler(this.btn_VolverMenu_Click);
            // 
            // Cuenta_Letras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources.fondo_6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(667, 309);
            this.Controls.Add(this.btn_VolverMenu);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.lb_NumeroVeces);
            this.Controls.Add(this.tb_Letra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Frase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Contar);
            this.Name = "Cuenta_Letras";
            this.Text = "Cuenta_Letras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Contar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Frase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Letra;
        private System.Windows.Forms.Label lb_NumeroVeces;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_VolverMenu;
    }
}