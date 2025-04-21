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

        //Clase general que da la estructura de cada producto de mongoDB
        public class Producto
        {
            public ObjectId id { get; set; }
            public string id_prod { get; set; }
            public string nombre { get; set; }
            public double precio { get; set; }
            public bool granel { get; set; }
            public int inv { get; set; }
        }

        //Clase que contiene los datos globales de la aplicacion
        public static class Global
        {
            //Usuario que está usando la aplicación actualmente
            public static string usr { get; set; }

            //Nivel de privilegio del usuario para determinar a que funciones puede acceder
            // 1 = Administrador
            // 2< = Usuario
            public static int privilege { get; set; }

            //Lista de los productos que se van a comprar
            public static List<Producto> productos { get; set; } = new List<Producto>(); //[("Manzana", "2"), ("Palomitas", "3"), ("Leche", "4")]

            //Precio total de la compra actual
            public static double precioTotal { get; set; } = 0.0;

            public static string connectionString { get; set; } = "mongodb://localhost:27017";

            public static MongoClient client { get; set; } = new MongoClient(connectionString);

            public static string databaseName { get; set; } = "ZapaVentas";
        }
    }
}
