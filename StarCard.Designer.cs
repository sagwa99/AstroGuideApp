namespace AstroGuideApp
{
    partial class StarCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lblConstellation = new Label();
            lblMagnitude = new Label();
            lblDistance = new Label();
            picFavorite = new PictureBox();
            lblLuminosity = new Label();
            lblRA = new Label();
            lblDec = new Label();
            picDeleteStar = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)picFavorite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDeleteStar).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(30, 27);
            lblName.Name = "lblName";
            lblName.Size = new Size(50, 20);
            lblName.TabIndex = 1;
            lblName.Text = "label1";
            // 
            // lblConstellation
            // 
            lblConstellation.AutoSize = true;
            lblConstellation.Location = new Point(30, 47);
            lblConstellation.Name = "lblConstellation";
            lblConstellation.Size = new Size(50, 20);
            lblConstellation.TabIndex = 2;
            lblConstellation.Text = "label2";
            // 
            // lblMagnitude
            // 
            lblMagnitude.AutoSize = true;
            lblMagnitude.Location = new Point(30, 67);
            lblMagnitude.Name = "lblMagnitude";
            lblMagnitude.Size = new Size(50, 20);
            lblMagnitude.TabIndex = 3;
            lblMagnitude.Text = "label3";
            // 
            // lblDistance
            // 
            lblDistance.AutoSize = true;
            lblDistance.Location = new Point(30, 87);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(50, 20);
            lblDistance.TabIndex = 4;
            lblDistance.Text = "label4";
            // 
            // picFavorite
            // 
            picFavorite.BackColor = Color.FromArgb(184, 210, 255);
            picFavorite.Cursor = Cursors.Hand;
            picFavorite.Image = Properties.Resources.icons8_favorite_16;
            picFavorite.Location = new Point(525, 30);
            picFavorite.Name = "picFavorite";
            picFavorite.Size = new Size(41, 40);
            picFavorite.SizeMode = PictureBoxSizeMode.CenterImage;
            picFavorite.TabIndex = 5;
            picFavorite.TabStop = false;
            // 
            // lblLuminosity
            // 
            lblLuminosity.AutoSize = true;
            lblLuminosity.Location = new Point(30, 107);
            lblLuminosity.Name = "lblLuminosity";
            lblLuminosity.Size = new Size(50, 20);
            lblLuminosity.TabIndex = 6;
            lblLuminosity.Text = "label5";
            // 
            // lblRA
            // 
            lblRA.AutoSize = true;
            lblRA.Location = new Point(30, 127);
            lblRA.Name = "lblRA";
            lblRA.Size = new Size(50, 20);
            lblRA.TabIndex = 7;
            lblRA.Text = "label6";
            // 
            // lblDec
            // 
            lblDec.AutoSize = true;
            lblDec.Location = new Point(30, 147);
            lblDec.Name = "lblDec";
            lblDec.Size = new Size(50, 20);
            lblDec.TabIndex = 8;
            lblDec.Text = "label7";
            // 
            // picDeleteStar
            // 
            picDeleteStar.BackColor = Color.FromArgb(184, 210, 255);
            picDeleteStar.Cursor = Cursors.Hand;
            picDeleteStar.Image = Properties.Resources.icons8_remove_16;
            picDeleteStar.Location = new Point(539, 184);
            picDeleteStar.Name = "picDeleteStar";
            picDeleteStar.Size = new Size(41, 40);
            picDeleteStar.SizeMode = PictureBoxSizeMode.CenterImage;
            picDeleteStar.TabIndex = 10;
            picDeleteStar.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 50, 90, 1);
            panel1.Controls.Add(picFavorite);
            panel1.Controls.Add(lblDec);
            panel1.Controls.Add(lblMagnitude);
            panel1.Controls.Add(lblRA);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(lblLuminosity);
            panel1.Controls.Add(lblConstellation);
            panel1.Controls.Add(lblDistance);
            panel1.Location = new Point(14, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(613, 240);
            panel1.TabIndex = 11;
            // 
            // StarCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(picDeleteStar);
            Controls.Add(panel1);
            Name = "StarCard";
            Size = new Size(660, 322);
            ((System.ComponentModel.ISupportInitialize)picFavorite).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDeleteStar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblName;
        private Label lblConstellation;
        private Label lblMagnitude;
        private Label lblDistance;
        private PictureBox picFavorite;
        private Label lblLuminosity;
        private Label lblRA;
        private Label lblDec;
        private PictureBox picDeleteStar;
        private Panel panel1;
    }
}
