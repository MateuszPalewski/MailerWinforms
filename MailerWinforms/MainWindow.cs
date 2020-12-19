using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailerWinforms
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Dodaj adresata do listy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddAddress_Click(object sender, EventArgs e)
        {
            if(textBoxAddresses.Text.Length > 0)
                listBoxMailAdresses.Items.Add(textBoxAddresses.Text);

        }

        /// <summary>
        /// Dodaj nazwę załącznika do listy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAttachments_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    
                }
            }
            listBoxAttachments.Items.Add(filePath);
        }

        
        /// <summary>
        /// Wysłanie wiadomości
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSendMessage_Click(object sender, EventArgs e)
        {
            bool isHtml = checkBoxIsHTML.Checked;
            string topicText = textBoxTopic.Text;
            string messageText = richTextBoxMessage.Text;
            List<string> mailList = new List<string>();

            
            foreach (object x in listBoxMailAdresses.Items)
            {
                mailList.Add(x.ToString()); //wyciąga po kolei liste
            }

            if (topicText.Length == 0 || messageText.Length == 0)
            {
                MessageBox.Show("Brak tematu/wiadomości.", "Błąd", MessageBoxButtons.OK);
                return; //przerwanie metody
            }
            if (mailList.Count == 0)
            {
                MessageBox.Show("Brak adresatów.", "Błąd", MessageBoxButtons.OK);
                return; //przerwanie metody
            }




            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("18903@student.pwsz.elblag.pl");
            foreach (string x in mailList)
            {
                mailMessage.To.Add(x);
            }
            mailMessage.Subject = topicText;
            mailMessage.Body = messageText;
            mailMessage.IsBodyHtml = isHtml;


            foreach (string x in listBoxAttachments.Items)
            {
                Attachment data = new Attachment(x, MediaTypeNames.Application.Octet);
                ContentDisposition disposition = data.ContentDisposition;
                disposition.CreationDate = System.IO.File.GetCreationTime(x);
                disposition.ModificationDate = System.IO.File.GetLastWriteTime(x);
                disposition.ReadDate = System.IO.File.GetLastAccessTime(x);
                mailMessage.Attachments.Add(data);
            }


            SmtpClient SmtpServer = new SmtpClient("poczta.pwsz.elblag.pl");
            SmtpServer.Port = 587;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new System.Net.NetworkCredential(textBoxLogin.Text, textBoxPassword.Text);
            SmtpServer.EnableSsl = true;

            try
            {
                SmtpServer.Send(mailMessage);
                MessageBox.Show("Wiadomość wysłana.", "Sukces", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Coś poszło nie tak, wiadomość nie została wysłana", "Błąd", MessageBoxButtons.OK);
            }



            

        }
        
    }
}
