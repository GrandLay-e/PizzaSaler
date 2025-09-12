using libPizza;
namespace wfPizza
{
    public partial class Form1 : Form
    {
        //public List<Client> listeClients;
        public Gestion gestionPizza;
        public Form1()
        {
            InitializeComponent();
            //listeClients = new List<Client>();
            gestionPizza = new Gestion();
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
