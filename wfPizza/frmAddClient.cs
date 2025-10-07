using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using libPizza;
namespace wfPizza
{
    public partial class FrmAddClient : Form
    {
        private Home _accueil;
        public FrmAddClient()
        {
            InitializeComponent();
        }
        public FrmAddClient(Home accueil)
        {
            InitializeComponent();
            _accueil = accueil;
        }

        private void addClientValidationButton_Click(object sender, EventArgs e)
        {
            foreach(TextBox txt in this.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    MessageBox.Show("Veuillez remplir tous les champs.");
                    return;
                }
            }

            _accueil.GestionPizza.AjouterNouveauClient(clientAdressInput.Text,
                                        clientPostalCodeInput.Text,
                                        clientLastNameInput.Text,
                                        clientFirstNameInput.Text,
                                        clientPhoneNumberInput.Text,
                                        clientCityInput.Text);
            this.Close();

        }
    }
}
