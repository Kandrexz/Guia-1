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
    public partial class HorasExtras : Form
    {
        public HorasExtras()
        {
            InitializeComponent();
        }

        private void SueldoFinal(object sender, EventArgs e)
        {
            String Nombre = textNombre.Text;
            String Mes = comboBoxMes.Text;
            int Horas = int.Parse(textHoras.Text);
            Double Sueldo = Convert.ToDouble(textBase.Text);
            double Hora = (Sueldo * 0.007777)* Horas ;

            MessageBox.Show("El Trabajador " + Nombre + " en el mes de " + Mes + " ha generado un total de " + Horas + " Equivale a un monto de " + Hora);
               
        }
    }
}
