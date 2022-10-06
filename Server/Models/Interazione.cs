using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Server.Models
{
    class Interazione
    {
        private static readonly string connectionString = ConfigurationManager.AppSettings["connectionString"];
        private static MySqlConnection connessione = null;

        public static string ConnectionString => connectionString;
        public static MySqlConnection Connessione { get => connessione; set => connessione = value; }

        public static void ReadingQuery(string q)
        {
            try
            {
                using (MySqlCommand cmd = Connessione.CreateCommand())
                {

                }
            }
            catch
            {

            }
    }
}
