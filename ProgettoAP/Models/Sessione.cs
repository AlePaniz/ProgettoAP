using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgettoAP.ServiceReference;

namespace ProgettoAP.Models
{
    static class Sessione
    {
        private static Utente utente;
        private static DBServiceClient serverDB;
        private static Ceo_organizzazioni ceo;

        public static DBServiceClient ServerDB { get => serverDB; set => serverDB = value; }
        public static Utente Utente { get => utente; set => utente = value; }
        internal static Ceo_organizzazioni Ceo { get => ceo; set => ceo = value; }
    }
}
