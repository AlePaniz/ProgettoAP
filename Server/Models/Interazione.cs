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

        public static bool ReadingQuery(string q)
        {
            try
            {
                using (MySqlCommand cmd = Connessione.CreateCommand())
                {
                    cmd.CommandText = q;

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        int cont = 0;

                        while (reader.Read())
                            cont++;

                        if (cont != 0)
                            return true;

                        else
                            return false;
                    }

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERRORE!!! Metodo EseguiQuery_Lettura in InterazioneDB: " + ex.ToString());
                Console.ReadLine();
            }

            return false;
        }
        

        //metodo che esegue query che prendono informazioni da il db 
        public static string GetInfo(string q)
        {
            try
            {
                if (ReadingQuery(q))
                {
                    using (MySqlCommand cmd = Connessione.CreateCommand())
                    {
                        cmd.CommandText = q;
                        string r = "";
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                    r += reader[i].ToString() + "-";

                                r += "\n";
                            }

                            return r;
                        }
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRORE!!! Metodo EseguiQuery_Lettura in InterazioneDB: " + ex.ToString());
                Console.ReadLine();
            }

            return null;
        }
    }

    
}
