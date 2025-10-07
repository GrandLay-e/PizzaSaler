using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libPizza
{
    public sealed class ConnexionSingleton
    {
        private string _server = @"SIRE\SOW";
        private string _log = "pizzaSqlUser";
        private string _mdp = "pizzaSqlUser";
        private string _bd = "PizzaSale";
        private string _connectionString = "";

        private static ConnexionSingleton _instance;
        private static readonly object _lock = new object();
        public SqlConnection connection;
        private bool isConnected = false;

        // Constructeur privé pour empêcher l'instanciation directe
        private ConnexionSingleton() { }
        // Propriété pour obtenir l'instance unique
        public static ConnexionSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new ConnexionSingleton();
                        }
                    }
                }
                return _instance;
            }
        }

        // Propriété pour vérifier l'état de connexion
        public bool IsConnected => isConnected;

        // Méthode pour initialiser la connexion
        public void Initialize()
        {
            // Chaîne de connexion avec authentification SQL Server
            this._connectionString = $"Server={_server};Database={_bd};User Id={_log};Password={_mdp};TrustServerCertificate=true;";
            //this._connectionString = $"Server={_server};Database={_bd};TrustServerCertificate=True;";

            // Fermer la connexion précédente si elle existe
            if (connection != null)
            {
                connection.Close();
                connection.Dispose();
            }

            this.connection = new SqlConnection(_connectionString);
            this.isConnected = false;
        }
        // Méthode pour ouvrir la connexion
        public void OpenConnection()
        {
            if (connection == null)
            {
                throw new InvalidOperationException("La connexion n'a pas été initialisée. Appelez Initialize() d'abord.");
            }

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            // CORRECTION : Mettre à jour isConnected selon l'état réel de la connexion
            isConnected = (connection.State == ConnectionState.Open);
        }

        // Méthode pour fermer la connexion
        public void CloseConnection()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
                isConnected = false; // CORRECTION : Mettre à jour l'état
            }
        }

        // Méthode pour déconnecter complètement
        public void Disconnect()
        {
            if (connection != null)
            {
                connection.Close();
                connection.Dispose();
                connection = null;
            }
            isConnected = false;
        }
        // Exécution d'une requête SELECT
        public DataTable ExecuteQuery(string query)
        {
            if (connection == null)
            {
                throw new InvalidOperationException("La connexion n'a pas été initialisée. Appelez Initialize() d'abord.");
            }

            DataTable dataTable = new DataTable();

            try
            {
                OpenConnection();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new InvalidOperationException($"Erreur lors de l'exécution de la requête : {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }

            return dataTable;
        }
        // Exécution d'une commande INSERT, UPDATE ou DELETE
        public int ExecuteNonQuery(string query)
        {
            if (connection == null)
            {
                throw new InvalidOperationException("La connexion n'a pas été initialisée. Appelez Initialize() d'abord.");
            }

            int rowsAffected = 0;

            try
            {
                OpenConnection();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Erreur lors de l'exécution de la requête : {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }

            return rowsAffected;
        }
    }
}
