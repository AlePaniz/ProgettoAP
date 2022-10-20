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
            try
            {
                if (organizzatore)             //LOGIN CEO
                {
                    string qCeo = "SELECT * FROM ceo_organizzazioni WHERE Email = '" + email + "' AND Password = MD5('" + psw + "')";    //VERIFICA CHE I DATI INSERITI SIANO PRESENTI NEL DATABASE
                    return Interazione.ReadingQuery(qCeo);
                }
                else                                         //LOGIN UTENTI NORMALI
                {
                    string qUtenti = "SELECT * FROM utenti WHERE Email = '" + email + "' AND Password = MD5('" + psw + "')";
                    return Interazione.ReadingQuery(qUtenti);
                }
            }
            catch (Exception)
            {
                throw new Exception();
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
                Console.WriteLine("DATI RICHIESTI PER L'UTENTE AL SERVER CON SUCCESSO");
            }
            return null;
        }

        public Ceo_organizzazioniS InfoCeo(string e, string psw)
        {
            string q = "SELECT* FROM ceo_organizzazioni WHERE Email = '" + e + "' AND Password = MD5('" + psw + "')";

            try
            {
                string r = Interazione.GetInfo(q);
                if (r != null)
                {
                    return Ceo_organizzazioniS.GeneraCeo(r);
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
                Console.WriteLine("DATI RICHIESTI PER IL CEO AL SERVER CON SUCCESSO");
            }
            return null;
        }

        public string GetNomiOrganizzazioni()
        {
            string q= "SELECT nome " +
                      "FROM organizzazione";
            try
            {
                string r = Interazione.GetInfo(q);
                if (r != null)
                {
                    return r;
                }

            }
            catch(Exception ex)
            {
                if (Interazione.Connessione != null) //Controllo che la connessione sia stata aperta
                    Interazione.Connessione.Close(); //Chiudo la connessione
                Console.WriteLine("ERRORE NELL'ESECUZIONE DELLA QUERY PER I NOMI DELLE ORGANIZZAZIONI: " + ex.ToString());
                Console.ReadLine();

            }
            finally
            {
                Console.WriteLine("DATI RICHIESTI PER LE ORGANIZZAZIONI AL SERVER CON SUCCESSO");
            }
            return "";
        }
    }
}
