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
    }
}
