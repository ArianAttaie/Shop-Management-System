namespace Presentation
{
    partial class FormInvoice
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
            labelID = new Label();
            btnFind = new Button();
            textBoxID = new TextBox();
            dataGridView1 = new DataGridView();
            btnExit = new Button();
            labelTitle = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Trebuchet MS", 10F);
            labelID.Location = new Point(106, 337);
            labelID.Name = "labelID";
            labelID.Size = new Size(80, 18);
            labelID.TabIndex = 0;
            labelID.Text = "Invoice ID :";
            // 
            // btnFind
            // 
            btnFind.BackColor = SystemColors.ButtonFace;
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Trebuchet MS", 11F);
            btnFind.Location = new Point(535, 330);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(90, 31);
            btnFind.TabIndex = 2;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = false;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(192, 336);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(202, 23);
            textBoxID.TabIndex = 1;
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
            labelTitle.Location = new Point(332, 17);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(136, 29);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Invoice List";
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
            // FormInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(labelID);
            Controls.Add(btnFind);
            Controls.Add(textBoxID);
            Controls.Add(dataGridView1);
            Controls.Add(btnExit);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormInvoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormInvoice";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelID;
        private Button btnFind;
        private TextBox textBoxID;
        private DataGridView dataGridView1;
        private Button btnExit;
        private Label labelTitle;
        private Button btnBack;
    }
}