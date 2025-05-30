﻿using System;
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
using System.Globalization;
using System.Threading;
using static ZapaVentas.Program;
using ZapaVentas.Properties;

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
            // Carga el nombre de la base de datos.
            tbx_database_name.Text = Global.databaseName;
            // Carga las traducciones de los textos.
            lbl_alert.Text = Resources.lbl_alert;
            lbl_newUsr.Text = Resources.lbl_newUsr;
            lbl_pwd.Text = Resources.pwd;
            lbl_role.Text = Resources.role;
            lbl_usr.Text = Resources.usr;
            lbl_database.Text = Resources.lbl_database;
        }

        private void tbx_database_name_TextChanged(object sender, EventArgs e)
        {
            if (tbx_database_name.Text != Global.databaseName) // 
            {
                // Si el nombre de la base de datos es diferente al actual, entonces muestra el botón de cambiar nombre.
                btn_cambiar_nombre.Visible = true;
                lbl_alert.Visible = true;
            }
        }

        private void btn_cambiar_nombre_Click(object sender, EventArgs e)
        {
            string lastDatabaseName = Global.databaseName; // Guarda el nombre de la base de datos actual.
            try // Intenta cambiar el nombre de la base de datos.
            {
                Global.databaseName = tbx_database_name.Text;
                // Conectar a la base de datos
                var connectionString = "mongodb://localhost:27017";
                var client = new MongoClient(connectionString);
                var database = client.GetDatabase(Global.databaseName);
                var collection = database.GetCollection<Usuario>("usuarios");

                // Verificar si la colección existe
                var filter = Builders<Usuario>.Filter.Eq(u => u.usr, "admin");
                var result = collection.Find(filter).FirstOrDefault();

                if (result == null) // Si no existe el usuario admin, entonces lo crea
                {
                    var adminUser = new Usuario // Crear un nuevo usuario admin por defecto
                    {
                        usr = "admin",
                        pwd = "1234",
                        privilege = 1
                    };

                    collection.InsertOne(adminUser); // Inserta el usuario admin en la colección
                }

            }
            catch (Exception ex) // Si hubo un error al cambiar el nombre de la base de datos, entonces muestra un mensaje de error.
            {
                MessageBox.Show("Error al cambiar el nombre de la base de datos: " + ex.Message);
                // Si hubo un error, revertir el nombre de la base de datos
                Global.databaseName = lastDatabaseName;
            }
            finally // Ya una vez terminado, vuelve a ocultar los botones.
            {
                btn_cambiar_nombre.Visible = false;
                lbl_alert.Visible = false;
            }
        }

        private void btn_create_profile_Click(object sender, EventArgs e) // Crea un nuevo perfil de usuario
        {
            // Conectar a la base de datos
            var connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(Global.databaseName);
            var collection = database.GetCollection<Usuario>("usuarios");

            var newUser = new Usuario // Crear un nuevo usuario
            {
                usr = tbx_usr.Text,
                pwd = tbx_pwd.Text,
                privilege = Convert.ToInt32(cmb_rol.SelectedIndex) + 1
            };

            // Verificar si el usuario ya existe
            var filter = Builders<Usuario>.Filter.Eq(u => u.usr, newUser.usr);
            var result = collection.Find(filter).FirstOrDefault();

            if (result == null) // Si no existe el usuario, entonces lo agrega
            {
                collection.InsertOne(newUser);
                MessageBox.Show("Usuario creado exitosamente");
            }
            else // Si existe el usuario, entonces muestra un mensaje de error
            {
                MessageBox.Show("El usuario ya existe");
            }
        }

 
        
    }
}
