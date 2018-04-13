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
    public partial class Arandanos : Form
    {
        public Arandanos()
        {
            InitializeComponent();
        }

        private void semanal(object sender, EventArgs e)
        {
            String Nombre = textNombre.Text;
            int Lunes = int.Parse(textLunes.Text);
            int Martes = int.Parse(textMartes.Text);
            int Miercoles = int.Parse(textMiercoles.Text);

            int Jueves = int.Parse(textJueves.Text);
            int Viernes = int.Parse(textViernes.Text);
            int Sabado = int.Parse(textSabado.Text);
            int Result = ((Lunes + Martes + Miercoles + Jueves + Viernes + Sabado) / 6);
            if (Result >= 500)
            {
                MessageBox.Show(Nombre + " recolecto un promedio de " + Result+ " Bandejas por dia");
            }
            else
            {
                MessageBox.Show("El trabajador "+ Nombre +" No Sobrepaso las El Promedio de 500 Bandejas Diarias" 
                                     );
            }

        }   
    }
}
