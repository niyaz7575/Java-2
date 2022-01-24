using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PharmacyManagementSystem
{
    public string conString = "server=localhost;user id=root;database=pharmacydb;allowuservariables=True";
    public partial class MedicineStock : Form
    {
        public MedicineStock()
        {
            InitializeComponent();
        }


        private void MedicineStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacydbDataSet.stocktb' table. You can move, or remove it, as needed.
            this.stocktbTableAdapter.Fill(this.pharmacydbDataSet.stocktb);

        }

        private void Addbttn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO 'stocktb'(" + MedName.Text + ", " + Bprice.Text + "," + Sprice.Text"," + Qt.Text", " + DateTime.ToString() + ", " + CompanyCombo.ToString() + ")", Con);
        }

        private void Upbttn_Click(object sender, EventArgs e)
        {

        }

        private void Deletebttn_Click(object sender, EventArgs e)
        {

        }

        private void Backbttn_Click(object sender, EventArgs e)
        {

        }
    }
}
