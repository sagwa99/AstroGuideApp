namespace AstroGuideApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelMenu = new Panel();
            btnNavFav = new Button();
            btnNavFlashcard = new Button();
            btnNavConstellation = new Button();
            btnNavStar = new Button();
            panelLogo = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(184, 210, 255);
            panelMenu.Controls.Add(btnNavFav);
            panelMenu.Controls.Add(btnNavFlashcard);
            panelMenu.Controls.Add(btnNavConstellation);
            panelMenu.Controls.Add(btnNavStar);
            panelMenu.Controls.Add(panelLogo);
            resources.ApplyResources(panelMenu, "panelMenu");
            panelMenu.Name = "panelMenu";
            // 
            // btnNavFav
            // 
            btnNavFav.BackColor = Color.FromArgb(184, 210, 255);
            btnNavFav.Cursor = Cursors.Hand;
            resources.ApplyResources(btnNavFav, "btnNavFav");
            btnNavFav.FlatAppearance.BorderSize = 0;
            btnNavFav.FlatAppearance.MouseDownBackColor = Color.FromArgb(220, 233, 255);
            btnNavFav.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 255);
            btnNavFav.Image = Properties.Resources.icons8_favorite_16;
            btnNavFav.Name = "btnNavFav";
            btnNavFav.UseVisualStyleBackColor = false;
            // 
            // btnNavFlashcard
            // 
            btnNavFlashcard.BackColor = Color.FromArgb(184, 210, 255);
            btnNavFlashcard.Cursor = Cursors.Hand;
            resources.ApplyResources(btnNavFlashcard, "btnNavFlashcard");
            btnNavFlashcard.FlatAppearance.BorderSize = 0;
            btnNavFlashcard.FlatAppearance.MouseDownBackColor = Color.FromArgb(220, 233, 255);
            btnNavFlashcard.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 255);
            btnNavFlashcard.Image = Properties.Resources.icons8_red_card_16;
            btnNavFlashcard.Name = "btnNavFlashcard";
            btnNavFlashcard.UseVisualStyleBackColor = false;
            // 
            // btnNavConstellation
            // 
            btnNavConstellation.BackColor = Color.FromArgb(184, 210, 255);
            btnNavConstellation.Cursor = Cursors.Hand;
            resources.ApplyResources(btnNavConstellation, "btnNavConstellation");
            btnNavConstellation.FlatAppearance.BorderSize = 0;
            btnNavConstellation.FlatAppearance.MouseDownBackColor = Color.FromArgb(220, 233, 255);
            btnNavConstellation.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 255);
            btnNavConstellation.Image = Properties.Resources.icons8_constellation_16;
            btnNavConstellation.Name = "btnNavConstellation";
            btnNavConstellation.UseVisualStyleBackColor = false;
            // 
            // btnNavStar
            // 
            btnNavStar.BackColor = Color.FromArgb(184, 210, 255);
            btnNavStar.Cursor = Cursors.Hand;
            resources.ApplyResources(btnNavStar, "btnNavStar");
            btnNavStar.FlatAppearance.BorderSize = 0;
            btnNavStar.FlatAppearance.MouseDownBackColor = Color.FromArgb(220, 233, 255);
            btnNavStar.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 244, 255);
            btnNavStar.Image = Properties.Resources.icons8_star_16;
            btnNavStar.Name = "btnNavStar";
            btnNavStar.UseVisualStyleBackColor = false;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(184, 210, 255);
            resources.ApplyResources(panelLogo, "panelLogo");
            panelLogo.Name = "panelLogo";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMenu);
            Name = "MainForm";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnNavStar;
        private Panel panelLogo;
        private Button btnNavFav;
        private Button btnNavFlashcard;
        private Button btnNavConstellation;
    }
}