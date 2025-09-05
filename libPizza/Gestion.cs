using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libPizza
{
    public class Gestion
    {
        private List<Commande> mesCommandes;
        private List<Client> mesClients;
        private List<Pizza> mesPizzas;

        public List<Commande> MesCommandes
        {
            get { return mesCommandes; }
            set { mesCommandes = value; }
        }

        public List<Client> MesClients
        {
            get { return mesClients; }
            set { mesClients = value; }
        }

        public List<Pizza> MesPizzas
        {
            get { return mesPizzas; }
            set { mesPizzas = value; }
        }

        public Gestion()
        {
            this.MesCommandes = new List<Commande>();
            this.MesClients = new List<Client>();
            this.MesPizzas = new List<Pizza>();
        }

        public int NumCommandeClient(Client client) // Testé ok
        {
            foreach(Commande commande in mesCommandes)
            {
                if (commande.LeClient == client)
                    return commande.NumCommande;
            }
            return 0;
        }

        public void AjouterCommande(Client client) // Testé Ok
        {
            this.MesCommandes.Add(new Commande(client));
        }

        public void AjouterNouveauClient( //Testé OK
            string adresse,
            string codePostal, 
            string nom, 
            string prenom, 
            string telephone, 
            string ville)
        {
            this.MesClients.Add(new Client(adresse, codePostal, nom, prenom, telephone, ville));
        }

        public void AjouterNouvelPizza(string nom)
        {
            this.MesPizzas.Add(new Pizza(nom));
        }
        public void AjouterPizza(Pizza pizza, int numCommande)
        {
            foreach(Commande commande in this.MesCommandes)
            {
                if(commande.NumCommande == numCommande)
                {
                    commande.AjouterNouvellePizza(pizza);
                }
            }
        }

        public List<Client> GetListClient() => this.MesClients;
        public List<Pizza> GetListPizza() => this.MesPizzas;
        
        public Client GetClient(string nom)
        {
            foreach (Client client in this.MesClients)
            {
                if(client.Nom == nom)
                    return client;
            }
            return null;
        }

        public Pizza GetPizza(string nom)
        {
            foreach(Pizza pizza  in this.MesPizzas)
            {
                if(pizza.Nom == nom) return pizza;
            }
            return null;
        }

        public Commande GetCommande(int numCommande)
        {
            foreach(Commande commande in this.MesCommandes)
            {
                if(commande.NumCommande == numCommande)
                    return commande;
            }
            return null;
        }

        public string AfficherCommande(int numCommande)
        {
            return GetCommande(numCommande).ToString();
        }
    }
}
