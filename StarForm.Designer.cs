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
            comboBox1 = new ComboBox();
            button1 = new Button();
            textBox1 = new TextBox();
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
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(697, 29);
            panel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Left;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(377, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(187, 28);
            comboBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.Location = new Point(603, 0);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Пошук";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Left;
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(377, 27);
            textBox1.TabIndex = 2;
            // 
            // gridViewStars
            // 
            gridViewStars.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridViewStars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewStars.Location = new Point(12, 35);
            gridViewStars.Name = "gridViewStars";
            gridViewStars.RowHeadersWidth = 51;
            gridViewStars.Size = new Size(673, 322);
            gridViewStars.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(12, 385);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Додати";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(237, 385);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Видалити";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(127, 385);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 5;
            button4.Text = "Редагувати";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(515, 385);
            button5.Name = "button5";
            button5.Size = new Size(170, 29);
            button5.TabIndex = 6;
            button5.Text = "Оновити таблицю";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(12, 420);
            button6.Name = "button6";
            button6.Size = new Size(319, 29);
            button6.TabIndex = 7;
            button6.Text = "Згенерувати флеш-картки";
            button6.UseVisualStyleBackColor = true;
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
        private Button button1;
        private TextBox textBox1;
        private DataGridView gridViewStars;
        private Button button2;
        private Button button3;
        private Button button4;
        private ComboBox comboBox1;
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