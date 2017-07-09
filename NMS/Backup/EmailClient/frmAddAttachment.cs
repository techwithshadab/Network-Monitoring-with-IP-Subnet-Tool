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
    public partial class frmAddAttachment : DevComponents.DotNetBar.Office2007Form 
    {
        public frmAddAttachment()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            dlg.ShowDialog();
            txtFile.Text = dlg.FileName;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtFile.Text = "";
            this.Hide();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmAddAttachment_Load(object sender, EventArgs e)
        {
            this.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black ;
        }
    }
}
