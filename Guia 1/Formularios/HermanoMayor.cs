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
    public partial class HermanoMayor : Form
    {
        public HermanoMayor()
        {
            InitializeComponent();
        }

        private void Calcular(object sender, EventArgs e)
        {
            String Nombre1 = texNom1.Text;
            String Nombre2 = texNom2.Text;
            int Edad1 = int.Parse(textEdad1.Text);
            int Edad2 = int.Parse(textEdad2.Text);


            if (Edad1>Edad2)
            {
                int comparacion = Edad1 - Edad2;
                MessageBox.Show(Nombre1 + " Es mayor que " + Nombre2 + " Por "+comparacion+ " Años de Edad" );
                
            }
            else
            {
                if (Edad2>Edad1)
                {
                    int comparacion = Edad2 - Edad1;
                    MessageBox.Show(Nombre2 + " Es mayor que " + Nombre1+ " Por " + comparacion + " Años de Edad");
                    
                }
                else
                {
                    MessageBox.Show(Nombre2 + " y " + Nombre1 + "Tienen la misma edad" );
                    
                }
            }
        }
    }
}
