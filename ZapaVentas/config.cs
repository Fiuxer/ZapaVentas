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
    public partial class config : Form
    {
        public class Usuario
        {
            public ObjectId id { get; set; }
            public string usr { get; set; }
            public string pwd { get; set; }
            public int privilege { get; set; }
        }

        public config()
        {
            InitializeComponent();
        }

        private void config_Load(object sender, EventArgs e)
        {
            tbx_database_name.Text = Global.databaseName;
        }

        private void tbx_database_name_TextChanged(object sender, EventArgs e)
        {
            if (tbx_database_name.Text != Global.databaseName)
            {
                btn_cambiar_nombre.Visible = true;
                lbl_alert.Visible = true;
                lbl_alert2.Visible = true;
            }
        }

        private void btn_cambiar_nombre_Click(object sender, EventArgs e)
        {
            string lastDatabaseName = Global.databaseName;
            try
            {
                Global.databaseName = tbx_database_name.Text;

                var connectionString = "mongodb://localhost:27017";
                var client = new MongoClient(connectionString);
                var database = client.GetDatabase(Global.databaseName);
                var collection = database.GetCollection<Usuario>("usuarios");

                // Verificar si la colección existe
                var filter = Builders<Usuario>.Filter.Eq(u => u.usr, "admin");
                var result = collection.Find(filter).FirstOrDefault();

                if (result == null)
                {
                    var adminUser = new Usuario
                    {
                        usr = "admin",
                        pwd = "1234",
                        privilege = 1
                    };

                    collection.InsertOne(adminUser);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar el nombre de la base de datos: " + ex.Message);
                // Si hubo un error, revertir el nombre de la base de datos
                Global.databaseName = lastDatabaseName;
            }
            finally
            {
                btn_cambiar_nombre.Visible = false;
                lbl_alert.Visible = false;
                lbl_alert2.Visible = false;
            }
        }
    }
}
