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
    public partial class Triangulos : Form
    {
        public Triangulos()
        {
            InitializeComponent();
        }

        private void Seleccion(object sender, EventArgs e)
        {
            int Lado1 = int.Parse(textLado1.Text);
            int Lado2 = int.Parse(textLado2.Text);
            int Lado3 = int.Parse(textLado3.Text);


            if (Lado1 == Lado2 & Lado1==Lado3)
            {
                MessageBox.Show("El Triangulo es Equilatero");
            }
            else
            {
                if (Lado1 == Lado2 || Lado1 == Lado3)
                {
                    MessageBox.Show("El Triangulo es Isoseles");
                }
                else
                {
                    MessageBox.Show("El Triangulo es Escaleno");
                }
            }

        }
    }
}
