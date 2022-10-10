using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
