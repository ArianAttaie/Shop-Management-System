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
            button6 = new Button();
            label3 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button6
            // 
            button6.BackColor = Color.OliveDrab;
            button6.Font = new Font("Stencil", 16F, FontStyle.Bold);
            button6.ForeColor = Color.Ivory;
            button6.Location = new Point(12, 12);
            button6.Name = "button6";
            button6.Size = new Size(39, 39);
            button6.TabIndex = 44;
            button6.TabStop = false;
            button6.Text = "←";
            button6.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 10F);
            label3.Location = new Point(127, 337);
            label3.Name = "label3";
            label3.Size = new Size(69, 18);
            label3.TabIndex = 42;
            label3.Text = "Order ID :";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Trebuchet MS", 11F);
            button2.Location = new Point(535, 315);
            button2.Name = "button2";
            button2.Size = new Size(90, 31);
            button2.TabIndex = 41;
            button2.Text = "Accept";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(202, 336);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(202, 23);
            textBox2.TabIndex = 39;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 200);
            dataGridView1.TabIndex = 38;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            button1.ForeColor = Color.MistyRose;
            button1.Location = new Point(754, 12);
            button1.Name = "button1";
            button1.Size = new Size(34, 39);
            button1.TabIndex = 37;
            button1.TabStop = false;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F);
            label1.Location = new Point(343, 17);
            label1.Name = "label1";
            label1.Size = new Size(119, 29);
            label1.TabIndex = 36;
            label1.Text = "Order List";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Trebuchet MS", 11F);
            button3.Location = new Point(535, 352);
            button3.Name = "button3";
            button3.Size = new Size(90, 31);
            button3.TabIndex = 45;
            button3.Text = "Decline";
            button3.UseVisualStyleBackColor = false;
            // 
            // FormOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button6);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormOrder";
            Text = "FormOrder";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button6;
        private Label label3;
        private Button button2;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private Button button3;
    }
}