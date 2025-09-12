using libPizza;

namespace wfPizza
{
    public partial class FrmCommander : Form
    {
        private Form1 _accueil;
        public FrmCommander()
        {
            InitializeComponent();
        }

        public FrmCommander(Form1 accueil)
        {
            InitializeComponent();
            _accueil = accueil;
            RemplirComboBox();
            cmbClientName.SelectedIndexChanged += cmbClientName_SelectedIndexChanged;
        }

        private void RemplirComboBox()
        {
            cmbClientName.DataSource = _accueil.gestionPizza.MesClients;
            cmbClientName.DisplayMember = "Nom";
        }


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

        private void btnCommander_Click(object sender, EventArgs e)
        {
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
                        break;
                }
            }
            raz();
        }

        private void grbClient_Enter(object sender, EventArgs e)
        {
            Client monClient = _accueil.gestionPizza.GetClient(cmbClientName.Text);
            if (monClient == null)
            {
                clientAdress.Text = "";
                clientPostalCode.Text = "";
                clientFirstName.Text = "";
                clientCity.Text = "";
                clientPhoneNumber.Text = "";
            }
            else
            {
                clientAdress.Text = monClient.Adresse;
                clientPostalCode.Text = monClient.CodePostal;
                clientFirstName.Text = monClient.Prenom;
                clientCity.Text = monClient.Ville;
                clientPhoneNumber.Text = monClient.Telephone;
            }

        }

        private void cmbClientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Client monClient = _accueil.gestionPizza.GetClient(cmbClientName.Text);
            clientAdress.Text = monClient.Adresse;
            clientPostalCode.Text = monClient.CodePostal;
            clientFirstName.Text = monClient.Prenom;
            clientCity.Text = monClient.Ville;
            clientPhoneNumber.Text = monClient.Telephone;
        }

        private void grbCommande_Enter(object sender, EventArgs e)
        {
            foreach (Pizza pizza in _accueil.gestionPizza.MesPizzas)
            {
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
                Pizza maPizza = _accueil.gestionPizza.GetPizza(nomPizza);
                if (maPizza != null)
                {
                    double montantPizza = maPizza.Prix * qtePizza;
                    double total = montantPizza * qtePizza;

                    listCommClient.Items.Add($"{nomPizza} - {qtePizza} - {montantPizza} €");
                    lblMtPizza.Text = total.ToString("0.00");

                    _accueil.gestionPizza.AjouterCommande(_accueil.gestionPizza.GetClient(cmbClientName.Text));
                }
                else
                {
                    MessageBox.Show("La pizza sélectionnée n'existe pas.");
                }
            }
        }
    }
}
