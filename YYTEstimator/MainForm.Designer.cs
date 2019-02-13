namespace YYTEstimator
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.aboutButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deckBox = new System.Windows.Forms.ListBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.cardBox = new System.Windows.Forms.TextBox();
            this.estimateButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.importBrowser = new System.Windows.Forms.OpenFileDialog();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.ListBox();
            this.quantityBox = new System.Windows.Forms.ListBox();
            this.quantitySelection = new System.Windows.Forms.ComboBox();
            this.exportButton = new System.Windows.Forms.Button();
            this.cardPicturebox = new System.Windows.Forms.PictureBox();
            this.exportDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.cardPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.aboutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aboutButton.Location = new System.Drawing.Point(414, 417);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(75, 23);
            this.aboutButton.TabIndex = 1;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = false;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Location = new System.Drawing.Point(307, 6);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deckBox
            // 
            this.deckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deckBox.ForeColor = System.Drawing.Color.White;
            this.deckBox.FormattingEnabled = true;
            this.deckBox.Location = new System.Drawing.Point(12, 40);
            this.deckBox.Name = "deckBox";
            this.deckBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.deckBox.Size = new System.Drawing.Size(176, 342);
            this.deckBox.TabIndex = 3;
            this.deckBox.SelectedIndexChanged += new System.EventHandler(this.deckBox_SelectedIndexChanged);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.removeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeButton.Location = new System.Drawing.Point(307, 40);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // cardBox
            // 
            this.cardBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cardBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cardBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cardBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardBox.ForeColor = System.Drawing.Color.White;
            this.cardBox.Location = new System.Drawing.Point(12, 9);
            this.cardBox.Name = "cardBox";
            this.cardBox.Size = new System.Drawing.Size(176, 20);
            this.cardBox.TabIndex = 5;
            // 
            // estimateButton
            // 
            this.estimateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.estimateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.estimateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.estimateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.estimateButton.Location = new System.Drawing.Point(12, 388);
            this.estimateButton.Name = "estimateButton";
            this.estimateButton.Size = new System.Drawing.Size(116, 52);
            this.estimateButton.TabIndex = 6;
            this.estimateButton.Text = "Estimate !";
            this.estimateButton.UseVisualStyleBackColor = false;
            this.estimateButton.Click += new System.EventHandler(this.estimateButton_Click);
            // 
            // importButton
            // 
            this.importButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.importButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.importButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.importButton.Location = new System.Drawing.Point(134, 388);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(75, 23);
            this.importButton.TabIndex = 7;
            this.importButton.Text = "Import...";
            this.importButton.UseVisualStyleBackColor = false;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // importBrowser
            // 
            this.importBrowser.FileName = "openFileDialog1";
            this.importBrowser.Filter = "Text files (*.txt)|*.txt";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.priceLabel.Location = new System.Drawing.Point(230, 394);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(64, 46);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "0¥";
            // 
            // priceBox
            // 
            this.priceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.priceBox.ForeColor = System.Drawing.Color.White;
            this.priceBox.FormattingEnabled = true;
            this.priceBox.Location = new System.Drawing.Point(253, 40);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(48, 342);
            this.priceBox.TabIndex = 9;
            // 
            // quantityBox
            // 
            this.quantityBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quantityBox.ForeColor = System.Drawing.Color.White;
            this.quantityBox.FormattingEnabled = true;
            this.quantityBox.Location = new System.Drawing.Point(194, 40);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(53, 342);
            this.quantityBox.TabIndex = 10;
            // 
            // quantitySelection
            // 
            this.quantitySelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quantitySelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quantitySelection.ForeColor = System.Drawing.Color.White;
            this.quantitySelection.FormattingEnabled = true;
            this.quantitySelection.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.quantitySelection.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.quantitySelection.Location = new System.Drawing.Point(194, 9);
            this.quantitySelection.Name = "quantitySelection";
            this.quantitySelection.Size = new System.Drawing.Size(53, 21);
            this.quantitySelection.TabIndex = 11;
            // 
            // exportButton
            // 
            this.exportButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exportButton.Location = new System.Drawing.Point(134, 417);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 12;
            this.exportButton.Text = "Export...";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // cardPicturebox
            // 
            this.cardPicturebox.Location = new System.Drawing.Point(307, 69);
            this.cardPicturebox.Name = "cardPicturebox";
            this.cardPicturebox.Size = new System.Drawing.Size(189, 264);
            this.cardPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardPicturebox.TabIndex = 14;
            this.cardPicturebox.TabStop = false;
            this.cardPicturebox.Click += new System.EventHandler(this.cardPicturebox_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(501, 448);
            this.Controls.Add(this.cardPicturebox);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.quantitySelection);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.estimateButton);
            this.Controls.Add(this.cardBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.deckBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.aboutButton);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "YYT Estimator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardPicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox deckBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox cardBox;
        private System.Windows.Forms.Button estimateButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.OpenFileDialog importBrowser;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.ListBox priceBox;
        private System.Windows.Forms.ListBox quantityBox;
        private System.Windows.Forms.ComboBox quantitySelection;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.PictureBox cardPicturebox;
        private System.Windows.Forms.SaveFileDialog exportDialog;
    }
}

