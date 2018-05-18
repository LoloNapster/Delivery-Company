namespace TestDataGridView
{
    partial class PackageManagementPanel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddPackage = new System.Windows.Forms.Button();
            this.buttonEditPackage = new System.Windows.Forms.Button();
            this.buttonChangeStatusPackage = new System.Windows.Forms.Button();
            this.buttonRemovePackage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(732, 353);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(98, 27);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(663, 20);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wyszukaj:";
            // 
            // buttonAddPackage
            // 
            this.buttonAddPackage.Location = new System.Drawing.Point(29, 430);
            this.buttonAddPackage.Name = "buttonAddPackage";
            this.buttonAddPackage.Size = new System.Drawing.Size(115, 23);
            this.buttonAddPackage.TabIndex = 3;
            this.buttonAddPackage.Text = "Dodaj";
            this.buttonAddPackage.UseVisualStyleBackColor = true;
            this.buttonAddPackage.Click += new System.EventHandler(this.ButtonAddPackage_Click);
            // 
            // buttonEditPackage
            // 
            this.buttonEditPackage.Location = new System.Drawing.Point(201, 430);
            this.buttonEditPackage.Name = "buttonEditPackage";
            this.buttonEditPackage.Size = new System.Drawing.Size(133, 23);
            this.buttonEditPackage.TabIndex = 4;
            this.buttonEditPackage.Text = "Edytuj";
            this.buttonEditPackage.UseVisualStyleBackColor = true;
            this.buttonEditPackage.Click += new System.EventHandler(this.ButtonEditPackage_Click);
            // 
            // buttonChangeStatusPackage
            // 
            this.buttonChangeStatusPackage.Location = new System.Drawing.Point(424, 430);
            this.buttonChangeStatusPackage.Name = "buttonChangeStatusPackage";
            this.buttonChangeStatusPackage.Size = new System.Drawing.Size(112, 23);
            this.buttonChangeStatusPackage.TabIndex = 5;
            this.buttonChangeStatusPackage.Text = "Zmień status";
            this.buttonChangeStatusPackage.UseVisualStyleBackColor = true;
            this.buttonChangeStatusPackage.Click += new System.EventHandler(this.ButtonChangeStatusPackage_Click);
            // 
            // buttonRemovePackage
            // 
            this.buttonRemovePackage.Location = new System.Drawing.Point(625, 430);
            this.buttonRemovePackage.Name = "buttonRemovePackage";
            this.buttonRemovePackage.Size = new System.Drawing.Size(136, 23);
            this.buttonRemovePackage.TabIndex = 6;
            this.buttonRemovePackage.Text = "Usuń";
            this.buttonRemovePackage.UseVisualStyleBackColor = true;
            this.buttonRemovePackage.Click += new System.EventHandler(this.ButtonRemovePackage_Click);
            // 
            // PackageManagementPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.buttonRemovePackage);
            this.Controls.Add(this.buttonChangeStatusPackage);
            this.Controls.Add(this.buttonEditPackage);
            this.Controls.Add(this.buttonAddPackage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PackageManagementPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paczki";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PackageManagementPanel_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddPackage;
        private System.Windows.Forms.Button buttonEditPackage;
        private System.Windows.Forms.Button buttonChangeStatusPackage;
        private System.Windows.Forms.Button buttonRemovePackage;
    }
}