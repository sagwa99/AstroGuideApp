using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static AstroGuideApp.StarForm;

namespace AstroGuideApp
{
    public partial class ConstellationForm : Form
    {
        public class Constellation
        {
            public string Name { get; set; }
            public string EnglishName { get; set; }
            public double Area { get; set; }
            public string BrightestStar { get; set; }

            public List<string> Stars { get; set; }
            public Visibility Visibility { get; set; }
            public string Hemisphere => Visibility?.Hemisphere;
            public string RightAscension => Visibility?.RightAscension;
            public string Declination => Visibility?.Declination;
            public string BestMonths => Visibility?.BestMonths != null ? string.Join(", ", Visibility.BestMonths) : "";

            public string Description { get; set; }
        }
        //TODO better add this description as a tooltip
        public class Visibility
        {
            public List<int> BestMonths { get; set; }
            public string Hemisphere { get; set; }
            public string RightAscension { get; set; }
            public string Declination { get; set; }
        }
        public ConstellationForm()
        {
            InitializeComponent();
        }

        private void ConstellationForm_Load(object sender, EventArgs e)
        {
            string json = File.ReadAllText(@"C:\Users\user\source\repos\AstroGuideApp\Data\constellations.json");
            List<Constellation> constellations = JsonConvert.DeserializeObject<List<Constellation>>(json);
            gridViewConstellations.AutoGenerateColumns = true;
            gridViewConstellations.DataSource = constellations;
        }
    }
}
