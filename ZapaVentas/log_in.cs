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
using System.Globalization;
using System.Threading;
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
            // Conexión a la base de datos
            var connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(Global.databaseName);
            var collection = database.GetCollection<user>("usuarios");

            // Buscar usuarios en los que el nombre y el usuario coincidan a
            // los que el vendedor escribió con el uso de funciones lambda
            var filter = Builders<user>.Filter.Eq("usr", tbx_usr.Text) &
                            Builders<user>.Filter.Eq("pwd", tbx_pwd.Text);

            // Si el usuario existe, se guarda en la variable usuarios
            var usuarios = collection.Find(filter).FirstOrDefault();

            // Si el usuario si existe, entra a la sección de ventas
            if (usuarios != null)
            {
                Global.usr = tbx_usr.Text;
                Global.privilege = usuarios.privilege;
                Form main = new main();
                main.Show();
                this.Hide();
            } else
            {
                // Si el usuario no existe, muestra un mensaje de datos incorrectos
                MessageBox.Show("Usuario o contraseña incorrectos");
                tbx_usr.Clear();
                tbx_pwd.Clear();
                tbx_usr.Focus();
            }
        }

        private void log_in_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void log_in_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh-CHS");
            refresh();
        }

        private void refresh()
        {
            btn_login.Text = Properties.Resources.login;
            tbx_usr.Text = Properties.Resources.usr;
        }

        private void btn_es_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es");
            refresh();
        }

        private void btn_en_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            refresh();
        }

        private void btn_de_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");
            refresh();
        }

        private void btn_zn_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh-CHS");
            refresh();
        }

        private void btn_fr_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr");
            refresh();
        }
    }
}
