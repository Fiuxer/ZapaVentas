using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
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
            // Revisa si el vendedor es administrador
            if (Global.privilege > 1)
            {
                // Si no es administrador entonces le avisa al vendedor
                MessageBox.Show("No tienes privilegios para acceder a esta sección");
            }
            else
            {
                // Si es administrador, abre la sección de configuración
                //Form config = new Config();
                //config.Show();
                //this.Hide();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            add_prod add_Prod = new add_prod();
            add_Prod.Show();
            dgv_compra_actual.Refresh();
        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            product_editor product_Editor = new product_editor();
            product_Editor.Show();
            this.Hide();
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            //Conexión a la base de datos
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            var database = client.GetDatabase("ZapaVentas");
            var collection = database.GetCollection<Producto>("productos");
            Global.precioTotal = 0;

            // Por cada producto en la lista de productos
            foreach (Producto producto in Global.productos)
            {
                // Busca el producto en la base de datos
                var filter = Builders<Producto>.Filter.Eq(u => u.nombre, producto.nombre);

                var result = collection.Find(filter).FirstOrDefault();

                // Si el producto existe, actualiza el precio
                if (result != null)
                {
                    producto.precio = result.precio * producto.inv;
                    Global.precioTotal += producto.precio;
                }

            }

            // Elegir valores para mostrar
            dgv_compra_actual.DataSource = null;
            dgv_compra_actual.DataSource = Global.productos;
            dgv_compra_actual.Columns["id"].Visible = false;
            dgv_compra_actual.Columns["granel"].Visible = false;
            dgv_compra_actual.Columns["inv"].Name = "Cantidad";

            // Mostrar el total en pantalla
            lbl_total.Text = "$" + Global.precioTotal.ToString("0.00");
        }

        private void btn_cobrar_Click(object sender, EventArgs e)
        {
            checkout Checkout = new checkout();
            Checkout.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Si se pulsa la tecla F12, cobrar
            if (e.KeyCode == Keys.F12)
            {
                checkout Checkout = new checkout();
                Checkout.Show();
            }
        }
    }
}
