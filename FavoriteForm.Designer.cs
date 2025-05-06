namespace AstroGuideApp
{
    partial class FavoriteForm
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
            panelFavoriteCards = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // panelFavoriteCards
            // 
            panelFavoriteCards.AutoScroll = true;
            panelFavoriteCards.Dock = DockStyle.Fill;
            panelFavoriteCards.Location = new Point(0, 0);
            panelFavoriteCards.Name = "panelFavoriteCards";
            panelFavoriteCards.Size = new Size(697, 803);
            panelFavoriteCards.TabIndex = 0;
            // 
            // FavoriteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 803);
            Controls.Add(panelFavoriteCards);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FavoriteForm";
            Text = "FavoriteForm";
            Load += FavoriteForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panelFavoriteCards;
    }
}