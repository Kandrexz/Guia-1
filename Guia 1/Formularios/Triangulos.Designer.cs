namespace Guia_1.Formularios
{
    partial class Triangulos
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
            this.textLado1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textLado2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textLado3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textLado1
            // 
            this.textLado1.Location = new System.Drawing.Point(12, 66);
            this.textLado1.Name = "textLado1";
            this.textLado1.Size = new System.Drawing.Size(137, 20);
            this.textLado1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lado N° 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lado N° 2";
            // 
            // textLado2
            // 
            this.textLado2.Location = new System.Drawing.Point(12, 105);
            this.textLado2.Name = "textLado2";
            this.textLado2.Size = new System.Drawing.Size(137, 20);
            this.textLado2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lado N° 3";
            // 
            // textLado3
            // 
            this.textLado3.Location = new System.Drawing.Point(12, 144);
            this.textLado3.Name = "textLado3";
            this.textLado3.Size = new System.Drawing.Size(137, 20);
            this.textLado3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Triangulo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Tipo de Triangulo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Seleccion);
            // 
            // Triangulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textLado3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textLado2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textLado1);
            this.Name = "Triangulos";
            this.Text = "Triangulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textLado1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textLado2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textLado3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}