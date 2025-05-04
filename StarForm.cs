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
        public StarForm()
        {
            InitializeComponent();
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
            List<Star> stars = JsonConvert.DeserializeObject<List<Star>>(json);
            gridViewStars.DataSource = stars;
        }
    }
}
