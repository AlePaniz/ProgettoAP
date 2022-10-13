using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgettoAP.Models;

namespace ProgettoAP.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            try { 
            
                string email = tbEmail.Text;
                string password = tbPsw.Text;

                if (Controller.EffettuaLogin(email, password)) ///Effettuo il login
                {
                    Utente utente = Controller.getInfoUser(email, password);

                if (utente != null)
                {
                    Sessione.Utente = utente;
                }

                else
                    MessageBox.Show("Username o password non validi");
                }
            }

            catch
            {
                MessageBox.Show("ERRORE! FormLogin: errore click bottone accesso");
                Application.Exit();
            }
        }

        
    }
}
