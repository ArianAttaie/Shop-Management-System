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
    public partial class FormPeople : Form
    {
        public FormPeople()
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
            PeopleServices pS = new PeopleServices();
            dataGridViewPeople.DataSource = pS.GetAll();
        }

        private void dataGridViewPeople_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxID.Text = dataGridViewPeople.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxFname.Text = dataGridViewPeople.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxLname.Text = dataGridViewPeople.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxTitle.Text = dataGridViewPeople.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "")
            {
                MessageBox.Show("Enter ID.");
                return;
            }
            else
            {
                PeopleServices pS = new PeopleServices();
                long id = long.Parse(textBoxID.Text);
                dataGridViewPeople.DataSource = pS.Get(id);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (textBoxFname.Text == "" || textBoxLname.Text == "" || textBoxTitle.Text == "")
            {
                MessageBox.Show("You need to fill the all the boxes in order to create any new person.\n" +
                    "(There is no need to fill ID box.)");
                return;
            }
            else
            {
                PeopleServices pS = new PeopleServices();
                pS.Post(textBoxFname.Text, textBoxLname.Text, textBoxTitle.Text);
            }
            btnLoad_Click(sender, e);
        }
    }
}
