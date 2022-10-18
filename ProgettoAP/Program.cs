using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgettoAP.Forms;
using ProgettoAP.Models;
namespace ProgettoAP
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Sessione.ServerDB = new ServiceReference.DBServiceClient();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
