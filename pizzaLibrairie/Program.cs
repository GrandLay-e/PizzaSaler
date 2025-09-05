using libPizza;

//CLLIENTS
Client cl = new Client("153 rue Mitry", "13001", "Boulanger","Cedric","0707070707","Marseille");
Client cl2 = new Client("153 rue alma", "75017", "Thomas","Lemar","0707070707","Paris");

//PIZZAS
Pizza pizza = new Pizza("Reine");
Pizza pizza2 = new Pizza("Calzone");

//Commandes
Commande c1 = new Commande(cl);
c1.AjouterNouvellePizza(pizza);

Commande c2 = new Commande(cl2);
c2.AjouterNouvellePizza(pizza2);

//Gestion
Gestion g = new Gestion();

void TestGestion()
{
    // Création de l'objet Gestion
    Gestion gestion = new Gestion();

    // Test AjouterNouveauClient
    gestion.AjouterNouveauClient("10 rue de la Paix", "75002", "Dupont", "Jean", "0601020304", "Paris");
    gestion.AjouterNouveauClient("20 avenue des Champs", "75008", "Martin", "Claire", "0605060708", "Paris");

    // Test GetListClient
    var clients = gestion.GetListClient();
    Console.WriteLine("Liste des clients :");
    foreach (var client in clients)
        Console.WriteLine(client);

    // Test GetClient
    var clientJean = gestion.GetClient("Dupont");
    Console.WriteLine("\nRecherche client 'Dupont' :");
    Console.WriteLine(clientJean);

    // Test AjouterNouvelPizza
    gestion.AjouterNouvelPizza("Margherita");
    gestion.AjouterNouvelPizza("4 Fromages");

    // Test GetListPizza
    var pizzas = gestion.GetListPizza();
    Console.WriteLine("\nListe des pizzas :");
    foreach (var pizza in pizzas)
        Console.WriteLine(pizza.GetNomPizza());

    // Test GetPizza
    var pizzaMargherita = gestion.GetPizza("Margherita");
    Console.WriteLine("\nRecherche pizza 'Margherita' :");
    Console.WriteLine(pizzaMargherita.GetNomPizza());

    // Test AjouterCommande
    gestion.AjouterCommande(clientJean);
    var numCommandeJean = gestion.NumCommandeClient(clientJean);
    Console.WriteLine($"\nNuméro de commande pour Jean Dupont : {numCommandeJean}");

    // Test AjouterPizza
    gestion.AjouterPizza(pizzaMargherita, numCommandeJean);

    // Test GetCommande
    var commandeJean = gestion.GetCommande(numCommandeJean);
    Console.WriteLine("\nCommande de Jean Dupont :");
    Console.WriteLine(commandeJean);

    // Test AfficherCommande
    Console.WriteLine("\nAfficherCommande :");
    Console.WriteLine(gestion.AfficherCommande(numCommandeJean));
}

TestGestion();
