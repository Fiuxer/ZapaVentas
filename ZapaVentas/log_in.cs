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
        public class user
        {
            public ObjectId Id { get; set; }
            public string usr { get; set; }
            public string pwd { get; set; }
            public int privilege { get; set; }
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("ZapaVentas");
            var collection = database.GetCollection<user>("usuarios");

            var filter = Builders<user>.Filter.Eq("usr", tbx_usr.Text) &
                            Builders<user>.Filter.Eq("pwd", tbx_pwd.Text);

            var usuarios = collection.Find(filter).FirstOrDefault();

            if (usuarios != null)
            {
                MessageBox.Show("Bienvenido " + tbx_usr.Text);
                Global.usr = tbx_usr.Text;
                Global.privilege = usuarios.privilege;
                Form main = new Form1();
                main.Show();
                this.Hide();
            } else
            {
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
    }
}
