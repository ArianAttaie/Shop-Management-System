using Business.Services;
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
    public partial class FormProduct : Form
    {
        public FormProduct()
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
            ProductServices pS = new ProductServices();
            dataGridViewProduct.DataSource = pS.GetAll();
        }

        private void dataGridViewProduct_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxID.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxName.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxCat.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxPrice.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxQTY.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
