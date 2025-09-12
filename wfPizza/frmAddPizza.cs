using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfPizza
{
    public partial class FrmAddPizza : Form
    {
        private Form1 _accueil;
        public FrmAddPizza()
        {
            InitializeComponent();
        }
        public FrmAddPizza(Form1 accueil)
        {
            InitializeComponent();
             _accueil = accueil;
        }

        private void addPizzaValidationButton_Click(object sender, EventArgs e)
        {
            string nomPizza = pizzaNameInput.Text;
            string price = pizzaPriceInput.Text;
            double prixPizza;

            if (!double.TryParse(price, out prixPizza) || prixPizza < 0)
            {
                MessageBox.Show("Veuillez entrer un prix valide pour la pizza.");
                return;
            }
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    MessageBox.Show("Veuillez remplir tous les champs.");
                    return;
                }
            }

            _accueil.gestionPizza.MesPizzas.Add(new libPizza.Pizza(nomPizza, prixPizza));

        }
    }
}
