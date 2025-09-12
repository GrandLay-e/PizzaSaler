namespace wfPizza
{
    partial class FrmAddClient
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
            clientLastNameIndication = new Label();
            clientFirstNameIndication = new Label();
            clientAdress = new Label();
            clientPostalCode = new Label();
            clientCity = new Label();
            clientPhoneNumber = new Label();
            clientLastNameInput = new TextBox();
            clientFirstNameInput = new TextBox();
            clientAdressInput = new TextBox();
            clientPostalCodeInput = new TextBox();
            clientCityInput = new TextBox();
            clientPhoneNumberInput = new TextBox();
            addClientValidationButton = new Button();
            SuspendLayout();
            // 
            // clientLastNameIndication
            // 
            clientLastNameIndication.AutoSize = true;
            clientLastNameIndication.Location = new Point(173, 41);
            clientLastNameIndication.Name = "clientLastNameIndication";
            clientLastNameIndication.Size = new Size(46, 20);
            clientLastNameIndication.TabIndex = 0;
            clientLastNameIndication.Text = "Nom ";
            // 
            // clientFirstNameIndication
            // 
            clientFirstNameIndication.AutoSize = true;
            clientFirstNameIndication.Location = new Point(173, 102);
            clientFirstNameIndication.Name = "clientFirstNameIndication";
            clientFirstNameIndication.Size = new Size(60, 20);
            clientFirstNameIndication.TabIndex = 1;
            clientFirstNameIndication.Text = "Prénom";
            // 
            // clientAdress
            // 
            clientAdress.AutoSize = true;
            clientAdress.Location = new Point(173, 167);
            clientAdress.Name = "clientAdress";
            clientAdress.Size = new Size(61, 20);
            clientAdress.TabIndex = 2;
            clientAdress.Text = "Adresse";
            // 
            // clientPostalCode
            // 
            clientPostalCode.AutoSize = true;
            clientPostalCode.Location = new Point(173, 225);
            clientPostalCode.Name = "clientPostalCode";
            clientPostalCode.Size = new Size(87, 20);
            clientPostalCode.TabIndex = 3;
            clientPostalCode.Text = "Code Postal";
            // 
            // clientCity
            // 
            clientCity.AutoSize = true;
            clientCity.Location = new Point(173, 288);
            clientCity.Name = "clientCity";
            clientCity.Size = new Size(38, 20);
            clientCity.TabIndex = 4;
            clientCity.Text = "Ville";
            // 
            // clientPhoneNumber
            // 
            clientPhoneNumber.AutoSize = true;
            clientPhoneNumber.Location = new Point(173, 356);
            clientPhoneNumber.Name = "clientPhoneNumber";
            clientPhoneNumber.Size = new Size(78, 20);
            clientPhoneNumber.TabIndex = 5;
            clientPhoneNumber.Text = "Téléphone";
            // 
            // clientLastNameInput
            // 
            clientLastNameInput.Location = new Point(360, 34);
            clientLastNameInput.Name = "clientLastNameInput";
            clientLastNameInput.Size = new Size(125, 27);
            clientLastNameInput.TabIndex = 6;
            // 
            // clientFirstNameInput
            // 
            clientFirstNameInput.Location = new Point(360, 95);
            clientFirstNameInput.Name = "clientFirstNameInput";
            clientFirstNameInput.Size = new Size(125, 27);
            clientFirstNameInput.TabIndex = 7;
            // 
            // clientAdressInput
            // 
            clientAdressInput.Location = new Point(360, 167);
            clientAdressInput.Name = "clientAdressInput";
            clientAdressInput.Size = new Size(125, 27);
            clientAdressInput.TabIndex = 8;
            // 
            // clientPostalCodeInput
            // 
            clientPostalCodeInput.Location = new Point(360, 225);
            clientPostalCodeInput.Name = "clientPostalCodeInput";
            clientPostalCodeInput.Size = new Size(125, 27);
            clientPostalCodeInput.TabIndex = 9;
            // 
            // clientCityInput
            // 
            clientCityInput.Location = new Point(360, 285);
            clientCityInput.Name = "clientCityInput";
            clientCityInput.Size = new Size(125, 27);
            clientCityInput.TabIndex = 10;
            // 
            // clientPhoneNumberInput
            // 
            clientPhoneNumberInput.Location = new Point(360, 349);
            clientPhoneNumberInput.Name = "clientPhoneNumberInput";
            clientPhoneNumberInput.Size = new Size(125, 27);
            clientPhoneNumberInput.TabIndex = 11;
            // 
            // addClientValidationButton
            // 
            addClientValidationButton.Location = new Point(272, 409);
            addClientValidationButton.Name = "addClientValidationButton";
            addClientValidationButton.Size = new Size(94, 29);
            addClientValidationButton.TabIndex = 12;
            addClientValidationButton.Text = "Valider";
            addClientValidationButton.UseVisualStyleBackColor = true;
            addClientValidationButton.Click += addClientValidationButton_Click;
            // 
            // FrmAddClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addClientValidationButton);
            Controls.Add(clientPhoneNumberInput);
            Controls.Add(clientCityInput);
            Controls.Add(clientPostalCodeInput);
            Controls.Add(clientAdressInput);
            Controls.Add(clientFirstNameInput);
            Controls.Add(clientLastNameInput);
            Controls.Add(clientPhoneNumber);
            Controls.Add(clientCity);
            Controls.Add(clientPostalCode);
            Controls.Add(clientAdress);
            Controls.Add(clientFirstNameIndication);
            Controls.Add(clientLastNameIndication);
            Name = "FrmAddClient";
            Text = "Ajouter Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label clientLastNameIndication;
        private Label clientFirstNameIndication;
        private Label clientAdress;
        private Label clientPostalCode;
        private Label clientCity;
        private Label clientPhoneNumber;
        private TextBox clientLastNameInput;
        private TextBox clientFirstNameInput;
        private TextBox clientAdressInput;
        private TextBox clientPostalCodeInput;
        private TextBox clientCityInput;
        private TextBox clientPhoneNumberInput;
        private Button addClientValidationButton;
    }
}