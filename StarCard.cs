using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AstroGuideApp.StarForm;

namespace AstroGuideApp
{
    public partial class StarCard : UserControl
    {
        private bool isFavorite;
        private Star star;
        private Action<Star> onFavoriteClicked;
        private Action<Star> onDeleteRequested;

        string basePath = Application.StartupPath + @"\images\";

        public StarCard(Star star, Action<Star> onFavoriteClicked, Action<Star> onDeleteRequested, bool isFavoriteView = false)
        {
            this.star = star ?? throw new ArgumentNullException(nameof(star));
            InitializeComponent();

            lblName.Text = star.Name;
            lblConstellation.Text = $"Сузір'я: {star.Constellation}";
            lblMagnitude.Text = $"Довжина: {star.ApparentMagnitude}";
            lblDistance.Text = $"Відстань: {star.Distance} ly";
            lblLuminosity.Text = $"Світність: {star.Luminosity}";
            lblRA.Text = $"RA: {star.RightAscension}";
            lblDec.Text = $"Dec: {star.Declination}";

            isFavorite = star.IsFavorite;

            UpdateFavoriteIcon();

            picFavorite.Cursor = Cursors.Hand;

            picFavorite.Click += (s, e) =>
            {
                isFavorite = !isFavorite;
                star.IsFavorite = isFavorite;
                UpdateFavoriteIcon();

                onFavoriteClicked?.Invoke(star);
            };

            picDeleteStar.Click += (s, e) => onDeleteRequested?.Invoke(star);

        }

        private void UpdateFavoriteIcon()
        {
            picFavorite.Image = isFavorite
         ? Image.FromFile(basePath + "icons8-filled-bookmark-ribbon-16.png")
         : Image.FromFile(basePath + "icons8-favorite-16.png");
        }

        //private void picDeleteStar_Click(object sender, EventArgs e)
        //{
        //    //делегат на видалення
        //    onDeleteRequested?.Invoke(star);
        //}
    }
}
