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

            LoadCards(isFavoriteView ? allStars.Where(s => s.IsFavorite).ToList() : allStars);


            if (isFavoriteView)
            {
                comboBoxFilterSearch.Visible = false;
                button6.Visible = false;
                btnSearch.Visible = false;
                picAddStar.Visible = false;
                txtSearch.Visible = false;
                panel1.Visible = false;
                panelCards.Dock = DockStyle.Fill;
                panelCards.Visible = true;
            }

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

            var filteredStars = allStars.Where(star =>
            {
                bool matchesQuery = star.Name.ToLower().Contains(searchText) ||
                                    star.Constellation.ToLower().Contains(searchText);

                if (searchCategory == "Star")
                    return star.Name.ToLower().Contains(searchText);
                else if (searchCategory == "Constellation")
                    return star.Constellation.ToLower().Contains(searchText);
                else
                    return matchesQuery;
            }).ToList();

            if (filteredStars.Count == 0)
            {
                MessageBox.Show("Немає співпадінь.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                filteredStars = allStars;
            }

            LoadCards(filteredStars);
            txtSearch.Clear();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
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

        private void OnDeleteStarRequested(Star starToDelete)
        {
            var result = MessageBox.Show(
            $"Видалити '{starToDelete.Name}'?",
            "Підтвердіть видалення",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                allStars.Remove(starToDelete);
                SaveStarsToJson();
                LoadCards(allStars.Where(s => !isFavoriteView || s.IsFavorite).ToList());
            }
        }
    }
}
