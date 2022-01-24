namespace PharmacyManagementSystem
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            this.EmpName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.EmpSalary = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.EmpAge = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.EmpID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Emplabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.EmpPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.backempbttn = new Guna.UI2.WinForms.Guna2Button();
            this.deleteempbttn = new Guna.UI2.WinForms.Guna2Button();
            this.upempbttn = new Guna.UI2.WinForms.Guna2Button();
            this.EmpTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.addempbttn = new Guna.UI2.WinForms.Guna2Button();
            this.EmpPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.EmpTable)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpName
            // 
            this.EmpName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpName.ForeColor = System.Drawing.Color.Brown;
            this.EmpName.HintForeColor = System.Drawing.Color.Empty;
            this.EmpName.HintText = "";
            this.EmpName.isPassword = false;
            this.EmpName.LineFocusedColor = System.Drawing.Color.Blue;
            this.EmpName.LineIdleColor = System.Drawing.Color.Gray;
            this.EmpName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.EmpName.LineThickness = 3;
            this.EmpName.Location = new System.Drawing.Point(33, 146);
            this.EmpName.Margin = new System.Windows.Forms.Padding(4);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(144, 31);
            this.EmpName.TabIndex = 14;
            this.EmpName.Text = "Employee Name";
            this.EmpName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // EmpSalary
            // 
            this.EmpSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpSalary.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpSalary.ForeColor = System.Drawing.Color.Brown;
            this.EmpSalary.HintForeColor = System.Drawing.Color.Empty;
            this.EmpSalary.HintText = "";
            this.EmpSalary.isPassword = false;
            this.EmpSalary.LineFocusedColor = System.Drawing.Color.Blue;
            this.EmpSalary.LineIdleColor = System.Drawing.Color.Gray;
            this.EmpSalary.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.EmpSalary.LineThickness = 3;
            this.EmpSalary.Location = new System.Drawing.Point(280, 69);
            this.EmpSalary.Margin = new System.Windows.Forms.Padding(4);
            this.EmpSalary.Name = "EmpSalary";
            this.EmpSalary.Size = new System.Drawing.Size(144, 31);
            this.EmpSalary.TabIndex = 12;
            this.EmpSalary.Text = "Employee Salary";
            this.EmpSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // EmpAge
            // 
            this.EmpAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpAge.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpAge.ForeColor = System.Drawing.Color.Brown;
            this.EmpAge.HintForeColor = System.Drawing.Color.Empty;
            this.EmpAge.HintText = "";
            this.EmpAge.isPassword = false;
            this.EmpAge.LineFocusedColor = System.Drawing.Color.Blue;
            this.EmpAge.LineIdleColor = System.Drawing.Color.Gray;
            this.EmpAge.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.EmpAge.LineThickness = 3;
            this.EmpAge.Location = new System.Drawing.Point(33, 227);
            this.EmpAge.Margin = new System.Windows.Forms.Padding(4);
            this.EmpAge.Name = "EmpAge";
            this.EmpAge.Size = new System.Drawing.Size(144, 31);
            this.EmpAge.TabIndex = 11;
            this.EmpAge.Text = "Employee Age";
            this.EmpAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // EmpID
            // 
            this.EmpID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpID.ForeColor = System.Drawing.Color.Brown;
            this.EmpID.HintForeColor = System.Drawing.Color.Empty;
            this.EmpID.HintText = "";
            this.EmpID.isPassword = false;
            this.EmpID.LineFocusedColor = System.Drawing.Color.Blue;
            this.EmpID.LineIdleColor = System.Drawing.Color.Gray;
            this.EmpID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.EmpID.LineThickness = 3;
            this.EmpID.Location = new System.Drawing.Point(37, 69);
            this.EmpID.Margin = new System.Windows.Forms.Padding(4);
            this.EmpID.Name = "EmpID";
            this.EmpID.Size = new System.Drawing.Size(144, 31);
            this.EmpID.TabIndex = 10;
            this.EmpID.Text = "Employee Id";
            this.EmpID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EmpID.OnValueChanged += new System.EventHandler(this.EmpID_OnValueChanged);
            // 
            // Emplabel
            // 
            this.Emplabel.BackColor = System.Drawing.Color.Transparent;
            this.Emplabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emplabel.ForeColor = System.Drawing.Color.Brown;
            this.Emplabel.Location = new System.Drawing.Point(33, 12);
            this.Emplabel.Name = "Emplabel";
            this.Emplabel.Size = new System.Drawing.Size(129, 27);
            this.Emplabel.TabIndex = 9;
            this.Emplabel.Text = "Employees";
            // 
            // EmpPhone
            // 
            this.EmpPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpPhone.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpPhone.ForeColor = System.Drawing.Color.Brown;
            this.EmpPhone.HintForeColor = System.Drawing.Color.Empty;
            this.EmpPhone.HintText = "";
            this.EmpPhone.isPassword = false;
            this.EmpPhone.LineFocusedColor = System.Drawing.Color.Blue;
            this.EmpPhone.LineIdleColor = System.Drawing.Color.Gray;
            this.EmpPhone.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.EmpPhone.LineThickness = 3;
            this.EmpPhone.Location = new System.Drawing.Point(280, 227);
            this.EmpPhone.Margin = new System.Windows.Forms.Padding(4);
            this.EmpPhone.Name = "EmpPhone";
            this.EmpPhone.Size = new System.Drawing.Size(144, 31);
            this.EmpPhone.TabIndex = 15;
            this.EmpPhone.Text = "Phone Number";
            this.EmpPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // backempbttn
            // 
            this.backempbttn.CheckedState.Parent = this.backempbttn;
            this.backempbttn.CustomImages.Parent = this.backempbttn;
            this.backempbttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backempbttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backempbttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backempbttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backempbttn.DisabledState.Parent = this.backempbttn;
            this.backempbttn.FillColor = System.Drawing.Color.Brown;
            this.backempbttn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backempbttn.ForeColor = System.Drawing.Color.White;
            this.backempbttn.HoverState.Parent = this.backempbttn;
            this.backempbttn.Location = new System.Drawing.Point(183, 400);
            this.backempbttn.Name = "backempbttn";
            this.backempbttn.ShadowDecoration.Parent = this.backempbttn;
            this.backempbttn.Size = new System.Drawing.Size(95, 38);
            this.backempbttn.TabIndex = 19;
            this.backempbttn.Text = "BACK";
            this.backempbttn.Click += new System.EventHandler(this.Backempbttn_Click);
            // 
            // deleteempbttn
            // 
            this.deleteempbttn.CheckedState.Parent = this.deleteempbttn;
            this.deleteempbttn.CustomImages.Parent = this.deleteempbttn;
            this.deleteempbttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteempbttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteempbttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteempbttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteempbttn.DisabledState.Parent = this.deleteempbttn;
            this.deleteempbttn.FillColor = System.Drawing.Color.Brown;
            this.deleteempbttn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteempbttn.ForeColor = System.Drawing.Color.White;
            this.deleteempbttn.HoverState.Parent = this.deleteempbttn;
            this.deleteempbttn.Location = new System.Drawing.Point(332, 329);
            this.deleteempbttn.Name = "deleteempbttn";
            this.deleteempbttn.ShadowDecoration.Parent = this.deleteempbttn;
            this.deleteempbttn.Size = new System.Drawing.Size(95, 38);
            this.deleteempbttn.TabIndex = 18;
            this.deleteempbttn.Text = "DELETE";
            this.deleteempbttn.Click += new System.EventHandler(this.Deleteempbttn_Click);
            // 
            // upempbttn
            // 
            this.upempbttn.CheckedState.Parent = this.upempbttn;
            this.upempbttn.CustomImages.Parent = this.upempbttn;
            this.upempbttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.upempbttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.upempbttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.upempbttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.upempbttn.DisabledState.Parent = this.upempbttn;
            this.upempbttn.FillColor = System.Drawing.Color.Brown;
            this.upempbttn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upempbttn.ForeColor = System.Drawing.Color.White;
            this.upempbttn.HoverState.Parent = this.upempbttn;
            this.upempbttn.Location = new System.Drawing.Point(183, 329);
            this.upempbttn.Name = "upempbttn";
            this.upempbttn.ShadowDecoration.Parent = this.upempbttn;
            this.upempbttn.Size = new System.Drawing.Size(95, 38);
            this.upempbttn.TabIndex = 17;
            this.upempbttn.Text = "UPDATE";
            this.upempbttn.Click += new System.EventHandler(this.Upempbttn_Click);
            // 
            // EmpTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.EmpTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EmpTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmpTable.BackgroundColor = System.Drawing.Color.White;
            this.EmpTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmpTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmpTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmpTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmpTable.ColumnHeadersHeight = 18;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmpTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.EmpTable.EnableHeadersVisualStyles = false;
            this.EmpTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmpTable.Location = new System.Drawing.Point(433, 13);
            this.EmpTable.Name = "EmpTable";
            this.EmpTable.RowHeadersVisible = false;
            this.EmpTable.RowTemplate.Height = 30;
            this.EmpTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmpTable.Size = new System.Drawing.Size(606, 425);
            this.EmpTable.TabIndex = 20;
            this.EmpTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.EmpTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EmpTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EmpTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EmpTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EmpTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.EmpTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmpTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Brown;
            this.EmpTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EmpTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EmpTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmpTable.ThemeStyle.HeaderStyle.Height = 18;
            this.EmpTable.ThemeStyle.ReadOnly = false;
            this.EmpTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.EmpTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmpTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.EmpTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmpTable.ThemeStyle.RowsStyle.Height = 30;
            this.EmpTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmpTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmpTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpTable_CellContentClick);
            // 
            // addempbttn
            // 
            this.addempbttn.CheckedState.Parent = this.addempbttn;
            this.addempbttn.CustomImages.Parent = this.addempbttn;
            this.addempbttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addempbttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addempbttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addempbttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addempbttn.DisabledState.Parent = this.addempbttn;
            this.addempbttn.FillColor = System.Drawing.Color.Brown;
            this.addempbttn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addempbttn.ForeColor = System.Drawing.Color.White;
            this.addempbttn.HoverState.Parent = this.addempbttn;
            this.addempbttn.Location = new System.Drawing.Point(33, 329);
            this.addempbttn.Name = "addempbttn";
            this.addempbttn.ShadowDecoration.Parent = this.addempbttn;
            this.addempbttn.Size = new System.Drawing.Size(95, 38);
            this.addempbttn.TabIndex = 21;
            this.addempbttn.Text = "ADD";
            this.addempbttn.Click += new System.EventHandler(this.Addempbttn_Click);
            // 
            // EmpPass
            // 
            this.EmpPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpPass.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpPass.ForeColor = System.Drawing.Color.Brown;
            this.EmpPass.HintForeColor = System.Drawing.Color.Empty;
            this.EmpPass.HintText = "";
            this.EmpPass.isPassword = false;
            this.EmpPass.LineFocusedColor = System.Drawing.Color.Blue;
            this.EmpPass.LineIdleColor = System.Drawing.Color.Gray;
            this.EmpPass.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.EmpPass.LineThickness = 3;
            this.EmpPass.Location = new System.Drawing.Point(280, 146);
            this.EmpPass.Margin = new System.Windows.Forms.Padding(4);
            this.EmpPass.Name = "EmpPass";
            this.EmpPass.Size = new System.Drawing.Size(144, 31);
            this.EmpPass.TabIndex = 22;
            this.EmpPass.Text = "Employee Pass";
            this.EmpPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1051, 450);
            this.Controls.Add(this.EmpPass);
            this.Controls.Add(this.addempbttn);
            this.Controls.Add(this.EmpTable);
            this.Controls.Add(this.backempbttn);
            this.Controls.Add(this.deleteempbttn);
            this.Controls.Add(this.upempbttn);
            this.Controls.Add(this.EmpPhone);
            this.Controls.Add(this.EmpName);
            this.Controls.Add(this.EmpSalary);
            this.Controls.Add(this.EmpAge);
            this.Controls.Add(this.EmpID);
            this.Controls.Add(this.Emplabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox EmpName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmpSalary;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmpAge;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmpID;
        private Guna.UI2.WinForms.Guna2HtmlLabel Emplabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmpPhone;
        private Guna.UI2.WinForms.Guna2Button backempbttn;
        private Guna.UI2.WinForms.Guna2Button deleteempbttn;
        private Guna.UI2.WinForms.Guna2Button upempbttn;
        private Guna.UI2.WinForms.Guna2DataGridView EmpTable;
        private Guna.UI2.WinForms.Guna2Button addempbttn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmpPass;
    }
}