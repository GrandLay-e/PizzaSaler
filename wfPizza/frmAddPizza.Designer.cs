namespace wfPizza
{
    partial class FrmAddPizza
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
            pizzaNameIndication = new Label();
            pizzaPriceIndication = new Label();
            pizzaNameInput = new TextBox();
            pizzaPriceInput = new TextBox();
            addPizzaValidationButton = new Button();
            SuspendLayout();
            // 
            // pizzaNameIndication
            // 
            pizzaNameIndication.AutoSize = true;
            pizzaNameIndication.Location = new Point(128, 91);
            pizzaNameIndication.Name = "pizzaNameIndication";
            pizzaNameIndication.Size = new Size(117, 20);
            pizzaNameIndication.TabIndex = 0;
            pizzaNameIndication.Text = "Nom de la Pizza";
            // 
            // pizzaPriceIndication
            // 
            pizzaPriceIndication.AutoSize = true;
            pizzaPriceIndication.Location = new Point(527, 91);
            pizzaPriceIndication.Name = "pizzaPriceIndication";
            pizzaPriceIndication.Size = new Size(33, 20);
            pizzaPriceIndication.TabIndex = 1;
            pizzaPriceIndication.Text = "Prix";
            // 
            // pizzaNameInput
            // 
            pizzaNameInput.Location = new Point(120, 141);
            pizzaNameInput.Name = "pizzaNameInput";
            pizzaNameInput.Size = new Size(125, 27);
            pizzaNameInput.TabIndex = 2;
            // 
            // pizzaPriceInput
            // 
            pizzaPriceInput.Location = new Point(482, 141);
            pizzaPriceInput.Name = "pizzaPriceInput";
            pizzaPriceInput.Size = new Size(125, 27);
            pizzaPriceInput.TabIndex = 3;
            // 
            // addPizzaValidationButton
            // 
            addPizzaValidationButton.Location = new Point(297, 278);
            addPizzaValidationButton.Name = "addPizzaValidationButton";
            addPizzaValidationButton.Size = new Size(94, 29);
            addPizzaValidationButton.TabIndex = 4;
            addPizzaValidationButton.Text = "Valider";
            addPizzaValidationButton.UseVisualStyleBackColor = true;
            addPizzaValidationButton.Click += addPizzaValidationButton_Click;
            // 
            // FrmAddPizza
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addPizzaValidationButton);
            Controls.Add(pizzaPriceInput);
            Controls.Add(pizzaNameInput);
            Controls.Add(pizzaPriceIndication);
            Controls.Add(pizzaNameIndication);
            Name = "FrmAddPizza";
            Text = "Ajouter Pizza";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pizzaNameIndication;
        private Label pizzaPriceIndication;
        private TextBox pizzaNameInput;
        private TextBox pizzaPriceInput;
        private Button addPizzaValidationButton;
    }
}