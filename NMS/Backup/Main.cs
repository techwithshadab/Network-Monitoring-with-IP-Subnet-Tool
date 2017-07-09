using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Networks
{
    public partial class Main : DevComponents.DotNetBar.Office2007RibbonForm 
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BtnIPCalc_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            MainForm mm = new MainForm();
            mm.MdiParent = this;
            mm.Show();
        }

        private void BtnEmailClient_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            Email eclient = new Email();
            eclient.MdiParent = this;
            eclient.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnSystemRes_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            Form1 frm = new Form1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnRemoteDesktop_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
                RemoteDesktop RM = new RemoteDesktop();
                RM.ShowDialog();
            
        }  
    }
}
