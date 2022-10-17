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
            string cs = @"server=localhost;userid=root;password=;database=a_p_ticket";
            var con = new MySqlConnection(cs);

            con.Open();

            var cmd = new MySqlCommand(q, con);
            MySqlDataReader rdr;

            try
            {   
                cmd.CommandText = q;

                using (rdr = cmd.ExecuteReader())
                {
                    int cont = 0;

                    while (rdr.Read())
                        cont++;

                    if (cont != 0)
                        return true;

                    else
                        return false;
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
            string cs = @"server=localhost;userid=root;password=;database=a_p_ticket";
            var con = new MySqlConnection(cs);

            con.Open();

            var cmd = new MySqlCommand(q, con);
            MySqlDataReader rdr;
            try
            {
                if (ReadingQuery(q))
                {
                    
                        cmd.CommandText = q;
                        string r = "";
                        using (rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                for (int i = 0; i < rdr.FieldCount; i++)
                                    r += rdr[i].ToString() + "-";

                                r += "\n";
                            }

                            return r;
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
