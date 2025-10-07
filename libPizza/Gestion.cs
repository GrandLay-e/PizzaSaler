using System;
using System.Collections.Generic;
using System.Data;
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

        public ConnexionSingleton Connexion = ConnexionSingleton.Instance;

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
            MesCommandes = new List<Commande>();
            MesClients = new List<Client>();
            MesPizzas = new List<Pizza>();
            Connexion.Initialize();
            Connexion.OpenConnection();
            LoadAll();
        }

        public int NumCommandeClient(Client client)
        {
            foreach(Commande commande in mesCommandes)
            {
                if (commande.LeClient == client)
                    return commande.NumCommande;
            }
            return 0;
        }

        public void AjouterCommande(Client client)
        {
            Commande commande = new Commande(client);
            MesCommandes.Add(commande);
            SauvegarderCommandes(commande);
        }

        public void AjouterNouveauClient(
            string adresse,
            string codePostal,
            string nom,
            string prenom,
            string telephone,
            string ville){
            Client client = new Client(adresse, codePostal, nom, prenom, telephone, ville);
            MesClients.Add(client);
            SauvegarderClients(client);
        }

        //public void AjouterNouvelPizza(string nom)
        //{
        //    MesPizzas.Add(new Pizza(nom));
        //}
        public void AjouterNouvelPizza(string nom, double prix)
        {
            Pizza pizza = new Pizza(nom, prix);
            MesPizzas.Add(pizza);
            SauvegarderPizzas(pizza);
        }


        public void AjouterPizza(Pizza pizza, int numCommande)
        {
            foreach(Commande commande in MesCommandes)
            {
                if(commande.NumCommande == numCommande)
                {
                    commande.AjouterNouvellePizza(pizza);
                }
            }
        }

        public List<Client> GetListClient() => MesClients;
        public List<Pizza> GetListPizza() => MesPizzas;
        
        public Client GetClient(string nom)
        {
            foreach (Client client in MesClients)
            {
                if(client.Nom == nom)
                    return client;
            }
            return null;
        }

        public Pizza GetPizza(string nom)
        {
            foreach(Pizza pizza  in MesPizzas)
            {
                if(pizza.Nom == nom) return pizza;
            }
            return null;
        }

        public Commande GetCommande(int numCommande)
        {
            foreach(Commande commande in MesCommandes)
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

        public override string ToString()
        {
            return $"Gestion : [Commandes={string.Join(", ", MesCommandes)}, " + 
                   $"Clients : {string.Join(", ", MesClients)}, " +
                   $"Pizzas : {string.Join(", ", MesPizzas)}]";
        }

        ///_______________________________________________________________________________________________///
        /// <summary>
        /// METHODES POUR LA SAUVEGARDE ET LE CHARGEMENT
        /// </summary>
        /// 

        private void SauvegarderClients( Client c)
        {
            Connexion.ExecuteNonQuery($"INSERT INTO Client (Nom, Prenom, Adresse, code_postal, Ville, Telephone) " +
                                      $"VALUES ('{c.Nom}', '{c.Prenom}', '{c.Adresse}', '{c.CodePostal}', '{c.Ville}', '{c.Telephone}')");
        }
        private void SauvegarderPizzas( Pizza p)
        {
            Connexion.ExecuteNonQuery($"INSERT INTO Pizza (Nom, Prix) " +
                                      $"VALUES ('{p.Nom}', {p.Prix})");
        }
        private void SauvegarderCommandes(Commande cmd)
        {

            // Sauvegarder la commande
            Connexion.ExecuteNonQuery($"INSERT INTO Commande (num_commande, date_, emporter, id_client) " +
                                      $"VALUES ({cmd.NumCommande}, '{cmd.DateCommande:yyyy-MM-dd HH:mm:ss}', {(cmd.AEmporter ? 1 : 0)}, " +
                                      $"(SELECT id_client FROM Client WHERE Nom = '{cmd.LeClient.Nom}' AND Prenom = '{cmd.LeClient.Prenom}'))");

            // Sauvegarder les pizzas associées à la commande dans la table de gestion
            //SauvegarderGestion(cmd);
        }
        public void SauvegarderGestion(Commande cmd)
        {
            // Grouper les pizzas par nom pour calculer la quantité de chaque type de pizza
            var pizzasGroupees = cmd.MesPizzas.GroupBy(p => p.Nom);
            
            foreach (var groupe in pizzasGroupees)
            {
                string nomPizza = groupe.Key;
                int quantite = groupe.Count(); // Nombre de pizzas de ce type dans la commande
                
                // Insérer UNE SEULE ligne par type de pizza avec la quantité totale
                Connexion.ExecuteNonQuery(
                    $"INSERT INTO Gestion (id_pizza, num_commande, quantite) " +
                    $"VALUES ((SELECT id_pizza FROM Pizza WHERE Nom = '{nomPizza}'), " +
                    $"{cmd.NumCommande}, {quantite})");
            }
        }

        private void LoadPizzas()
        {
            var result = Connexion.ExecuteQuery("SELECT * FROM Pizza");
            foreach (DataRow row in result.Rows)
            {
                string nom = row["Nom"].ToString();
                double prix = Convert.ToDouble(row["Prix"]);
                MesPizzas.Add(new Pizza(nom, prix));
            }
        }
        private void LoadClients()
        {
            var result = Connexion.ExecuteQuery("SELECT * FROM Client");
            foreach (DataRow row in result.Rows)
            {
                string adresse = row["Adresse"].ToString();
                string codePostal = row["Code_postal"].ToString();
                string nom = row["Nom"].ToString();
                string prenom = row["Prenom"].ToString();
                string telephone = row["Telephone"].ToString();
                string ville = row["Ville"].ToString();
                MesClients.Add(new Client(adresse, codePostal, nom, prenom, telephone, ville));
            }
        }
        private void LoadCommandes()
        {
            var result = Connexion.ExecuteQuery("SELECT * FROM Commande");
            foreach (DataRow row in result.Rows)
            {
                int numCommande = Convert.ToInt32(row["Num_Commande"]);
                DateTime dateCommande = Convert.ToDateTime(row["date_"]);
                bool aEmporter = Convert.ToBoolean(row["emporter"]); // PROBLEME ICI
                //var aEmporter = row["aEmporter"];
                int clientID = Convert.ToInt32(row["id_client"]);
                Client leClient = null;
                var clientResult = Connexion.ExecuteQuery($"SELECT * FROM Client WHERE id_client = {clientID}");
                if (clientResult.Rows.Count > 0)
                {
                    DataRow clientRow = clientResult.Rows[0];
                    string adresse = clientRow["Adresse"].ToString();
                    string codePostal = clientRow["Code_postal"].ToString();
                    string nom = clientRow["Nom"].ToString();
                    string prenom = clientRow["Prenom"].ToString();
                    string telephone = clientRow["Telephone"].ToString();
                    string ville = clientRow["Ville"].ToString();
                    leClient = new Client(adresse, codePostal, nom, prenom, telephone, ville);
                }
                Commande cmd = new Commande(leClient)
                {
                    NumCommande = numCommande,
                    DateCommande = dateCommande,
                    AEmporter = aEmporter
                };
                MesCommandes.Add(cmd);
            }
        }
        private void LoadAll()
        {
            LoadPizzas();
            LoadClients();
            LoadCommandes();
        }

    }
}
