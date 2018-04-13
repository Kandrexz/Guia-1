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
    public partial class CapCd : Form
    {
        public CapCd()
        {
            InitializeComponent();
        }

        private void Calculo(object sender, EventArgs e)
        {
            decimal Capacidad = decimal.Parse(textCap.Text);
            int resplado = int.Parse(textTotal.Text);
            Decimal Result = Convert.ToDecimal( resplado) / (Capacidad);

            MessageBox.Show("Necesita " + Convert.ToInt16(Result) + " DVD para respaldar " + resplado+"GB");
        }
    }
}
