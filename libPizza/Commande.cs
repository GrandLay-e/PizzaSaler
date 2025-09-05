using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libPizza
{
    public class Commande
    {
        private static int nbCommande;

        private Client leClient;
        private List<Pizza> mesPizzas;
        private int numCommande;
        private bool aEmporter;
        private DateTime dateCommande;

        public int NbCommande
        {
            get { return nbCommande; }
            set { nbCommande = value; }
        }
        public Client LeClient
        {
            get {return leClient;}
            set {leClient = value;}
        }
        public List<Pizza> MesPizzas
        {
            get {  return mesPizzas; }
            set { mesPizzas = value; }
        }
        public int NumCommande
        {
            get { return numCommande; }
            set { numCommande = value; }
        }
        public DateTime DateCommande
        {
            get { return dateCommande;}
            set { dateCommande = value; }
        }
        public bool AEmporter
        {
            get { return aEmporter; }
            set { aEmporter = value; }
        }

        public Commande()
        {
            this.NbCommande += 1;
            this.NumCommande = NbCommande;
            this.MesPizzas = new List<Pizza>();
            this.AEmporter = true;
            this.DateCommande = DateTime.Now;

        }
        public Commande(Client client)
        {
            this.NbCommande += 1;
            this.NumCommande = NbCommande;
            this.DateCommande = DateTime.Now;
            this.MesPizzas = new List<Pizza>();
            this.LeClient = client;
            this.AEmporter = true;
        }

        public void AjouterNouvellePizza(Pizza pizza)
        {
            this.MesPizzas.Add(pizza);
        }

        public int GetQuantiteTotalePizzas()
        {
            return this.NbCommande;
        }

        public override string ToString()
        {
            return $"Commande #{this.GetQuantiteTotalePizzas()} pour {this.LeClient.Prenom} le {this.DateCommande:d} à {this.DateCommande:t}";
        }
    }
}
