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
using static ZapaVentas.Program;

namespace ZapaVentas
{
    public partial class checkout : Form
    {
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
                    var database = client.GetDatabase("ZapaVentas");
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
            { // Si el pago no es suficiente se muestra un mensaje
                MessageBox.Show("El pago no es suficiente");
            }
        }
    }
}
