namespace Presentation
{
    partial class FormProduct
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
            labelCat = new Label();
            labelName = new Label();
            labelID = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            btnFind = new Button();
            textBoxCat = new TextBox();
            textBoxName = new TextBox();
            textBoxID = new TextBox();
            dataGridViewProduct = new DataGridView();
            btnExit = new Button();
            labelTitle = new Label();
            btnBack = new Button();
            labelPrice = new Label();
            textBoxPrice = new TextBox();
            labelQTY = new Label();
            textBoxQTY = new TextBox();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            SuspendLayout();
            // 
            // labelCat
            // 
            labelCat.AutoSize = true;
            labelCat.Font = new Font("Trebuchet MS", 10F);
            labelCat.Location = new Point(103, 338);
            labelCat.Name = "labelCat";
            labelCat.Size = new Size(73, 18);
            labelCat.TabIndex = 0;
            labelCat.Text = "Category :";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Trebuchet MS", 10F);
            labelName.Location = new Point(103, 309);
            labelName.Name = "labelName";
            labelName.Size = new Size(52, 18);
            labelName.TabIndex = 0;
            labelName.Text = "Name :";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Trebuchet MS", 10F);
            labelID.Location = new Point(103, 280);
            labelID.Name = "labelID";
            labelID.Size = new Size(83, 18);
            labelID.TabIndex = 0;
            labelID.Text = "Product ID :";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ButtonFace;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Trebuchet MS", 11F);
            btnDelete.Location = new Point(535, 390);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 31);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ButtonFace;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Trebuchet MS", 11F);
            btnUpdate.Location = new Point(535, 353);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 31);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.ButtonFace;
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.Font = new Font("Trebuchet MS", 11F);
            btnInsert.Location = new Point(535, 316);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(90, 31);
            btnInsert.TabIndex = 7;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // btnFind
            // 
            btnFind.BackColor = SystemColors.ButtonFace;
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Trebuchet MS", 11F);
            btnFind.Location = new Point(535, 279);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(90, 31);
            btnFind.TabIndex = 6;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = false;
            // 
            // textBoxCat
            // 
            textBoxCat.Location = new Point(192, 337);
            textBoxCat.Name = "textBoxCat";
            textBoxCat.Size = new Size(202, 23);
            textBoxCat.TabIndex = 3;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(192, 308);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(202, 23);
            textBoxName.TabIndex = 2;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(192, 279);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(202, 23);
            textBoxID.TabIndex = 1;
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.Enabled = false;
            dataGridViewProduct.Location = new Point(12, 57);
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.Size = new Size(776, 200);
            dataGridViewProduct.TabIndex = 0;
            dataGridViewProduct.TabStop = false;
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
            labelTitle.Location = new Point(329, 17);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(141, 29);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Product List";
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
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Trebuchet MS", 10F);
            labelPrice.Location = new Point(103, 370);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(79, 18);
            labelPrice.TabIndex = 0;
            labelPrice.Text = "Unit Price :";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(192, 369);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(202, 23);
            textBoxPrice.TabIndex = 4;
            // 
            // labelQTY
            // 
            labelQTY.AutoSize = true;
            labelQTY.Font = new Font("Trebuchet MS", 10F);
            labelQTY.Location = new Point(103, 399);
            labelQTY.Name = "labelQTY";
            labelQTY.Size = new Size(73, 18);
            labelQTY.TabIndex = 0;
            labelQTY.Text = "Quantity :";
            // 
            // textBoxQTY
            // 
            textBoxQTY.Location = new Point(192, 398);
            textBoxQTY.Name = "textBoxQTY";
            textBoxQTY.Size = new Size(202, 23);
            textBoxQTY.TabIndex = 5;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = SystemColors.ButtonFace;
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.Font = new Font("Trebuchet MS", 9F);
            btnLoad.Location = new Point(722, 263);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(66, 25);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoad);
            Controls.Add(labelQTY);
            Controls.Add(textBoxQTY);
            Controls.Add(labelPrice);
            Controls.Add(textBoxPrice);
            Controls.Add(btnBack);
            Controls.Add(labelCat);
            Controls.Add(labelName);
            Controls.Add(labelID);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(btnFind);
            Controls.Add(textBoxCat);
            Controls.Add(textBoxName);
            Controls.Add(textBoxID);
            Controls.Add(dataGridViewProduct);
            Controls.Add(btnExit);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProduct";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelCat;
        private Label labelName;
        private Label labelID;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private Button btnFind;
        private TextBox textBoxCat;
        private TextBox textBoxName;
        private TextBox textBoxID;
        private DataGridView dataGridViewProduct;
        private Button btnExit;
        private Label labelTitle;
        private Button btnBack;
        private Label labelPrice;
        private TextBox textBoxPrice;
        private Label labelQTY;
        private TextBox textBoxQTY;
        private Button btnLoad;
    }
}