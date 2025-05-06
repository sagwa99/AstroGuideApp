using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Drawing.Drawing2D;

namespace AstroGuideApp
{
    public partial class StarForm : Form
    {
        private List<Star> allStars;
        private List<Star> stars;
        private bool isFavoriteView;
        public StarForm(List<Star> stars = null, bool isFavoriteView = false)
        {
            InitializeComponent();
            this.stars = stars;
            this.isFavoriteView = isFavoriteView;
            comboBoxFilterSearch.Items.Add("Star");
            comboBoxFilterSearch.Items.Add("Constellation");
            comboBoxFilterSearch.SelectedIndex = 0;

        }

        public class Star
        {
            public string Name { get; set; }
            public string Constellation { get; set; }
            public double ApparentMagnitude { get; set; }
            public double Distance { get; set; }
            public double Luminosity { get; set; }
            public Coordinates Coordinates { get; set; }
            public string RightAscension => Coordinates?.RightAscension;
            public string Declination => Coordinates?.Declination;

            public bool IsFavorite { get; set; }
        }

        public class Coordinates
        {
            public string RightAscension { get; set; }
            public string Declination { get; set; }
        }

        //завантажуємо дані з JSON файлу
        private void StarForm_Load_1(object sender, EventArgs e)
        {
            if (stars == null || stars.Count == 0 || !isFavoriteView)
            {
                string json = File.ReadAllText(@"C:\Users\user\source\repos\AstroGuideApp\Data\stars.json");
                allStars = JsonConvert.DeserializeObject<List<Star>>(json);
            }
            else
            {
                allStars = stars;
            }

            gridViewStars.DataSource = allStars;
            LoadCards(isFavoriteView ? allStars.Where(s => s.IsFavorite).ToList() : allStars);


            if (isFavoriteView)
            {
                btnAddStar.Visible = false;
                btnDeleteSelected.Visible = false;
                btnToggleView.Visible = false;
                comboBoxFilterSearch.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                btnSearch.Visible = false;
                picAddStar.Visible = false;
                gridViewStars.Visible = false;
                txtSearch.Visible = false;
                panel1.Visible = false;
                panelCards.Dock = DockStyle.Fill;
                panelCards.Visible = true;
            }


            gridViewStars.ClearSelection();
        }


        private void SaveStarsToJson()
        {
            string json = JsonConvert.SerializeObject(allStars, Formatting.Indented);
            File.WriteAllText(@"C:\Users\user\source\repos\AstroGuideApp\Data\stars.json", json);
        }

        private void LoadCards(List<Star> stars)
        {
            panelCards.Controls.Clear();
            foreach (var star in stars)
            {
                StarCard card = new StarCard(star, OnFavoriteClicked, OnDeleteStarRequested);
                panelCards.Controls.Add(card);
            }
        }
        private void OnFavoriteClicked(Star star)
        {

            SaveStarsToJson();
            MessageBox.Show($"⭐ {star.Name} {(star.IsFavorite ? "додано до" : "видалено з")} обраного.", "Favorites", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (isFavoriteView)
            {
                var favorites = allStars.Where(s => s.IsFavorite).ToList();
                LoadCards(favorites);
            }
        }


        //search by star or constellation
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();
            string searchCategory = comboBoxFilterSearch.SelectedItem.ToString();

            if (searchCategory == "Star")
            {
                var starsInConstellations = allStars.Where(star =>
                    star.Name.ToLower().Contains(searchText, StringComparison.OrdinalIgnoreCase)
                ).ToList();

                gridViewStars.DataSource = new BindingList<Star>(starsInConstellations);
            }
            else if (searchCategory == "Constellation")
            {
                var starsInConstellation = allStars.Where(star =>
                    star.Constellation.ToLower().Contains(searchText, StringComparison.OrdinalIgnoreCase)
                ).ToList();
                gridViewStars.DataSource = new BindingList<Star>(starsInConstellation);
            }

            if (gridViewStars.Rows.Count == 1)
            {
                MessageBox.Show("Немає співпадінь.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridViewStars.DataSource = allStars;
            }

            txtSearch.Clear();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void btnAddStar_Click_1(object sender, EventArgs e)
        {

            using (AddStarForm addForm = new AddStarForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    Star newStar = addForm.NewStar;
                    allStars.Add(newStar);
                    SaveStarsToJson();
                    gridViewStars.DataSource = new BindingList<Star>(allStars);
                    LoadCards(allStars);
                }
            }
        }

        private void btnToggleView_Click_1(object sender, EventArgs e)
        {
            bool showCards = !panelCards.Visible;
            panelCards.Visible = showCards;
            gridViewStars.Visible = !showCards;
        }

        private void btnDeleteSelected_Click_1(object sender, EventArgs e)
        {
            if (gridViewStars.SelectedRows.Count > 0)
            {
                var starToDelete = gridViewStars.SelectedRows[0].DataBoundItem as Star;
                if (starToDelete != null)
                {
                    allStars.Remove(starToDelete);
                    SaveStarsToJson();
                    gridViewStars.DataSource = new BindingList<Star>(allStars);
                    LoadCards(allStars);
                }
            }
        }

        private void picAddStar_Click(object sender, EventArgs e)
        {
            using (AddStarForm addForm = new AddStarForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    Star newStar = addForm.NewStar;
                    allStars.Add(newStar);
                    SaveStarsToJson();
                    LoadCards(allStars.Where(s => !isFavoriteView || s.IsFavorite).ToList());
                }
            }
        }

        //обробник на видалення зірки
        private void OnDeleteStarRequested(Star starToDelete)
        {
            allStars.Remove(starToDelete);
            SaveStarsToJson();
            LoadCards(allStars.Where(s => !isFavoriteView || s.IsFavorite).ToList());
        }
    }
}
