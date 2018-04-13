namespace Guia_1.Formularios
{
    partial class NumeroMayor
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
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.textNum2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNum3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Numero 1";
            // 
            // textNum1
            // 
            this.textNum1.Location = new System.Drawing.Point(39, 53);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(100, 20);
            this.textNum1.TabIndex = 1;
            // 
            // textNum2
            // 
            this.textNum2.Location = new System.Drawing.Point(39, 92);
            this.textNum2.Name = "textNum2";
            this.textNum2.Size = new System.Drawing.Size(100, 20);
            this.textNum2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero 2";
            // 
            // textNum3
            // 
            this.textNum3.Location = new System.Drawing.Point(39, 131);
            this.textNum3.Name = "textNum3";
            this.textNum3.Size = new System.Drawing.Size(100, 20);
            this.textNum3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero 3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular Mayor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Mayor);
            // 
            // NumeroMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textNum3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNum2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNum1);
            this.Controls.Add(this.label1);
            this.Name = "NumeroMayor";
            this.Text = "NumeroMayor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNum1;
        private System.Windows.Forms.TextBox textNum2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNum3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}