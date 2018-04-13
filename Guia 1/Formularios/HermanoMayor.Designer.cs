namespace Guia_1.Formularios
{
    partial class HermanoMayor
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
            this.texNom1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textEdad1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.texNom2 = new System.Windows.Forms.TextBox();
            this.textEdad2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // texNom1
            // 
            this.texNom1.Location = new System.Drawing.Point(69, 53);
            this.texNom1.Name = "texNom1";
            this.texNom1.Size = new System.Drawing.Size(100, 20);
            this.texNom1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Hermano N°1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Hermano N°2";
            // 
            // textEdad1
            // 
            this.textEdad1.Location = new System.Drawing.Point(69, 92);
            this.textEdad1.Name = "textEdad1";
            this.textEdad1.Size = new System.Drawing.Size(100, 20);
            this.textEdad1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Edad N° 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Edad N° 2";
            // 
            // texNom2
            // 
            this.texNom2.Location = new System.Drawing.Point(293, 53);
            this.texNom2.Name = "texNom2";
            this.texNom2.Size = new System.Drawing.Size(100, 20);
            this.texNom2.TabIndex = 6;
            // 
            // textEdad2
            // 
            this.textEdad2.Location = new System.Drawing.Point(293, 92);
            this.textEdad2.Name = "textEdad2";
            this.textEdad2.Size = new System.Drawing.Size(100, 20);
            this.textEdad2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calcular Mayor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Calcular);
            // 
            // HermanoMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textEdad2);
            this.Controls.Add(this.texNom2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textEdad1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texNom1);
            this.Name = "HermanoMayor";
            this.Text = "HermanoMayor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texNom1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textEdad1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texNom2;
        private System.Windows.Forms.TextBox textEdad2;
        private System.Windows.Forms.Button button1;
    }
}