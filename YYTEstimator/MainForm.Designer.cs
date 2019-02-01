﻿namespace YYTEstimator
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
            this.SuspendLayout();
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(313, 359);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(75, 23);
            this.aboutButton.TabIndex = 1;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(307, 6);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deckBox
            // 
            this.deckBox.FormattingEnabled = true;
            this.deckBox.Location = new System.Drawing.Point(12, 40);
            this.deckBox.Name = "deckBox";
            this.deckBox.Size = new System.Drawing.Size(176, 342);
            this.deckBox.TabIndex = 3;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(307, 40);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // cardBox
            // 
            this.cardBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cardBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cardBox.Location = new System.Drawing.Point(12, 9);
            this.cardBox.Name = "cardBox";
            this.cardBox.Size = new System.Drawing.Size(176, 20);
            this.cardBox.TabIndex = 5;
            // 
            // estimateButton
            // 
            this.estimateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.estimateButton.Location = new System.Drawing.Point(12, 388);
            this.estimateButton.Name = "estimateButton";
            this.estimateButton.Size = new System.Drawing.Size(116, 52);
            this.estimateButton.TabIndex = 6;
            this.estimateButton.Text = "Estimate !";
            this.estimateButton.UseVisualStyleBackColor = true;
            this.estimateButton.Click += new System.EventHandler(this.estimateButton_Click);
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(134, 413);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(75, 23);
            this.importButton.TabIndex = 7;
            this.importButton.Text = "Import...";
            this.importButton.UseVisualStyleBackColor = true;
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
            this.priceBox.FormattingEnabled = true;
            this.priceBox.Location = new System.Drawing.Point(253, 40);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(48, 342);
            this.priceBox.TabIndex = 9;
            // 
            // quantityBox
            // 
            this.quantityBox.FormattingEnabled = true;
            this.quantityBox.Location = new System.Drawing.Point(194, 40);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(53, 342);
            this.quantityBox.TabIndex = 10;
            // 
            // quantitySelection
            // 
            this.quantitySelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 448);
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
            this.Name = "MainForm";
            this.Text = "YYT Estimator";
            this.Load += new System.EventHandler(this.MainForm_Load);
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
    }
}

