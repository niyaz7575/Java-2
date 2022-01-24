
namespace PharmacyManagementSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.Username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Cross = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(105, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.Snow;
            this.Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Username.ForeColor = System.Drawing.Color.Brown;
            this.Username.HintForeColor = System.Drawing.Color.Empty;
            this.Username.HintText = "";
            this.Username.isPassword = false;
            this.Username.LineFocusedColor = System.Drawing.Color.Brown;
            this.Username.LineIdleColor = System.Drawing.Color.Gray;
            this.Username.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.Username.LineThickness = 3;
            this.Username.Location = new System.Drawing.Point(56, 113);
            this.Username.Margin = new System.Windows.Forms.Padding(4);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(205, 33);
            this.Username.TabIndex = 1;
            this.Username.Text = "User ID";
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Username.OnValueChanged += new System.EventHandler(this.Username_OnValueChanged);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.Snow;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Password.ForeColor = System.Drawing.Color.Brown;
            this.Password.HintForeColor = System.Drawing.Color.Empty;
            this.Password.HintText = "";
            this.Password.isPassword = true;
            this.Password.LineFocusedColor = System.Drawing.Color.Brown;
            this.Password.LineIdleColor = System.Drawing.Color.Gray;
            this.Password.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.Password.LineThickness = 3;
            this.Password.Location = new System.Drawing.Point(56, 180);
            this.Password.Margin = new System.Windows.Forms.Padding(4);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(205, 33);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Brown;
            this.guna2Button1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(56, 277);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(205, 45);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "LOGIN";
            this.guna2Button1.Click += new System.EventHandler(this.Guna2Button1_Click);
            // 
            // Cross
            // 
            this.Cross.AutoSize = true;
            this.Cross.BackColor = System.Drawing.Color.Transparent;
            this.Cross.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cross.ForeColor = System.Drawing.Color.Red;
            this.Cross.Location = new System.Drawing.Point(269, 9);
            this.Cross.Name = "Cross";
            this.Cross.Size = new System.Drawing.Size(41, 38);
            this.Cross.TabIndex = 4;
            this.Cross.Text = "X";
            this.Cross.Click += new System.EventHandler(this.Cross_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(322, 395);
            this.Controls.Add(this.Cross);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Username;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Password;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label Cross;
    }
}