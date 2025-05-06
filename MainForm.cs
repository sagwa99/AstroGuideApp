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
    public partial class MainForm : Form
    {
        private List<Star> allStars;
        public MainForm()
        {
            InitializeComponent();
            allStars = new List<Star>();
        }


        //відкриває нову окрему форму на панелі
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnNavStar_Click(object sender, EventArgs e)
        {
            openChildForm(new StarForm(allStars, false));
        }

        private void btnNavConstellation_Click(object sender, EventArgs e)
        {
            openChildForm(new ConstellationForm());
        }

        private void btnNavFlashcard_Click(object sender, EventArgs e)
        {
            openChildForm(new FlashcardForm());
        }

        private void btnNavCalculator_Click(object sender, EventArgs e)
        {
            openChildForm(new CalculatorForm());
        }

        private void btnFav_Click(object sender, EventArgs e)
        {
            var favoriteStars = allStars.Where(star => star.IsFavorite).ToList();
            openChildForm(new StarForm(favoriteStars, true));
        }
    }
}
