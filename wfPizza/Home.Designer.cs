namespace wfPizza
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStripHome = new MenuStrip();
            menuCommandButton = new ToolStripMenuItem();
            menuAddClientButton = new ToolStripMenuItem();
            menuAddPizzaButton = new ToolStripMenuItem();
            menuStripHome.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripHome
            // 
            menuStripHome.ImageScalingSize = new Size(20, 20);
            menuStripHome.Items.AddRange(new ToolStripItem[] { menuCommandButton, menuAddClientButton, menuAddPizzaButton });
            menuStripHome.Location = new Point(0, 0);
            menuStripHome.Name = "menuStripHome";
            menuStripHome.Size = new Size(800, 28);
            menuStripHome.TabIndex = 0;
            menuStripHome.Text = "menuStrip1";
            // 
            // menuCommandButton
            // 
            menuCommandButton.Name = "menuCommandButton";
            menuCommandButton.Size = new Size(105, 24);
            menuCommandButton.Text = "Commander";
            menuCommandButton.Click += menuCommandButton_Click;
            // 
            // menuAddClientButton
            // 
            menuAddClientButton.Name = "menuAddClientButton";
            menuAddClientButton.Size = new Size(114, 24);
            menuAddClientButton.Text = "Ajouter Client";
            menuAddClientButton.Click += menuAddClientButton_Click;
            // 
            // menuAddPizzaButton
            // 
            menuAddPizzaButton.Name = "menuAddPizzaButton";
            menuAddPizzaButton.Size = new Size(110, 24);
            menuAddPizzaButton.Text = "Ajouter Pizza";
            menuAddPizzaButton.Click += menuAddPizzaButton_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStripHome);
            MainMenuStrip = menuStripHome;
            Name = "Home";
            Text = "Commande";
            menuStripHome.ResumeLayout(false);
            menuStripHome.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripHome;
        private ToolStripMenuItem menuCommandButton;
        private ToolStripMenuItem menuAddClientButton;
        private ToolStripMenuItem menuAddPizzaButton;
    }
}
