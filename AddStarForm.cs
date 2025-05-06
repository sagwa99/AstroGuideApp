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
    public partial class AddStarForm : Form
    {
        public Star NewStar { get; private set; }

        public AddStarForm()
        {
            InitializeComponent();
        }
        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            if (!double.TryParse(txtMagnitude.Text, out double magnitude) ||
               !double.TryParse(txtDistance.Text, out double distance) ||
               !double.TryParse(txtLuminosity.Text, out double luminosity))
            {
                MessageBox.Show("Введіть числові значення для зоряної величини, відстані, та світності.");
                return;
            }

            NewStar = new Star
            {
                Name = txtName.Text.Trim(),
                Constellation = txtConstellation.Text.Trim(),
                ApparentMagnitude = magnitude,
                Distance = distance,
                Luminosity = luminosity,
                Coordinates = new Coordinates
                {
                    RightAscension = txtRA.Text.Trim(),
                    Declination = txtDec.Text.Trim()
                }
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
