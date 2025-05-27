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
using MySql.Data.MySqlClient;
using ZapaVentas.Properties;
using static ZapaVentas.Program;

namespace ZapaVentas
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Carga las traducciones cuando inicia el form
            btn_ventas.Text = Resources.btn_ventas;
            btn_productos.Text = Resources.btn_productos;
            btn_conteo.Text = Resources.btn_conteo;
            btn_config.Text = Resources.btn_config;
            btn_exit.Text = Resources.btn_exit;
            btn_add.Text = Resources.btn_add;
            btn_cobrar.Text = Resources.btn_cobrar;
            lbl_total.Text = Resources.lbl_total;
        }

        private void btn_exit_Click(object sender, EventArgs e) // Boton de cerrar sesión
        {
            // Cierra la sesión actual
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
                MessageBox.Show(Resources.noPriv);
            }
            else
            {
                // Si es administrador, abre la sección de configuración
                Form config = new config();
                config.Show();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Va a el formulario de agregar productos a la lista de compras
            add_prod add_Prod = new add_prod();
            add_Prod.Show();
            // Recarga la lista de productos
            dgv_compra_actual.Refresh();
        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            // Va a el formulario del editor de productos
            product_editor product_Editor = new product_editor();
            product_Editor.Show();
            this.Hide();
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            // Conexión a la base de datos
            string connectionString = "server=localhost;user=root;password=;database=zapaventas";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                Global.precioTotal = 0;

                foreach (Producto producto in Global.productos)
                {
                    string query = "SELECT precio FROM productos WHERE nombre = @nombre LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", producto.nombre);

                        decimal precioDB = 0;

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                precioDB = reader.GetDecimal("precio");
                            }
                        } //✅

                        producto.precio = (double)(precioDB * producto.inv);
                        Global.precioTotal += producto.precio;
                    }
                }

                // Mostrar en DataGridView
                dgv_compra_actual.DataSource = null;
                dgv_compra_actual.DataSource = Global.productos;
                dgv_compra_actual.Columns["id"].Visible = false;
                dgv_compra_actual.Columns["granel"].Visible = false;
                dgv_compra_actual.Columns["inv"].Name = "Cantidad";

                // Mostrar el total en pantalla
                lbl_total.Text = "$" + Global.precioTotal.ToString("0.00");
            }
        }

        private void btn_cobrar_Click(object sender, EventArgs e)
        {
            checkout Checkout = new checkout(); // Abre el formulario de cobro
            Checkout.ShowDialog();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Si se pulsa la tecla F12, hace el acceso directo a la pantalla de cobro
            if (e.KeyCode == Keys.F12)
            {
                checkout Checkout = new checkout();
                Checkout.Show();
            }
        }

        private void btn_conteo_Click(object sender, EventArgs e)
        {
            Form conteo = new conteo(); // Abre el formulario de conteo, que es el registro de todas las compras
            conteo.Show();
            this.Hide();
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            Form creditos = new creditos(); // Va al formulario de los creditos
            creditos.Show();
        }
    }
}
