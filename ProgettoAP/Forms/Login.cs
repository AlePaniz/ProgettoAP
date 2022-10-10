using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            
                    string username = tbUsername.Text;
                    string password = tbPassword.Text;

                    if (Controller.EffettuaLogin(username, password)) ///Effettuo il login
                    {
                        Lavoratore lavoratore = Controller.GetInfoLavoratore(username, username);

                        if (lavoratore != null)
                            Sessione.Lavoratore = lavoratore;

                        CheckLavoraotre();
                    }

                    else
                        MessageBox.Show("Username o password non validi", "Errore compilazione campi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                    lbErrore.Visible = true;
            }

            catch
            {
                MessageBox.Show("ERRORE! FormLogin: errore click bottone accesso", "FormLogin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
