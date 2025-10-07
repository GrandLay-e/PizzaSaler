using System.Data;
using System.Net;
using libPizza;
using Microsoft.Data.SqlClient;

//CLLIENTS
Client cl = new Client("153 rue Mitry", "13001", "Boulanger","Cedric","0707070707","Marseille");
Client cl2 = new Client("153 rue alma", "75017", "Thomas","Lemar","0707070707","Paris");
Console.WriteLine(Convert.ToBoolean("1"));
//PIZZAS
Pizza pizza = new Pizza("Reine", 12);
Pizza pizza2 = new Pizza("Calzone", 7);

//Commandes
Commande c1 = new Commande(cl);
c1.AjouterNouvellePizza(pizza);

Commande c2 = new Commande(cl2);
c2.AjouterNouvellePizza(pizza2);

//Gestion
Gestion g = new Gestion(); 

var test = ConnexionSingleton.Instance;
test.Initialize();
test.OpenConnection();
if (test.IsConnected)
{
    Console.WriteLine("Connexion réussie !");
    //DataTable result_ = test.ExecuteQuery("SELECT * FROM Pizza");
    //Console.WriteLine(result_.Rows[0]["nom"]);
    //string query = "INSERT INTO Pizza (nom, prix) VALUES (@nom, @prix)";
    //using (SqlCommand command = new SqlCommand(query, test.connection))
    //{
    //    command.Parameters.AddWithValue("@nom", pizza.Nom);
    //    command.Parameters.AddWithValue("@prix", pizza.Prix);
    //    int result = command.ExecuteNonQuery();
    //    // Check Error
    //    if (result < 0)
    //        Console.WriteLine("Error inserting data into Database!");
    //    else
    //        Console.WriteLine("Données insérées avec succès !");
    //}
}
else
{
    Console.WriteLine("Échec de la connexion.");
}