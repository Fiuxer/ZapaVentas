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
    public partial class conteo : Form
    {
        public conteo()
        {
            InitializeComponent();
        }

        public class Producto
        {
            public string nombre { get; set; }
            public double precio { get; set; }
            public int cant { get; set; }
        }

        public class Venta
        {
            public ObjectId id { get; set; }
            public DateTime fecha { get; set; }
            public List<Producto> productos { get; set; }
            public double total { get; set; }
            public string usuario { get; set; }
        }

        private void reload()
        {
            // Conexión a la base de datos
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(Global.databaseName);
            var collection = database.GetCollection<Venta>("ventas");

            var filter = Builders<Venta>.Filter.Empty;

            if (cbx_view_mine.Checked)
            {
                filter = Builders<Venta>.Filter.Eq(u => u.usuario, Global.usr);
            }

            var result = collection.Find(filter);

            dgv_conteo.DataSource = result.ToList();
            dgv_conteo.Columns["id"].Visible = false;
        }
        private void conteo_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void conteo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form main = new main();
            main.Show();
        }

        private void cbx_view_mine_CheckedChanged(object sender, EventArgs e)
        {
            reload();
        }
    }
}
