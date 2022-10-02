using System.Text.RegularExpressions;

namespace SendEmail
{
    public partial class SendEmail : Form
    {
        public SendEmail()
        {
            InitializeComponent();
        }
        string EMailValidationStirng = @"^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$";
        int vertical = 5;
        int horizontal = 5;
        private void SendEmail_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                FontStyles_comboBox.Items.Add(font.Name.ToString());
            }
            Mail_richTextBox.Font = new Font(FontStyles_comboBox.Text, Mail_richTextBox.Font.Size);
            FontStyles_comboBox.Text = "Calibri";
            ColorPicker_button.BackColor = Mail_richTextBox.ForeColor;
        }

        private void Email_textBox_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(Email_textBox.Text, EMailValidationStirng))
            {
                Email_errorProvider.Icon = Properties.Resources.close_FILL0_wght400_GRAD0_opsz48;
                Email_errorProvider.SetError(Email_textBox, "Enter a valid E-Mail.");
            }
            else
            {
                Email_errorProvider.Icon = Properties.Resources.done_FILL0_wght400_GRAD0_opsz48;
                Email_errorProvider.SetError(Email_textBox, "Done");
            }
        }

        private void Password_textBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Password_textBox.Text))
            {
                Password_errorProvider.Icon = Properties.Resources.close_FILL0_wght400_GRAD0_opsz48;
                Password_errorProvider.SetError(Password_textBox, "Enter a valid E-Mail.");
            }
            else
            {
                Password_errorProvider.Icon = Properties.Resources.done_FILL0_wght400_GRAD0_opsz48;
                Password_errorProvider.SetError(Password_textBox, "Done");
            }
        }

        private void To_textBox_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(To_textBox.Text, EMailValidationStirng))
            {
                TargetEmail_errorProvider.Icon = Properties.Resources.close_FILL0_wght400_GRAD0_opsz48;
                TargetEmail_errorProvider.SetError(To_textBox, "Enter a valid E-Mail.");
            }
            else
            {
                TargetEmail_errorProvider.Icon = Properties.Resources.done_FILL0_wght400_GRAD0_opsz48;
                TargetEmail_errorProvider.SetError(To_textBox, "Done");
            }
        }

        private void BoldText_button_Click(object sender, EventArgs e)
        {
            Font SelectedText = Mail_richTextBox.SelectionFont;
            if (SelectedText != null)
            {
                Mail_richTextBox.SelectionFont = new Font(SelectedText, SelectedText.Style ^ FontStyle.Bold);
            }
            else if (!Mail_richTextBox.Font.Bold)
            {
                Mail_richTextBox.Font = new Font(Mail_richTextBox.Font.Name, Mail_richTextBox.Font.Size, FontStyle.Bold);
            }
            else
            {
                Mail_richTextBox.Font = new Font(Mail_richTextBox.Font.Name, Mail_richTextBox.Font.Size);
            }
        }

        private void Send_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Mail_richTextBox.Text))
            {
                EmptyMail_errorProvider.Icon = Properties.Resources.close_FILL0_wght400_GRAD0_opsz48;
                EmptyMail_errorProvider.SetError(Send_button, "Enter some content in the mail.");
            }
            else
            {
                EmptyMail_errorProvider.Clear();
            }
        }

        private void ColorPicker_button_Click(object sender, EventArgs e)
        {
            Color color;
            Font SelectedText = Mail_richTextBox.SelectionFont;
            if (SelectedText != null && colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
                Mail_richTextBox.SelectionColor = color;
                ColorPicker_button.BackColor = color;
            }
            else if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
                Mail_richTextBox.ForeColor = color;
                ColorPicker_button.BackColor = color;
            }
        }

        private void Italicize_button_Click(object sender, EventArgs e)
        {
            Font SelectedText = Mail_richTextBox.SelectionFont;
            if (SelectedText != null)
            {
                Mail_richTextBox.SelectionFont = new Font(SelectedText, SelectedText.Style ^ FontStyle.Italic);
            }
            else if (!Mail_richTextBox.Font.Bold)
            {
                Mail_richTextBox.Font = new Font(Mail_richTextBox.Font.Name, Mail_richTextBox.Font.Size, FontStyle.Italic);
            }
            else
            {
                Mail_richTextBox.Font = new Font(Mail_richTextBox.Font.Name, Mail_richTextBox.Font.Size);
            }
        }

        private void UnderLine_button_Click(object sender, EventArgs e)
        {
            Font SelectedText = Mail_richTextBox.SelectionFont;
            if (SelectedText != null)
            {
                Mail_richTextBox.SelectionFont = new Font(SelectedText, SelectedText.Style ^ FontStyle.Underline);
            }
            else if (!Mail_richTextBox.Font.Bold)
            {
                Mail_richTextBox.Font = new Font(Mail_richTextBox.Font.Name, Mail_richTextBox.Font.Size, FontStyle.Underline);
            }
            else
            {
                Mail_richTextBox.Font = new Font(Mail_richTextBox.Font.Name, Mail_richTextBox.Font.Size);
            }
        }

        private void FontStyles_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mail_richTextBox.Font = new Font(FontStyles_comboBox.Text, Mail_richTextBox.Font.Size);
            FontStyles_comboBox.Text = Mail_richTextBox.Font.Name.ToString();
        }

        private void Attachment_button_Click(object sender, EventArgs e)
        {
            Attachment_openFileDialog.ShowDialog();
        }

        private void Attachment_openFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            foreach (String file in Attachment_openFileDialog.FileNames)
            {
                Label lbl = new Label();
                lbl.Height = 50;
                lbl.Width = 55;
                lbl.BorderStyle = BorderStyle.Fixed3D;
                lbl.BackgroundImage = Properties.Resources.check_circle_FILL0_wght400_GRAD0_opsz48;
                lbl.Location = new Point(horizontal, vertical);
                horizontal += 60;
                lbl.BackgroundImageLayout = ImageLayout.Stretch;
                lbl.BackColor = Color.Transparent;
                AttachmentList_panel.Controls.Add(lbl);
            }
        }
    }
}