namespace PharmacyManagementSystem
{
    partial class Company
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Company));
            this.Companylabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Cname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Cphnno = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Cid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Caddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CDataTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Cbackbttn = new Guna.UI2.WinForms.Guna2Button();
            this.Cdeletebttn = new Guna.UI2.WinForms.Guna2Button();
            this.Cupbttn = new Guna.UI2.WinForms.Guna2Button();
            this.Caddbttn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.CDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // Companylabel
            // 
            this.Companylabel.BackColor = System.Drawing.Color.Transparent;
            this.Companylabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Companylabel.ForeColor = System.Drawing.Color.Brown;
            this.Companylabel.Location = new System.Drawing.Point(35, 12);
            this.Companylabel.Name = "Companylabel";
            this.Companylabel.Size = new System.Drawing.Size(272, 27);
            this.Companylabel.TabIndex = 10;
            this.Companylabel.Text = "Medicine Manufacturer";
            // 
            // Cname
            // 
            this.Cname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Cname.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cname.ForeColor = System.Drawing.Color.Brown;
            this.Cname.HintForeColor = System.Drawing.Color.Empty;
            this.Cname.HintText = "";
            this.Cname.isPassword = false;
            this.Cname.LineFocusedColor = System.Drawing.Color.Blue;
            this.Cname.LineIdleColor = System.Drawing.Color.Gray;
            this.Cname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Cname.LineThickness = 3;
            this.Cname.Location = new System.Drawing.Point(35, 181);
            this.Cname.Margin = new System.Windows.Forms.Padding(4);
            this.Cname.Name = "Cname";
            this.Cname.Size = new System.Drawing.Size(144, 31);
            this.Cname.TabIndex = 18;
            this.Cname.Text = "Company Name";
            this.Cname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Cphnno
            // 
            this.Cphnno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Cphnno.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cphnno.ForeColor = System.Drawing.Color.Brown;
            this.Cphnno.HintForeColor = System.Drawing.Color.Empty;
            this.Cphnno.HintText = "";
            this.Cphnno.isPassword = false;
            this.Cphnno.LineFocusedColor = System.Drawing.Color.Blue;
            this.Cphnno.LineIdleColor = System.Drawing.Color.Gray;
            this.Cphnno.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Cphnno.LineThickness = 3;
            this.Cphnno.Location = new System.Drawing.Point(282, 73);
            this.Cphnno.Margin = new System.Windows.Forms.Padding(4);
            this.Cphnno.Name = "Cphnno";
            this.Cphnno.Size = new System.Drawing.Size(144, 31);
            this.Cphnno.TabIndex = 17;
            this.Cphnno.Text = "Phone Number";
            this.Cphnno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Cid
            // 
            this.Cid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Cid.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cid.ForeColor = System.Drawing.Color.Brown;
            this.Cid.HintForeColor = System.Drawing.Color.Empty;
            this.Cid.HintText = "";
            this.Cid.isPassword = false;
            this.Cid.LineFocusedColor = System.Drawing.Color.Blue;
            this.Cid.LineIdleColor = System.Drawing.Color.Gray;
            this.Cid.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Cid.LineThickness = 3;
            this.Cid.Location = new System.Drawing.Point(35, 73);
            this.Cid.Margin = new System.Windows.Forms.Padding(4);
            this.Cid.Name = "Cid";
            this.Cid.Size = new System.Drawing.Size(144, 31);
            this.Cid.TabIndex = 20;
            this.Cid.Text = "Company Id";
            this.Cid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Cid.OnValueChanged += new System.EventHandler(this.Cid_OnValueChanged);
            // 
            // Caddress
            // 
            this.Caddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Caddress.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Caddress.ForeColor = System.Drawing.Color.Brown;
            this.Caddress.HintForeColor = System.Drawing.Color.Empty;
            this.Caddress.HintText = "";
            this.Caddress.isPassword = false;
            this.Caddress.LineFocusedColor = System.Drawing.Color.Blue;
            this.Caddress.LineIdleColor = System.Drawing.Color.Gray;
            this.Caddress.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Caddress.LineThickness = 3;
            this.Caddress.Location = new System.Drawing.Point(282, 181);
            this.Caddress.Margin = new System.Windows.Forms.Padding(4);
            this.Caddress.Name = "Caddress";
            this.Caddress.Size = new System.Drawing.Size(144, 31);
            this.Caddress.TabIndex = 21;
            this.Caddress.Text = "Address";
            this.Caddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CDataTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CDataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CDataTable.BackgroundColor = System.Drawing.Color.White;
            this.CDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CDataTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CDataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CDataTable.ColumnHeadersHeight = 18;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CDataTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.CDataTable.EnableHeadersVisualStyles = false;
            this.CDataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CDataTable.Location = new System.Drawing.Point(433, 12);
            this.CDataTable.Name = "CDataTable";
            this.CDataTable.RowHeadersVisible = false;
            this.CDataTable.RowTemplate.Height = 30;
            this.CDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CDataTable.Size = new System.Drawing.Size(606, 425);
            this.CDataTable.TabIndex = 22;
            this.CDataTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CDataTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CDataTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CDataTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CDataTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CDataTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CDataTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CDataTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Brown;
            this.CDataTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CDataTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDataTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CDataTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CDataTable.ThemeStyle.HeaderStyle.Height = 18;
            this.CDataTable.ThemeStyle.ReadOnly = false;
            this.CDataTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CDataTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CDataTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CDataTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CDataTable.ThemeStyle.RowsStyle.Height = 30;
            this.CDataTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CDataTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CDataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CDataTable_CellContentClick);
            // 
            // Cbackbttn
            // 
            this.Cbackbttn.CheckedState.Parent = this.Cbackbttn;
            this.Cbackbttn.CustomImages.Parent = this.Cbackbttn;
            this.Cbackbttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Cbackbttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Cbackbttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Cbackbttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Cbackbttn.DisabledState.Parent = this.Cbackbttn;
            this.Cbackbttn.FillColor = System.Drawing.Color.Brown;
            this.Cbackbttn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbackbttn.ForeColor = System.Drawing.Color.White;
            this.Cbackbttn.HoverState.Parent = this.Cbackbttn;
            this.Cbackbttn.Location = new System.Drawing.Point(182, 400);
            this.Cbackbttn.Name = "Cbackbttn";
            this.Cbackbttn.ShadowDecoration.Parent = this.Cbackbttn;
            this.Cbackbttn.Size = new System.Drawing.Size(95, 38);
            this.Cbackbttn.TabIndex = 29;
            this.Cbackbttn.Text = "BACK";
            this.Cbackbttn.Click += new System.EventHandler(this.Cbackbttn_Click);
            // 
            // Cdeletebttn
            // 
            this.Cdeletebttn.CheckedState.Parent = this.Cdeletebttn;
            this.Cdeletebttn.CustomImages.Parent = this.Cdeletebttn;
            this.Cdeletebttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Cdeletebttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Cdeletebttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Cdeletebttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Cdeletebttn.DisabledState.Parent = this.Cdeletebttn;
            this.Cdeletebttn.FillColor = System.Drawing.Color.Brown;
            this.Cdeletebttn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cdeletebttn.ForeColor = System.Drawing.Color.White;
            this.Cdeletebttn.HoverState.Parent = this.Cdeletebttn;
            this.Cdeletebttn.Location = new System.Drawing.Point(331, 329);
            this.Cdeletebttn.Name = "Cdeletebttn";
            this.Cdeletebttn.ShadowDecoration.Parent = this.Cdeletebttn;
            this.Cdeletebttn.Size = new System.Drawing.Size(95, 38);
            this.Cdeletebttn.TabIndex = 28;
            this.Cdeletebttn.Text = "DELETE";
            this.Cdeletebttn.Click += new System.EventHandler(this.Cdeletebttn_Click);
            // 
            // Cupbttn
            // 
            this.Cupbttn.CheckedState.Parent = this.Cupbttn;
            this.Cupbttn.CustomImages.Parent = this.Cupbttn;
            this.Cupbttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Cupbttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Cupbttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Cupbttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Cupbttn.DisabledState.Parent = this.Cupbttn;
            this.Cupbttn.FillColor = System.Drawing.Color.Brown;
            this.Cupbttn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cupbttn.ForeColor = System.Drawing.Color.White;
            this.Cupbttn.HoverState.Parent = this.Cupbttn;
            this.Cupbttn.Location = new System.Drawing.Point(182, 329);
            this.Cupbttn.Name = "Cupbttn";
            this.Cupbttn.ShadowDecoration.Parent = this.Cupbttn;
            this.Cupbttn.Size = new System.Drawing.Size(95, 38);
            this.Cupbttn.TabIndex = 27;
            this.Cupbttn.Text = "UPDATE";
            this.Cupbttn.Click += new System.EventHandler(this.Cupbttn_Click);
            // 
            // Caddbttn
            // 
            this.Caddbttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Caddbttn.BackgroundImage")));
            this.Caddbttn.CheckedState.Parent = this.Caddbttn;
            this.Caddbttn.CustomImages.Parent = this.Caddbttn;
            this.Caddbttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Caddbttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Caddbttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Caddbttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Caddbttn.DisabledState.Parent = this.Caddbttn;
            this.Caddbttn.FillColor = System.Drawing.Color.Brown;
            this.Caddbttn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Caddbttn.ForeColor = System.Drawing.Color.White;
            this.Caddbttn.HoverState.Parent = this.Caddbttn;
            this.Caddbttn.Location = new System.Drawing.Point(35, 329);
            this.Caddbttn.Name = "Caddbttn";
            this.Caddbttn.ShadowDecoration.Parent = this.Caddbttn;
            this.Caddbttn.Size = new System.Drawing.Size(95, 38);
            this.Caddbttn.TabIndex = 26;
            this.Caddbttn.Text = "ADD";
            this.Caddbttn.Click += new System.EventHandler(this.Caddbttn_Click);
            // 
            // Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1051, 450);
            this.Controls.Add(this.Cbackbttn);
            this.Controls.Add(this.Cdeletebttn);
            this.Controls.Add(this.Cupbttn);
            this.Controls.Add(this.Caddbttn);
            this.Controls.Add(this.CDataTable);
            this.Controls.Add(this.Caddress);
            this.Controls.Add(this.Cid);
            this.Controls.Add(this.Cname);
            this.Controls.Add(this.Cphnno);
            this.Controls.Add(this.Companylabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Company";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company";
            this.Load += new System.EventHandler(this.Company_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel Companylabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Cname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Cphnno;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Cid;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Caddress;
        private Guna.UI2.WinForms.Guna2DataGridView CDataTable;
        private Guna.UI2.WinForms.Guna2Button Cbackbttn;
        private Guna.UI2.WinForms.Guna2Button Cdeletebttn;
        private Guna.UI2.WinForms.Guna2Button Cupbttn;
        private Guna.UI2.WinForms.Guna2Button Caddbttn;
    }
}