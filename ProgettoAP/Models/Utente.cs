
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Models;

namespace ProgettoAP.Models
{
    class Utente
    {
        //Attributi
        private int id;
        private string nome;
        private string cognome;
        private string username;
        private string email;
        private string password;
        
        //Costruttore Vuoto
        public Utente() { }

        //Costruttore della classe Utente
        public Utente(int id, string nome, string cognome, string username, string email, string password)
        {
            this.Id = id;
            this.nome = nome;
            this.cognome = cognome;
            this.username = username;
            this.email = email;
            this.password = password;
        }

        
        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public int Id { get => id; set => id = value; }


        //Metodi

        //Convertitore utente server in utente client
        public static Utente UtenteSToUUtente(UtenteS u)
        {
            return new Utente(u.Id, u.Nome, u.Cognome, u.Username, u.Email, u.Password);
        }
    }
}
