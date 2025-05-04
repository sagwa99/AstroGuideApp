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
        private List<Star> allStars = new List<Star>();
        public StarForm()
        {
            InitializeComponent();
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
        }

        public class Coordinates
        {
            public string RightAscension { get; set; }
            public string Declination { get; set; }
        }

        //завантажуємо дані з JSON файлу
        private void StarForm_Load_1(object sender, EventArgs e)
        {

            string json = File.ReadAllText(@"C:\Users\user\source\repos\AstroGuideApp\Data\stars.json");
            allStars = JsonConvert.DeserializeObject<List<Star>>(json);
            gridViewStars.DataSource = allStars;
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
    }
}
