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
    public partial class FormInvoice : Form
    {
        public FormInvoice()
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
            InvoiceServices iS = new InvoiceServices();
            dataGridViewInvoice.DataSource = iS.GetAll();
        }

        private void dataGridViewInvoice_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxID.Text = dataGridViewInvoice.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            InvoiceServices pS = new InvoiceServices();
            long id = long.Parse(textBoxID.Text);
            dataGridViewInvoice.DataSource = pS.Get(id);
        }
    }
}
