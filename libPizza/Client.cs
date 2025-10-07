using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace libPizza
{
    public class Client
    {
        private string adresse;
        private string codePostal;
        private string nom;
        private string prenom;
        private string telephone;
        private string ville;

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
        public string CodePostal
        {
            get { return codePostal; }
            set { codePostal = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }
        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }
        public Client()
        {
            this.Adresse = "";
            this.CodePostal = "";
            this.Nom = "";
            this.Prenom = "";
            this.Telephone = ""; 
            this.Ville = "";

        }
        public Client(string adresse, string codePostal, string nom, string prenom, string telephone, string ville)
        {
            this.Adresse = adresse;
            this.CodePostal = codePostal;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Telephone = telephone;
            this.Ville = ville;
        }

        public override string ToString()
        {
            return $" Le client {Prenom} {Nom}, \n adresse : {Adresse}, {CodePostal}, {Ville} \n N° de Téléphone : {Telephone}";
        }
    }
}
