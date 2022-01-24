using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Comlbl_Click(object sender, EventArgs e)
        {

        }

        private void Cross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        MedicineForm Medform = new MedicineForm();
        Employees Empform = new Employees();
        Company Cmpform = new Company();
        Billing Billform = new Billing();

        private void Medimage_Click(object sender, EventArgs e)
        {
            
            Medform.Show();
            this.Hide();
        }

        private void Empimage_Click(object sender, EventArgs e)
        {
            Empform.Show();
            this.Hide();
        }

        private void Comimage_Click(object sender, EventArgs e)
        {
            Cmpform.Show();
            this.Hide();
        }

        private void Billimage_Click(object sender, EventArgs e)
        {
            Billform.Show();
            this.Hide();
        }

        private void Logoutimage_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void Emplbl_Click(object sender, EventArgs e)
        {

        }

        private void Medicinelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
