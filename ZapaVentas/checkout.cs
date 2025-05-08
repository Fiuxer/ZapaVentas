using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using ZapaVentas.Properties;
using static ZapaVentas.Program;

namespace ZapaVentas
{
    public partial class checkout : Form
    {
        //Para la animación del temporizador
        int time;

        public class product
        {
            public string nombre { get; set; }
            public double precio { get; set; }
            public int cant { get; set; }
        }

        public class Venta
        {
            public ObjectId id { get; set; }
            public DateTime fecha { get; set; }
            public List<product> productos { get; set; }
            public double total { get; set; }
            public string usuario { get; set; }
        }

        public checkout()
        {
            InitializeComponent();
        }

        private void checkout_Load(object sender, EventArgs e)
        {
            // Mostrar el precio de la compra
            lbl_total.Text = "$" + Global.precioTotal.ToString();
        }

        private void btn_efectivo_Click(object sender, EventArgs e)
        {
            // Mostrar el panel de efectivo y la cantidad a pagar
            pnl_efectivo.Visible = true;
            lbl_total_efectivo.Text = "$" + Global.precioTotal.ToString("0.00");
        }

        private void nud_pago_ValueChanged(object sender, EventArgs e)
        {
            // Calcular el cambio y mostrarlo
            double pago = (double)nud_pago.Value;
            var change = pago - Global.precioTotal;

            tbx_change.Text = change.ToString("0.00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Revisar si el pago es suficiente
            double pago = (double)nud_pago.Value;
            if (pago >= Global.precioTotal)
            { // Si el pago es suficiente se muestra que se realizó el pago
                MessageBox.Show("Pago realizado con éxito");
                foreach (Producto producto in Global.productos)
                {
                    // Conexión a la base de datos
                    string connectionString = "mongodb://localhost:27017";
                    MongoClient client = new MongoClient(connectionString);
                    var database = client.GetDatabase(Global.databaseName);
                    var collection = database.GetCollection<Producto>("productos");

                    // Buscar el producto en la base de datos con una función lambda
                    var filter = Builders<Producto>.Filter.Eq(u => u.nombre, producto.nombre);

                    var result = collection.Find(filter).FirstOrDefault();

                    // Si el producto existe, se actualiza su inventario
                    if (result != null)
                    {
                        var update = Builders<Producto>.Update.Set(u => u.inv, result.inv - producto.inv);
                        collection.UpdateOne(filter, update);
                    }
                }
                // Limpiar la lista de productos después de la compra
                Global.productos.Clear();
                this.Close();
            }
            else
            { // Si el pago no es suficiente se muestra un mensaje con el recurso local
                MessageBox.Show(Resources.ResourceManager.GetString("Error_NoEsSuficiente"));
            }
        }

        private void nud_pago_KeyDown(object sender, KeyEventArgs e)
        {
            //Permite pulsar la tecla enter en caso de que se haga eso
            if (e.KeyCode == Keys.Enter)
            {
                // Revisar si el pago es suficiente
                double pago = (double)nud_pago.Value;
                if (pago >= Global.precioTotal)
                { // Si el pago es suficiente se muestra que se realizó el pago
                    MessageBox.Show("Pago realizado con éxito");
                    foreach (Producto producto in Global.productos)
                    {
                        // Conexión a la base de datos
                        string connectionString = "mongodb://localhost:27017";
                        MongoClient client = new MongoClient(connectionString);
                        var database = client.GetDatabase(Global.databaseName);
                        var collection = database.GetCollection<Producto>("productos");

                        // Buscar el producto en la base de datos con una función lambda
                        var filter = Builders<Producto>.Filter.Eq(u => u.nombre, producto.nombre);

                        var result = collection.Find(filter).FirstOrDefault();

                        // Si el producto existe, se actualiza su inventario
                        if (result != null)
                        {
                            var update = Builders<Producto>.Update.Set(u => u.inv, result.inv - producto.inv);
                            collection.UpdateOne(filter, update);
                        }
                    }
                    // Limpiar la lista de productos después de la compra
                    addToVentas();
                    Global.productos.Clear();
                    this.Close();
                }
                else
                { // Si el pago no es suficiente se muestra un mensaje
                    MessageBox.Show(Resources.ResourceManager.GetString("Error_NoEsSuficiente"));
                }
            }
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            // Una animación para la pura estética del programa
            if (time < 15)
            {
                string text = "Insertar tarjeta.";

                for (int i = 0; i < time % 3; i++)
                {
                    text += ".";
                }

                lbl_card.Text = text;
                time++;
            } else if (time < 20)
            {
                lbl_card.Text = "Gracias por su compra";
                time++;
            }
            else
            {
                // Actualizar los datos de la base de datos
                foreach (Producto producto in Global.productos)
                {
                    // Conexión a la base de datos
                    string connectionString = "mongodb://localhost:27017";
                    MongoClient client = new MongoClient(connectionString);
                    var database = client.GetDatabase(Global.databaseName);
                    var collection = database.GetCollection<Producto>("productos");

                    // Buscar el producto en la base de datos con una función lambda
                    var filter = Builders<Producto>.Filter.Eq(u => u.nombre, producto.nombre);

                    var result = collection.Find(filter).FirstOrDefault();

                    // Si el producto existe, se actualiza su inventario
                    if (result != null)
                    {
                        var update = Builders<Producto>.Update.Set(u => u.inv, result.inv - producto.inv);
                        collection.UpdateOne(filter, update);
                    }
                }
                // Limpiar la lista de productos después de la compra
                addToVentas();
                Global.productos.Clear();
                this.Close();
            }
        }

        private void addToVentas()
        {
            List<product> products = Global.productos.Select(p => new product
            {
                nombre = p.nombre,
                precio = p.precio,
                cant = p.inv,
            }).ToList();


            var productos = Global.productos;
            var venta = new Venta
            {
                fecha = DateTime.Now,
                productos = products,
                usuario = Global.usr,
                total = Global.precioTotal
            };

            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            var database = client.GetDatabase(Global.databaseName);
            var collection = database.GetCollection<Venta>("ventas");

            collection.InsertOne(venta);
        }
        private void btn_tarjeta_Click(object sender, EventArgs e)
        {
            tick.Start();
            pnl_card.Visible = true;
        }
    }
}
