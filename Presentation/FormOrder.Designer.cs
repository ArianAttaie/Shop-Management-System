namespace Presentation
{
    partial class FormOrder
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
            btnBack = new Button();
            labelID = new Label();
            btnAccept = new Button();
            textBoxID = new TextBox();
            dataGridViewOrder = new DataGridView();
            btnExit = new Button();
            labelTitle = new Label();
            btnDecline = new Button();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).BeginInit();
            SuspendLayout();
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
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Trebuchet MS", 10F);
            labelID.Location = new Point(117, 337);
            labelID.Name = "labelID";
            labelID.Size = new Size(69, 18);
            labelID.TabIndex = 0;
            labelID.Text = "Order ID :";
            // 
            // btnAccept
            // 
            btnAccept.BackColor = SystemColors.ButtonFace;
            btnAccept.FlatStyle = FlatStyle.Flat;
            btnAccept.Font = new Font("Trebuchet MS", 11F);
            btnAccept.Location = new Point(535, 315);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(90, 31);
            btnAccept.TabIndex = 2;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = false;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(192, 336);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(202, 23);
            textBoxID.TabIndex = 1;
            // 
            // dataGridViewOrder
            // 
            dataGridViewOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrder.Location = new Point(12, 57);
            dataGridViewOrder.Name = "dataGridViewOrder";
            dataGridViewOrder.ReadOnly = true;
            dataGridViewOrder.Size = new Size(776, 200);
            dataGridViewOrder.TabIndex = 0;
            dataGridViewOrder.TabStop = false;
            dataGridViewOrder.RowHeaderMouseClick += dataGridViewOrder_RowHeaderMouseClick;
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
            labelTitle.Location = new Point(343, 17);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(119, 29);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Order List";
            // 
            // btnDecline
            // 
            btnDecline.BackColor = SystemColors.ButtonFace;
            btnDecline.FlatStyle = FlatStyle.Flat;
            btnDecline.Font = new Font("Trebuchet MS", 11F);
            btnDecline.Location = new Point(535, 352);
            btnDecline.Name = "btnDecline";
            btnDecline.Size = new Size(90, 31);
            btnDecline.TabIndex = 3;
            btnDecline.Text = "Decline";
            btnDecline.UseVisualStyleBackColor = false;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = SystemColors.ButtonFace;
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.Font = new Font("Trebuchet MS", 9F);
            btnLoad.Location = new Point(722, 263);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(66, 25);
            btnLoad.TabIndex = 4;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // FormOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoad);
            Controls.Add(btnDecline);
            Controls.Add(btnBack);
            Controls.Add(labelID);
            Controls.Add(btnAccept);
            Controls.Add(textBoxID);
            Controls.Add(dataGridViewOrder);
            Controls.Add(btnExit);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormOrder";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label labelID;
        private Button btnAccept;
        private TextBox textBoxID;
        private DataGridView dataGridViewOrder;
        private Button btnExit;
        private Label labelTitle;
        private Button btnDecline;
        private Button btnLoad;
    }
}