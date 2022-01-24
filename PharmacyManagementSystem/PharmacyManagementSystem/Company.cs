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
    public partial class Company : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\7th Semester\JAVA 2\Final project\PharmacyManagementSystem\PharmacyManagementSystem\DatabaseM.mdf;Integrated Security=True");
        public void populate()
        {
            cn.Open();
            String Myquery = "select * from Company_tbl";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, cn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            CDataTable.ReadOnly = true;
            CDataTable.DataSource = ds.Tables[0];
            cn.Close();
        }
        public Company()
        {
            InitializeComponent();
        }

        private void Caddbttn_Click(object sender, EventArgs e)
        {
            if (Cid.Text == "" || Cname.Text == "" || Cphnno.Text == "" || Caddress.Text == "")
            {
                MessageBox.Show("Missing Data. Fill All The Information");
            }
            else
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("insert into Company_tbl values('" + Cid.Text + "','" + Cname.Text + "','" + Cphnno.Text + "','" + Caddress.Text + "')", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Company Successfully Added");
                cn.Close();
                populate();
            }
        }

        private void Company_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void Cupbttn_Click(object sender, EventArgs e)
        {
            cn.Open();
            String Myquery = "UPDATE Company_tbl SET CNAME = '" + Cname.Text + "',CPHONE = '" + Cphnno.Text + "',CADDRESS = '" + Caddress.Text + "' WHERE CID= '" + Cid.Text + "';";
            SqlCommand cmd = new SqlCommand(Myquery, cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Company Successfully Updated");
            cn.Close();
            populate();
            cn.Close();
        }

        private void CDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cid.Text = CDataTable.SelectedRows[0].Cells[0].Value.ToString();
            Cname.Text = CDataTable.SelectedRows[0].Cells[1].Value.ToString();
            Cphnno.Text = CDataTable.SelectedRows[0].Cells[2].Value.ToString();
            Caddress.Text = CDataTable.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void Cdeletebttn_Click(object sender, EventArgs e)
        {
            if (Cname.Text == "")
            {
                MessageBox.Show("Wrong Operation. Click on the Company to Delete");

            }
            else
            {
                cn.Open();
                string query = "delete from Company_tbl where CID = '" + Cid.Text + "';";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Company Successfully Deleted");
                cn.Close();
                populate();
            }
        }

        private void Cbackbttn_Click(object sender, EventArgs e)
        {
            Home homef = new Home();
            homef.Show();
            this.Hide();
        }

        private void Cid_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
