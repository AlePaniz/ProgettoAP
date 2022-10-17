using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoAP.Models
{
    class Ceo_organizzazioni
    {
        //Atttributi
        private int id;
        private string nome;
        private string cognome;
        private string email;
        private string password;
        private int codOrganizzazione;

        public Ceo_organizzazioni() { }

        public Ceo_organizzazioni(int id, string nome, string cognome, string email, string password, int codOrganizzazione)
        {
            this.id = id;
            this.nome = nome;
            this.cognome = cognome;
            this.email = email;
            this.password = password;
            this.codOrganizzazione = codOrganizzazione;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public int CodOrganizzazione { get => codOrganizzazione; set => codOrganizzazione = value; }

        //Metodi

    }
}
