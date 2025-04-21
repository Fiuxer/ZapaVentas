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
    public partial class add_prod : Form
    {
        string nombre;
        int cantidad;
        int inv;

        public add_prod()
        {
            InitializeComponent();
        }

        private void add_prod_Load(object sender, EventArgs e)
        {
            reload_dgv();
        }

        private void reload_dgv()
        {
            // Conectar a la base de datos
            var connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(Global.databaseName);
            var collection = database.GetCollection<Producto>("productos");

            // Agarrar el nombre del producto
            // .Trim() elimina espacios al principio y al final
            string prod_name = tbx_nombre.Text.Trim();

            /* 
             * Buscar el producto en una base de datos usando una función lambda
             * 
             * Una función lambda es un tipo de función "anónima"
             * 
             * Con esta se pueden hacer operaciones complejas como la comprobación de
             * un nombre en una base de datos sin la necesidad de hacer un filtro
             * completo.
             */
            var productos = collection.Find(u => u.nombre.Contains(prod_name)).ToList();


            //Mostrar los productos en el DataGridView
            dgv_productos.DataSource = productos;
        }

        private void dgv_productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Si el vendedor hace click en la parte de arriba del DataGridView (Los tipos de variables que se muestran
            // en lugar del producto), no se hace nada y en lugar se regresa
            if (e.RowIndex < 0) return;

            // Agarra el producto seleccionado
            var selectedProduct = (Producto)dgv_productos.Rows[e.RowIndex].DataBoundItem;

            // Busca el nombre del producto y lo muestra en pantalla
            nombre = selectedProduct.nombre;
            tbx_nombre.Text = selectedProduct.nombre;
            inv = selectedProduct.inv;

            // Checa si el producto es a granel o no para saber como venderlo
            if (!selectedProduct.granel)
            {
                // Si el producto no es a granel, muestra el panel de cantidad
                pnl_cantidad_envasado.Visible = true;
                nud_cantidad.Focus();
            }
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Al presionar Enter, se guarda el producto en la lista de productos
            if (e.KeyChar == (char)Keys.Enter) {
                cantidad = (int)nud_cantidad.Value;

                if (inv >= cantidad)
                {
                    var compra = new Producto
                    {
                        id_prod = nombre,
                        nombre = nombre,
                        precio = 0,
                        granel = true,
                        inv = cantidad
                    };

                    Global.productos.Add(compra);

                    this.Close();
                } else
                {
                    MessageBox.Show("No hay inventario suficiente");
                }

            }
        }

        private void add_prod_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
