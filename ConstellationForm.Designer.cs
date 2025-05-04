namespace AstroGuideApp
{
    partial class ConstellationForm
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
            gridViewConstellations = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridViewConstellations).BeginInit();
            SuspendLayout();
            // 
            // gridViewConstellations
            // 
            gridViewConstellations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewConstellations.Location = new Point(12, 73);
            gridViewConstellations.Name = "gridViewConstellations";
            gridViewConstellations.RowHeadersWidth = 51;
            gridViewConstellations.Size = new Size(673, 441);
            gridViewConstellations.TabIndex = 0;
            // 
            // ConstellationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 803);
            Controls.Add(gridViewConstellations);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConstellationForm";
            Text = "ConstellationForm";
            Load += ConstellationForm_Load;
            ((System.ComponentModel.ISupportInitialize)gridViewConstellations).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridViewConstellations;
    }
}