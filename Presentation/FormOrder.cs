﻿using Business.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to Exit the program?",
                "Quit",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 formMain = new Form1();
            formMain.Visible = true;
            Visible = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OrderServices oS = new OrderServices();
            dataGridViewOrder.DataSource = null;
            dataGridViewOrder.DataSource = oS.GetAll();
        }

        private void dataGridViewOrder_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxID.Text = dataGridViewOrder.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "")
            {
                MessageBox.Show("Enter ID.");
                return;
            }
            else
            {
                OrderServices oS = new OrderServices();
                oS.Accept(long.Parse(textBoxID.Text));
            }
            btnLoad_Click(sender, e);
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "")
            {
                MessageBox.Show("Enter ID.");
                return;
            }
            else
            {
                OrderServices oS = new OrderServices();
                oS.Decline(long.Parse(textBoxID.Text));
            }
            btnLoad_Click(sender, e);
        }
    }
}
