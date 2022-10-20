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
    public partial class Registrazione : Form
    {
        public Registrazione()
        {
            InitializeComponent();
        }

        private void Registrazione_Load(object sender, EventArgs e)
        {
            tOrg.Hide();
            cbOrg.Hide();
            this.cbOrg.DropDownStyle = ComboBoxStyle.DropDownList; //Non permette di scrivere nella combobox facendola diventare di fatto una ddlist
            string s = Controller.GetNomeOrganizzazioni();
            List<string> oInfo = s.Split('-').ToList();
            foreach(string i in oInfo)
            {
                cbOrg.Items.Add(i);
            }
        }

        private void checkBoxOrg_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOrg.Checked)
            {
                tOrg.Show();
                cbOrg.Show();
                tUser.Hide();
                tbUser.Hide();
            }
            else
            {
                tUser.Show();
                tbUser.Show();
                tOrg.Hide();
                cbOrg.Hide();
            }
        }
    }
}
