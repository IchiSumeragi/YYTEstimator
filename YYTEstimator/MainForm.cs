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

            //on cherche un match pour la carte qu'on vient d'ajouter
            Card card = Card.Cards.Find(c => c.ID == cardBox.Text);

            //si on en trouve un, on ajoute la carte et ses données dans les box puis on calcule la somme                
            if (card != null)
            {
                deckBox.Items.Clear();
                deckBox.Items.Add(card.ID);
                priceBox.Items.Add(card.Price.ToString());
                
                //sum += Convert.ToInt32(priceLabel.Text) * card.Price * Convert.ToInt32(quantitySelection);

                //priceLabel.Text = sum.ToString() + "¥";
            }

            //si on a pas selectionné de quantité, on en met 1 par défaut
            if (quantitySelection.SelectedItem != null)
                quantityBox.Items.Add(quantitySelection.SelectedItem);
            else
                quantityBox.Items.Add(1);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            //on remove de deckbox en dernier sinon l'index saute
            //l'index vaut -1 quand rien n'est selectionné
            if (deckBox.SelectedIndex != -1)
            {
                quantityBox.Items.RemoveAt(deckBox.SelectedIndex);
                priceBox.Items.RemoveAt(deckBox.SelectedIndex);
                deckBox.Items.RemoveAt(deckBox.SelectedIndex);
            }
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            //affiche la fenêtre "About"
            AboutForm form = new AboutForm();
            form.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //PATH FIXE : DB à mettre dans bin/debug
            using (StreamReader file = File.OpenText("YYTDB.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject obj = (JObject)JToken.ReadFrom(reader);

                Card.Cards = new List<Card>();

                foreach (var x in obj)
                    Card.Cards.Add(JsonConvert.DeserializeObject<Card>(x.Value.ToString()));
            }

            //pour l'autocomplétion, il faut lui passer une collection d'un type précis
            //qui est remplie avec les ID des cartes à autocompléter
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            foreach (Card c in Card.Cards)
                coll.Add(c.ID);

            cardBox.AutoCompleteCustomSource = coll;
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            //si le result est OK, on a un fichier et tout s'est bien passé
            DialogResult result = importBrowser.ShowDialog();
            int sum = 0;

            //quand on importe d'un txt, on clean toutes les données
            //pour mettre celles du txt à la place
            deckBox.Items.Clear();
            quantityBox.Items.Clear();
            priceBox.Items.Clear();

            if (result == DialogResult.OK)
            {
                if (importBrowser.CheckFileExists)
                {
                    //on lit le fichier
                    Stream s = importBrowser.OpenFile();

                    using (StreamReader reader = new StreamReader(s))
                    {
                        string line;

                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] sline = line.Split(null);

                            //on cherche un match entre l'ID trouvé dans le txt et une carte de la DB
                            Card card = Card.Cards.Find(c => c.ID == sline[0]);

                            //si on en trouve un, on ajoute la carte et ses données dans les box
                            if (card != null)
                            {
                                deckBox.Items.Add(card.ID);
                                priceBox.Items.Add(card.Price.ToString());

                                //par défaut, si aucune quantité n'est précisée dans le txt, on en met 1
                                //puis on calcule la somme du prix (+= prix * quantité)
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

            //pour chaque carte, on cherche un match entre l'id et une carte de la DB
            foreach (string s in deckBox.Items)
            {
                Card card = Card.Cards.Find(c => c.ID == s);

                //si on en trouve un, on ajoute la carte et ses données dans les box puis on calcule la somme                
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

        private void exportButton_Click(object sender, EventArgs e)
        {
            //string path = "";
            //DialogResult result = importBrowser.ShowDialog();

            //path = importBrowser.cre
            //if (result == DialogResult.OK)
            //{
            //    using (StreamWriter writer = new StreamWriter(path))
            //    {
            //        foreach (var c in deckBox.Items)
            //        {

            //        }
            //    }
            //}
        }

        private void deckBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Card card = Card.Cards.Find(c => c.ID == deckBox.SelectedItem.ToString());

            //si on en trouve un, on ajoute la carte et ses données dans les box puis on calcule la somme                
            if (card != null)
            {
                cardPicturebox.LoadAsync(card.URL);
            }
        }
    }
}