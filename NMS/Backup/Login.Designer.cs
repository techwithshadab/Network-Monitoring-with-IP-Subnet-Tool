namespace Networks
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
            this.GroupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.BtnClose = new System.Windows.Forms.LinkLabel();
            this.LabelX3 = new DevComponents.DotNetBar.LabelX();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelX2 = new DevComponents.DotNetBar.LabelX();
            this.LabelX1 = new DevComponents.DotNetBar.LabelX();
            this.TxtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BtnLogin = new DevComponents.DotNetBar.ButtonX();
            this.TxtUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.GroupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupPanel1
            // 
            this.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.GroupPanel1.Controls.Add(this.BtnClose);
            this.GroupPanel1.Controls.Add(this.LabelX3);
            this.GroupPanel1.Controls.Add(this.PictureBox1);
            this.GroupPanel1.Controls.Add(this.LabelX2);
            this.GroupPanel1.Controls.Add(this.LabelX1);
            this.GroupPanel1.Controls.Add(this.TxtPassword);
            this.GroupPanel1.Controls.Add(this.BtnLogin);
            this.GroupPanel1.Controls.Add(this.TxtUserName);
            this.GroupPanel1.Location = new System.Drawing.Point(12, 10);
            this.GroupPanel1.Name = "GroupPanel1";
            this.GroupPanel1.Size = new System.Drawing.Size(352, 192);
            // 
            // 
            // 
            this.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.GroupPanel1.Style.BackColorGradientAngle = 90;
            this.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel1.Style.BorderBottomWidth = 1;
            this.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel1.Style.BorderLeftWidth = 1;
            this.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel1.Style.BorderRightWidth = 1;
            this.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GroupPanel1.Style.BorderTopWidth = 1;
            this.GroupPanel1.Style.CornerDiameter = 4;
            this.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.GroupPanel1.TabIndex = 1;
            this.GroupPanel1.TitleImagePosition = DevComponents.DotNetBar.eTitleImagePosition.Center;
            // 
            // BtnClose
            // 
            this.BtnClose.AutoSize = true;
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.Location = new System.Drawing.Point(319, 173);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(24, 13);
            this.BtnClose.TabIndex = 7;
            this.BtnClose.TabStop = true;
            this.BtnClose.Text = "Exit";
            this.BtnClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BtnClose_LinkClicked);
            // 
            // LabelX3
            // 
            this.LabelX3.AutoSize = true;
            this.LabelX3.BackColor = System.Drawing.Color.Transparent;
            this.LabelX3.Location = new System.Drawing.Point(79, 21);
            this.LabelX3.Name = "LabelX3";
            this.LabelX3.Size = new System.Drawing.Size(248, 15);
            this.LabelX3.TabIndex = 6;
            this.LabelX3.Text = "Please Enter User Name and Password Pres login";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.Image = global::Networks.Properties.Resources.login;
            this.PictureBox1.Location = new System.Drawing.Point(3, 0);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(61, 59);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 5;
            this.PictureBox1.TabStop = false;
            // 
            // LabelX2
            // 
            this.LabelX2.AutoSize = true;
            this.LabelX2.BackColor = System.Drawing.Color.Transparent;
            this.LabelX2.Location = new System.Drawing.Point(80, 108);
            this.LabelX2.Name = "LabelX2";
            this.LabelX2.Size = new System.Drawing.Size(67, 15);
            this.LabelX2.TabIndex = 4;
            this.LabelX2.Text = "PASSWORD";
            // 
            // LabelX1
            // 
            this.LabelX1.AutoSize = true;
            this.LabelX1.BackColor = System.Drawing.Color.Transparent;
            this.LabelX1.Location = new System.Drawing.Point(79, 59);
            this.LabelX1.Name = "LabelX1";
            this.LabelX1.Size = new System.Drawing.Size(68, 15);
            this.LabelX1.TabIndex = 3;
            this.LabelX1.Text = "USER NAME";
            // 
            // TxtPassword
            // 
            // 
            // 
            // 
            this.TxtPassword.Border.Class = "TextBoxBorder";
            this.TxtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(174, 104);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(151, 32);
            this.TxtPassword.TabIndex = 1;
            // 
            // BtnLogin
            // 
            this.BtnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnLogin.Location = new System.Drawing.Point(207, 151);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtUserName
            // 
            // 
            // 
            // 
            this.TxtUserName.Border.Class = "TextBoxBorder";
            this.TxtUserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.TxtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserName.Location = new System.Drawing.Point(174, 58);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(151, 32);
            this.TxtUserName.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 213);
            this.Controls.Add(this.GroupPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.GroupPanel1.ResumeLayout(false);
            this.GroupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal DevComponents.DotNetBar.Controls.GroupPanel GroupPanel1;
        internal System.Windows.Forms.LinkLabel BtnClose;
        internal DevComponents.DotNetBar.LabelX LabelX3;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal DevComponents.DotNetBar.LabelX LabelX2;
        internal DevComponents.DotNetBar.LabelX LabelX1;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtPassword;
        internal DevComponents.DotNetBar.ButtonX BtnLogin;
        internal DevComponents.DotNetBar.Controls.TextBoxX TxtUserName;
    }
}