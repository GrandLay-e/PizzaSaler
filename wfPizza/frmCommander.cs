namespace wfPizza
{
    public partial class FrmCommander : Form
    {
        public FrmCommander()
        {
            InitializeComponent();
        }

        private void raz()
        {
            cmbPizza.SelectedIndex = -1;
            qtePizzaInput.Value = 0;
            listCommClient.Items.Clear();
            lblMtPizza.Text = null;
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
    }
}
