using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ZapaVentas.Program;

namespace ZapaVentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Ntc
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Form logIn = new log_in();
            logIn.Show();
            this.Hide();
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            if (Global.privilege > 1)
            {
                MessageBox.Show("No tienes privilegios para acceder a esta sección");
            }
            else
            {
                //Form config = new Config();
                //config.Show();
                //this.Hide();
            }
        }
    }
}
