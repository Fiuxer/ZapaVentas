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
        class producto
        {
            public ObjectId id { get; set; }
            public string id_prod { get; set; }
            public string nombre { get; set; }
            public double precio { get; set; }
            public bool granel { get; set; }
            public int inv { get; set; }
        }

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
            var connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("ZapaVentas");
            var collection = database.GetCollection<producto>("productos");

            string prod_name = tbx_nombre.Text.Trim();

            var productos = collection.Find(u => u.nombre.Contains(prod_name)).ToList();

            dgv_productos.DataSource = productos;
        }

        private void dgv_productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedProduct = (producto)dgv_productos.Rows[e.RowIndex].DataBoundItem;

                Global.nombre_prod = selectedProduct.nombre;

                pnl_cantidad_envasado.Visible = selectedProduct.granel;
                nud_cantidad.Focus();
            }
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) {
                Global.cant_prod = (int)nud_cantidad.Value;
                this.Close();
            }
        }
    }
}
