﻿namespace Guia_1.Formularios
{
    partial class PuntajeFinal
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
            this.textBlanco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textIncorrec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textCorrer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBlanco
            // 
            this.textBlanco.Location = new System.Drawing.Point(395, 104);
            this.textBlanco.Name = "textBlanco";
            this.textBlanco.Size = new System.Drawing.Size(100, 20);
            this.textBlanco.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Respuestas en Blanco";
            // 
            // textIncorrec
            // 
            this.textIncorrec.Location = new System.Drawing.Point(209, 104);
            this.textIncorrec.Name = "textIncorrec";
            this.textIncorrec.Size = new System.Drawing.Size(100, 20);
            this.textIncorrec.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Respuestas Incorrectas";
            // 
            // textCorrer
            // 
            this.textCorrer.Location = new System.Drawing.Point(23, 104);
            this.textCorrer.Name = "textCorrer";
            this.textCorrer.Size = new System.Drawing.Size(108, 20);
            this.textCorrer.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Respuestas Correctas";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(23, 43);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(347, 20);
            this.textNombre.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre De Evaluado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Puntaje Final";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Puntaje);
            // 
            // PuntajeFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBlanco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textIncorrec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textCorrer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label1);
            this.Name = "PuntajeFinal";
            this.Text = "PromedioFinal";
            this.Click += new System.EventHandler(this.Puntaje);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBlanco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textIncorrec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCorrer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}