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
    public partial class product_editor : Form
    {
        public class producto
        {
            public ObjectId id { get; set; }
            public string id_prod { get; set; }
            public string nombre { get; set; }
            public double precio { get; set; }
            public bool granel { get; set; }
            public int inv { get; set; }
        }

        public product_editor()
        {
            InitializeComponent();
        }

        private void tbx_nombre_TextChanged(object sender, EventArgs e)
        {
            // Función para recargar el DataGridView que guarda si encontró un valor
            bool found = reload_dgv();

            // Si no encontró un valor, entonces muestra el label de no encontrado
            // y cambia el texto del botón de agregar producto
            if (!found)
            {
                lbl_no_encontrado.Visible = true;
                lbl_no_encontrado.Text = "No se encontraron productos con ese nombre\n Añadir producto a la derecha";
                btn_commit.Text = "Agregar producto";
            } else
            {
                lbl_no_encontrado.Visible = false;
                lbl_no_encontrado.Text = "";
                btn_commit.Text = "Editar producto";
            }
        }

        private bool reload_dgv()
        {
            // Conexión a la base de datos
            var connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(Global.databaseName);
            var collection = database.GetCollection<producto>("productos");

            string prod_name = tbx_nombre.Text.Trim();

            // Busca el producto en la base de datos con una función lambda
            var productos = collection.Find(u => u.nombre.Contains(prod_name)).ToList();

            dgv_productos.DataSource = productos;

            // Si no se encontró un producto, entonces no lo muestra
            if (productos.Count == 0)
            {
                // Regresa que no se encontró un producto
                return false;
            }
            else
            {
                // Si sí se encontró un producto, entonces lo muestra
                tbx_precio.Text = productos[0].precio.ToString();
                tbx_inv.Text = productos[0].inv.ToString();
                tbx_id_prod.Text = productos[0].id_prod;
                cbx_granel.Checked = productos[0].granel;

                // Regresa que se encontró un producto
                return true;
            }
        }

        private void product_editor_FormClosed(object sender, FormClosedEventArgs e)
        {
            main form1 = new main();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Conexión a la base de datos
            var connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(Global.databaseName);
            var collection = database.GetCollection<producto>("productos");

            // Agarra los datos de las textbox
            string id_prod = tbx_id_prod.Text.Trim();
            string nombre = tbx_nombre.Text.Trim();
            double precio = Convert.ToDouble(tbx_precio.Text.Trim());
            bool granel = cbx_granel.Checked;
            int inv = Convert.ToInt32(tbx_inv.Text.Trim());

            // Busca el producto en la base de datos con una función lambda
            var exists = collection.Find(u => u.nombre == nombre).Any();

            // Si no existe, entonces lo agrega
            if (!exists)
            {

                var new_prod = new producto
                {
                    id_prod = id_prod,
                    nombre = nombre,
                    precio = precio,
                    granel = granel,
                    inv = inv
                };

                collection.InsertOne(new_prod);

                MessageBox.Show("Producto añadido correctamente");
            } else
            { // Si existe, entonces lo edita
                var update = Builders<producto>.Update
                    .Set("precio", precio)
                    .Set("granel", granel)
                    .Set("id_prod", id_prod)
                    .Set("inv", inv);
                collection.UpdateOne(u => u.nombre == nombre, update);

                MessageBox.Show("Producto editado correctamente");
            }

            // Recarga el DataGridView con la función reload_dgv()
            reload_dgv();
        }

        private void product_editor_Load(object sender, EventArgs e)
        {
            // Al cargar la base de datos, recarga el DataGridView
            reload_dgv();
        }

        private void dgv_productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Si el vendedor hace click en una celda, entonces agarra los datos de la celda
            // y los pone en las textbox
            if (e.RowIndex > 0)
            {
                var selectedProduct = (producto)dgv_productos.Rows[e.RowIndex].DataBoundItem;
                tbx_nombre.Text = selectedProduct.nombre;
                tbx_inv.Text = selectedProduct.inv.ToString();
                tbx_precio.Text = selectedProduct.precio.ToString();
                cbx_granel.Checked = selectedProduct.granel;
                tbx_id_prod.Text = selectedProduct.id_prod.ToString();
            }

        }
    }
}
