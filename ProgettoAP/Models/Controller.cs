using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ProgettoAP.Models
{
    //Interazione Client e server
    class Controller
    {

        public static bool EffettuaLogin(string user, string psw)
        {
            if (Sessione.ServerDB.Login(user, psw, true))
                return true;

            else
                return false;
        }

        public static Utente getInfoUser(string email, string psw)
        {
            try
            {
                Utente utente = Utente.UtenteSToUUtente(Sessione.ServerDB.InfoUtente(email, psw));
                if(utente.Id != 0)
                {
                    return utente;
                }
                return null;
            }

            catch
            {
                MessageBox.Show("ERRORE! MetodoGetInfoUser nel cotnroller");
                Application.Exit();
            }
            return null;
        }
    }
}
