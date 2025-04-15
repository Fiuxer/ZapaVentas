using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            Application.Run(new Form1());
        }

        class Global
        {
            public MongoClient client;
            public IMongoDatabase database;

            public Global()
            {
                client = new MongoClient("mongodb://localhost:27017");
                database = client.GetDatabase("ZapaVentas");
            }
        }
    }
}
