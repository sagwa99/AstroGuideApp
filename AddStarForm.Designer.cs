namespace AstroGuideApp
{
    partial class AddStarForm
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
            btnConfirm = new Button();
            btnCancel = new Button();
            txtName = new TextBox();
            txtConstellation = new TextBox();
            txtMagnitude = new TextBox();
            txtDistance = new TextBox();
            txtLuminosity = new TextBox();
            txtRA = new TextBox();
            txtDec = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(330, 279);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(94, 29);
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(201, 279);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // txtName
            // 
            txtName.Location = new Point(220, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 2;
            // 
            // txtConstellation
            // 
            txtConstellation.Location = new Point(220, 52);
            txtConstellation.Name = "txtConstellation";
            txtConstellation.Size = new Size(125, 27);
            txtConstellation.TabIndex = 3;
            // 
            // txtMagnitude
            // 
            txtMagnitude.Location = new Point(220, 93);
            txtMagnitude.Name = "txtMagnitude";
            txtMagnitude.Size = new Size(125, 27);
            txtMagnitude.TabIndex = 4;
            // 
            // txtDistance
            // 
            txtDistance.Location = new Point(220, 126);
            txtDistance.Name = "txtDistance";
            txtDistance.Size = new Size(125, 27);
            txtDistance.TabIndex = 5;
            // 
            // txtLuminosity
            // 
            txtLuminosity.Location = new Point(220, 160);
            txtLuminosity.Name = "txtLuminosity";
            txtLuminosity.Size = new Size(125, 27);
            txtLuminosity.TabIndex = 6;
            // 
            // txtRA
            // 
            txtRA.Location = new Point(220, 201);
            txtRA.Name = "txtRA";
            txtRA.Size = new Size(125, 27);
            txtRA.TabIndex = 7;
            // 
            // txtDec
            // 
            txtDec.Location = new Point(220, 237);
            txtDec.Name = "txtDec";
            txtDec.Size = new Size(125, 27);
            txtDec.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 15);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 9;
            label1.Text = "Назва зірки";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 52);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 10;
            label2.Text = "Назва сузір'я";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 93);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(143, 20);
            label3.TabIndex = 11;
            label3.Text = "Видима зор. велич.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 126);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 12;
            label4.Text = "Відстань";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 167);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 13;
            label5.Text = "Світність";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 204);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(191, 20);
            label6.TabIndex = 14;
            label6.Text = "Пряме піднесення(коорд)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 237);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(128, 20);
            label7.TabIndex = 15;
            label7.Text = "Схилення(коорд)";
            // 
            // AddStarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDec);
            Controls.Add(txtRA);
            Controls.Add(txtLuminosity);
            Controls.Add(txtDistance);
            Controls.Add(txtMagnitude);
            Controls.Add(txtConstellation);
            Controls.Add(txtName);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Name = "AddStarForm";
            Text = "AddStarForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirm;
        private Button btnCancel;
        private TextBox txtName;
        private TextBox txtConstellation;
        private TextBox txtMagnitude;
        private TextBox txtDistance;
        private TextBox txtLuminosity;
        private TextBox txtRA;
        private TextBox txtDec;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}