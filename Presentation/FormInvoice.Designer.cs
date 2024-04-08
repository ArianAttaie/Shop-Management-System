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
            label4 = new Label();
            label3 = new Label();
            button2 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 10F);
            label4.Location = new Point(84, 351);
            label4.Name = "label4";
            label4.Size = new Size(102, 18);
            label4.TabIndex = 34;
            label4.Text = "Customer's ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 10F);
            label3.Location = new Point(84, 322);
            label3.Name = "label3";
            label3.Size = new Size(80, 18);
            label3.TabIndex = 33;
            label3.Text = "Invoice ID :";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Trebuchet MS", 11F);
            button2.Location = new Point(535, 330);
            button2.Name = "button2";
            button2.Size = new Size(90, 31);
            button2.TabIndex = 28;
            button2.Text = "Find";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(192, 350);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(202, 23);
            textBox3.TabIndex = 26;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(192, 321);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(202, 23);
            textBox2.TabIndex = 25;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 200);
            dataGridView1.TabIndex = 23;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            button1.ForeColor = Color.MistyRose;
            button1.Location = new Point(754, 12);
            button1.Name = "button1";
            button1.Size = new Size(34, 39);
            button1.TabIndex = 22;
            button1.TabStop = false;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F);
            label1.Location = new Point(332, 17);
            label1.Name = "label1";
            label1.Size = new Size(136, 29);
            label1.TabIndex = 21;
            label1.Text = "Invoice List";
            // 
            // button6
            // 
            button6.BackColor = Color.OliveDrab;
            button6.Font = new Font("Stencil", 16F, FontStyle.Bold);
            button6.ForeColor = Color.Ivory;
            button6.Location = new Point(12, 12);
            button6.Name = "button6";
            button6.Size = new Size(39, 39);
            button6.TabIndex = 35;
            button6.TabStop = false;
            button6.Text = "←";
            button6.UseVisualStyleBackColor = false;
            // 
            // FormInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormInvoice";
            Text = "FormInvoice";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label3;
        private Button button2;
        private TextBox textBox3;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private Button button6;
    }
}