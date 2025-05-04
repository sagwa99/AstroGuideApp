namespace AstroGuideApp
{
    partial class StarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StarForm));
            panel1 = new Panel();
            btnSearch = new Button();
            txtSearch = new TextBox();
            comboBoxFilterSearch = new ComboBox();
            gridViewStars = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridViewStars).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(comboBoxFilterSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(697, 43);
            panel1.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.FromArgb(184, 210, 255);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Image = Properties.Resources.icons8_search_16;
            btnSearch.Location = new Point(639, 6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(37, 34);
            btnSearch.TabIndex = 2;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Location = new Point(31, 9);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(389, 28);
            txtSearch.TabIndex = 2;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // comboBoxFilterSearch
            // 
            comboBoxFilterSearch.Anchor = AnchorStyles.Top;
            comboBoxFilterSearch.FormattingEnabled = true;
            comboBoxFilterSearch.Location = new Point(436, 9);
            comboBoxFilterSearch.Name = "comboBoxFilterSearch";
            comboBoxFilterSearch.Size = new Size(187, 28);
            comboBoxFilterSearch.TabIndex = 6;
            // 
            // gridViewStars
            // 
            gridViewStars.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridViewStars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewStars.Location = new Point(12, 74);
            gridViewStars.Name = "gridViewStars";
            gridViewStars.RowHeadersWidth = 51;
            gridViewStars.Size = new Size(673, 322);
            gridViewStars.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(184, 210, 255);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(12, 402);
            button2.Name = "button2";
            button2.Size = new Size(107, 47);
            button2.TabIndex = 3;
            button2.Text = "Додати";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(184, 210, 255);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(258, 402);
            button3.Name = "button3";
            button3.Size = new Size(111, 47);
            button3.TabIndex = 4;
            button3.Text = "Видалити";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(184, 210, 255);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F);
            button4.Location = new Point(125, 402);
            button4.Name = "button4";
            button4.Size = new Size(127, 47);
            button4.TabIndex = 5;
            button4.Text = "Редагувати";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(184, 210, 255);
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F);
            button5.Location = new Point(375, 402);
            button5.Name = "button5";
            button5.Size = new Size(174, 47);
            button5.TabIndex = 6;
            button5.Text = "Оновити таблицю";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(184, 210, 255);
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 12F);
            button6.Location = new Point(12, 455);
            button6.Name = "button6";
            button6.Size = new Size(319, 47);
            button6.TabIndex = 7;
            button6.Text = "Згенерувати флеш-картки";
            button6.UseVisualStyleBackColor = false;
            // 
            // StarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 803);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(gridViewStars);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StarForm";
            Text = "StarForm";
            Load += StarForm_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridViewStars).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView gridViewStars;
        private Button button2;
        private Button button3;
        private Button button4;
        private ComboBox comboBoxFilterSearch;
        private Button button5;
        private Button button6;
        private DataGridViewTextBoxColumn acceptButtonDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn autoScrollDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn autoSizeDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn autoSizeModeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn autoValidateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn backColorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn formBorderStyleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cancelButtonDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn controlBoxDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn helpButtonDataGridViewCheckBoxColumn;
        private DataGridViewImageColumn iconDataGridViewImageColumn;
        private DataGridViewCheckBoxColumn isMdiContainerDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn keyPreviewDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maximumSizeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mainMenuStripDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn minimumSizeDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn maximizeBoxDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn mdiChildrenMinimizedAnchorBottomDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn minimizeBoxDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn opacityDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn rightToLeftLayoutDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn showInTaskbarDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn showIconDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sizeGripStyleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startPositionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn topMostDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn transparencyKeyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn windowStateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn autoScrollMarginDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn autoScrollMinSizeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accessibleDescriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accessibleNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accessibleRoleDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn allowDropDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn anchorDataGridViewTextBoxColumn;
        private DataGridViewImageColumn backgroundImageDataGridViewImageColumn;
        private DataGridViewTextBoxColumn backgroundImageLayoutDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn causesValidationDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn contextMenuStripDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cursorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataBindingsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dockDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn enabledDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn fontDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn foreColorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rightToLeftDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn useWaitCursorDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn visibleDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn paddingDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn imeModeDataGridViewTextBoxColumn;
        private BindingSource bindingSourceStars;
    }
}