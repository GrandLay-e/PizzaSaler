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
            grbClient.Controls.Add(boxAEmporter);
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
            grbClient.Location = new Point(215, 30);
            grbClient.Name = "grbClient";
            grbClient.Size = new Size(554, 223);
            grbClient.TabIndex = 0;
            grbClient.TabStop = false;
            grbClient.Text = "Client";
            // 
            // boxAEmporter
            // 
            boxAEmporter.AutoSize = true;
            boxAEmporter.Location = new Point(19, 193);
            boxAEmporter.Name = "boxAEmporter";
            boxAEmporter.Size = new Size(111, 24);
            boxAEmporter.TabIndex = 12;
            boxAEmporter.Text = "A emporter ";
            boxAEmporter.UseVisualStyleBackColor = true;
            // 
            // lblClientCity
            // 
            lblClientCity.AutoSize = true;
            lblClientCity.Location = new Point(289, 153);
            lblClientCity.Name = "lblClientCity";
            lblClientCity.Size = new Size(38, 20);
            lblClientCity.TabIndex = 11;
            lblClientCity.Text = "Ville";
            // 
            // lblClientPostalCode
            // 
            lblClientPostalCode.AutoSize = true;
            lblClientPostalCode.Location = new Point(289, 97);
            lblClientPostalCode.Name = "lblClientPostalCode";
            lblClientPostalCode.Size = new Size(87, 20);
            lblClientPostalCode.TabIndex = 10;
            lblClientPostalCode.Text = "Code Postal";
            // 
            // lblClientAdress
            // 
            lblClientAdress.AutoSize = true;
            lblClientAdress.Location = new Point(289, 43);
            lblClientAdress.Name = "lblClientAdress";
            lblClientAdress.Size = new Size(61, 20);
            lblClientAdress.TabIndex = 9;
            lblClientAdress.Text = "Adresse";
            // 
            // lblClientPhone
            // 
            lblClientPhone.AutoSize = true;
            lblClientPhone.Location = new Point(19, 153);
            lblClientPhone.Name = "lblClientPhone";
            lblClientPhone.Size = new Size(78, 20);
            lblClientPhone.TabIndex = 8;
            lblClientPhone.Text = "Téléphone";
            // 
            // lblClientFIrstName
            // 
            lblClientFIrstName.AutoSize = true;
            lblClientFIrstName.Location = new Point(19, 97);
            lblClientFIrstName.Name = "lblClientFIrstName";
            lblClientFIrstName.Size = new Size(60, 20);
            lblClientFIrstName.TabIndex = 7;
            lblClientFIrstName.Text = "Prénom";
            // 
            // lblclientName
            // 
            lblclientName.AutoSize = true;
            lblclientName.Location = new Point(19, 43);
            lblclientName.Name = "lblclientName";
            lblclientName.Size = new Size(46, 20);
            lblclientName.TabIndex = 6;
            lblclientName.Text = "Nom ";
            // 
            // clientCity
            // 
            clientCity.Location = new Point(397, 146);
            clientCity.Name = "clientCity";
            clientCity.ReadOnly = true;
            clientCity.Size = new Size(151, 27);
            clientCity.TabIndex = 5;
            // 
            // clientPostalCode
            // 
            clientPostalCode.Location = new Point(397, 90);
            clientPostalCode.Name = "clientPostalCode";
            clientPostalCode.ReadOnly = true;
            clientPostalCode.Size = new Size(151, 27);
            clientPostalCode.TabIndex = 4;
            // 
            // clientAdress
            // 
            clientAdress.Location = new Point(397, 40);
            clientAdress.Name = "clientAdress";
            clientAdress.ReadOnly = true;
            clientAdress.Size = new Size(151, 27);
            clientAdress.TabIndex = 3;
            // 
            // clientPhoneNumber
            // 
            clientPhoneNumber.Location = new Point(101, 146);
            clientPhoneNumber.Name = "clientPhoneNumber";
            clientPhoneNumber.ReadOnly = true;
            clientPhoneNumber.Size = new Size(151, 27);
            clientPhoneNumber.TabIndex = 2;
            // 
            // clientFirstName
            // 
            clientFirstName.Location = new Point(101, 90);
            clientFirstName.Name = "clientFirstName";
            clientFirstName.ReadOnly = true;
            clientFirstName.Size = new Size(151, 27);
            clientFirstName.TabIndex = 1;
            // 
            // cmbClientName
            // 
            cmbClientName.FormattingEnabled = true;
            cmbClientName.Location = new Point(101, 40);
            cmbClientName.Name = "cmbClientName";
            cmbClientName.Size = new Size(151, 28);
            cmbClientName.TabIndex = 0;
            // 
            // grbCommande
            // 
            grbCommande.Controls.Add(btsAddPizza);
            grbCommande.Controls.Add(qtePizzaIndication);
            grbCommande.Controls.Add(cmbPizzaIndication);
            grbCommande.Controls.Add(qtePizzaInput);
            grbCommande.Controls.Add(cmbPizza);
            grbCommande.Location = new Point(215, 263);
            grbCommande.Name = "grbCommande";
            grbCommande.Size = new Size(554, 175);
            grbCommande.TabIndex = 1;
            grbCommande.TabStop = false;
            grbCommande.Text = "Commande";
            // 
            // btsAddPizza
            // 
            btsAddPizza.Location = new Point(219, 140);
            btsAddPizza.Name = "btsAddPizza";
            btsAddPizza.Size = new Size(94, 29);
            btsAddPizza.TabIndex = 4;
            btsAddPizza.Text = "Ajouter";
            btsAddPizza.UseVisualStyleBackColor = true;
            // 
            // qtePizzaIndication
            // 
            qtePizzaIndication.AutoSize = true;
            qtePizzaIndication.Location = new Point(375, 47);
            qtePizzaIndication.Name = "qtePizzaIndication";
            qtePizzaIndication.Size = new Size(66, 20);
            qtePizzaIndication.TabIndex = 3;
            qtePizzaIndication.Text = "Quantité";
            // 
            // cmbPizzaIndication
            // 
            cmbPizzaIndication.AutoSize = true;
            cmbPizzaIndication.Location = new Point(55, 47);
            cmbPizzaIndication.Name = "cmbPizzaIndication";
            cmbPizzaIndication.Size = new Size(43, 20);
            cmbPizzaIndication.TabIndex = 2;
            cmbPizzaIndication.Text = "Pizza";
            // 
            // qtePizzaInput
            // 
            qtePizzaInput.Location = new Point(375, 85);
            qtePizzaInput.Name = "qtePizzaInput";
            qtePizzaInput.Size = new Size(75, 27);
            qtePizzaInput.TabIndex = 1;
            // 
            // cmbPizza
            // 
            cmbPizza.FormattingEnabled = true;
            cmbPizza.Location = new Point(30, 85);
            cmbPizza.Name = "cmbPizza";
            cmbPizza.Size = new Size(120, 28);
            cmbPizza.TabIndex = 0;
            // 
            // btnCommander
            // 
            btnCommander.Location = new Point(215, 444);
            btnCommander.Name = "btnCommander";
            btnCommander.Size = new Size(554, 69);
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
            toolStrip1.Size = new Size(800, 27);
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
            listCommClient.Location = new Point(12, 30);
            listCommClient.Name = "listCommClient";
            listCommClient.Size = new Size(176, 404);
            listCommClient.TabIndex = 4;
            // 
            // lblMtPizza
            // 
            lblMtPizza.AutoSize = true;
            lblMtPizza.Location = new Point(73, 444);
            lblMtPizza.Name = "lblMtPizza";
            lblMtPizza.Size = new Size(17, 20);
            lblMtPizza.TabIndex = 5;
            lblMtPizza.Text = "0";
            // 
            // btnEffacer
            // 
            btnEffacer.Location = new Point(38, 484);
            btnEffacer.Name = "btnEffacer";
            btnEffacer.Size = new Size(94, 29);
            btnEffacer.TabIndex = 6;
            btnEffacer.Text = "Effacer";
            btnEffacer.UseVisualStyleBackColor = true;
            btnEffacer.Click += btnEffacer_Click;
            // 
            // FrmCommander
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 525);
            Controls.Add(btnEffacer);
            Controls.Add(lblMtPizza);
            Controls.Add(listCommClient);
            Controls.Add(toolStrip1);
            Controls.Add(btnCommander);
            Controls.Add(grbCommande);
            Controls.Add(grbClient);
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