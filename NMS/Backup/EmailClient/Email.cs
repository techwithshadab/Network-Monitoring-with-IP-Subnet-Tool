using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Windows.Forms;

namespace Networks
{
    public partial class Email : DevComponents.DotNetBar.Office2007Form 
    {
        MailMessage mail = new MailMessage();
        public Email()
        {
            InitializeComponent();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Networks.frmAddAttachment frm = new Networks.frmAddAttachment();
            frm.ShowDialog(this);
            if (frm.txtFile.Text.Trim() != "")
                listBox1.Items.Add(frm.txtFile.Text);
            frm.Dispose();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            try
            {
            using (MailMessage mailMessage = new MailMessage(new MailAddress(textBox1.Text),
           new MailAddress(textBox1.Text)))
            {
                mailMessage.Body = textBox5.Text;
                mailMessage.Subject = textBox4.Text;
                try
                {
                    SmtpClient SmtpServer = new SmtpClient();
                    SmtpServer.Credentials = new System.Net.NetworkCredential(textBox2.Text, textBox3.Text);
                    SmtpServer.Port = 587;
                    if (checkBox1.Checked == true)
                        try
                        {
                            SmtpServer.Host = "smtp.gmail.com";
                            SmtpServer.EnableSsl = true;
                        }
                        catch
                        {
                            SmtpServer.Host = "smtp.gmail.com";
                            SmtpServer.EnableSsl = true;
                        }
                    if (checkBox2.Checked == true)
                        try
                        {
                            SmtpServer.Host = "smtp.mail.yahoo.com";
                            SmtpServer.EnableSsl = false;
                        }
                        catch
                        {
                            SmtpServer.Host = "smtp.mail.yahoo.com";
                            SmtpServer.EnableSsl = false;
                        }
                    if (checkBox3.Checked == true)
                        try
                        {
                            SmtpServer.Host = "smtp.aol.com";
                            SmtpServer.EnableSsl = false;
                        }
                        catch
                        {
                            SmtpServer.Host = "smtp.aol.com";
                            SmtpServer.EnableSsl = false;
                        }
                    if (checkBox4.Checked == true)
                        try
                        {
                            SmtpServer.Credentials = new System.Net.NetworkCredential(textBox2.Text, textBox3.Text);
                            SmtpServer.Host = "smtp.live.com";
                            SmtpServer.EnableSsl = true;
                        }
                        catch
                        {
                            SmtpServer.Credentials = new System.Net.NetworkCredential(textBox2.Text, textBox3.Text);
                            SmtpServer.Host = "smtp.live.com";
                            SmtpServer.EnableSsl = true;
                        }
                    if (checkBox1.Checked && checkBox2.Checked == true)
                        try
                        {
                            MessageBox.Show("Please Choose Only One Email Client At A Time");
                        }
                        catch
                        {
                            MessageBox.Show("Please Choose Only One Email Client At A Time");
                        }
                    mail = new MailMessage();
                    String[] addr = textBox1.Text.Split(',');
                    mail.From = new MailAddress(textBox2.Text);
                    Byte i;
                    for (i = 0; i < addr.Length; i++)
                        mail.To.Add(addr[i]);
                    mail.Subject = textBox4.Text;
                    mail.Body = textBox5.Text;
                    if (listBox1.Items.Count != 0)
                    {
                        for (i = 0; i < listBox1.Items.Count; i++)
                            mail.Attachments.Add(new Attachment(listBox1.Items[i].ToString()));
                    }
                    mail.IsBodyHtml = true;
                    mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                    mail.ReplyTo = new MailAddress(textBox1.Text);
                    SmtpServer.Send(mail);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "EMail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "EMail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
        }

        private void Email_Load(object sender, EventArgs e)
        {
            this.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black;
        }

        private void groupPanel3_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            listBox1.Text = "";

        }

    }
}

