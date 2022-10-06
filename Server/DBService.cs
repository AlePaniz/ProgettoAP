using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;

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

        public bool Login(string user, string psw)
        {
            DataTable dt = new DataTable();
            DataTable id = new DataTable();
            DataTable dataTable = new DataTable();

            con.cn.Open();

            try
            {
                con.cn.Open();

                if (organizzatore)             //LOGIN CEO
                {
                    string queryCEO = "SELECT * FROM ceo_organizzazioni WHERE Email = '" + email + "' AND Password = MD5('" + password + "')";    //VERIFICA CHE I DATI INSERITI SIANO PRESENTI NEL DATABASE
                    MySqlDataAdapter da = new MySqlDataAdapter(queryCEO, con.cn);

                    da.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        string qId = "SELECT ID from ceo_organizzazioni WHERE Email = '" + email + "'";//QUERY PER TROVARE L'ID DELL'UTENTE
                        MySqlDataAdapter da1 = new MySqlDataAdapter(qId, con.cn);                  //CON LE VARIABILI DI SQL UTILI PER CIO'
                        da1.Fill(id);
                        LoginInfo.UserID = Int32.Parse(id.Rows[0]["ID"].ToString());            //SE I DATI INSERITI SONO CORRETTI ALLORA L'UTENTE VIENE LOGGATO E REINDIRIZZATO NELLA HOME DEL PROGRAMMA
                        FormInterfacciaCEO home = new FormInterfacciaCEO();
                        home.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Dati inseriti errati", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);       //SE I DATI INSERITI SONO ERRATI ESCE QUESTO MESSAGGIO DI ERRORE E I DATI VENGONO CANCELLATI 
                    }
                }
                else                                         //LOGIN UTENTI NORMALI
                {
                    string queryUtenti = "SELECT * FROM utenti WHERE Email = '" + email + "' AND Password = MD5('" + password + "')";
                    MySqlDataAdapter sda = new MySqlDataAdapter(queryUtenti, con.cn);

                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        string qId = "SELECT ID from utenti WHERE Email = '" + email + "'";//QUERY PER TROVARE L'ID DELL'UTENTE
                        MySqlDataAdapter da = new MySqlDataAdapter(qId, con.cn);                  //CON LE VARIABILI DI SQL UTILI PER CIO'
                        da.Fill(id);
                        LoginInfo.UserID = Int32.Parse(id.Rows[0]["ID"].ToString());
                        FormInterfacciaUtente home = new FormInterfacciaUtente();
                        home.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Dati inseriti errati", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }
            finally
            {
                con.cn.Close();
            }
        }

    }
}
