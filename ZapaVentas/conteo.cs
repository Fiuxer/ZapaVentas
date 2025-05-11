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
    public partial class conteo : Form
    {
        public conteo()
        {
            InitializeComponent();
        }

        public class Producto // Clase para leer los productos mas facil
        {
            public string nombre { get; set; }
            public double precio { get; set; }
            public int cant { get; set; }
        }

        public class Venta // Clase para leer las ventas mas facil
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
            // Reinicia el filtro
            var filter = Builders<Venta>.Filter.Empty;

            if (cbx_view_mine.Checked)
            {
                filter = Builders<Venta>.Filter.Eq(u => u.usuario, Global.usr); // Filtro para ver solo las ventas del usuario
            }

            var result = collection.Find(filter); // Busca todas las ventas en la base de datos

            // Carga los datos obtenidos en el DataGridView
            dgv_conteo.DataSource = result.ToList();
            dgv_conteo.Columns["id"].Visible = false;
        }
        private void conteo_Load(object sender, EventArgs e)
        {
            reload();
            // Carga las traducciones de los textos.
            cbx_view_mine.Text = Resources.cbx_viewMine;
        }

        private void conteo_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Si se cierra el form, entonces vuelve a abrir el form principal
            Form main = new main();
            main.Show();
        }

        private void cbx_view_mine_CheckedChanged(object sender, EventArgs e)
        {
            // Si se cambia el checkbox, entonces recarga el DataGridView
            reload();
        }
    }
}
