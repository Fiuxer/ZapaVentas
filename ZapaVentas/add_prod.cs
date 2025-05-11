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
using ZapaVentas.Properties;
using static ZapaVentas.Program;

namespace ZapaVentas
{
    public partial class add_prod : Form
    {
        // Declaración de Variables
        string nombre; // Nombre del producto
        int cantidad; // Cantidad de producto a comprar
        int inv; // Inventario del producto

        public add_prod()
        {
            InitializeComponent();
        }

        private void add_prod_Load(object sender, EventArgs e)
        {
            // Recarga el DataGridView
            reload_dgv();
            // Carga las traducciones de los textos.
            lbl_granQuant.Text = Resources.lbl_price;
            lbl_prodName.Text = Resources.lbl_prodName;
            lbl_unitPrice.Text = Resources.lbl_price;
            
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
            } else
            {
                // De lo contrario, muestra el panel de granel
                pnl_granel.Visible = true;
                nud_granel.Focus();
            }
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Al presionar Enter, se guarda el producto en la lista de productos
            if (e.KeyChar == (char)Keys.Enter) {
                cantidad = (int)nud_cantidad.Value;
                // Si hay inventario suficiente, se guarda el producto en la lista de productos
                if (inv >= cantidad)
                {
                    var compra = new Producto
                    {
                        // Guarda los datos del item
                        id_prod = nombre,
                        nombre = nombre,
                        precio = 0,
                        granel = false,
                        inv = cantidad
                    };
                    // Agrega el producto a la lista de compra
                    Global.productos.Add(compra);
                    // Cierra el form
                    this.Close();
                }
                else // Si no hay inventario suficiente, muestra un mensaje
                {
                    MessageBox.Show("No hay inventario suficiente");
                }

            }
        }



        private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            // Al presionar Enter, se guarda el producto en la lista de productos
            if (e.KeyCode == Keys.Enter)
            {
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
                }
                else
                {
                    MessageBox.Show("No hay inventario suficiente");
                }                                                                     
            }

        }

        private void nud_granel_ValueChanged(object sender, EventArgs e)
        {
            // Al cambiar el valor del NumericUpDown, se busca el precio del producto
            var connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(Global.databaseName);
            var collection = database.GetCollection<Producto>("productos");
            // Busca el producto en la base de datos
            var filter = Builders<Producto>.Filter.Eq(u => u.nombre, nombre);
            var result = collection.Find(filter).FirstOrDefault();

            // Ver el producto y actualizar el precio
            if (result != null)
            {
                string prsst = result.precio.ToString();
                decimal price = decimal.Parse(prsst) * nud_granel.Value;
                lbl_ppk.Text = "$" + price.ToString();
            }
        }
    }
}
