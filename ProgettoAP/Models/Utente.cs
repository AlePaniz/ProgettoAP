
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoAP.Models
{
    class Utente
    {
        //Attributi
        private string nome;
        private string cognome;
        private string username;
        private string email;
        private string password;
        
        //Costruttore Vuoto
        public Utente() { }

        //Costruttore della classe Utente
        public Utente(string nome, string cognome, string username, string email, string password)
        {
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
   
        

    }
}
