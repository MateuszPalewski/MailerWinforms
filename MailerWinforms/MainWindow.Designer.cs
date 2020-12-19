namespace MailerWinforms
{
    partial class MainWindow
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
            this.listBoxMailAdresses = new System.Windows.Forms.ListBox();
            this.textBoxAddresses = new System.Windows.Forms.TextBox();
            this.buttonAddAddress = new System.Windows.Forms.Button();
            this.listBoxAttachments = new System.Windows.Forms.ListBox();
            this.groupBoxAddresses = new System.Windows.Forms.GroupBox();
            this.groupBoxAttachment = new System.Windows.Forms.GroupBox();
            this.buttonAttachments = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxMessage = new System.Windows.Forms.GroupBox();
            this.checkBoxIsHTML = new System.Windows.Forms.CheckBox();
            this.buttonSendMessage = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelTopic = new System.Windows.Forms.Label();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.textBoxTopic = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.groupBoxAddresses.SuspendLayout();
            this.groupBoxAttachment.SuspendLayout();
            this.groupBoxMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxMailAdresses
            // 
            this.listBoxMailAdresses.FormattingEnabled = true;
            this.listBoxMailAdresses.Location = new System.Drawing.Point(6, 19);
            this.listBoxMailAdresses.Name = "listBoxMailAdresses";
            this.listBoxMailAdresses.Size = new System.Drawing.Size(241, 459);
            this.listBoxMailAdresses.TabIndex = 0;
            // 
            // textBoxAddresses
            // 
            this.textBoxAddresses.Location = new System.Drawing.Point(6, 509);
            this.textBoxAddresses.Name = "textBoxAddresses";
            this.textBoxAddresses.Size = new System.Drawing.Size(241, 20);
            this.textBoxAddresses.TabIndex = 1;
            // 
            // buttonAddAddress
            // 
            this.buttonAddAddress.Location = new System.Drawing.Point(6, 540);
            this.buttonAddAddress.Name = "buttonAddAddress";
            this.buttonAddAddress.Size = new System.Drawing.Size(241, 58);
            this.buttonAddAddress.TabIndex = 2;
            this.buttonAddAddress.Text = "Dodaj";
            this.buttonAddAddress.UseVisualStyleBackColor = true;
            this.buttonAddAddress.Click += new System.EventHandler(this.buttonAddAddress_Click);
            // 
            // listBoxAttachments
            // 
            this.listBoxAttachments.FormattingEnabled = true;
            this.listBoxAttachments.Location = new System.Drawing.Point(6, 19);
            this.listBoxAttachments.Name = "listBoxAttachments";
            this.listBoxAttachments.Size = new System.Drawing.Size(247, 511);
            this.listBoxAttachments.TabIndex = 3;
            // 
            // groupBoxAddresses
            // 
            this.groupBoxAddresses.Controls.Add(this.listBoxMailAdresses);
            this.groupBoxAddresses.Controls.Add(this.textBoxAddresses);
            this.groupBoxAddresses.Controls.Add(this.buttonAddAddress);
            this.groupBoxAddresses.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAddresses.Name = "groupBoxAddresses";
            this.groupBoxAddresses.Size = new System.Drawing.Size(263, 604);
            this.groupBoxAddresses.TabIndex = 4;
            this.groupBoxAddresses.TabStop = false;
            this.groupBoxAddresses.Text = "Lista adresów";
            // 
            // groupBoxAttachment
            // 
            this.groupBoxAttachment.Controls.Add(this.buttonAttachments);
            this.groupBoxAttachment.Controls.Add(this.listBoxAttachments);
            this.groupBoxAttachment.Location = new System.Drawing.Point(281, 12);
            this.groupBoxAttachment.Name = "groupBoxAttachment";
            this.groupBoxAttachment.Size = new System.Drawing.Size(271, 615);
            this.groupBoxAttachment.TabIndex = 5;
            this.groupBoxAttachment.TabStop = false;
            this.groupBoxAttachment.Text = "Załączniki";
            // 
            // buttonAttachments
            // 
            this.buttonAttachments.Location = new System.Drawing.Point(17, 540);
            this.buttonAttachments.Name = "buttonAttachments";
            this.buttonAttachments.Size = new System.Drawing.Size(236, 57);
            this.buttonAttachments.TabIndex = 4;
            this.buttonAttachments.Text = "Dodaj plik";
            this.buttonAttachments.UseVisualStyleBackColor = true;
            this.buttonAttachments.Click += new System.EventHandler(this.buttonAttachments_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // groupBoxMessage
            // 
            this.groupBoxMessage.Controls.Add(this.labelPassword);
            this.groupBoxMessage.Controls.Add(this.labelLogin);
            this.groupBoxMessage.Controls.Add(this.textBoxPassword);
            this.groupBoxMessage.Controls.Add(this.textBoxLogin);
            this.groupBoxMessage.Controls.Add(this.checkBoxIsHTML);
            this.groupBoxMessage.Controls.Add(this.buttonSendMessage);
            this.groupBoxMessage.Controls.Add(this.labelMessage);
            this.groupBoxMessage.Controls.Add(this.labelTopic);
            this.groupBoxMessage.Controls.Add(this.richTextBoxMessage);
            this.groupBoxMessage.Controls.Add(this.textBoxTopic);
            this.groupBoxMessage.Location = new System.Drawing.Point(559, 13);
            this.groupBoxMessage.Name = "groupBoxMessage";
            this.groupBoxMessage.Size = new System.Drawing.Size(657, 603);
            this.groupBoxMessage.TabIndex = 6;
            this.groupBoxMessage.TabStop = false;
            this.groupBoxMessage.Text = "Wiadomość";
            // 
            // checkBoxIsHTML
            // 
            this.checkBoxIsHTML.AutoSize = true;
            this.checkBoxIsHTML.Location = new System.Drawing.Point(10, 539);
            this.checkBoxIsHTML.Name = "checkBoxIsHTML";
            this.checkBoxIsHTML.Size = new System.Drawing.Size(115, 17);
            this.checkBoxIsHTML.TabIndex = 5;
            this.checkBoxIsHTML.Text = "Wiadomość HTML";
            this.checkBoxIsHTML.UseVisualStyleBackColor = true;
            // 
            // buttonSendMessage
            // 
            this.buttonSendMessage.Location = new System.Drawing.Point(522, 539);
            this.buttonSendMessage.Name = "buttonSendMessage";
            this.buttonSendMessage.Size = new System.Drawing.Size(129, 58);
            this.buttonSendMessage.TabIndex = 4;
            this.buttonSendMessage.Text = "Wyślij";
            this.buttonSendMessage.UseVisualStyleBackColor = true;
            this.buttonSendMessage.Click += new System.EventHandler(this.buttonSendMessage_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(7, 60);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(37, 13);
            this.labelMessage.TabIndex = 3;
            this.labelMessage.Text = "Treść:";
            // 
            // labelTopic
            // 
            this.labelTopic.AutoSize = true;
            this.labelTopic.Location = new System.Drawing.Point(6, 18);
            this.labelTopic.Name = "labelTopic";
            this.labelTopic.Size = new System.Drawing.Size(40, 13);
            this.labelTopic.TabIndex = 2;
            this.labelTopic.Text = "Temat:";
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.Location = new System.Drawing.Point(6, 76);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.Size = new System.Drawing.Size(645, 453);
            this.richTextBoxMessage.TabIndex = 1;
            this.richTextBoxMessage.Text = "";
            // 
            // textBoxTopic
            // 
            this.textBoxTopic.Location = new System.Drawing.Point(6, 33);
            this.textBoxTopic.Name = "textBoxTopic";
            this.textBoxTopic.Size = new System.Drawing.Size(645, 20);
            this.textBoxTopic.TabIndex = 0;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(274, 539);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(214, 20);
            this.textBoxLogin.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(274, 576);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(214, 20);
            this.textBoxPassword.TabIndex = 7;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(208, 543);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(33, 13);
            this.labelLogin.TabIndex = 8;
            this.labelLogin.Text = "Login";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(208, 583);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(36, 13);
            this.labelPassword.TabIndex = 9;
            this.labelPassword.Text = "Hasło";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 628);
            this.Controls.Add(this.groupBoxMessage);
            this.Controls.Add(this.groupBoxAttachment);
            this.Controls.Add(this.groupBoxAddresses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mailer";
            this.groupBoxAddresses.ResumeLayout(false);
            this.groupBoxAddresses.PerformLayout();
            this.groupBoxAttachment.ResumeLayout(false);
            this.groupBoxMessage.ResumeLayout(false);
            this.groupBoxMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMailAdresses;
        private System.Windows.Forms.TextBox textBoxAddresses;
        private System.Windows.Forms.Button buttonAddAddress;
        private System.Windows.Forms.ListBox listBoxAttachments;
        private System.Windows.Forms.GroupBox groupBoxAddresses;
        private System.Windows.Forms.GroupBox groupBoxAttachment;
        private System.Windows.Forms.Button buttonAttachments;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBoxMessage;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private System.Windows.Forms.TextBox textBoxTopic;
        private System.Windows.Forms.Label labelTopic;
        private System.Windows.Forms.CheckBox checkBoxIsHTML;
        private System.Windows.Forms.Button buttonSendMessage;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
    }
}

