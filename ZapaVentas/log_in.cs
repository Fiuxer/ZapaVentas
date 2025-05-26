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
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

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
            string connectionString = "server=localhost;user=root;password=;database=zapaventas";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM usuarios WHERE usr = @usr AND pwd = @pwd";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@usr", tbx_usr.Text);
                    cmd.Parameters.AddWithValue("@pwd", tbx_pwd.Text);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Global.usr = (reader["usr"]).ToString();
                            Global.privilege = Convert.ToInt16(reader["privilege"]);
                            Form main = new main();
                            main.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Contraseña o usuario incorrectos");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void log_in_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void log_in_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es"); // Coloca el idioma español por defecto.
            refresh();
        }

        private void refresh() // Función para refrescar el texto de los botones
        {
            // Reemplaza el texto de los botones para que sean multilenguaje, para poder cambiarles el texto con facilidad.
            btn_login.Text = Properties.Resources.login;  
            tbx_usr.Text = Properties.Resources.usr;
            lbl_title.Text = Properties.Resources.iniciarsesion;
            lbl_user.Text = Properties.Resources.usr;
            lbl_pass.Text = Properties.Resources.pwd;
        }

        private void btn_es_Click(object sender, EventArgs e) // Botón para cambiar el idioma a español
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es"); // Cambia el idioma a español
            refresh(); // Recarga el texto de los botones
        }

        private void btn_en_Click(object sender, EventArgs e) // Botón para cambiar el idioma a inglés
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US"); // Cambia el idioma a inglés
            refresh(); // Recarga el texto de los botones
        }

        private void btn_de_Click(object sender, EventArgs e) // Botón para cambiar el idioma a alemán
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE"); // Cambia el idioma a alemán
            refresh(); // Recarga el texto de los botones
        }

        private void btn_zn_Click(object sender, EventArgs e) // Botón para cambiar el idioma a chino
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh-CHS"); // Cambia el idioma a chino
            refresh(); // Recarga el texto de los botones
        }

        private void btn_fr_Click(object sender, EventArgs e) // Botón para cambiar el idioma a francés
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr"); // Cambia el idioma a francés
            refresh(); // Recarga el texto de los botones
        }
    }
}
