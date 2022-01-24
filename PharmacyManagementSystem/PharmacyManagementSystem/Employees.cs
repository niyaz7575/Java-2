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
    public partial class Employees : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\7th Semester\JAVA 2\Final project\PharmacyManagementSystem\PharmacyManagementSystem\DatabaseM.mdf;Integrated Security=True");
        public void populate()
        {
            cn.Open();
            String Myquery = "select * from Employe_tbl";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, cn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            //EmpTable.ReadOnly = true;
            EmpTable.DataSource = ds.Tables[0];
            cn.Close();

        }
        public Employees()
        {
            InitializeComponent();
        }
        private void Addempbttn_Click(object sender, EventArgs e)
        {
            if (EmpID.Text == ""|| EmpName.Text == "" || EmpSalary.Text == "" || EmpAge.Text == "" || EmpPhone.Text == "" || EmpPass == null)
            {
                MessageBox.Show("Wrong input. Fill All The Filled");
            }
            else
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("insert into Employe_tbl values('" + EmpID.Text + "','" + EmpName.Text + "'," + EmpSalary.Text + "," + EmpAge.Text + ",'" + EmpPhone.Text + "','" + EmpPass.Text +"' )", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Successfully Added");
                cn.Close();
                populate();
            }
        }

        private void Upempbttn_Click(object sender, EventArgs e)
        {
            cn.Open();
            String Myquery = "UPDATE Employe_tbl SET EmpName = '" + EmpName.Text + "',EmpSalary = " + EmpSalary.Text + ",EmpAge = " + EmpAge.Text + ",EmpPhone = '" + EmpPhone.Text + "',EmpPassword = '" + EmpPass.Text + "' WHERE EmpId = '" + EmpID.Text + "'; " ;
            SqlCommand cmd = new SqlCommand(Myquery, cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employee Successfully Updated");
            cn.Close();
            populate();
            cn.Close();
        }

        private void Deleteempbttn_Click(object sender, EventArgs e)
        {
            if (EmpID.Text == "")
            {
                MessageBox.Show("Wrong Operation. Click on the Employee to Delete");

            }
            else
            {
                cn.Open();
                string query = "delete from Employe_tbl where EmpId = '" + EmpID.Text + "';";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Successfully Deleted");
                cn.Close();
                populate();
            }
        }

        private void Backempbttn_Click(object sender, EventArgs e)
        {
            Home homef = new Home();
            homef.Show();
            this.Hide();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void EmpTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpID.Text = EmpTable.SelectedRows[0].Cells[0].Value.ToString();
            EmpName.Text = EmpTable.SelectedRows[0].Cells[1].Value.ToString();
            EmpSalary.Text = EmpTable.SelectedRows[0].Cells[2].Value.ToString();
            EmpAge.Text = EmpTable.SelectedRows[0].Cells[3].Value.ToString();
            EmpPhone.Text = EmpTable.SelectedRows[0].Cells[4].Value.ToString();
            EmpPass.Text = EmpTable.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void EmpID_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
