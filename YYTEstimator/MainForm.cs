using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace YYTEstimator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            deckBox.Items.Add(cardBox.Text);
            if (quantitySelection.SelectedItem != null)
                quantityBox.Items.Add(quantitySelection.SelectedItem);
            else
                quantityBox.Items.Add(1);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            deckBox.Items.RemoveAt(deckBox.SelectedIndex);
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (StreamReader file = File.OpenText("YYTDB.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject obj = (JObject)JToken.ReadFrom(reader);

                Card.Cards = new List<Card>();

                foreach (var x in obj)
                    Card.Cards.Add(JsonConvert.DeserializeObject<Card>(x.Value.ToString()));
            }

            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            foreach (Card c in Card.Cards)
                coll.Add(c.ID);

            cardBox.AutoCompleteCustomSource = coll;
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            DialogResult result = importBrowser.ShowDialog();
            int sum = 0;

            deckBox.Items.Clear();
            priceBox.Items.Clear();

            if (result == DialogResult.OK)
            {
                if (importBrowser.CheckFileExists)
                {
                    Stream s = importBrowser.OpenFile();

                    using (StreamReader reader = new StreamReader(s))
                    {
                        string line;

                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] sline = line.Split(null);

                            Card card = Card.Cards.Find(c => c.ID == sline[0]);

                            if (card != null)
                            {
                                deckBox.Items.Add(card.ID);
                                priceBox.Items.Add(card.Price.ToString());

                                if (sline.Length == 2)
                                {
                                    quantityBox.Items.Add(sline[1]);

                                    sum += card.Price * Convert.ToInt32(sline[1]);
                                }
                                else
                                {
                                    quantityBox.Items.Add(1);

                                    sum += card.Price;
                                }
                            }
                        }
                    }
                }
            }

            priceLabel.Text = sum.ToString() + "¥";
        }

        private void estimateButton_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int i = 0;

            foreach (string s in deckBox.Items)
            {
                Card card = Card.Cards.Find(c => c.ID == s);

                if (card != null)
                {
                    deckBox.Items.Clear();
                    deckBox.Items.Add(card.ID);
                    priceBox.Items.Add(card.Price.ToString());

                    sum += card.Price * Convert.ToInt32(quantityBox.Items[i]);

                    i++;
                }
            }

            priceLabel.Text = sum.ToString() + "¥";
        }
    }
}
