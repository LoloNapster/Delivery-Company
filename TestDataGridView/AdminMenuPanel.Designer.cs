namespace TestDataGridView
{
    partial class AdminMenuPanel
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
            this.buttonUserManagmentPanel = new System.Windows.Forms.Button();
            this.buttonManagementPackagePanel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUserManagmentPanel
            // 
            this.buttonUserManagmentPanel.Location = new System.Drawing.Point(48, 39);
            this.buttonUserManagmentPanel.Name = "buttonUserManagmentPanel";
            this.buttonUserManagmentPanel.Size = new System.Drawing.Size(173, 40);
            this.buttonUserManagmentPanel.TabIndex = 0;
            this.buttonUserManagmentPanel.Text = "Zarządzanie urzytkownikami";
            this.buttonUserManagmentPanel.UseVisualStyleBackColor = true;
            this.buttonUserManagmentPanel.Click += new System.EventHandler(this.ButtonUserManagmentPanel_Click);
            // 
            // buttonManagementPackagePanel
            // 
            this.buttonManagementPackagePanel.Location = new System.Drawing.Point(48, 126);
            this.buttonManagementPackagePanel.Name = "buttonManagementPackagePanel";
            this.buttonManagementPackagePanel.Size = new System.Drawing.Size(173, 38);
            this.buttonManagementPackagePanel.TabIndex = 1;
            this.buttonManagementPackagePanel.Text = "Zarządzanie paczkami";
            this.buttonManagementPackagePanel.UseVisualStyleBackColor = true;
            this.buttonManagementPackagePanel.Click += new System.EventHandler(this.ButtonManagementPackagePanel_Click);
            // 
            // AdminMenuPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 216);
            this.Controls.Add(this.buttonManagementPackagePanel);
            this.Controls.Add(this.buttonUserManagmentPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminMenuPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminMenuPanel_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUserManagmentPanel;
        private System.Windows.Forms.Button buttonManagementPackagePanel;
    }
}