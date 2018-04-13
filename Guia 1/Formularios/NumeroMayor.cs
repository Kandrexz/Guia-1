using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_1.Formularios
{
    public partial class NumeroMayor : Form
    {
        public NumeroMayor()
        {
            InitializeComponent();
        }

        private void Mayor(object sender, EventArgs e)
        {
            int Num1 = int.Parse(textNum1.Text);
            int Num2 = int.Parse(textNum2.Text);
            int Num3 = int.Parse(textNum3.Text);

            if (Num1 > Num2 & Num1 > Num3)
            {
                MessageBox.Show("El numero mayor es "+ Num1);
            }
            else
            {
                if(Num2 > Num1 & Num2 > Num3)
                {
                    MessageBox.Show("El numero mayor es " + Num2);
                }
                else
                {
                    MessageBox.Show("El numero mayor es " + Num3);
                }
            }
        }
    }
}
