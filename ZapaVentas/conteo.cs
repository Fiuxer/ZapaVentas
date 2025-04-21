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

        private void conteo_Load(object sender, EventArgs e)
        {
            // Conexión a la base de datos
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(Global.databaseName);
            var collection = database.GetCollection<Producto>("ventas");

            // Ya bro tu aquí escribes 👽🔥🔥
        }

        private void conteo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form main = new main();
            main.Show();
        }
    }
}
