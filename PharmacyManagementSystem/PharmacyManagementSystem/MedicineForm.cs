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
    public partial class MedicineForm : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\7th Semester\JAVA 2\Final project\PharmacyManagementSystem\PharmacyManagementSystem\DatabaseM.mdf;Integrated Security=True");
        public void populate()
        {
            cn.Open();
            String Myquery = "select * from Medstock_tbl";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, cn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            DataTable.ReadOnly = true;
            DataTable.DataSource = ds.Tables[0];
            cn.Close();

        }
        
        public MedicineForm()
        {
            InitializeComponent();
        }

        private void BunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Addbttn_Click(object sender, EventArgs e)
        {
            if (MedName.Text == "" || Sprice.Text == "" || Bprice.Text == "" || Qty.Text == "" || CCombo.SelectedItem == null)
            {
                MessageBox.Show("Missing Data. Fill All The Information");
            }
            else
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("insert into Medstock_tbl values('" + MedName.Text + "'," + Bprice.Text + "," + Sprice.Text + "," + Qty.Text + ",'" + DateTime.Text + "','" + CCombo.Text+ "')", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine Successfully Added");
                cn.Close();
                populate();
            }
        }
        public void fillcombobox()
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("select CNAME from Company_tbl", cn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CNAME", typeof(string));
            dt.Load(rdr);
            CCombo.ValueMember = "CNAME";
            CCombo.DataSource = dt;
            cn.Close();
        }
        private void MedicineForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseMDataSet.Medstock_tbl' table. You can move, or remove it, as needed.
            this.medstock_tblTableAdapter.Fill(this.databaseMDataSet.Medstock_tbl);
            populate();
            fillcombobox();
        }

        private void DataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MedName.Text = DataTable.SelectedRows[0].Cells[0].Value.ToString();
            Bprice.Text = DataTable.SelectedRows[0].Cells[1].Value.ToString();
            Sprice.Text = DataTable.SelectedRows[0].Cells[2].Value.ToString();
            Qty.Text = DataTable.SelectedRows[0].Cells[3].Value.ToString();
            DateTime.Text = DataTable.SelectedRows[0].Cells[4].Value.ToString();
            CCombo.Text = DataTable.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void Upbttn_Click(object sender, EventArgs e)
        {
            cn.Open();
            String Myquery = "UPDATE Medstock_tbl SET BPrice = " + Bprice.Text + ",Sprice = " + Sprice.Text + ",Quantity = " + Qty.Text + ",ExpDate = '" + DateTime.Text + "',Company = '" + CCombo.Text + "' WHERE Medicine= '" + MedName.Text + "';";
            SqlCommand cmd = new SqlCommand(Myquery, cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Medicine Successfully Updated");
            cn.Close();
            populate();
            cn.Close();
        }

        private void Deletebttn_Click(object sender, EventArgs e)
        {
            if(MedName.Text == "")
            {
                MessageBox.Show("Wrong Operation. Click on the medicine to Delete");

            }
            else
            {
                cn.Open();
                string query = "delete from Medstock_tbl where Medicine = '" + MedName.Text + "';";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine Successfully Deleted"); 
                cn.Close();
                populate();
            }
        }

        private void Backbttn_Click(object sender, EventArgs e)
        {
            Home homef = new Home();
            homef.Show();
            this.Hide();

        }

        private void DateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void MedName_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
