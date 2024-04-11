namespace Presentation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new Label();
            btnExit = new Button();
            btnPeople = new Button();
            btnProducts = new Button();
            btnOrders = new Button();
            btnInvoices = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Trebuchet MS", 18F);
            labelTitle.Location = new Point(252, 22);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(292, 29);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Shop Management System";
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
            // btnPeople
            // 
            btnPeople.BackColor = SystemColors.HighlightText;
            btnPeople.FlatStyle = FlatStyle.Flat;
            btnPeople.Font = new Font("Trebuchet MS", 14F);
            btnPeople.Location = new Point(325, 140);
            btnPeople.Name = "btnPeople";
            btnPeople.Size = new Size(150, 36);
            btnPeople.TabIndex = 0;
            btnPeople.TabStop = false;
            btnPeople.Text = "People";
            btnPeople.UseVisualStyleBackColor = false;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = SystemColors.HighlightText;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Trebuchet MS", 14F);
            btnProducts.Location = new Point(325, 182);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(150, 36);
            btnProducts.TabIndex = 0;
            btnProducts.TabStop = false;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = false;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = SystemColors.HighlightText;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Font = new Font("Trebuchet MS", 14F);
            btnOrders.Location = new Point(325, 224);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(150, 36);
            btnOrders.TabIndex = 0;
            btnOrders.TabStop = false;
            btnOrders.Text = "Orders";
            btnOrders.UseVisualStyleBackColor = false;
            // 
            // btnInvoices
            // 
            btnInvoices.BackColor = SystemColors.HighlightText;
            btnInvoices.FlatStyle = FlatStyle.Flat;
            btnInvoices.Font = new Font("Trebuchet MS", 14F);
            btnInvoices.Location = new Point(325, 266);
            btnInvoices.Name = "btnInvoices";
            btnInvoices.Size = new Size(150, 36);
            btnInvoices.TabIndex = 0;
            btnInvoices.TabStop = false;
            btnInvoices.Text = "Invoices";
            btnInvoices.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInvoices);
            Controls.Add(btnOrders);
            Controls.Add(btnProducts);
            Controls.Add(btnPeople);
            Controls.Add(btnExit);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTitle;
        private Button btnExit;
        private Button btnPeople;
        private Button btnInvoices;
        private Button btnOrders;
        private Button btnProducts;
    }
}
