using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ZapaVentas
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new log_in());
        }

        public class Producto
        {
            public ObjectId id { get; set; }
            public string id_prod { get; set; }
            public string nombre { get; set; }
            public double precio { get; set; }
            public bool granel { get; set; }
            public int inv { get; set; }
        }

        public static class Global
        {
            public static string usr { get; set; }
            public static int privilege { get; set; }
            public static List<Producto> productos { get; set; } = new List<Producto>(); //[("Manzana", "2"), ("Palomitas", "3"), ("Leche", "4")]
        }
    }
}
