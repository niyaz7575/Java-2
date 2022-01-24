
namespace PharmacyManagementSystem
{
    partial class MedicineStock
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
            this.MedStock = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.MedName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Bprice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Sprice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Qt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DateTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.Backbttn = new Guna.UI2.WinForms.Guna2Button();
            this.pharmacydbDataSet = new PharmacyManagementSystem.pharmacydbDataSet();
            this.stocktbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stocktbTableAdapter = new PharmacyManagementSystem.pharmacydbDataSetTableAdapters.stocktbTableAdapter();
            this.Addbttn = new Guna.UI2.WinForms.Guna2Button();
            this.Upbttn = new Guna.UI2.WinForms.Guna2Button();
            this.Deletebttn = new Guna.UI2.WinForms.Guna2Button();
            this.CompanyCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocktbBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MedStock
            // 
            this.MedStock.BackColor = System.Drawing.Color.Transparent;
            this.MedStock.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedStock.ForeColor = System.Drawing.Color.Brown;
            this.MedStock.Location = new System.Drawing.Point(60, 36);
            this.MedStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MedStock.Name = "MedStock";
            this.MedStock.Size = new System.Drawing.Size(179, 27);
            this.MedStock.TabIndex = 0;
            this.MedStock.Text = "Medicine Stock";
            // 
            // MedName
            // 
            this.MedName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MedName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedName.ForeColor = System.Drawing.Color.Brown;
            this.MedName.HintForeColor = System.Drawing.Color.Empty;
            this.MedName.HintText = "";
            this.MedName.isPassword = false;
            this.MedName.LineFocusedColor = System.Drawing.Color.Brown;
            this.MedName.LineIdleColor = System.Drawing.Color.Gray;
            this.MedName.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.MedName.LineThickness = 3;
            this.MedName.Location = new System.Drawing.Point(68, 130);
            this.MedName.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.MedName.Name = "MedName";
            this.MedName.Size = new System.Drawing.Size(260, 39);
            this.MedName.TabIndex = 1;
            this.MedName.Text = "Medicine";
            this.MedName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTable.BackgroundColor = System.Drawing.Color.White;
            this.DTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.DTable.EnableHeadersVisualStyles = false;
            this.DTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DTable.Location = new System.Drawing.Point(585, 15);
            this.DTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DTable.Name = "DTable";
            this.DTable.RowHeadersVisible = false;
            this.DTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTable.Size = new System.Drawing.Size(597, 524);
            this.DTable.TabIndex = 2;
            this.DTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTable.ThemeStyle.HeaderStyle.Height = 18;
            this.DTable.ThemeStyle.ReadOnly = false;
            this.DTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Brown;
            this.DTable.ThemeStyle.RowsStyle.Height = 22;
            this.DTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Bprice
            // 
            this.Bprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Bprice.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bprice.ForeColor = System.Drawing.Color.Brown;
            this.Bprice.HintForeColor = System.Drawing.Color.Empty;
            this.Bprice.HintText = "";
            this.Bprice.isPassword = false;
            this.Bprice.LineFocusedColor = System.Drawing.Color.Brown;
            this.Bprice.LineIdleColor = System.Drawing.Color.Gray;
            this.Bprice.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.Bprice.LineThickness = 3;
            this.Bprice.Location = new System.Drawing.Point(407, 130);
            this.Bprice.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Bprice.Name = "Bprice";
            this.Bprice.Size = new System.Drawing.Size(167, 39);
            this.Bprice.TabIndex = 3;
            this.Bprice.Text = "BuyingPrice";
            this.Bprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Sprice
            // 
            this.Sprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Sprice.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sprice.ForeColor = System.Drawing.Color.Brown;
            this.Sprice.HintForeColor = System.Drawing.Color.Empty;
            this.Sprice.HintText = "";
            this.Sprice.isPassword = false;
            this.Sprice.LineFocusedColor = System.Drawing.Color.Brown;
            this.Sprice.LineIdleColor = System.Drawing.Color.Gray;
            this.Sprice.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.Sprice.LineThickness = 3;
            this.Sprice.Location = new System.Drawing.Point(407, 207);
            this.Sprice.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Sprice.Name = "Sprice";
            this.Sprice.Size = new System.Drawing.Size(167, 39);
            this.Sprice.TabIndex = 4;
            this.Sprice.Text = "SellingPrice";
            this.Sprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Qt
            // 
            this.Qt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Qt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qt.ForeColor = System.Drawing.Color.Brown;
            this.Qt.HintForeColor = System.Drawing.Color.Empty;
            this.Qt.HintText = "";
            this.Qt.isPassword = false;
            this.Qt.LineFocusedColor = System.Drawing.Color.Brown;
            this.Qt.LineIdleColor = System.Drawing.Color.Gray;
            this.Qt.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.Qt.LineThickness = 3;
            this.Qt.Location = new System.Drawing.Point(407, 293);
            this.Qt.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Qt.Name = "Qt";
            this.Qt.Size = new System.Drawing.Size(167, 39);
            this.Qt.TabIndex = 5;
            this.Qt.Text = "Quantity";
            this.Qt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DateTime
            // 
            this.DateTime.CheckedState.Parent = this.DateTime;
            this.DateTime.FillColor = System.Drawing.Color.Brown;
            this.DateTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTime.ForeColor = System.Drawing.Color.White;
            this.DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTime.HoverState.Parent = this.DateTime;
            this.DateTime.Location = new System.Drawing.Point(60, 217);
            this.DateTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTime.Name = "DateTime";
            this.DateTime.ShadowDecoration.Parent = this.DateTime;
            this.DateTime.Size = new System.Drawing.Size(268, 44);
            this.DateTime.TabIndex = 6;
            this.DateTime.Value = new System.DateTime(2021, 7, 13, 19, 49, 27, 777);
            // 
            // Backbttn
            // 
            this.Backbttn.BackColor = System.Drawing.SystemColors.Control;
            this.Backbttn.CheckedState.Parent = this.Backbttn;
            this.Backbttn.CustomImages.Parent = this.Backbttn;
            this.Backbttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Backbttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Backbttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Backbttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Backbttn.DisabledState.Parent = this.Backbttn;
            this.Backbttn.FillColor = System.Drawing.Color.Brown;
            this.Backbttn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbttn.ForeColor = System.Drawing.Color.White;
            this.Backbttn.HoverState.Parent = this.Backbttn;
            this.Backbttn.Location = new System.Drawing.Point(224, 496);
            this.Backbttn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Backbttn.Name = "Backbttn";
            this.Backbttn.ShadowDecoration.Parent = this.Backbttn;
            this.Backbttn.Size = new System.Drawing.Size(132, 43);
            this.Backbttn.TabIndex = 10;
            this.Backbttn.Text = "BACK";
            this.Backbttn.Click += new System.EventHandler(this.Backbttn_Click);
            // 
            // pharmacydbDataSet
            // 
            this.pharmacydbDataSet.DataSetName = "pharmacydbDataSet";
            this.pharmacydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stocktbBindingSource
            // 
            this.stocktbBindingSource.DataMember = "stocktb";
            this.stocktbBindingSource.DataSource = this.pharmacydbDataSet;
            // 
            // stocktbTableAdapter
            // 
            this.stocktbTableAdapter.ClearBeforeFill = true;
            // 
            // Addbttn
            // 
            this.Addbttn.BackColor = System.Drawing.SystemColors.Control;
            this.Addbttn.CheckedState.Parent = this.Addbttn;
            this.Addbttn.CustomImages.Parent = this.Addbttn;
            this.Addbttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Addbttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Addbttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Addbttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Addbttn.DisabledState.Parent = this.Addbttn;
            this.Addbttn.FillColor = System.Drawing.Color.Brown;
            this.Addbttn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbttn.ForeColor = System.Drawing.Color.White;
            this.Addbttn.HoverState.Parent = this.Addbttn;
            this.Addbttn.Location = new System.Drawing.Point(60, 428);
            this.Addbttn.Margin = new System.Windows.Forms.Padding(4);
            this.Addbttn.Name = "Addbttn";
            this.Addbttn.ShadowDecoration.Parent = this.Addbttn;
            this.Addbttn.Size = new System.Drawing.Size(132, 43);
            this.Addbttn.TabIndex = 11;
            this.Addbttn.Text = "ADD";
            this.Addbttn.Click += new System.EventHandler(this.Addbttn_Click);
            // 
            // Upbttn
            // 
            this.Upbttn.BackColor = System.Drawing.SystemColors.Control;
            this.Upbttn.CheckedState.Parent = this.Upbttn;
            this.Upbttn.CustomImages.Parent = this.Upbttn;
            this.Upbttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Upbttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Upbttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Upbttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Upbttn.DisabledState.Parent = this.Upbttn;
            this.Upbttn.FillColor = System.Drawing.Color.Brown;
            this.Upbttn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upbttn.ForeColor = System.Drawing.Color.White;
            this.Upbttn.HoverState.Parent = this.Upbttn;
            this.Upbttn.Location = new System.Drawing.Point(224, 428);
            this.Upbttn.Margin = new System.Windows.Forms.Padding(4);
            this.Upbttn.Name = "Upbttn";
            this.Upbttn.ShadowDecoration.Parent = this.Upbttn;
            this.Upbttn.Size = new System.Drawing.Size(132, 43);
            this.Upbttn.TabIndex = 12;
            this.Upbttn.Text = "UPDATE";
            this.Upbttn.Click += new System.EventHandler(this.Upbttn_Click);
            // 
            // Deletebttn
            // 
            this.Deletebttn.BackColor = System.Drawing.SystemColors.Control;
            this.Deletebttn.CheckedState.Parent = this.Deletebttn;
            this.Deletebttn.CustomImages.Parent = this.Deletebttn;
            this.Deletebttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Deletebttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Deletebttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Deletebttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Deletebttn.DisabledState.Parent = this.Deletebttn;
            this.Deletebttn.FillColor = System.Drawing.Color.Brown;
            this.Deletebttn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebttn.ForeColor = System.Drawing.Color.White;
            this.Deletebttn.HoverState.Parent = this.Deletebttn;
            this.Deletebttn.Location = new System.Drawing.Point(395, 428);
            this.Deletebttn.Margin = new System.Windows.Forms.Padding(4);
            this.Deletebttn.Name = "Deletebttn";
            this.Deletebttn.ShadowDecoration.Parent = this.Deletebttn;
            this.Deletebttn.Size = new System.Drawing.Size(132, 43);
            this.Deletebttn.TabIndex = 13;
            this.Deletebttn.Text = "DELETE";
            this.Deletebttn.Click += new System.EventHandler(this.Deletebttn_Click);
            // 
            // CompanyCombo
            // 
            this.CompanyCombo.BackColor = System.Drawing.Color.Transparent;
            this.CompanyCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CompanyCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CompanyCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CompanyCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CompanyCombo.FocusedState.Parent = this.CompanyCombo;
            this.CompanyCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CompanyCombo.ForeColor = System.Drawing.Color.Brown;
            this.CompanyCombo.HoverState.Parent = this.CompanyCombo;
            this.CompanyCombo.ItemHeight = 30;
            this.CompanyCombo.ItemsAppearance.Parent = this.CompanyCombo;
            this.CompanyCombo.Location = new System.Drawing.Point(68, 295);
            this.CompanyCombo.Name = "CompanyCombo";
            this.CompanyCombo.ShadowDecoration.Parent = this.CompanyCombo;
            this.CompanyCombo.Size = new System.Drawing.Size(260, 36);
            this.CompanyCombo.TabIndex = 14;
            // 
            // MedicineStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.CompanyCombo);
            this.Controls.Add(this.Deletebttn);
            this.Controls.Add(this.Upbttn);
            this.Controls.Add(this.Addbttn);
            this.Controls.Add(this.Backbttn);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.Qt);
            this.Controls.Add(this.Sprice);
            this.Controls.Add(this.Bprice);
            this.Controls.Add(this.DTable);
            this.Controls.Add(this.MedName);
            this.Controls.Add(this.MedStock);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Brown;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MedicineStock";
            this.Text = "MedicineStock";
            this.Load += new System.EventHandler(this.MedicineStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocktbBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel MedStock;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MedName;
        private Guna.UI2.WinForms.Guna2DataGridView DTable;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Bprice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Sprice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Qt;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTime;
        private Guna.UI2.WinForms.Guna2Button Backbttn;
        private pharmacydbDataSet pharmacydbDataSet;
        private System.Windows.Forms.BindingSource stocktbBindingSource;
        private pharmacydbDataSetTableAdapters.stocktbTableAdapter stocktbTableAdapter;
        private Guna.UI2.WinForms.Guna2Button Addbttn;
        private Guna.UI2.WinForms.Guna2Button Upbttn;
        private Guna.UI2.WinForms.Guna2Button Deletebttn;
        private Guna.UI2.WinForms.Guna2ComboBox CompanyCombo;
    }
}