namespace PharmacyManagementSystem
{
    partial class Billing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            this.Billinglabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Bcombo = new System.Windows.Forms.ComboBox();
            this.Bquantity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Bstocklabel = new System.Windows.Forms.Label();
            this.Baddbttn = new Guna.UI2.WinForms.Guna2Button();
            this.BDataTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btotalamount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Bpbttn = new Guna.UI2.WinForms.Guna2Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Bhome = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.BDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // Billinglabel
            // 
            this.Billinglabel.BackColor = System.Drawing.Color.Transparent;
            this.Billinglabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Billinglabel.ForeColor = System.Drawing.Color.Brown;
            this.Billinglabel.Location = new System.Drawing.Point(41, 12);
            this.Billinglabel.Name = "Billinglabel";
            this.Billinglabel.Size = new System.Drawing.Size(144, 27);
            this.Billinglabel.TabIndex = 11;
            this.Billinglabel.Text = "Billing Form";
            // 
            // Bcombo
            // 
            this.Bcombo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bcombo.ForeColor = System.Drawing.Color.Brown;
            this.Bcombo.FormattingEnabled = true;
            this.Bcombo.Location = new System.Drawing.Point(41, 56);
            this.Bcombo.Name = "Bcombo";
            this.Bcombo.Size = new System.Drawing.Size(144, 24);
            this.Bcombo.TabIndex = 12;
            this.Bcombo.Text = "Select Medicine";
            this.Bcombo.SelectedIndexChanged += new System.EventHandler(this.Bcombo_SelectedIndexChanged);
            this.Bcombo.SelectionChangeCommitted += new System.EventHandler(this.Bcombo_SelectionChangeCommitted);
            // 
            // Bquantity
            // 
            this.Bquantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Bquantity.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bquantity.ForeColor = System.Drawing.Color.Brown;
            this.Bquantity.HintForeColor = System.Drawing.Color.Empty;
            this.Bquantity.HintText = "";
            this.Bquantity.isPassword = false;
            this.Bquantity.LineFocusedColor = System.Drawing.Color.Blue;
            this.Bquantity.LineIdleColor = System.Drawing.Color.Gray;
            this.Bquantity.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Bquantity.LineThickness = 3;
            this.Bquantity.Location = new System.Drawing.Point(41, 173);
            this.Bquantity.Margin = new System.Windows.Forms.Padding(4);
            this.Bquantity.Name = "Bquantity";
            this.Bquantity.Size = new System.Drawing.Size(144, 31);
            this.Bquantity.TabIndex = 22;
            this.Bquantity.Text = "Quantity";
            this.Bquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Bstocklabel
            // 
            this.Bstocklabel.AutoSize = true;
            this.Bstocklabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bstocklabel.ForeColor = System.Drawing.Color.Brown;
            this.Bstocklabel.Location = new System.Drawing.Point(38, 115);
            this.Bstocklabel.Name = "Bstocklabel";
            this.Bstocklabel.Size = new System.Drawing.Size(119, 16);
            this.Bstocklabel.TabIndex = 23;
            this.Bstocklabel.Text = "Available Stock";
            this.Bstocklabel.Visible = false;
            // 
            // Baddbttn
            // 
            this.Baddbttn.CheckedState.Parent = this.Baddbttn;
            this.Baddbttn.CustomImages.Parent = this.Baddbttn;
            this.Baddbttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Baddbttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Baddbttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Baddbttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Baddbttn.DisabledState.Parent = this.Baddbttn;
            this.Baddbttn.FillColor = System.Drawing.Color.Brown;
            this.Baddbttn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Baddbttn.ForeColor = System.Drawing.Color.White;
            this.Baddbttn.HoverState.Parent = this.Baddbttn;
            this.Baddbttn.Location = new System.Drawing.Point(67, 244);
            this.Baddbttn.Name = "Baddbttn";
            this.Baddbttn.ShadowDecoration.Parent = this.Baddbttn;
            this.Baddbttn.Size = new System.Drawing.Size(118, 38);
            this.Baddbttn.TabIndex = 27;
            this.Baddbttn.Text = "Add To Bill";
            this.Baddbttn.Click += new System.EventHandler(this.Baddbttn_Click);
            // 
            // BDataTable
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.BDataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.BDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BDataTable.BackgroundColor = System.Drawing.Color.White;
            this.BDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BDataTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BDataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.BDataTable.ColumnHeadersHeight = 18;
            this.BDataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Medname,
            this.Medqty,
            this.UnitPrice,
            this.TotalPrice});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BDataTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.BDataTable.EnableHeadersVisualStyles = false;
            this.BDataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BDataTable.Location = new System.Drawing.Point(222, 12);
            this.BDataTable.Name = "BDataTable";
            this.BDataTable.RowHeadersVisible = false;
            this.BDataTable.RowTemplate.Height = 30;
            this.BDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BDataTable.Size = new System.Drawing.Size(606, 355);
            this.BDataTable.TabIndex = 28;
            this.BDataTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BDataTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BDataTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BDataTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BDataTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BDataTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BDataTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BDataTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Brown;
            this.BDataTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BDataTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDataTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BDataTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BDataTable.ThemeStyle.HeaderStyle.Height = 18;
            this.BDataTable.ThemeStyle.ReadOnly = false;
            this.BDataTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BDataTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BDataTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.BDataTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BDataTable.ThemeStyle.RowsStyle.Height = 30;
            this.BDataTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BDataTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Id
            // 
            this.Id.HeaderText = "MedId";
            this.Id.Name = "Id";
            // 
            // Medname
            // 
            this.Medname.HeaderText = "Medname";
            this.Medname.Name = "Medname";
            // 
            // Medqty
            // 
            this.Medqty.HeaderText = "Quantity";
            this.Medqty.Name = "Medqty";
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "UnitPrice";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "TotalPrice";
            this.TotalPrice.Name = "TotalPrice";
            // 
            // Btotalamount
            // 
            this.Btotalamount.BackColor = System.Drawing.Color.Transparent;
            this.Btotalamount.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btotalamount.ForeColor = System.Drawing.Color.Brown;
            this.Btotalamount.Location = new System.Drawing.Point(396, 373);
            this.Btotalamount.Name = "Btotalamount";
            this.Btotalamount.Size = new System.Drawing.Size(161, 27);
            this.Btotalamount.TabIndex = 29;
            this.Btotalamount.Text = "Total Amount";
            // 
            // Bpbttn
            // 
            this.Bpbttn.CheckedState.Parent = this.Bpbttn;
            this.Bpbttn.CustomImages.Parent = this.Bpbttn;
            this.Bpbttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Bpbttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Bpbttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Bpbttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Bpbttn.DisabledState.Parent = this.Bpbttn;
            this.Bpbttn.FillColor = System.Drawing.Color.Brown;
            this.Bpbttn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bpbttn.ForeColor = System.Drawing.Color.White;
            this.Bpbttn.HoverState.Parent = this.Bpbttn;
            this.Bpbttn.Location = new System.Drawing.Point(483, 400);
            this.Bpbttn.Name = "Bpbttn";
            this.Bpbttn.ShadowDecoration.Parent = this.Bpbttn;
            this.Bpbttn.Size = new System.Drawing.Size(118, 38);
            this.Bpbttn.TabIndex = 30;
            this.Bpbttn.Text = "Print";
            this.Bpbttn.Click += new System.EventHandler(this.Bpbttn_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Bhome
            // 
            this.Bhome.CheckedState.Parent = this.Bhome;
            this.Bhome.CustomImages.Parent = this.Bhome;
            this.Bhome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Bhome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Bhome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Bhome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Bhome.DisabledState.Parent = this.Bhome;
            this.Bhome.FillColor = System.Drawing.Color.Brown;
            this.Bhome.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bhome.ForeColor = System.Drawing.Color.White;
            this.Bhome.HoverState.Parent = this.Bhome;
            this.Bhome.Location = new System.Drawing.Point(328, 400);
            this.Bhome.Name = "Bhome";
            this.Bhome.ShadowDecoration.Parent = this.Bhome;
            this.Bhome.Size = new System.Drawing.Size(118, 38);
            this.Bhome.TabIndex = 31;
            this.Bhome.Text = "Home";
            this.Bhome.Click += new System.EventHandler(this.Bhome_Click);
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.Bhome);
            this.Controls.Add(this.Bpbttn);
            this.Controls.Add(this.Btotalamount);
            this.Controls.Add(this.BDataTable);
            this.Controls.Add(this.Baddbttn);
            this.Controls.Add(this.Bstocklabel);
            this.Controls.Add(this.Bquantity);
            this.Controls.Add(this.Bcombo);
            this.Controls.Add(this.Billinglabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel Billinglabel;
        private System.Windows.Forms.ComboBox Bcombo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Bquantity;
        private System.Windows.Forms.Label Bstocklabel;
        private Guna.UI2.WinForms.Guna2Button Baddbttn;
        private Guna.UI2.WinForms.Guna2DataGridView BDataTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel Btotalamount;
        private Guna.UI2.WinForms.Guna2Button Bpbttn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Guna.UI2.WinForms.Guna2Button Bhome;
    }
}