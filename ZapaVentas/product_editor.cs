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
            bool found = reload_dgv();

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
            var connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("ZapaVentas");
            var collection = database.GetCollection<producto>("productos");

            string prod_name = tbx_nombre.Text.Trim();

            var productos = collection.Find(u => u.nombre.Contains(prod_name)).ToList();

            dgv_productos.DataSource = productos;

            if (productos.Count == 0)
            {
                return false;
            }
            else
            {
                tbx_precio.Text = productos[0].precio.ToString();
                tbx_inv.Text = productos[0].inv.ToString();
                tbx_id_prod.Text = productos[0].id_prod;
                cbx_granel.Checked = productos[0].granel;
                return true;
            }
        }

        private void product_editor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("ZapaVentas");
            var collection = database.GetCollection<producto>("productos");

            string id_prod = tbx_id_prod.Text.Trim();
            string nombre = tbx_nombre.Text.Trim();
            double precio = Convert.ToDouble(tbx_precio.Text.Trim());
            bool granel = cbx_granel.Checked;
            int inv = Convert.ToInt32(tbx_inv.Text.Trim());

            var exists = collection.Find(u => u.nombre == nombre).Any();

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
            {
                var update = Builders<producto>.Update
                    .Set("precio", precio)
                    .Set("granel", granel)
                    .Set("id_prod", id_prod)
                    .Set("inv", inv);
                collection.UpdateOne(u => u.nombre == nombre, update);

                MessageBox.Show("Producto editado correctamente");
            }
            reload_dgv();
        }

        private void product_editor_Load(object sender, EventArgs e)
        {
            reload_dgv();
        }

        private void dgv_productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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
