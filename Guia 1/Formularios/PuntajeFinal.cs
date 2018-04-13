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
    public partial class PuntajeFinal : Form
    {
        public PuntajeFinal()
        {
            InitializeComponent();
        }

        private void Puntaje(object sender, EventArgs e)
        {
            String Nombre = textNombre.Text;
            int Correctas = int.Parse(textCorrer.Text);
            int Incorrectas = int.Parse(textIncorrec.Text);
            int Resultado = (Correctas * 10) - (Incorrectas * 5);
            MessageBox.Show(""+Nombre + " su puntaje Final es = " + Resultado);
        }
    }
}
