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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F);
            label1.Location = new Point(252, 22);
            label1.Name = "label1";
            label1.Size = new Size(292, 29);
            label1.TabIndex = 0;
            label1.Text = "Shop Management System";
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            button1.ForeColor = Color.MistyRose;
            button1.Location = new Point(754, 12);
            button1.Name = "button1";
            button1.Size = new Size(34, 39);
            button1.TabIndex = 1;
            button1.TabStop = false;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HighlightText;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Trebuchet MS", 14F);
            button2.Location = new Point(325, 140);
            button2.Name = "button2";
            button2.Size = new Size(150, 36);
            button2.TabIndex = 2;
            button2.TabStop = false;
            button2.Text = "People";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HighlightText;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Trebuchet MS", 14F);
            button3.Location = new Point(325, 182);
            button3.Name = "button3";
            button3.Size = new Size(150, 36);
            button3.TabIndex = 3;
            button3.TabStop = false;
            button3.Text = "Products";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.HighlightText;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Trebuchet MS", 14F);
            button4.Location = new Point(325, 224);
            button4.Name = "button4";
            button4.Size = new Size(150, 36);
            button4.TabIndex = 4;
            button4.TabStop = false;
            button4.Text = "Orders";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.HighlightText;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Trebuchet MS", 14F);
            button5.Location = new Point(325, 266);
            button5.Name = "button5";
            button5.Size = new Size(150, 36);
            button5.TabIndex = 5;
            button5.TabStop = false;
            button5.Text = "Invoice";
            button5.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
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
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button5;
        private Button button4;
        private Button button3;
    }
}
