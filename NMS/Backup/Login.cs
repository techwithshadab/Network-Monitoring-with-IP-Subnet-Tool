using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Networks
{
    public partial class Login : DevComponents.DotNetBar.Office2007Form 
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black;

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUserName.Text=="admin" && TxtPassword.Text=="admin")
            {
                Main mn = new Main();
               mn.Show();
               Hide();
            }
            else
            {
                MessageBox.Show("Please Enter valid UserName or Password","Login",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void BtnClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }
    }
}
