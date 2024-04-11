namespace Presentation
{
    partial class FormPeople
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
            btnExit = new Button();
            labelTitle = new Label();
            dataGridView1 = new DataGridView();
            textBoxID = new TextBox();
            textBoxFname = new TextBox();
            textBoxLname = new TextBox();
            textBoxTitle = new TextBox();
            btnFind = new Button();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            labelID = new Label();
            labelFname = new Label();
            labelLname = new Label();
            labelTitleBox = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Firebrick;
            btnExit.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnExit.ForeColor = Color.MistyRose;
            btnExit.Location = new Point(754, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(34, 39);
            btnExit.TabIndex = 0;
            btnExit.TabStop = false;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Trebuchet MS", 18F);
            labelTitle.Location = new Point(334, 17);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(130, 29);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "People List";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 200);
            dataGridView1.TabIndex = 0;
            dataGridView1.TabStop = false;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(192, 292);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(202, 23);
            textBoxID.TabIndex = 1;
            // 
            // textBoxFname
            // 
            textBoxFname.Location = new Point(192, 321);
            textBoxFname.Name = "textBoxFname";
            textBoxFname.Size = new Size(202, 23);
            textBoxFname.TabIndex = 2;
            // 
            // textBoxLname
            // 
            textBoxLname.Location = new Point(192, 350);
            textBoxLname.Name = "textBoxLname";
            textBoxLname.Size = new Size(202, 23);
            textBoxLname.TabIndex = 3;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(192, 380);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(202, 23);
            textBoxTitle.TabIndex = 4;
            // 
            // btnFind
            // 
            btnFind.BackColor = SystemColors.ButtonFace;
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Trebuchet MS", 11F);
            btnFind.Location = new Point(535, 279);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(90, 31);
            btnFind.TabIndex = 5;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.ButtonFace;
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.Font = new Font("Trebuchet MS", 11F);
            btnInsert.Location = new Point(535, 316);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(90, 31);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ButtonFace;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Trebuchet MS", 11F);
            btnUpdate.Location = new Point(535, 353);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 31);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ButtonFace;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Trebuchet MS", 11F);
            btnDelete.Location = new Point(535, 390);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 31);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Trebuchet MS", 10F);
            labelID.Location = new Point(100, 292);
            labelID.Name = "labelID";
            labelID.Size = new Size(76, 18);
            labelID.TabIndex = 0;
            labelID.Text = "Person ID :";
            // 
            // labelFname
            // 
            labelFname.AutoSize = true;
            labelFname.Font = new Font("Trebuchet MS", 10F);
            labelFname.Location = new Point(100, 322);
            labelFname.Name = "labelFname";
            labelFname.Size = new Size(84, 18);
            labelFname.TabIndex = 0;
            labelFname.Text = "First Name :";
            // 
            // labelLname
            // 
            labelLname.AutoSize = true;
            labelLname.Font = new Font("Trebuchet MS", 10F);
            labelLname.Location = new Point(102, 351);
            labelLname.Name = "labelLname";
            labelLname.Size = new Size(82, 18);
            labelLname.TabIndex = 0;
            labelLname.Text = "Last Name :";
            // 
            // labelTitleBox
            // 
            labelTitleBox.AutoSize = true;
            labelTitleBox.Font = new Font("Trebuchet MS", 10F);
            labelTitleBox.Location = new Point(100, 381);
            labelTitleBox.Name = "labelTitleBox";
            labelTitleBox.Size = new Size(45, 18);
            labelTitleBox.TabIndex = 0;
            labelTitleBox.Text = "Title :";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.OliveDrab;
            btnBack.Font = new Font("Stencil", 16F, FontStyle.Bold);
            btnBack.ForeColor = Color.Ivory;
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(39, 39);
            btnBack.TabIndex = 0;
            btnBack.TabStop = false;
            btnBack.Text = "←";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // FormPeople
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(labelTitleBox);
            Controls.Add(labelLname);
            Controls.Add(labelFname);
            Controls.Add(labelID);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(btnFind);
            Controls.Add(textBoxTitle);
            Controls.Add(textBoxLname);
            Controls.Add(textBoxFname);
            Controls.Add(textBoxID);
            Controls.Add(dataGridView1);
            Controls.Add(btnExit);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPeople";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPeople";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnExit;
        private Label labelTitle;
        private DataGridView dataGridView1;
        private TextBox textBoxID;
        private TextBox textBoxFname;
        private TextBox textBoxLname;
        private TextBox textBoxTitle;
        private Button btnFind;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Label labelID;
        private Label labelFname;
        private Label labelLname;
        private Label labelTitleBox;
        private Button btnBack;
    }
}