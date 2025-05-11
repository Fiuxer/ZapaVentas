using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZapaVentas.Properties;

namespace ZapaVentas
{
    public partial class creditos : Form
    {
        public creditos()
        {
            InitializeComponent();
        }

        private void creditos_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void creditos_Load(object sender, EventArgs e)
        {
            // Carga las traducciones de los textos.
            label3.Text = Resources.label3_Text;
            label1.Text = Resources.credits;
        }
    }
}
