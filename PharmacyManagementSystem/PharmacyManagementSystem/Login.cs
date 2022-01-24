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
    public partial class Login : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\7th Semester\JAVA 2\Final project\PharmacyManagementSystem\PharmacyManagementSystem\DatabaseM.mdf;Integrated Security=True");

        public Login()
        {
            InitializeComponent();
        }

        private void Username_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            /*   if (Username.Text== "Admin" && Password.Text=="admin")
               {
                   home.Show();
                   this.Hide();
               }
               else
               {
                   MessageBox.Show("Wrong Username or Password");
               }
               */
            cn.Open();
            SqlDataAdapter ada = new SqlDataAdapter("Select COUNT(*) from Employe_tbl where EmpName = '" + Username.Text + "' and EmpPassword = '" + Password.Text + "' ", cn);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            if(dt.Rows[0][0].ToString() == "1")
            {
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
            cn.Close();
        }

        private void Cross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
