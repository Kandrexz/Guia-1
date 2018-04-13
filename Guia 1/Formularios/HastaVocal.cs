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
    public partial class HastaVocal : Form
    {
        public HastaVocal()
        {
            InitializeComponent();
        }

        private void vocal(object sender, EventArgs e)
        {
            String vocal = textBox1.Text;

            if (vocal == "a" || vocal == "e" || vocal == "i" || vocal == "o" || vocal == "u" )
            {
                MessageBox.Show("Usted ingreso una vocal");

            }

        }
    }
}
