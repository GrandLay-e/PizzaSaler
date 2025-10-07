namespace wfPizza
{
    partial class FrmCommander
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCommander));
            grbClient = new GroupBox();
            boxAEmporter = new CheckBox();
            lblClientCity = new Label();
            lblClientPostalCode = new Label();
            lblClientAdress = new Label();
            lblClientPhone = new Label();
            lblClientFIrstName = new Label();
            lblclientName = new Label();
            clientCity = new TextBox();
            clientPostalCode = new TextBox();
            clientAdress = new TextBox();
            clientPhoneNumber = new TextBox();
            clientFirstName = new TextBox();
            cmbClientName = new ComboBox();
            grbCommande = new GroupBox();
            btsAddPizza = new Button();
            qtePizzaIndication = new Label();
            cmbPizzaIndication = new Label();
            qtePizzaInput = new NumericUpDown();
            cmbPizza = new ComboBox();
            btnCommander = new Button();
            toolStrip1 = new ToolStrip();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            errorProvider1 = new ErrorProvider(components);
            helpProvider1 = new HelpProvider();
            listCommClient = new ListBox();
            lblMtPizza = new Label();
            btnEffacer = new Button();
            grbClient.SuspendLayout();
            grbCommande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)qtePizzaInput).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // grbClient
            // 
            grbClient.Controls.Add(lblClientCity);
            grbClient.Controls.Add(lblClientPostalCode);
            grbClient.Controls.Add(lblClientAdress);
            grbClient.Controls.Add(lblClientPhone);
            grbClient.Controls.Add(lblClientFIrstName);
            grbClient.Controls.Add(lblclientName);
            grbClient.Controls.Add(clientCity);
            grbClient.Controls.Add(clientPostalCode);
            grbClient.Controls.Add(clientAdress);
            grbClient.Controls.Add(clientPhoneNumber);
            grbClient.Controls.Add(clientFirstName);
            grbClient.Controls.Add(cmbClientName);
            grbClient.Location = new Point(269, 38);
            grbClient.Margin = new Padding(4, 4, 4, 4);
            grbClient.Name = "grbClient";
            grbClient.Padding = new Padding(4, 4, 4, 4);
            grbClient.Size = new Size(692, 279);
            grbClient.TabIndex = 0;
            grbClient.TabStop = false;
            grbClient.Text = "Client";
            grbClient.Enter += grbClient_Enter;
            // 
            // boxAEmporter
            // 
            boxAEmporter.AutoSize = true;
            boxAEmporter.Location = new Point(529, 110);
            boxAEmporter.Margin = new Padding(4, 4, 4, 4);
            boxAEmporter.Name = "boxAEmporter";
            boxAEmporter.Size = new Size(130, 29);
            boxAEmporter.TabIndex = 12;
            boxAEmporter.Text = "A emporter ";
            boxAEmporter.UseVisualStyleBackColor = true;
            // 
            // lblClientCity
            // 
            lblClientCity.AutoSize = true;
            lblClientCity.Location = new Point(361, 191);
            lblClientCity.Margin = new Padding(4, 0, 4, 0);
            lblClientCity.Name = "lblClientCity";
            lblClientCity.Size = new Size(44, 25);
            lblClientCity.TabIndex = 11;
            lblClientCity.Text = "Ville";
            // 
            // lblClientPostalCode
            // 
            lblClientPostalCode.AutoSize = true;
            lblClientPostalCode.Location = new Point(361, 121);
            lblClientPostalCode.Margin = new Padding(4, 0, 4, 0);
            lblClientPostalCode.Name = "lblClientPostalCode";
            lblClientPostalCode.Size = new Size(106, 25);
            lblClientPostalCode.TabIndex = 10;
            lblClientPostalCode.Text = "Code Postal";
            // 
            // lblClientAdress
            // 
            lblClientAdress.AutoSize = true;
            lblClientAdress.Location = new Point(361, 54);
            lblClientAdress.Margin = new Padding(4, 0, 4, 0);
            lblClientAdress.Name = "lblClientAdress";
            lblClientAdress.Size = new Size(75, 25);
            lblClientAdress.TabIndex = 9;
            lblClientAdress.Text = "Adresse";
            // 
            // lblClientPhone
            // 
            lblClientPhone.AutoSize = true;
            lblClientPhone.Location = new Point(24, 191);
            lblClientPhone.Margin = new Padding(4, 0, 4, 0);
            lblClientPhone.Name = "lblClientPhone";
            lblClientPhone.Size = new Size(92, 25);
            lblClientPhone.TabIndex = 8;
            lblClientPhone.Text = "Téléphone";
            // 
            // lblClientFIrstName
            // 
            lblClientFIrstName.AutoSize = true;
            lblClientFIrstName.Location = new Point(24, 121);
            lblClientFIrstName.Margin = new Padding(4, 0, 4, 0);
            lblClientFIrstName.Name = "lblClientFIrstName";
            lblClientFIrstName.Size = new Size(74, 25);
            lblClientFIrstName.TabIndex = 7;
            lblClientFIrstName.Text = "Prénom";
            // 
            // lblclientName
            // 
            lblclientName.AutoSize = true;
            lblclientName.Location = new Point(24, 54);
            lblclientName.Margin = new Padding(4, 0, 4, 0);
            lblclientName.Name = "lblclientName";
            lblclientName.Size = new Size(57, 25);
            lblclientName.TabIndex = 6;
            lblclientName.Text = "Nom ";
            // 
            // clientCity
            // 
            clientCity.Location = new Point(496, 182);
            clientCity.Margin = new Padding(4, 4, 4, 4);
            clientCity.Name = "clientCity";
            clientCity.ReadOnly = true;
            clientCity.Size = new Size(188, 31);
            clientCity.TabIndex = 5;
            // 
            // clientPostalCode
            // 
            clientPostalCode.Location = new Point(496, 112);
            clientPostalCode.Margin = new Padding(4, 4, 4, 4);
            clientPostalCode.Name = "clientPostalCode";
            clientPostalCode.ReadOnly = true;
            clientPostalCode.Size = new Size(188, 31);
            clientPostalCode.TabIndex = 4;
            // 
            // clientAdress
            // 
            clientAdress.Location = new Point(496, 50);
            clientAdress.Margin = new Padding(4, 4, 4, 4);
            clientAdress.Name = "clientAdress";
            clientAdress.ReadOnly = true;
            clientAdress.Size = new Size(188, 31);
            clientAdress.TabIndex = 3;
            // 
            // clientPhoneNumber
            // 
            clientPhoneNumber.Location = new Point(126, 182);
            clientPhoneNumber.Margin = new Padding(4, 4, 4, 4);
            clientPhoneNumber.Name = "clientPhoneNumber";
            clientPhoneNumber.ReadOnly = true;
            clientPhoneNumber.Size = new Size(188, 31);
            clientPhoneNumber.TabIndex = 2;
            // 
            // clientFirstName
            // 
            clientFirstName.Location = new Point(126, 112);
            clientFirstName.Margin = new Padding(4, 4, 4, 4);
            clientFirstName.Name = "clientFirstName";
            clientFirstName.ReadOnly = true;
            clientFirstName.Size = new Size(188, 31);
            clientFirstName.TabIndex = 1;
            // 
            // cmbClientName
            // 
            cmbClientName.FormattingEnabled = true;
            cmbClientName.Location = new Point(126, 50);
            cmbClientName.Margin = new Padding(4, 4, 4, 4);
            cmbClientName.Name = "cmbClientName";
            cmbClientName.Size = new Size(188, 33);
            cmbClientName.TabIndex = 0;
            // 
            // grbCommande
            // 
            grbCommande.Controls.Add(boxAEmporter);
            grbCommande.Controls.Add(btsAddPizza);
            grbCommande.Controls.Add(qtePizzaIndication);
            grbCommande.Controls.Add(cmbPizzaIndication);
            grbCommande.Controls.Add(qtePizzaInput);
            grbCommande.Controls.Add(cmbPizza);
            grbCommande.Location = new Point(269, 329);
            grbCommande.Margin = new Padding(4, 4, 4, 4);
            grbCommande.Name = "grbCommande";
            grbCommande.Padding = new Padding(4, 4, 4, 4);
            grbCommande.Size = new Size(692, 219);
            grbCommande.TabIndex = 1;
            grbCommande.TabStop = false;
            grbCommande.Text = "Commande";
            grbCommande.Enter += grbCommande_Enter;
            // 
            // btsAddPizza
            // 
            btsAddPizza.Location = new Point(274, 175);
            btsAddPizza.Margin = new Padding(4, 4, 4, 4);
            btsAddPizza.Name = "btsAddPizza";
            btsAddPizza.Size = new Size(118, 36);
            btsAddPizza.TabIndex = 4;
            btsAddPizza.Text = "Ajouter";
            btsAddPizza.UseVisualStyleBackColor = true;
            btsAddPizza.Click += btsAddPizza_Click;
            // 
            // qtePizzaIndication
            // 
            qtePizzaIndication.AutoSize = true;
            qtePizzaIndication.Location = new Point(325, 59);
            qtePizzaIndication.Margin = new Padding(4, 0, 4, 0);
            qtePizzaIndication.Name = "qtePizzaIndication";
            qtePizzaIndication.Size = new Size(80, 25);
            qtePizzaIndication.TabIndex = 3;
            qtePizzaIndication.Text = "Quantité";
            // 
            // cmbPizzaIndication
            // 
            cmbPizzaIndication.AutoSize = true;
            cmbPizzaIndication.Location = new Point(69, 59);
            cmbPizzaIndication.Margin = new Padding(4, 0, 4, 0);
            cmbPizzaIndication.Name = "cmbPizzaIndication";
            cmbPizzaIndication.Size = new Size(51, 25);
            cmbPizzaIndication.TabIndex = 2;
            cmbPizzaIndication.Text = "Pizza";
            // 
            // qtePizzaInput
            // 
            qtePizzaInput.Location = new Point(325, 108);
            qtePizzaInput.Margin = new Padding(4, 4, 4, 4);
            qtePizzaInput.Name = "qtePizzaInput";
            qtePizzaInput.Size = new Size(94, 31);
            qtePizzaInput.TabIndex = 1;
            // 
            // cmbPizza
            // 
            cmbPizza.FormattingEnabled = true;
            cmbPizza.Location = new Point(38, 106);
            cmbPizza.Margin = new Padding(4, 4, 4, 4);
            cmbPizza.Name = "cmbPizza";
            cmbPizza.Size = new Size(149, 33);
            cmbPizza.TabIndex = 0;
            cmbPizza.SelectedIndexChanged += cmbPizza_SelectedIndexChanged;
            // 
            // btnCommander
            // 
            btnCommander.Location = new Point(269, 555);
            btnCommander.Margin = new Padding(4, 4, 4, 4);
            btnCommander.Name = "btnCommander";
            btnCommander.Size = new Size(692, 86);
            btnCommander.TabIndex = 2;
            btnCommander.Text = "Commander";
            btnCommander.UseVisualStyleBackColor = true;
            btnCommander.Click += btnCommander_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1000, 27);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 24);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 24);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(29, 24);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // listCommClient
            // 
            listCommClient.FormattingEnabled = true;
            listCommClient.ItemHeight = 25;
            listCommClient.Location = new Point(15, 38);
            listCommClient.Margin = new Padding(4, 4, 4, 4);
            listCommClient.Name = "listCommClient";
            listCommClient.Size = new Size(219, 504);
            listCommClient.TabIndex = 4;
            // 
            // lblMtPizza
            // 
            lblMtPizza.AutoSize = true;
            lblMtPizza.Location = new Point(91, 555);
            lblMtPizza.Margin = new Padding(4, 0, 4, 0);
            lblMtPizza.Name = "lblMtPizza";
            lblMtPizza.Size = new Size(22, 25);
            lblMtPizza.TabIndex = 5;
            lblMtPizza.Text = "0";
            // 
            // btnEffacer
            // 
            btnEffacer.Location = new Point(48, 605);
            btnEffacer.Margin = new Padding(4, 4, 4, 4);
            btnEffacer.Name = "btnEffacer";
            btnEffacer.Size = new Size(118, 36);
            btnEffacer.TabIndex = 6;
            btnEffacer.Text = "Effacer";
            btnEffacer.UseVisualStyleBackColor = true;
            btnEffacer.Click += btnEffacer_Click;
            // 
            // FrmCommander
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 656);
            Controls.Add(btnEffacer);
            Controls.Add(lblMtPizza);
            Controls.Add(listCommClient);
            Controls.Add(toolStrip1);
            Controls.Add(btnCommander);
            Controls.Add(grbCommande);
            Controls.Add(grbClient);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FrmCommander";
            Text = "Commander";
            grbClient.ResumeLayout(false);
            grbClient.PerformLayout();
            grbCommande.ResumeLayout(false);
            grbCommande.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)qtePizzaInput).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbClient;
        private GroupBox grbCommande;
        private Button btnCommander;
        private NumericUpDown qtePizzaInput;
        private ComboBox cmbPizza;
        private Label qtePizzaIndication;
        private Label cmbPizzaIndication;
        private Button btsAddPizza;
        private ComboBox cmbClientName;
        private TextBox clientFirstName;
        private TextBox clientCity;
        private TextBox clientPostalCode;
        private TextBox clientAdress;
        private TextBox clientPhoneNumber;
        private Label lblClientCity;
        private Label lblClientPostalCode;
        private Label lblClientAdress;
        private Label lblClientPhone;
        private Label lblClientFIrstName;
        private Label lblclientName;
        private CheckBox boxAEmporter;
        private ToolStrip toolStrip1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ErrorProvider errorProvider1;
        private HelpProvider helpProvider1;
        private ListBox listCommClient;
        private Label lblMtPizza;
        private Button btnEffacer;
    }
}