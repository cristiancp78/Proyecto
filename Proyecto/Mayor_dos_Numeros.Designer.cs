
namespace Proyecto
{
    partial class Mayor_dos_Numeros
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
            this.btn_MayorN = new System.Windows.Forms.Button();
            this.lbl_PrimerN = new System.Windows.Forms.Label();
            this.tb_PrimerN = new System.Windows.Forms.TextBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.tb_SegundoN = new System.Windows.Forms.TextBox();
            this.lbl_SegundoN = new System.Windows.Forms.Label();
            this.lbl_MayorN = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_VolverMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_MayorN
            // 
            this.btn_MayorN.Location = new System.Drawing.Point(163, 244);
            this.btn_MayorN.Name = "btn_MayorN";
            this.btn_MayorN.Size = new System.Drawing.Size(84, 37);
            this.btn_MayorN.TabIndex = 0;
            this.btn_MayorN.Text = "Mayor Número";
            this.btn_MayorN.UseVisualStyleBackColor = true;
            this.btn_MayorN.Click += new System.EventHandler(this.btn_MayorN_Click);
            // 
            // lbl_PrimerN
            // 
            this.lbl_PrimerN.AutoSize = true;
            this.lbl_PrimerN.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PrimerN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PrimerN.ForeColor = System.Drawing.Color.White;
            this.lbl_PrimerN.Location = new System.Drawing.Point(69, 110);
            this.lbl_PrimerN.Name = "lbl_PrimerN";
            this.lbl_PrimerN.Size = new System.Drawing.Size(208, 18);
            this.lbl_PrimerN.TabIndex = 1;
            this.lbl_PrimerN.Text = "Ingrese el primer número";
            // 
            // tb_PrimerN
            // 
            this.tb_PrimerN.Location = new System.Drawing.Point(340, 111);
            this.tb_PrimerN.Name = "tb_PrimerN";
            this.tb_PrimerN.Size = new System.Drawing.Size(165, 20);
            this.tb_PrimerN.TabIndex = 2;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_Titulo.Location = new System.Drawing.Point(114, 35);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(321, 32);
            this.lbl_Titulo.TabIndex = 3;
            this.lbl_Titulo.Text = "Mayor de Dos Números";
            // 
            // tb_SegundoN
            // 
            this.tb_SegundoN.Location = new System.Drawing.Point(340, 147);
            this.tb_SegundoN.Name = "tb_SegundoN";
            this.tb_SegundoN.Size = new System.Drawing.Size(165, 20);
            this.tb_SegundoN.TabIndex = 4;
            // 
            // lbl_SegundoN
            // 
            this.lbl_SegundoN.AutoSize = true;
            this.lbl_SegundoN.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SegundoN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SegundoN.ForeColor = System.Drawing.Color.White;
            this.lbl_SegundoN.Location = new System.Drawing.Point(69, 146);
            this.lbl_SegundoN.Name = "lbl_SegundoN";
            this.lbl_SegundoN.Size = new System.Drawing.Size(225, 18);
            this.lbl_SegundoN.TabIndex = 5;
            this.lbl_SegundoN.Text = "Ingrese el segundo número";
            // 
            // lbl_MayorN
            // 
            this.lbl_MayorN.AutoSize = true;
            this.lbl_MayorN.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MayorN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MayorN.ForeColor = System.Drawing.Color.White;
            this.lbl_MayorN.Location = new System.Drawing.Point(137, 201);
            this.lbl_MayorN.Name = "lbl_MayorN";
            this.lbl_MayorN.Size = new System.Drawing.Size(157, 18);
            this.lbl_MayorN.TabIndex = 6;
            this.lbl_MayorN.Text = "Número mayor es: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_VolverMenu
            // 
            this.btn_VolverMenu.Location = new System.Drawing.Point(310, 244);
            this.btn_VolverMenu.Name = "btn_VolverMenu";
            this.btn_VolverMenu.Size = new System.Drawing.Size(84, 37);
            this.btn_VolverMenu.TabIndex = 9;
            this.btn_VolverMenu.Text = "Volver al Menú";
            this.btn_VolverMenu.UseVisualStyleBackColor = true;
            this.btn_VolverMenu.Click += new System.EventHandler(this.btn_VolverMenu_Click);
            // 
            // Mayor_dos_Numeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources.fondo_6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(568, 322);
            this.Controls.Add(this.btn_VolverMenu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_MayorN);
            this.Controls.Add(this.lbl_SegundoN);
            this.Controls.Add(this.tb_SegundoN);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.tb_PrimerN);
            this.Controls.Add(this.lbl_PrimerN);
            this.Controls.Add(this.btn_MayorN);
            this.Name = "Mayor_dos_Numeros";
            this.Text = "Mayor_dos_Numeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_MayorN;
        private System.Windows.Forms.Label lbl_PrimerN;
        private System.Windows.Forms.TextBox tb_PrimerN;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.TextBox tb_SegundoN;
        private System.Windows.Forms.Label lbl_SegundoN;
        private System.Windows.Forms.Label lbl_MayorN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_VolverMenu;
    }
}