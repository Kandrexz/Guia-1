namespace Guia_1
{
    partial class Home
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Promedio Simple ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.PromedioSimple);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Puntaje Final";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.PuntajeFinal);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Hora Extras";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.HorasExtras);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(24, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Cant. Cd Respaldo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.RespaldoCd);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(24, 190);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Band. Arandanos";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.BandArandanos);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(24, 219);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Numero Mayor";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.NumeroMayor);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(24, 161);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(98, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "Hermano Mayor";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.HermanoMayor);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(24, 248);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "Triangulos";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Triangulos);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(24, 277);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(98, 23);
            this.button9.TabIndex = 8;
            this.button9.Text = "Metas Ventas";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Ventas);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(24, 306);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(104, 23);
            this.button10.TabIndex = 9;
            this.button10.Text = "Unid & Decenas";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Decenas);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(24, 335);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 10;
            this.button11.Text = "Hasta Vocal";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.HastaVocal);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Home";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
    }
}

