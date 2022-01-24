namespace PharmacyManagementSystem
{
    partial class MedicineForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicineForm));
            this.MedicineStock = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.MedName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Sprice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Qty = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DateTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.Bprice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.addbttn = new Guna.UI2.WinForms.Guna2Button();
            this.upbttn = new Guna.UI2.WinForms.Guna2Button();
            this.deletebttn = new Guna.UI2.WinForms.Guna2Button();
            this.backbttn = new Guna.UI2.WinForms.Guna2Button();
            this.databaseMDataSet = new PharmacyManagementSystem.DatabaseMDataSet();
            this.medstocktblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medstock_tblTableAdapter = new PharmacyManagementSystem.DatabaseMDataSetTableAdapters.Medstock_tblTableAdapter();
            this.DataTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.databaseMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medstocktblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // MedicineStock
            // 
            this.MedicineStock.BackColor = System.Drawing.Color.Transparent;
            this.MedicineStock.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicineStock.ForeColor = System.Drawing.Color.Brown;
            this.MedicineStock.Location = new System.Drawing.Point(31, 13);
            this.MedicineStock.Name = "MedicineStock";
            this.MedicineStock.Size = new System.Drawing.Size(179, 27);
            this.MedicineStock.TabIndex = 0;
            this.MedicineStock.Text = "Medicine Stock";
            // 
            // MedName
            // 
            this.MedName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MedName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedName.ForeColor = System.Drawing.Color.Brown;
            this.MedName.HintForeColor = System.Drawing.Color.Empty;
            this.MedName.HintText = "";
            this.MedName.isPassword = false;
            this.MedName.LineFocusedColor = System.Drawing.Color.Blue;
            this.MedName.LineIdleColor = System.Drawing.Color.Gray;
            this.MedName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.MedName.LineThickness = 3;
            this.MedName.Location = new System.Drawing.Point(35, 70);
            this.MedName.Margin = new System.Windows.Forms.Padding(4);
            this.MedName.Name = "MedName";
            this.MedName.Size = new System.Drawing.Size(144, 31);
            this.MedName.TabIndex = 1;
            this.MedName.Text = "Medicine Name";
            this.MedName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MedName.OnValueChanged += new System.EventHandler(this.MedName_OnValueChanged);
            // 
            // Sprice
            // 
            this.Sprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Sprice.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sprice.ForeColor = System.Drawing.Color.Brown;
            this.Sprice.HintForeColor = System.Drawing.Color.Empty;
            this.Sprice.HintText = "";
            this.Sprice.isPassword = false;
            this.Sprice.LineFocusedColor = System.Drawing.Color.Blue;
            this.Sprice.LineIdleColor = System.Drawing.Color.Gray;
            this.Sprice.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Sprice.LineThickness = 3;
            this.Sprice.Location = new System.Drawing.Point(282, 148);
            this.Sprice.Margin = new System.Windows.Forms.Padding(4);
            this.Sprice.Name = "Sprice";
            this.Sprice.Size = new System.Drawing.Size(144, 31);
            this.Sprice.TabIndex = 4;
            this.Sprice.Text = "SellingPriec";
            this.Sprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Qty
            // 
            this.Qty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Qty.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qty.ForeColor = System.Drawing.Color.Brown;
            this.Qty.HintForeColor = System.Drawing.Color.Empty;
            this.Qty.HintText = "";
            this.Qty.isPassword = false;
            this.Qty.LineFocusedColor = System.Drawing.Color.Blue;
            this.Qty.LineIdleColor = System.Drawing.Color.Gray;
            this.Qty.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Qty.LineThickness = 3;
            this.Qty.Location = new System.Drawing.Point(282, 222);
            this.Qty.Margin = new System.Windows.Forms.Padding(4);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(144, 31);
            this.Qty.TabIndex = 5;
            this.Qty.Text = "Quantity";
            this.Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DateTime
            // 
            this.DateTime.CheckedState.Parent = this.DateTime;
            this.DateTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTime.HoverState.Parent = this.DateTime;
            this.DateTime.Location = new System.Drawing.Point(35, 143);
            this.DateTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTime.Name = "DateTime";
            this.DateTime.ShadowDecoration.Parent = this.DateTime;
            this.DateTime.Size = new System.Drawing.Size(191, 36);
            this.DateTime.TabIndex = 7;
            this.DateTime.Value = new System.DateTime(2021, 7, 14, 9, 51, 27, 396);
            this.DateTime.ValueChanged += new System.EventHandler(this.DateTime_ValueChanged);
            // 
            // Bprice
            // 
            this.Bprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Bprice.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bprice.ForeColor = System.Drawing.Color.Brown;
            this.Bprice.HintForeColor = System.Drawing.Color.Empty;
            this.Bprice.HintText = "";
            this.Bprice.isPassword = false;
            this.Bprice.LineFocusedColor = System.Drawing.Color.Blue;
            this.Bprice.LineIdleColor = System.Drawing.Color.Gray;
            this.Bprice.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Bprice.LineThickness = 3;
            this.Bprice.Location = new System.Drawing.Point(282, 70);
            this.Bprice.Margin = new System.Windows.Forms.Padding(4);
            this.Bprice.Name = "Bprice";
            this.Bprice.Size = new System.Drawing.Size(144, 31);
            this.Bprice.TabIndex = 8;
            this.Bprice.Text = "BuyingPrice";
            this.Bprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // addbttn
            // 
            this.addbttn.CheckedState.Parent = this.addbttn;
            this.addbttn.CustomImages.Parent = this.addbttn;
            this.addbttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addbttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addbttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addbttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addbttn.DisabledState.Parent = this.addbttn;
            this.addbttn.FillColor = System.Drawing.Color.Brown;
            this.addbttn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbttn.ForeColor = System.Drawing.Color.White;
            this.addbttn.HoverState.Parent = this.addbttn;
            this.addbttn.Location = new System.Drawing.Point(35, 329);
            this.addbttn.Name = "addbttn";
            this.addbttn.ShadowDecoration.Parent = this.addbttn;
            this.addbttn.Size = new System.Drawing.Size(95, 38);
            this.addbttn.TabIndex = 9;
            this.addbttn.Text = "ADD";
            this.addbttn.Click += new System.EventHandler(this.Addbttn_Click);
            // 
            // upbttn
            // 
            this.upbttn.CheckedState.Parent = this.upbttn;
            this.upbttn.CustomImages.Parent = this.upbttn;
            this.upbttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.upbttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.upbttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.upbttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.upbttn.DisabledState.Parent = this.upbttn;
            this.upbttn.FillColor = System.Drawing.Color.Brown;
            this.upbttn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upbttn.ForeColor = System.Drawing.Color.White;
            this.upbttn.HoverState.Parent = this.upbttn;
            this.upbttn.Location = new System.Drawing.Point(182, 329);
            this.upbttn.Name = "upbttn";
            this.upbttn.ShadowDecoration.Parent = this.upbttn;
            this.upbttn.Size = new System.Drawing.Size(95, 38);
            this.upbttn.TabIndex = 10;
            this.upbttn.Text = "UPDATE";
            this.upbttn.Click += new System.EventHandler(this.Upbttn_Click);
            // 
            // deletebttn
            // 
            this.deletebttn.CheckedState.Parent = this.deletebttn;
            this.deletebttn.CustomImages.Parent = this.deletebttn;
            this.deletebttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deletebttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deletebttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deletebttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deletebttn.DisabledState.Parent = this.deletebttn;
            this.deletebttn.FillColor = System.Drawing.Color.Brown;
            this.deletebttn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebttn.ForeColor = System.Drawing.Color.White;
            this.deletebttn.HoverState.Parent = this.deletebttn;
            this.deletebttn.Location = new System.Drawing.Point(331, 329);
            this.deletebttn.Name = "deletebttn";
            this.deletebttn.ShadowDecoration.Parent = this.deletebttn;
            this.deletebttn.Size = new System.Drawing.Size(95, 38);
            this.deletebttn.TabIndex = 11;
            this.deletebttn.Text = "DELETE";
            this.deletebttn.Click += new System.EventHandler(this.Deletebttn_Click);
            // 
            // backbttn
            // 
            this.backbttn.CheckedState.Parent = this.backbttn;
            this.backbttn.CustomImages.Parent = this.backbttn;
            this.backbttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backbttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backbttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backbttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backbttn.DisabledState.Parent = this.backbttn;
            this.backbttn.FillColor = System.Drawing.Color.Brown;
            this.backbttn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbttn.ForeColor = System.Drawing.Color.White;
            this.backbttn.HoverState.Parent = this.backbttn;
            this.backbttn.Location = new System.Drawing.Point(182, 400);
            this.backbttn.Name = "backbttn";
            this.backbttn.ShadowDecoration.Parent = this.backbttn;
            this.backbttn.Size = new System.Drawing.Size(95, 38);
            this.backbttn.TabIndex = 12;
            this.backbttn.Text = "BACK";
            this.backbttn.Click += new System.EventHandler(this.Backbttn_Click);
            // 
            // databaseMDataSet
            // 
            this.databaseMDataSet.DataSetName = "DatabaseMDataSet";
            this.databaseMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medstocktblBindingSource
            // 
            this.medstocktblBindingSource.DataMember = "Medstock_tbl";
            this.medstocktblBindingSource.DataSource = this.databaseMDataSet;
            // 
            // medstock_tblTableAdapter
            // 
            this.medstock_tblTableAdapter.ClearBeforeFill = true;
            // 
            // DataTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataTable.BackgroundColor = System.Drawing.Color.White;
            this.DataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataTable.ColumnHeadersHeight = 18;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataTable.EnableHeadersVisualStyles = false;
            this.DataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataTable.Location = new System.Drawing.Point(433, 13);
            this.DataTable.Name = "DataTable";
            this.DataTable.RowHeadersVisible = false;
            this.DataTable.RowTemplate.Height = 30;
            this.DataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataTable.Size = new System.Drawing.Size(606, 425);
            this.DataTable.TabIndex = 13;
            this.DataTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Brown;
            this.DataTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataTable.ThemeStyle.HeaderStyle.Height = 18;
            this.DataTable.ThemeStyle.ReadOnly = false;
            this.DataTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataTable.ThemeStyle.RowsStyle.Height = 30;
            this.DataTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTable_CellContentClick);
            // 
            // CCombo
            // 
            this.CCombo.BackColor = System.Drawing.Color.Transparent;
            this.CCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CCombo.FocusedState.Parent = this.CCombo;
            this.CCombo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.CCombo.ForeColor = System.Drawing.Color.Brown;
            this.CCombo.HoverState.Parent = this.CCombo;
            this.CCombo.ItemHeight = 30;
            this.CCombo.ItemsAppearance.Parent = this.CCombo;
            this.CCombo.Location = new System.Drawing.Point(35, 216);
            this.CCombo.Name = "CCombo";
            this.CCombo.ShadowDecoration.Parent = this.CCombo;
            this.CCombo.Size = new System.Drawing.Size(140, 36);
            this.CCombo.TabIndex = 14;
            this.CCombo.SelectedIndexChanged += new System.EventHandler(this.CCombo_SelectedIndexChanged);
            // 
            // MedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1051, 450);
            this.Controls.Add(this.CCombo);
            this.Controls.Add(this.DataTable);
            this.Controls.Add(this.backbttn);
            this.Controls.Add(this.deletebttn);
            this.Controls.Add(this.upbttn);
            this.Controls.Add(this.addbttn);
            this.Controls.Add(this.Bprice);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.Qty);
            this.Controls.Add(this.Sprice);
            this.Controls.Add(this.MedName);
            this.Controls.Add(this.MedicineStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedicineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicineForm";
            this.Load += new System.EventHandler(this.MedicineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medstocktblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel MedicineStock;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MedName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Sprice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Qty;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTime;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Bprice;
        private Guna.UI2.WinForms.Guna2Button addbttn;
        private Guna.UI2.WinForms.Guna2Button upbttn;
        private Guna.UI2.WinForms.Guna2Button deletebttn;
        private Guna.UI2.WinForms.Guna2Button backbttn;
        private DatabaseMDataSet databaseMDataSet;
        private System.Windows.Forms.BindingSource medstocktblBindingSource;
        private DatabaseMDataSetTableAdapters.Medstock_tblTableAdapter medstock_tblTableAdapter;
        private Guna.UI2.WinForms.Guna2DataGridView DataTable;
        private Guna.UI2.WinForms.Guna2ComboBox CCombo;
    }
}