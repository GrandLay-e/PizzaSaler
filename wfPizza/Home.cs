using libPizza;

namespace wfPizza
{
    public partial class Home : Form
    {
        private Gestion gestionPizza;
        public Gestion GestionPizza { 
            get { return gestionPizza; }
            set { gestionPizza = value; }
        }
        public Home()
        {
            InitializeComponent();
            GestionPizza = new Gestion();
        }

        private void menuCommandButton_Click(object sender, EventArgs e)
        {
            FrmCommander frmCommander = new FrmCommander(this);
            frmCommander.ShowDialog();

        }

        private void menuAddClientButton_Click(object sender, EventArgs e)
        {
            FrmAddClient frmAddClient = new FrmAddClient(this);
            frmAddClient.ShowDialog();

        }

        private void menuAddPizzaButton_Click(object sender, EventArgs e)
        {
            FrmAddPizza  frmAddPizza = new FrmAddPizza(this); 
            frmAddPizza.ShowDialog();

        }
    }
}
