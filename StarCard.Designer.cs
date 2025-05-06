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
            ((System.ComponentModel.ISupportInitialize)picFavorite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDeleteStar).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(27, 16);
            lblName.Name = "lblName";
            lblName.Size = new Size(50, 20);
            lblName.TabIndex = 1;
            lblName.Text = "label1";
            // 
            // lblConstellation
            // 
            lblConstellation.AutoSize = true;
            lblConstellation.Location = new Point(27, 36);
            lblConstellation.Name = "lblConstellation";
            lblConstellation.Size = new Size(50, 20);
            lblConstellation.TabIndex = 2;
            lblConstellation.Text = "label2";
            // 
            // lblMagnitude
            // 
            lblMagnitude.AutoSize = true;
            lblMagnitude.Location = new Point(27, 56);
            lblMagnitude.Name = "lblMagnitude";
            lblMagnitude.Size = new Size(50, 20);
            lblMagnitude.TabIndex = 3;
            lblMagnitude.Text = "label3";
            // 
            // lblDistance
            // 
            lblDistance.AutoSize = true;
            lblDistance.Location = new Point(27, 76);
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
            picFavorite.Location = new Point(539, 6);
            picFavorite.Name = "picFavorite";
            picFavorite.Size = new Size(41, 40);
            picFavorite.SizeMode = PictureBoxSizeMode.CenterImage;
            picFavorite.TabIndex = 5;
            picFavorite.TabStop = false;
            // 
            // lblLuminosity
            // 
            lblLuminosity.AutoSize = true;
            lblLuminosity.Location = new Point(27, 96);
            lblLuminosity.Name = "lblLuminosity";
            lblLuminosity.Size = new Size(50, 20);
            lblLuminosity.TabIndex = 6;
            lblLuminosity.Text = "label5";
            // 
            // lblRA
            // 
            lblRA.AutoSize = true;
            lblRA.Location = new Point(27, 116);
            lblRA.Name = "lblRA";
            lblRA.Size = new Size(50, 20);
            lblRA.TabIndex = 7;
            lblRA.Text = "label6";
            // 
            // lblDec
            // 
            lblDec.AutoSize = true;
            lblDec.Location = new Point(27, 136);
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
            //picDeleteStar.Click += picDeleteStar_Click;
            // 
            // StarCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(picDeleteStar);
            Controls.Add(lblDec);
            Controls.Add(lblRA);
            Controls.Add(lblLuminosity);
            Controls.Add(picFavorite);
            Controls.Add(lblDistance);
            Controls.Add(lblMagnitude);
            Controls.Add(lblConstellation);
            Controls.Add(lblName);
            Name = "StarCard";
            Size = new Size(638, 246);
            ((System.ComponentModel.ISupportInitialize)picFavorite).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDeleteStar).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}
