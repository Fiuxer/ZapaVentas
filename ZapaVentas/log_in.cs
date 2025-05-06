using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using static ZapaVentas.Program;

namespace ZapaVentas
{
    public partial class log_in : Form
    {
        public log_in()
        {
            InitializeComponent();
        }
        // Clase de usuario para que el programa sepa que datos buscar en mongoDB
        public class user
        {
            public ObjectId Id { get; set; }
            public string usr { get; set; }
            public string pwd { get; set; }
            public int privilege { get; set; }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            const string connectionUri = "mongodb+srv://leonardinoeb:BL9Pyfej9em3dGyx@zapaventas.f63uizl.mongodb.net/?retryWrites=true&w=majority&appName=ZapaVentas";

            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);

            try { 
                var res = client.GetDatabase("ZapaVentas").RunCommand<BsonDocument>(new BsonDocument("ping", 1));
                Console.WriteLine("Conexión exitosa a MongoDB Atlas.");
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            //Comprobar el usuario
            var database = client.GetDatabase("ZapaVentas");
            var collection = database.GetCollection<user>("usuarios");
            var filter = Builders<user>.Filter.Eq(u => u.usr, tbx_usr.Text) & Builders<user>.Filter.Eq(u => u.pwd, tbx_pwd.Text);

            var result = collection.Find(filter).FirstOrDefault();

            if (result != null)
            {
                Form main = new main();
                Global.usr = tbx_usr.Text;
                Global.privilege = result.privilege;
                main.Show();
                this.Hide();
            }

        }

        private void log_in_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
