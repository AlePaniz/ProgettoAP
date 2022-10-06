using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost svcHost = new ServiceHost(typeof(DBService)); //Istanzio il servizio di tipo ServiceAgendaAziendale
            svcHost.Open(); //Apro il servizio                                                                             

            Console.WriteLine("Istanzazione client ServerAziendaleDB e test connessione a ServerAziendaleDB effettuata");
            Console.ReadLine();

            svcHost.Close();
            Console.WriteLine("Servizio chiuso.");
        }
    }
}
