namespace Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
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
                Close();
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            FormPeople formPep = new FormPeople();
            formPep.Show();
            Visible = false;
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            FormProduct formPro = new FormProduct();
            formPro.Show();
            Visible = false;
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            FormOrder formOrd = new FormOrder();
            formOrd.Show();
            Visible = false;
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            FormInvoice formInv = new FormInvoice();
            formInv.Show();
            Visible = false;
        }
    }
}
