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
    public partial class PromedioSimple : Form
    {
        public PromedioSimple()
        {
            InitializeComponent();
        }

        private void Resultado(object sender, EventArgs e)
        {

            String Nombre = textNombre.Text;
            int Resultado = (int.Parse(textNota1.Text) + int.Parse(textNota2.Text) + int.Parse(textNota3.Text) + int.Parse(textNota4.Text))/4;
            MessageBox.Show("El Alumno "+Nombre+" Tiene un promedio = "+Resultado);
        }
    }
}
