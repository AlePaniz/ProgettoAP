using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgettoAP.ServiceReference;

namespace ProgettoAP.Models
{
    //Interazione Client e server
    class Controller
    {
        
        public static bool EffettuaLoginUtente(string email, string psw)
        {
            if (Sessione.ServerDB.Login(email, psw, false))
                return true;

            else
                return false;
        }

        public static Utente getInfoUser(string email, string psw)
        {
            try
            {
                Utente utente = Utente.UtenteSToUUtente(Sessione.ServerDB.InfoUtente(email, psw));
                if (utente.Id != 0)
                {
                    return utente;
                }
                return null;
            }

            catch
            {
                MessageBox.Show("ERRORE! MetodoGetInfoUser nel cotroller");
                Application.Exit();
            }
            return null;
        }

        public static bool EffettuaLoginCeo(string email, string psw)
        {
            DBServiceClient server = new DBServiceClient();
            if(server.Login(email, psw, true))
            {
                return true;
            }
            return false;
        }
    }
}


