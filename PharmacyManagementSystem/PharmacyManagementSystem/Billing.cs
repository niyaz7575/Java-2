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
    public partial class Billing : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\7th Semester\JAVA 2\Final project\PharmacyManagementSystem\PharmacyManagementSystem\DatabaseM.mdf;Integrated Security=True");
        public void populatecombobox()
        {
            string sql = "select * from Medstock_tbl";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader rdr;
                cn.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("Medicine", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                Bcombo.ValueMember = "Medicine";
                Bcombo.DataSource = dt;
                cn.Close();
            
           
        }
        int x,unitp;
        public void fetchQty()
        {
            cn.Open();
            string mysql = "Select * from Medstock_tbl where Medicine = '" + Bcombo.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(mysql, cn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                x = Convert.ToInt32(dr["Quantity"].ToString());
                unitp = Convert.ToInt32(dr["Sprice"].ToString());
                Bstocklabel.Text = "Availabe stock is "+dr["Quantity"].ToString();
                Bstocklabel.Visible = true;
            }
            cn.Close();

        }
        public void updateMedicine()
        {
            cn.Open();
            int newBquantity = x - Convert.ToInt32(Bquantity.Text);
            String Myquery = "UPDATE Medstock_tbl SET Quantity = " + newBquantity + " WHERE Medicine= '" + Bcombo.SelectedValue.ToString() + "';";
            SqlCommand cmd = new SqlCommand(Myquery, cn);
            cmd.ExecuteNonQuery();
           // MessageBox.Show("Medicine Successfully Updated");
            cn.Close();
            
        }
        public Billing()
        {
            InitializeComponent();
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            populatecombobox();

        }

        private void Bcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Bcombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchQty();
        }

        int GrdTotal = 0;
        Bitmap bitmap;
        private void Bpbttn_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);
            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);

        }

        private void Bhome_Click(object sender, EventArgs e)
        {
            Home homef = new Home();
            homef.Show();
            this.Hide();
        }

        private void Baddbttn_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (Bquantity.Text == "" || Convert.ToInt32(Bquantity.Text) > x)
            {
                MessageBox.Show("Not Enough Stock Please Chek Available Stock");

            }
            else
            {
                int total = Convert.ToInt32(Bquantity.Text) * unitp;
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BDataTable);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = Bcombo.SelectedValue.ToString();
                newRow.Cells[2].Value = Bquantity.Text;
                newRow.Cells[3].Value = unitp;
                newRow.Cells[4].Value = unitp * Convert.ToInt32(Bquantity.Text);
                BDataTable.Rows.Add(newRow);
                GrdTotal = GrdTotal + total;
                Btotalamount.Text = "BDT " + GrdTotal + " Taka";
                updateMedicine();

            }

        }
    }
}
