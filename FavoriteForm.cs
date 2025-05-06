using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AstroGuideApp.StarForm;

namespace AstroGuideApp
{
    public partial class FavoriteForm : Form
    {
        private bool isFavoriteView = true;
        private List<Star> allStars;
        public FavoriteForm(List<Star> stars)
        {
            InitializeComponent();
            allStars = stars;
        }

        private void FavoriteForm_Load(object sender, EventArgs e)
        {
            LoadFavoriteCards();
        }

        private void LoadFavoriteCards()
        {
            panelFavoriteCards.Controls.Clear();

            var favoriteStars = allStars.Where(s => s.IsFavorite).ToList();

            foreach (var star in favoriteStars)
            {
                StarCard card = new StarCard(star, OnFavoriteToggled, OnDeleteRequested, isFavoriteView);
                panelFavoriteCards.Controls.Add(card);
            }
        }
        private void OnFavoriteToggled(Star star)
        {
            star.IsFavorite = !star.IsFavorite;
            LoadFavoriteCards();
        }

        private void OnDeleteRequested(Star star)
        {
            allStars.Remove(star);
            LoadFavoriteCards();
        }
    }
}
