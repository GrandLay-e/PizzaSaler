using libPizza;

namespace wfPizza
{
    public partial class FrmCommander : Form
    {
        private Home _accueil;
        private Client actualClient;
        private Pizza chosedPizza;
        private Dictionary<Pizza, int> pizaasInCommand;

        public Dictionary<Pizza, int> PizzaInCommand
        {
            get { return pizaasInCommand; }
            set { pizaasInCommand = value; }
        }
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
            PizzaInCommand = new Dictionary<Pizza, int>();
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
            PizzaInCommand.Clear();
            actualClient = null;
            cmbClientName.SelectedIndex = -1;
            chosedPizza = null;
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            raz();
        }

        // Gestion de l'événement de clic sur le bouton "Commander"
        private void btnCommander_Click(object sender, EventArgs e)
        {
            _accueil.GestionPizza.AjouterCommande(actualClient, boxAEmporter.Checked);
            int numCommande = _accueil.GestionPizza.NumCommandeClient(actualClient);
            foreach (Pizza p in PizzaInCommand.Keys)
            {
                _accueil.GestionPizza.AjouterPizza(p, numCommande, PizzaInCommand[p]);
            }

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
            raz();
            this.Close();
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
                if (!cmbPizza.Items.Contains(pizza.Nom))
                    cmbPizza.Items.Add(pizza.Nom);
            }
        }

        private void btsAddPizza_Click(object sender, EventArgs e)
        {
            string nomPizza = cmbPizza.Text;
            int qtePizza = (int)qtePizzaInput.Value;
            if (string.IsNullOrWhiteSpace(nomPizza) || qtePizza == 0)
            {
                MessageBox.Show("Assurez vous d'avoir bien fait vos saisies ");
                return;
            }
            else
            {
                chosedPizza = _accueil.GestionPizza.GetPizza(nomPizza);
                if (chosedPizza != null)
                {
                    if (PizzaInCommand.ContainsKey(chosedPizza))
                        PizzaInCommand[chosedPizza] += qtePizza;
                    else
                        PizzaInCommand.Add(chosedPizza, qtePizza);

                    updateLstCommandesAndToTal();
                }
                else
                {
                    MessageBox.Show("La pizza sélectionnée n'existe pas.");
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ma première version");
        }

        private void updateLstCommandesAndToTal()
        {
            listCommClient.Items.Clear();
            double total = 0;
            foreach (var entry in PizzaInCommand)
            {
                Pizza pizza = entry.Key;
                int quantity = entry.Value;
                double montantPizza = pizza.Prix * quantity;
                listCommClient.Items.Add($"{quantity} - {pizza.Nom} : {montantPizza} €");
                total += montantPizza;
            }
            lblMtPizza.Text = total.ToString("0.00");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            raz();
        }
    }
}
