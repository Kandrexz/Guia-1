using Guia_1.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void PromedioSimple(object sender, EventArgs e)
        {
            PromedioSimple ver = new PromedioSimple();
            ver.Show();
        }

        private void PuntajeFinal(object sender, EventArgs e)
        {
            PuntajeFinal ver = new PuntajeFinal();
            ver.Show();
        }

        private void HorasExtras(object sender, EventArgs e)
        {
            HorasExtras ver = new HorasExtras();
            ver.Show();
        }

        private void RespaldoCd(object sender, EventArgs e)
        {
            CapCd ver = new CapCd();
            ver.Show();
        }

        private void HermanoMayor(object sender, EventArgs e)
        {
            HermanoMayor ver = new HermanoMayor();
            ver.Show();
        }

        private void BandArandanos(object sender, EventArgs e)
        {
            Arandanos ver =  new Arandanos();
            ver.Show();
        }

        private void NumeroMayor(object sender, EventArgs e)
        {
            NumeroMayor ver = new NumeroMayor();
            ver.Show();
        }

        private void Triangulos(object sender, EventArgs e)
        {
            Triangulos ver = new Triangulos();
            ver.Show();
        }

        private void Ventas(object sender, EventArgs e)
        {
            MetasVentas ver = new MetasVentas();
            ver.Show();
        }

        private void Decenas(object sender, EventArgs e)
        {
            UnidDecenas ver = new UnidDecenas();
            ver.Show();
        }

        private void HastaVocal(object sender, EventArgs e)
        {
            HastaVocal ver = new HastaVocal();
            ver.Show();
        }
    }
}
