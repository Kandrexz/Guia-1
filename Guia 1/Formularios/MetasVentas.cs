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
    public partial class MetasVentas : Form
    {
        public MetasVentas()
        {
            InitializeComponent();
        }

        private void Bonificacion(object sender, EventArgs e)
        {
            int Venta = int.Parse(textVenta.Text);

            if (Venta > 0 & Venta <= 500000)
            {
                MessageBox.Show("A usted le corresponde a un 0% de bonificacion ya que el monto vendido es de "+Venta);
            }
            else
            {
                if (Venta > 500001 & Venta <= 1500000)
                {
                    MessageBox.Show("A usted le corresponde a un 3% de bonificacion ya que el monto vendido es de " + Venta);
                }
                else
                {
                    if (Venta > 1500001 & Venta <= 2500000)
                    {
                        MessageBox.Show("A usted le corresponde a un 8% de bonificacion ya que el monto vendido es de " + Venta);
                    }
                    else
                    {
                        if (Venta > 2500001 )
                        {
                            MessageBox.Show("A usted le corresponde a un 12% de bonificacion ya que el monto vendido es de " + Venta);
                        }
                    }
                }
            }


        }
    }
}
