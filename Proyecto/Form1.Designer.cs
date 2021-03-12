
namespace Proyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnM1 = new System.Windows.Forms.Button();
            this.btnM2 = new System.Windows.Forms.Button();
            this.btnM3 = new System.Windows.Forms.Button();
            this.btnM4 = new System.Windows.Forms.Button();
            this.btnM5 = new System.Windows.Forms.Button();
            this.btnM6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnM1
            // 
            this.btnM1.Location = new System.Drawing.Point(37, 57);
            this.btnM1.Name = "btnM1";
            this.btnM1.Size = new System.Drawing.Size(89, 55);
            this.btnM1.TabIndex = 0;
            this.btnM1.Text = "Modulo 1- Mayor de dos numeros";
            this.btnM1.UseVisualStyleBackColor = true;
            this.btnM1.Click += new System.EventHandler(this.btnM1_Click);
            // 
            // btnM2
            // 
            this.btnM2.Location = new System.Drawing.Point(157, 57);
            this.btnM2.Name = "btnM2";
            this.btnM2.Size = new System.Drawing.Size(87, 55);
            this.btnM2.TabIndex = 1;
            this.btnM2.Text = "Modulo 2- Calcular area cuadrado";
            this.btnM2.UseVisualStyleBackColor = true;
            this.btnM2.Click += new System.EventHandler(this.btnM2_Click);
            // 
            // btnM3
            // 
            this.btnM3.Location = new System.Drawing.Point(289, 57);
            this.btnM3.Name = "btnM3";
            this.btnM3.Size = new System.Drawing.Size(79, 55);
            this.btnM3.TabIndex = 2;
            this.btnM3.Text = "Modulo 3- Cuenta letras";
            this.btnM3.UseVisualStyleBackColor = true;
            this.btnM3.Click += new System.EventHandler(this.btnM3_Click);
            // 
            // btnM4
            // 
            this.btnM4.Location = new System.Drawing.Point(37, 154);
            this.btnM4.Name = "btnM4";
            this.btnM4.Size = new System.Drawing.Size(89, 47);
            this.btnM4.TabIndex = 3;
            this.btnM4.Text = "Modulo 4- Invertir palabra";
            this.btnM4.UseVisualStyleBackColor = true;
            this.btnM4.Click += new System.EventHandler(this.btnM4_Click);
            // 
            // btnM5
            // 
            this.btnM5.Location = new System.Drawing.Point(157, 154);
            this.btnM5.Name = "btnM5";
            this.btnM5.Size = new System.Drawing.Size(87, 47);
            this.btnM5.TabIndex = 4;
            this.btnM5.Text = "Modulo 5- Pangramas";
            this.btnM5.UseVisualStyleBackColor = true;
            this.btnM5.Click += new System.EventHandler(this.btnM5_Click);
            // 
            // btnM6
            // 
            this.btnM6.Location = new System.Drawing.Point(289, 154);
            this.btnM6.Name = "btnM6";
            this.btnM6.Size = new System.Drawing.Size(79, 47);
            this.btnM6.TabIndex = 5;
            this.btnM6.Text = "Modulo 6- Una suma dificil";
            this.btnM6.UseVisualStyleBackColor = true;
            this.btnM6.Click += new System.EventHandler(this.btnM6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccione el modulo al que quiere dirigirse ";
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(157, 220);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(87, 26);
            this.btn_Cerrar.TabIndex = 7;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 268);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnM6);
            this.Controls.Add(this.btnM5);
            this.Controls.Add(this.btnM4);
            this.Controls.Add(this.btnM3);
            this.Controls.Add(this.btnM2);
            this.Controls.Add(this.btnM1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnM1;
        private System.Windows.Forms.Button btnM2;
        private System.Windows.Forms.Button btnM3;
        private System.Windows.Forms.Button btnM4;
        private System.Windows.Forms.Button btnM5;
        private System.Windows.Forms.Button btnM6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cerrar;
    }
}

