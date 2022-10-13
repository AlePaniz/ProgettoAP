using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;
using Server.Models;

namespace Server
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "DBService" nel codice e nel file di configurazione contemporaneamente.
    public class DBService : IDBService
    {
        public MySqlConnection cn;
        public void Connessione()
        {
            cn = new MySqlConnection("Datasource = 127.0.0.1;username=root;password=;database=a_p_ticket");
        }


        
        public bool Login(string email, string psw, bool organizzatore)
        {
            DataTable dt = new DataTable();
            DataTable id = new DataTable();
            DataTable dataTable = new DataTable();

            cn.Open();

            try
            {
                if (organizzatore)             //LOGIN CEO
                {
                    string queryCEO = "SELECT * FROM ceo_organizzazioni WHERE Email = '" + email + "' AND Password = MD5('" + psw + "')";    //VERIFICA CHE I DATI INSERITI SIANO PRESENTI NEL DATABASE
                    MySqlDataAdapter da = new MySqlDataAdapter(queryCEO, cn);

                    da.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        string qId = "SELECT ID from ceo_organizzazioni WHERE Email = '" + email + "'";//QUERY PER TROVARE L'ID DELL'UTENTE
                        MySqlDataAdapter da1 = new MySqlDataAdapter(qId, cn);                  //CON LE VARIABILI DI SQL UTILI PER CIO'
                        da1.Fill(id);
                        //LoginInfo.UserID = Int32.Parse(id.Rows[0]["ID"].ToString());            //SE I DATI INSERITI SONO CORRETTI ALLORA L'UTENTE VIENE LOGGATO E REINDIRIZZATO NELLA HOME DEL PROGRAMMA
                        //FormInterfacciaCEO home = new FormInterfacciaCEO();
                        //home.ShowDialog();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Dati inseriti errati", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);       //SE I DATI INSERITI SONO ERRATI ESCE QUESTO MESSAGGIO DI ERRORE E I DATI VENGONO CANCELLATI 
                        return false;
                    }
                }
                else                                         //LOGIN UTENTI NORMALI
                {
                    string queryUtenti = "SELECT * FROM utenti WHERE Email = '" + email + "' AND Password = MD5('" + psw + "')";
                    MySqlDataAdapter sda = new MySqlDataAdapter(queryUtenti, cn);

                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        string qId = "SELECT ID from utenti WHERE Email = '" + email + "'";//QUERY PER TROVARE L'ID DELL'UTENTE
                        MySqlDataAdapter da = new MySqlDataAdapter(qId, cn);                  //CON LE VARIABILI DI SQL UTILI PER CIO'
                        da.Fill(id);
                        //LoginInfo.UserID = Int32.Parse(id.Rows[0]["ID"].ToString());
                        //FormInterfacciaUtente home = new FormInterfacciaUtente();
                        //home.ShowDialog();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Dati inseriti errati", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }
            finally
            {
                cn.Close();
            }
        }

        public UtenteS InfoUtente(string e, string psw)
        {
            string q = "SELECT* FROM utenti WHERE Email = '" + e + "' AND Password = MD5('" + psw + "')";

            try
            {
                string r = Interazione.GetInfo(q);
                if(r != null)
                {
                    return UtenteS.GeneraUtente(r);
                }

            }
            catch (Exception ex)
            {
                if (Interazione.Connessione != null) //Controllo che la connessione sia stata aperta
                    Interazione.Connessione.Close(); //Chiudo la connessione

                Console.WriteLine("ERRORE NELL'ESECUZIONE DELLA QUERY PER LE INFORMAZIONI DELL'UTENTE: " + ex.ToString());
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("DATI RICHIESTI AL SERVER CON SUCCESSO");
            }
            return null;
        }

    }
}
