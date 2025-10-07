using libPizza;

namespace wfPizza
{
    public partial class FrmCommander : Form
    {
        private Home _accueil;
        private Client actualClient;
        private Pizza chosedPizza;
        //private Dictionary<Commande, List<Pizza>> commandesPizzas = new Dictionary<Commande, List<Pizza>>();

        //public Dictionary<Commande, List<Pizza>> CommandesPizzas
        //{
        //    get { return commandesPizzas; }
        //    set { commandesPizzas = value; }
        //}

        // Constructeur par défaut
        public FrmCommander()
        {
            InitializeComponent();
        }

        // Constructeur avec référence à l'accueil
        public FrmCommander(Home accueil)
        {
            InitializeComponent();
            _accueil = accueil;
            RemplirComboBox();
            cmbClientName.SelectedIndexChanged += cmbClientName_SelectedIndexChanged;
        }

        // Méthode pour remplir la ComboBox avec les noms des clients
        private void RemplirComboBox()
        {
            cmbClientName.DataSource = _accueil.GestionPizza.MesClients;
            cmbClientName.DisplayMember = "Nom";
        }

        // Méthode pour réinitialiser les champs du formulaire
        private void raz()
        {
            cmbPizza.SelectedIndex = -1;
            qtePizzaInput.Value = 0;
            listCommClient.Items.Clear();
            lblMtPizza.Text = "0";
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            raz();
        }

        // Gestion de l'événement de clic sur le bouton "Commander"
        private void btnCommander_Click(object sender, EventArgs e)
        {
            foreach(Pizza pizza in _accueil.GestionPizza.MesPizzas)
            {
                if (pizza.Nom == cmbPizza.Text)
                {
                    _accueil.GestionPizza.AjouterCommande(actualClient);
                    break;
                }
            }

            //MessageBox.Show(_accueil.GestionPizza.ToString());

            foreach (Control control in grbClient.Controls)
            {
                switch (control)
                {
                    case TextBox:
                        TextBox txt = control as TextBox;
                        txt.Text = null;
                        break;
                    case CheckBox:
                        CheckBox chk = control as CheckBox;
                        chk.Checked = false;
                        break;
                    default:
                        // Ne rien faire pour les autres types de contrôles
                        break;
                }
            }
            //raz();
        }

        private void grbClient_Enter(object sender, EventArgs e)
        {
            actualClient = _accueil.GestionPizza.GetClient(cmbClientName.Text);
            if (actualClient == null)
            {
                clientAdress.Text = "";
                clientPostalCode.Text = "";
                clientFirstName.Text = "";
                clientCity.Text = "";
                clientPhoneNumber.Text = "";
            }
            else
            {
                clientAdress.Text = actualClient.Adresse;
                clientPostalCode.Text = actualClient.CodePostal;
                clientFirstName.Text = actualClient.Prenom;
                clientCity.Text = actualClient.Ville;
                clientPhoneNumber.Text = actualClient.Telephone;
            }

        }

        private void cmbClientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualClient = _accueil.GestionPizza.GetClient(cmbClientName.Text);
            clientAdress.Text = actualClient.Adresse;
            clientPostalCode.Text = actualClient.CodePostal;
            clientFirstName.Text = actualClient.Prenom;
            clientCity.Text = actualClient.Ville;
            clientPhoneNumber.Text = actualClient.Telephone;
        }

        private void grbCommande_Enter(object sender, EventArgs e)
        {
            foreach (Pizza pizza in _accueil.GestionPizza.MesPizzas)
            {
                if(!cmbPizza.Items.Contains(pizza.Nom))
                    cmbPizza.Items.Add(pizza.Nom);
            }
        }

        private void btsAddPizza_Click(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(lblMtPizza.Text);
            string nomPizza = cmbPizza.Text;
            int qtePizza = (int)qtePizzaInput.Value;
            if (string.IsNullOrWhiteSpace(nomPizza) || qtePizza == 0)
            {
                MessageBox.Show("Assurez vous d'avoir bien fait vos saisies ");
                return;
            }
            else
            {
                //Pizza maPizza = _accueil.GestionPizza.GetPizza(nomPizza);
                chosedPizza = _accueil.GestionPizza.GetPizza(nomPizza);
                if (chosedPizza != null)
                {
                    double montantPizza = chosedPizza.Prix * qtePizza;
                    bool aEmporter = boxAEmporter.Checked;
                    total += montantPizza;

                    listCommClient.Items.Add($"{cmbClientName.Text} - {nomPizza} - {qtePizza} - {montantPizza} € {(aEmporter ? "à emporter" : "sur place")}");
                    lblMtPizza.Text = total.ToString("0.00");

                    //_accueil.GestionPizza.AjouterCommande(actualClient);
                    _accueil.GestionPizza.AjouterPizza(chosedPizza, _accueil.GestionPizza.NumCommandeClient(actualClient));
                }
                else
                {
                    MessageBox.Show("La pizza sélectionnée n'existe pas.");
                }
            }
        }

        private void cmbPizza_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
