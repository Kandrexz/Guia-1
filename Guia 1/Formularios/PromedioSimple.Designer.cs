namespace Guia_1.Formularios
{
    partial class PromedioSimple
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
            this.label1 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textNota1 = new System.Windows.Forms.TextBox();
            this.textNota2 = new System.Windows.Forms.TextBox();
            this.textNota3 = new System.Windows.Forms.TextBox();
            this.textNota4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Promedio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(38, 47);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(176, 20);
            this.textNombre.TabIndex = 1;
            // 
            // textNota1
            // 
            this.textNota1.Location = new System.Drawing.Point(38, 86);
            this.textNota1.Name = "textNota1";
            this.textNota1.Size = new System.Drawing.Size(176, 20);
            this.textNota1.TabIndex = 2;
            // 
            // textNota2
            // 
            this.textNota2.Location = new System.Drawing.Point(38, 125);
            this.textNota2.Name = "textNota2";
            this.textNota2.Size = new System.Drawing.Size(176, 20);
            this.textNota2.TabIndex = 3;
            // 
            // textNota3
            // 
            this.textNota3.Location = new System.Drawing.Point(38, 164);
            this.textNota3.Name = "textNota3";
            this.textNota3.Size = new System.Drawing.Size(176, 20);
            this.textNota3.TabIndex = 4;
            // 
            // textNota4
            // 
            this.textNota4.Location = new System.Drawing.Point(38, 203);
            this.textNota4.Name = "textNota4";
            this.textNota4.Size = new System.Drawing.Size(176, 20);
            this.textNota4.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nota 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nota 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nota 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nota 4";
            // 
            // Promedio
            // 
            this.Promedio.Location = new System.Drawing.Point(38, 241);
            this.Promedio.Name = "Promedio";
            this.Promedio.Size = new System.Drawing.Size(75, 23);
            this.Promedio.TabIndex = 10;
            this.Promedio.Text = "Promediar";
            this.Promedio.UseVisualStyleBackColor = true;
            this.Promedio.Click += new System.EventHandler(this.Resultado);
            // 
            // PromedioSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 450);
            this.Controls.Add(this.Promedio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNota4);
            this.Controls.Add(this.textNota3);
            this.Controls.Add(this.textNota2);
            this.Controls.Add(this.textNota1);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label1);
            this.Name = "PromedioSimple";
            this.Text = "PromedioSimple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textNota1;
        private System.Windows.Forms.TextBox textNota2;
        private System.Windows.Forms.TextBox textNota3;
        private System.Windows.Forms.TextBox textNota4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Promedio;
    }
}