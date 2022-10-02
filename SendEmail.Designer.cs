namespace SendEmail
{
    partial class SendEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendEmail));
            this.Email_label = new System.Windows.Forms.Label();
            this.EmailPassword_panel = new System.Windows.Forms.Panel();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Email_textBox = new System.Windows.Forms.TextBox();
            this.Password_label = new System.Windows.Forms.Label();
            this.Attachment_button = new System.Windows.Forms.Button();
            this.FormatingButtons_panel = new System.Windows.Forms.Panel();
            this.FontStyles_comboBox = new System.Windows.Forms.ComboBox();
            this.ColorPicker_button = new System.Windows.Forms.Button();
            this.UnderLine_button = new System.Windows.Forms.Button();
            this.Italicize_button = new System.Windows.Forms.Button();
            this.BoldText_button = new System.Windows.Forms.Button();
            this.Send_button = new System.Windows.Forms.Button();
            this.Buttons_panel = new System.Windows.Forms.Panel();
            this.Mail_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AttachmentList_panel = new System.Windows.Forms.Panel();
            this.Mail_richTextBox = new System.Windows.Forms.RichTextBox();
            this.To_textBox = new System.Windows.Forms.TextBox();
            this.To_label = new System.Windows.Forms.Label();
            this.Email_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Password_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.TargetEmail_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.EmptyMail_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Attachment_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.EmailPassword_panel.SuspendLayout();
            this.FormatingButtons_panel.SuspendLayout();
            this.Buttons_panel.SuspendLayout();
            this.Mail_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Email_errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password_errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetEmail_errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmptyMail_errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Email_label
            // 
            this.Email_label.AutoSize = true;
            this.Email_label.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Email_label.Location = new System.Drawing.Point(25, 9);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(77, 29);
            this.Email_label.TabIndex = 0;
            this.Email_label.Text = "E-Mail";
            // 
            // EmailPassword_panel
            // 
            this.EmailPassword_panel.AutoSize = true;
            this.EmailPassword_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EmailPassword_panel.BackColor = System.Drawing.Color.Transparent;
            this.EmailPassword_panel.Controls.Add(this.Password_textBox);
            this.EmailPassword_panel.Controls.Add(this.Email_textBox);
            this.EmailPassword_panel.Controls.Add(this.Password_label);
            this.EmailPassword_panel.Controls.Add(this.Email_label);
            this.EmailPassword_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmailPassword_panel.Location = new System.Drawing.Point(0, 0);
            this.EmailPassword_panel.Name = "EmailPassword_panel";
            this.EmailPassword_panel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.EmailPassword_panel.Size = new System.Drawing.Size(900, 90);
            this.EmailPassword_panel.TabIndex = 0;
            // 
            // Password_textBox
            // 
            this.Password_textBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password_textBox.Location = new System.Drawing.Point(138, 50);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.PlaceholderText = "Passsword Here";
            this.Password_textBox.Size = new System.Drawing.Size(289, 37);
            this.Password_textBox.TabIndex = 2;
            this.Password_textBox.UseSystemPasswordChar = true;
            this.Password_textBox.Leave += new System.EventHandler(this.Password_textBox_Leave);
            // 
            // Email_textBox
            // 
            this.Email_textBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Email_textBox.Location = new System.Drawing.Point(138, 6);
            this.Email_textBox.Name = "Email_textBox";
            this.Email_textBox.PlaceholderText = "Enter  Valid Email ";
            this.Email_textBox.Size = new System.Drawing.Size(289, 37);
            this.Email_textBox.TabIndex = 1;
            this.Email_textBox.Leave += new System.EventHandler(this.Email_textBox_Leave);
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Password_label.Location = new System.Drawing.Point(25, 53);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(111, 29);
            this.Password_label.TabIndex = 0;
            this.Password_label.Text = "Password";
            // 
            // Attachment_button
            // 
            this.Attachment_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Attachment_button.BackgroundImage = global::SendEmail.Properties.Resources.attach_file_FILL0_wght400_GRAD0_opsz48;
            this.Attachment_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Attachment_button.Location = new System.Drawing.Point(7, 7);
            this.Attachment_button.Name = "Attachment_button";
            this.Attachment_button.Size = new System.Drawing.Size(30, 30);
            this.Attachment_button.TabIndex = 8;
            this.Attachment_button.UseVisualStyleBackColor = true;
            this.Attachment_button.Click += new System.EventHandler(this.Attachment_button_Click);
            // 
            // FormatingButtons_panel
            // 
            this.FormatingButtons_panel.AutoSize = true;
            this.FormatingButtons_panel.BackColor = System.Drawing.Color.Transparent;
            this.FormatingButtons_panel.Controls.Add(this.FontStyles_comboBox);
            this.FormatingButtons_panel.Controls.Add(this.ColorPicker_button);
            this.FormatingButtons_panel.Controls.Add(this.UnderLine_button);
            this.FormatingButtons_panel.Controls.Add(this.Italicize_button);
            this.FormatingButtons_panel.Controls.Add(this.BoldText_button);
            this.FormatingButtons_panel.Controls.Add(this.Attachment_button);
            this.FormatingButtons_panel.Location = new System.Drawing.Point(3, 7);
            this.FormatingButtons_panel.Name = "FormatingButtons_panel";
            this.FormatingButtons_panel.Size = new System.Drawing.Size(308, 45);
            this.FormatingButtons_panel.TabIndex = 7;
            // 
            // FontStyles_comboBox
            // 
            this.FontStyles_comboBox.DropDownHeight = 90;
            this.FontStyles_comboBox.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FontStyles_comboBox.FormattingEnabled = true;
            this.FontStyles_comboBox.IntegralHeight = false;
            this.FontStyles_comboBox.ItemHeight = 21;
            this.FontStyles_comboBox.Location = new System.Drawing.Point(127, 8);
            this.FontStyles_comboBox.Name = "FontStyles_comboBox";
            this.FontStyles_comboBox.Size = new System.Drawing.Size(144, 29);
            this.FontStyles_comboBox.Sorted = true;
            this.FontStyles_comboBox.TabIndex = 12;
            this.FontStyles_comboBox.SelectedIndexChanged += new System.EventHandler(this.FontStyles_comboBox_SelectedIndexChanged);
            // 
            // ColorPicker_button
            // 
            this.ColorPicker_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ColorPicker_button.BackColor = System.Drawing.Color.Black;
            this.ColorPicker_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ColorPicker_button.Location = new System.Drawing.Point(271, 7);
            this.ColorPicker_button.Name = "ColorPicker_button";
            this.ColorPicker_button.Size = new System.Drawing.Size(30, 30);
            this.ColorPicker_button.TabIndex = 11;
            this.ColorPicker_button.UseVisualStyleBackColor = false;
            this.ColorPicker_button.Click += new System.EventHandler(this.ColorPicker_button_Click);
            // 
            // UnderLine_button
            // 
            this.UnderLine_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UnderLine_button.BackgroundImage = global::SendEmail.Properties.Resources.format_underlined_FILL0_wght400_GRAD0_opsz48;
            this.UnderLine_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UnderLine_button.Location = new System.Drawing.Point(97, 7);
            this.UnderLine_button.Name = "UnderLine_button";
            this.UnderLine_button.Size = new System.Drawing.Size(30, 30);
            this.UnderLine_button.TabIndex = 11;
            this.UnderLine_button.UseVisualStyleBackColor = true;
            this.UnderLine_button.Click += new System.EventHandler(this.UnderLine_button_Click);
            // 
            // Italicize_button
            // 
            this.Italicize_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Italicize_button.BackgroundImage = global::SendEmail.Properties.Resources.format_italic_FILL0_wght400_GRAD0_opsz48;
            this.Italicize_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Italicize_button.Location = new System.Drawing.Point(67, 7);
            this.Italicize_button.Name = "Italicize_button";
            this.Italicize_button.Size = new System.Drawing.Size(30, 30);
            this.Italicize_button.TabIndex = 10;
            this.Italicize_button.UseVisualStyleBackColor = true;
            this.Italicize_button.Click += new System.EventHandler(this.Italicize_button_Click);
            // 
            // BoldText_button
            // 
            this.BoldText_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BoldText_button.BackgroundImage = global::SendEmail.Properties.Resources.format_bold_FILL0_wght400_GRAD0_opsz48;
            this.BoldText_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BoldText_button.Location = new System.Drawing.Point(37, 7);
            this.BoldText_button.Name = "BoldText_button";
            this.BoldText_button.Size = new System.Drawing.Size(30, 30);
            this.BoldText_button.TabIndex = 9;
            this.BoldText_button.UseVisualStyleBackColor = true;
            this.BoldText_button.Click += new System.EventHandler(this.BoldText_button_Click);
            // 
            // Send_button
            // 
            this.Send_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Send_button.BackgroundImage = global::SendEmail.Properties.Resources.send_FILL0_wght400_GRAD0_opsz481;
            this.Send_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Send_button.Location = new System.Drawing.Point(311, 7);
            this.Send_button.Name = "Send_button";
            this.Send_button.Size = new System.Drawing.Size(45, 45);
            this.Send_button.TabIndex = 13;
            this.Send_button.UseVisualStyleBackColor = true;
            this.Send_button.Click += new System.EventHandler(this.Send_button_Click);
            // 
            // Buttons_panel
            // 
            this.Buttons_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Buttons_panel.BackColor = System.Drawing.Color.Transparent;
            this.Buttons_panel.Controls.Add(this.Send_button);
            this.Buttons_panel.Controls.Add(this.FormatingButtons_panel);
            this.Buttons_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Buttons_panel.Location = new System.Drawing.Point(0, 536);
            this.Buttons_panel.Name = "Buttons_panel";
            this.Buttons_panel.Size = new System.Drawing.Size(900, 55);
            this.Buttons_panel.TabIndex = 6;
            // 
            // Mail_panel
            // 
            this.Mail_panel.BackColor = System.Drawing.Color.Transparent;
            this.Mail_panel.Controls.Add(this.panel1);
            this.Mail_panel.Controls.Add(this.To_textBox);
            this.Mail_panel.Controls.Add(this.To_label);
            this.Mail_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mail_panel.Location = new System.Drawing.Point(0, 90);
            this.Mail_panel.Name = "Mail_panel";
            this.Mail_panel.Size = new System.Drawing.Size(900, 446);
            this.Mail_panel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.AttachmentList_panel);
            this.panel1.Controls.Add(this.Mail_richTextBox);
            this.panel1.Location = new System.Drawing.Point(11, 55);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(877, 373);
            this.panel1.TabIndex = 7;
            // 
            // AttachmentList_panel
            // 
            this.AttachmentList_panel.BackColor = System.Drawing.Color.Silver;
            this.AttachmentList_panel.BackgroundImage = global::SendEmail.Properties.Resources.attach_file_FILL0_wght400_GRAD0_opsz48;
            this.AttachmentList_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AttachmentList_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AttachmentList_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AttachmentList_panel.Location = new System.Drawing.Point(5, 308);
            this.AttachmentList_panel.Name = "AttachmentList_panel";
            this.AttachmentList_panel.Size = new System.Drawing.Size(867, 60);
            this.AttachmentList_panel.TabIndex = 7;
            // 
            // Mail_richTextBox
            // 
            this.Mail_richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mail_richTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Mail_richTextBox.Location = new System.Drawing.Point(5, 5);
            this.Mail_richTextBox.Name = "Mail_richTextBox";
            this.Mail_richTextBox.Size = new System.Drawing.Size(867, 363);
            this.Mail_richTextBox.TabIndex = 6;
            this.Mail_richTextBox.Text = "";
            // 
            // To_textBox
            // 
            this.To_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.To_textBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.To_textBox.Location = new System.Drawing.Point(60, 12);
            this.To_textBox.Name = "To_textBox";
            this.To_textBox.PlaceholderText = "Target Email";
            this.To_textBox.Size = new System.Drawing.Size(462, 37);
            this.To_textBox.TabIndex = 4;
            this.To_textBox.Leave += new System.EventHandler(this.To_textBox_Leave);
            // 
            // To_label
            // 
            this.To_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.To_label.AutoSize = true;
            this.To_label.BackColor = System.Drawing.Color.Transparent;
            this.To_label.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.To_label.Location = new System.Drawing.Point(11, 15);
            this.To_label.Name = "To_label";
            this.To_label.Size = new System.Drawing.Size(43, 29);
            this.To_label.TabIndex = 5;
            this.To_label.Text = "To:";
            // 
            // Email_errorProvider
            // 
            this.Email_errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Email_errorProvider.ContainerControl = this;
            this.Email_errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("Email_errorProvider.Icon")));
            // 
            // Password_errorProvider
            // 
            this.Password_errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Password_errorProvider.ContainerControl = this;
            this.Password_errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("Password_errorProvider.Icon")));
            // 
            // TargetEmail_errorProvider
            // 
            this.TargetEmail_errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.TargetEmail_errorProvider.ContainerControl = this;
            this.TargetEmail_errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("TargetEmail_errorProvider.Icon")));
            // 
            // EmptyMail_errorProvider
            // 
            this.EmptyMail_errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.EmptyMail_errorProvider.ContainerControl = this;
            this.EmptyMail_errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("EmptyMail_errorProvider.Icon")));
            // 
            // Attachment_openFileDialog
            // 
            this.Attachment_openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.Attachment_openFileDialog_FileOk);
            // 
            // SendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::SendEmail.Properties.Resources.sabri_tuzcu_BbY__DT0ou0_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 591);
            this.Controls.Add(this.Mail_panel);
            this.Controls.Add(this.Buttons_panel);
            this.Controls.Add(this.EmailPassword_panel);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SendEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Mail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SendEmail_Load);
            this.EmailPassword_panel.ResumeLayout(false);
            this.EmailPassword_panel.PerformLayout();
            this.FormatingButtons_panel.ResumeLayout(false);
            this.Buttons_panel.ResumeLayout(false);
            this.Buttons_panel.PerformLayout();
            this.Mail_panel.ResumeLayout(false);
            this.Mail_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Email_errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password_errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetEmail_errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmptyMail_errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Email_label;
        private Panel EmailPassword_panel;
        private Label Password_label;
        private TextBox Email_textBox;
        private TextBox Password_textBox;
        private Button Attachment_button;
        private Panel FormatingButtons_panel;
        private ComboBox FontStyles_comboBox;
        private Button UnderLine_button;
        private Button Italicize_button;
        private Button BoldText_button;
        private Button Send_button;
        private Panel Buttons_panel;
        private Panel Mail_panel;
        private TextBox To_textBox;
        private Label To_label;
        private ErrorProvider Email_errorProvider;
        private ErrorProvider Password_errorProvider;
        private ErrorProvider TargetEmail_errorProvider;
        private ErrorProvider EmptyMail_errorProvider;
        private Button ColorPicker_button;
        private ColorDialog colorDialog1;
        private RichTextBox Mail_richTextBox;
        private Panel panel1;
        private Panel AttachmentList_panel;
        private OpenFileDialog Attachment_openFileDialog;
    }
}