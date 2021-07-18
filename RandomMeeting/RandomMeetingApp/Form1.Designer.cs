
namespace RandomMeetingApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CSVFileInput = new System.Windows.Forms.TextBox();
            this.OpenCSVFileButton = new System.Windows.Forms.Button();
            this.participantLabel = new System.Windows.Forms.Label();
            this.topicLabel = new System.Windows.Forms.Label();
            this.ThemeNmOutput = new System.Windows.Forms.TextBox();
            this.topicCountLabel = new System.Windows.Forms.Label();
            this.participantCountLabel = new System.Windows.Forms.Label();
            this.ParticipantsNmOutput = new System.Windows.Forms.TextBox();
            this.ThemeInput = new System.Windows.Forms.TextBox();
            this.AddTopicButton = new System.Windows.Forms.Button();
            this.GenerateGroupsButton = new System.Windows.Forms.Button();
            this.emailadressLabel = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.Label();
            this.SubjectText = new System.Windows.Forms.Label();
            this.MessageInput = new System.Windows.Forms.RichTextBox();
            this.MessageText = new System.Windows.Forms.Label();
            this.SendMailButton = new System.Windows.Forms.Button();
            this.groupLabel = new System.Windows.Forms.Label();
            this.NameList = new System.Windows.Forms.ListBox();
            this.EmailList = new System.Windows.Forms.ListBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.UserEmail = new System.Windows.Forms.TextBox();
            this.UserPassword = new System.Windows.Forms.TextBox();
            this.SubjectInput = new System.Windows.Forms.TextBox();
            this.DateStartPicker = new System.Windows.Forms.DateTimePicker();
            this.TopicListbox = new System.Windows.Forms.ListBox();
            this.contextMenuStripTopic = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.durationTimer = new System.Windows.Forms.ComboBox();
            this.durationLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialogFile = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.calendarPicturebox = new System.Windows.Forms.PictureBox();
            this.emailPicturebox = new System.Windows.Forms.PictureBox();
            this.passwordPicturebox = new System.Windows.Forms.PictureBox();
            this.dateEndPicturebox = new System.Windows.Forms.PictureBox();
            this.topicPicturebox = new System.Windows.Forms.PictureBox();
            this.RandomGroupsOutput = new System.Windows.Forms.ListBox();
            this.selectPictureBox = new System.Windows.Forms.PictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox8 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox9 = new FontAwesome.Sharp.IconPictureBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.contextMenuStripTopic.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // CSVFileInput
            // 
            this.CSVFileInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CSVFileInput.CausesValidation = false;
            this.CSVFileInput.Cursor = System.Windows.Forms.Cursors.No;
            this.CSVFileInput.ForeColor = System.Drawing.SystemColors.GrayText;
            this.CSVFileInput.Location = new System.Drawing.Point(184, 33);
            this.CSVFileInput.Name = "CSVFileInput";
            this.CSVFileInput.PlaceholderText = "Select a *.csv file.";
            this.CSVFileInput.ReadOnly = true;
            this.CSVFileInput.Size = new System.Drawing.Size(119, 15);
            this.CSVFileInput.TabIndex = 2;
            this.CSVFileInput.Click += new System.EventHandler(this.OpenCSVFileButton_Click);
            this.CSVFileInput.TextChanged += new System.EventHandler(this.CSVFileInput_TextChanged);
            // 
            // OpenCSVFileButton
            // 
            this.OpenCSVFileButton.BackColor = System.Drawing.Color.GhostWhite;
            this.OpenCSVFileButton.Location = new System.Drawing.Point(26, 22);
            this.OpenCSVFileButton.Name = "OpenCSVFileButton";
            this.OpenCSVFileButton.Size = new System.Drawing.Size(93, 34);
            this.OpenCSVFileButton.TabIndex = 1;
            this.OpenCSVFileButton.Text = "Browse..";
            this.OpenCSVFileButton.UseVisualStyleBackColor = false;
            this.OpenCSVFileButton.Click += new System.EventHandler(this.OpenCSVFileButton_Click);
            this.OpenCSVFileButton.MouseLeave += new System.EventHandler(this.OpenCSVFileButton_MouseLeave);
            this.OpenCSVFileButton.MouseHover += new System.EventHandler(this.OpenCSVFileButton_MouseHover);
            // 
            // participantLabel
            // 
            this.participantLabel.AutoSize = true;
            this.participantLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.participantLabel.Location = new System.Drawing.Point(100, 66);
            this.participantLabel.Name = "participantLabel";
            this.participantLabel.Size = new System.Drawing.Size(91, 21);
            this.participantLabel.TabIndex = 5;
            this.participantLabel.Text = "Participants";
            this.participantLabel.Visible = false;
            // 
            // topicLabel
            // 
            this.topicLabel.AutoSize = true;
            this.topicLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.topicLabel.Location = new System.Drawing.Point(382, 66);
            this.topicLabel.Name = "topicLabel";
            this.topicLabel.Size = new System.Drawing.Size(87, 21);
            this.topicLabel.TabIndex = 6;
            this.topicLabel.Text = "Topic input";
            this.topicLabel.Visible = false;
            // 
            // ThemeNmOutput
            // 
            this.ThemeNmOutput.Location = new System.Drawing.Point(365, 409);
            this.ThemeNmOutput.Name = "ThemeNmOutput";
            this.ThemeNmOutput.PlaceholderText = "0";
            this.ThemeNmOutput.ReadOnly = true;
            this.ThemeNmOutput.Size = new System.Drawing.Size(41, 22);
            this.ThemeNmOutput.TabIndex = 8;
            this.ThemeNmOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ThemeNmOutput.Visible = false;
            this.ThemeNmOutput.TextChanged += new System.EventHandler(this.ThemeNmOutput_TextChanged);
            this.ThemeNmOutput.MouseHover += new System.EventHandler(this.ThemeNmOutput_MouseHover);
            // 
            // topicCountLabel
            // 
            this.topicCountLabel.AutoSize = true;
            this.topicCountLabel.Location = new System.Drawing.Point(235, 412);
            this.topicCountLabel.Name = "topicCountLabel";
            this.topicCountLabel.Size = new System.Drawing.Size(98, 13);
            this.topicCountLabel.TabIndex = 9;
            this.topicCountLabel.Text = "number of topics:";
            this.topicCountLabel.Visible = false;
            // 
            // participantCountLabel
            // 
            this.participantCountLabel.AutoSize = true;
            this.participantCountLabel.Location = new System.Drawing.Point(267, 370);
            this.participantCountLabel.Name = "participantCountLabel";
            this.participantCountLabel.Size = new System.Drawing.Size(68, 13);
            this.participantCountLabel.TabIndex = 10;
            this.participantCountLabel.Text = "attendance:";
            this.participantCountLabel.Visible = false;
            // 
            // ParticipantsNmOutput
            // 
            this.ParticipantsNmOutput.Location = new System.Drawing.Point(365, 370);
            this.ParticipantsNmOutput.Name = "ParticipantsNmOutput";
            this.ParticipantsNmOutput.PlaceholderText = "0";
            this.ParticipantsNmOutput.ReadOnly = true;
            this.ParticipantsNmOutput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ParticipantsNmOutput.Size = new System.Drawing.Size(41, 22);
            this.ParticipantsNmOutput.TabIndex = 11;
            this.ParticipantsNmOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ParticipantsNmOutput.Visible = false;
            // 
            // ThemeInput
            // 
            this.ThemeInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ThemeInput.Location = new System.Drawing.Point(365, 113);
            this.ThemeInput.Name = "ThemeInput";
            this.ThemeInput.PlaceholderText = "Enter topic here..";
            this.ThemeInput.Size = new System.Drawing.Size(157, 15);
            this.ThemeInput.TabIndex = 3;
            this.ThemeInput.Visible = false;
            this.ThemeInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ThemeInput_KeyDown);
            this.ThemeInput.MouseLeave += new System.EventHandler(this.ThemeInput_MouseLeave);
            this.ThemeInput.MouseHover += new System.EventHandler(this.ThemeInput_MouseHover);
            // 
            // AddTopicButton
            // 
            this.AddTopicButton.Location = new System.Drawing.Point(534, 107);
            this.AddTopicButton.Name = "AddTopicButton";
            this.AddTopicButton.Size = new System.Drawing.Size(66, 25);
            this.AddTopicButton.TabIndex = 4;
            this.AddTopicButton.Text = "Add";
            this.AddTopicButton.UseVisualStyleBackColor = true;
            this.AddTopicButton.Visible = false;
            this.AddTopicButton.Click += new System.EventHandler(this.AddTopicButton_Click);
            this.AddTopicButton.MouseLeave += new System.EventHandler(this.AddTopicButton_MouseLeave);
            this.AddTopicButton.MouseHover += new System.EventHandler(this.AddTopicButton_MouseHover);
            // 
            // GenerateGroupsButton
            // 
            this.GenerateGroupsButton.Location = new System.Drawing.Point(492, 371);
            this.GenerateGroupsButton.Name = "GenerateGroupsButton";
            this.GenerateGroupsButton.Size = new System.Drawing.Size(108, 60);
            this.GenerateGroupsButton.TabIndex = 6;
            this.GenerateGroupsButton.Text = "Generate Groups";
            this.GenerateGroupsButton.UseVisualStyleBackColor = true;
            this.GenerateGroupsButton.Visible = false;
            this.GenerateGroupsButton.Click += new System.EventHandler(this.GenerateGroupsButton_Click);
            this.GenerateGroupsButton.MouseLeave += new System.EventHandler(this.GenerateGroupsButton_MouseLeave);
            this.GenerateGroupsButton.MouseHover += new System.EventHandler(this.GenerateGroupsButton_MouseHover);
            // 
            // emailadressLabel
            // 
            this.emailadressLabel.AutoSize = true;
            this.emailadressLabel.Location = new System.Drawing.Point(767, 249);
            this.emailadressLabel.Name = "emailadressLabel";
            this.emailadressLabel.Size = new System.Drawing.Size(39, 13);
            this.emailadressLabel.TabIndex = 18;
            this.emailadressLabel.Text = "E-Mail";
            this.emailadressLabel.Visible = false;
            // 
            // PasswordText
            // 
            this.PasswordText.AutoSize = true;
            this.PasswordText.Location = new System.Drawing.Point(749, 299);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(56, 13);
            this.PasswordText.TabIndex = 19;
            this.PasswordText.Text = "Password";
            this.PasswordText.Visible = false;
            // 
            // SubjectText
            // 
            this.SubjectText.AutoSize = true;
            this.SubjectText.Location = new System.Drawing.Point(762, 356);
            this.SubjectText.Name = "SubjectText";
            this.SubjectText.Size = new System.Drawing.Size(45, 13);
            this.SubjectText.TabIndex = 21;
            this.SubjectText.Text = "Subject";
            this.SubjectText.Visible = false;
            // 
            // MessageInput
            // 
            this.MessageInput.Location = new System.Drawing.Point(829, 392);
            this.MessageInput.Name = "MessageInput";
            this.MessageInput.Size = new System.Drawing.Size(197, 135);
            this.MessageInput.TabIndex = 12;
            this.MessageInput.Text = "";
            this.MessageInput.Visible = false;
            this.MessageInput.MouseLeave += new System.EventHandler(this.MessageInput_MouseLeave);
            this.MessageInput.MouseHover += new System.EventHandler(this.MessageInput_MouseHover);
            // 
            // MessageText
            // 
            this.MessageText.AutoSize = true;
            this.MessageText.Location = new System.Drawing.Point(752, 395);
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(55, 13);
            this.MessageText.TabIndex = 25;
            this.MessageText.Text = "Message:";
            this.MessageText.Visible = false;
            // 
            // SendMailButton
            // 
            this.SendMailButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SendMailButton.Location = new System.Drawing.Point(830, 535);
            this.SendMailButton.Name = "SendMailButton";
            this.SendMailButton.Size = new System.Drawing.Size(197, 46);
            this.SendMailButton.TabIndex = 13;
            this.SendMailButton.Text = "SEND MAIL";
            this.SendMailButton.UseVisualStyleBackColor = true;
            this.SendMailButton.Visible = false;
            this.SendMailButton.Click += new System.EventHandler(this.SendMailButton_Click);
            this.SendMailButton.MouseLeave += new System.EventHandler(this.SendMailButton_MouseLeave);
            this.SendMailButton.MouseHover += new System.EventHandler(this.SendMailButton_MouseHover);
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupLabel.Location = new System.Drawing.Point(12, 418);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(64, 21);
            this.groupLabel.TabIndex = 31;
            this.groupLabel.Text = "Groups:";
            this.groupLabel.Visible = false;
            // 
            // NameList
            // 
            this.NameList.FormattingEnabled = true;
            this.NameList.Location = new System.Drawing.Point(12, 142);
            this.NameList.Name = "NameList";
            this.NameList.Size = new System.Drawing.Size(120, 160);
            this.NameList.TabIndex = 32;
            this.NameList.Visible = false;
            this.NameList.MouseLeave += new System.EventHandler(this.NameList_MouseLeave);
            this.NameList.MouseHover += new System.EventHandler(this.NameList_MouseHover);
            // 
            // EmailList
            // 
            this.EmailList.FormattingEnabled = true;
            this.EmailList.Location = new System.Drawing.Point(138, 142);
            this.EmailList.Name = "EmailList";
            this.EmailList.Size = new System.Drawing.Size(195, 160);
            this.EmailList.TabIndex = 33;
            this.EmailList.Visible = false;
            this.EmailList.VisibleChanged += new System.EventHandler(this.EmailList_VisibleChanged);
            this.EmailList.MouseLeave += new System.EventHandler(this.EmailList_MouseLeave);
            this.EmailList.MouseHover += new System.EventHandler(this.EmailList_MouseHover);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(43, 113);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(36, 13);
            this.nameLabel.TabIndex = 34;
            this.nameLabel.Text = "Name";
            this.nameLabel.Visible = false;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(194, 113);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(39, 13);
            this.emailLabel.TabIndex = 35;
            this.emailLabel.Text = "E-Mail";
            this.emailLabel.Visible = false;
            // 
            // UserEmail
            // 
            this.UserEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserEmail.Location = new System.Drawing.Point(832, 255);
            this.UserEmail.Name = "UserEmail";
            this.UserEmail.PlaceholderText = "<name>@htw-berlin.de";
            this.UserEmail.Size = new System.Drawing.Size(191, 15);
            this.UserEmail.TabIndex = 36;
            this.UserEmail.Visible = false;
            this.UserEmail.TextChanged += new System.EventHandler(this.UserEmail_TextChanged);
            this.UserEmail.MouseLeave += new System.EventHandler(this.EmailInput_MouseLeave);
            this.UserEmail.MouseHover += new System.EventHandler(this.EmailInput_MouseHover);
            // 
            // UserPassword
            // 
            this.UserPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserPassword.Location = new System.Drawing.Point(832, 299);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.PasswordChar = '*';
            this.UserPassword.PlaceholderText = "Your password..";
            this.UserPassword.Size = new System.Drawing.Size(191, 15);
            this.UserPassword.TabIndex = 9;
            this.UserPassword.Visible = false;
            this.UserPassword.TextChanged += new System.EventHandler(this.UserPassword_TextChanged);
            this.UserPassword.MouseLeave += new System.EventHandler(this.PasswordInput_MouseLeave);
            this.UserPassword.MouseHover += new System.EventHandler(this.PasswordInput_MouseHover);
            // 
            // SubjectInput
            // 
            this.SubjectInput.Location = new System.Drawing.Point(829, 356);
            this.SubjectInput.Name = "SubjectInput";
            this.SubjectInput.PlaceholderText = "Type Subject here..";
            this.SubjectInput.Size = new System.Drawing.Size(198, 22);
            this.SubjectInput.TabIndex = 10;
            this.SubjectInput.Visible = false;
            this.SubjectInput.TextChanged += new System.EventHandler(this.SubjectInput_TextChanged);
            this.SubjectInput.MouseLeave += new System.EventHandler(this.SubjectInput_MouseLeave);
            this.SubjectInput.MouseHover += new System.EventHandler(this.SubjectInput_MouseHover);
            // 
            // DateStartPicker
            // 
            this.DateStartPicker.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.DateStartPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateStartPicker.Location = new System.Drawing.Point(832, 138);
            this.DateStartPicker.Name = "DateStartPicker";
            this.DateStartPicker.Size = new System.Drawing.Size(191, 22);
            this.DateStartPicker.TabIndex = 7;
            this.DateStartPicker.Visible = false;
            this.DateStartPicker.ValueChanged += new System.EventHandler(this.DateStartPicker_ValueChanged);
            this.DateStartPicker.MouseLeave += new System.EventHandler(this.DateStartPicker_MouseLeave);
            this.DateStartPicker.MouseHover += new System.EventHandler(this.DateStartPicker_MouseHover);
            // 
            // TopicListbox
            // 
            this.TopicListbox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TopicListbox.ContextMenuStrip = this.contextMenuStripTopic;
            this.TopicListbox.FormattingEnabled = true;
            this.TopicListbox.Location = new System.Drawing.Point(365, 142);
            this.TopicListbox.Name = "TopicListbox";
            this.TopicListbox.Size = new System.Drawing.Size(235, 160);
            this.TopicListbox.TabIndex = 5;
            this.TopicListbox.Visible = false;
            this.TopicListbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopicListbox_MouseDown);
            this.TopicListbox.MouseLeave += new System.EventHandler(this.TopicListbox_MouseLeave);
            this.TopicListbox.MouseHover += new System.EventHandler(this.TopicListbox_MouseHover);
            // 
            // contextMenuStripTopic
            // 
            this.contextMenuStripTopic.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripTopic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripRemove});
            this.contextMenuStripTopic.Name = "contextMenuStripTopic";
            this.contextMenuStripTopic.Size = new System.Drawing.Size(118, 26);
            this.contextMenuStripTopic.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripTopic_ItemClicked);
            // 
            // toolStripRemove
            // 
            this.toolStripRemove.Name = "toolStripRemove";
            this.toolStripRemove.Size = new System.Drawing.Size(117, 22);
            this.toolStripRemove.Text = "Remove";
            // 
            // durationTimer
            // 
            this.durationTimer.Cursor = System.Windows.Forms.Cursors.Default;
            this.durationTimer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.durationTimer.Items.AddRange(new object[] {
            "15",
            "30",
            "45"});
            this.durationTimer.Location = new System.Drawing.Point(953, 195);
            this.durationTimer.Name = "durationTimer";
            this.durationTimer.Size = new System.Drawing.Size(73, 21);
            this.durationTimer.TabIndex = 8;
            this.durationTimer.Visible = false;
            this.durationTimer.DropDown += new System.EventHandler(this.durationTimer_TextChanged);
            this.durationTimer.DropDownStyleChanged += new System.EventHandler(this.durationTimer_TextChanged);
            this.durationTimer.TextChanged += new System.EventHandler(this.durationTimer_TextChanged);
            this.durationTimer.MouseLeave += new System.EventHandler(this.durationTimer_MouseLeave);
            this.durationTimer.MouseHover += new System.EventHandler(this.durationTimer_MouseHover);
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(752, 193);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(53, 13);
            this.durationLabel.TabIndex = 41;
            this.durationLabel.Text = "Duration";
            this.durationLabel.Visible = false;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(767, 138);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(34, 13);
            this.dateLabel.TabIndex = 42;
            this.dateLabel.Text = "Date:";
            this.dateLabel.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 605);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1091, 22);
            this.statusStrip1.TabIndex = 43;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusMessage
            // 
            this.statusMessage.Name = "statusMessage";
            this.statusMessage.Size = new System.Drawing.Size(84, 17);
            this.statusMessage.Text = "statusMessage";
            // 
            // openFileDialogFile
            // 
            this.openFileDialogFile.FileName = "openFileDialog1";
            this.openFileDialogFile.Filter = "CSV FILES (*.csv)|*.csv";
            this.openFileDialogFile.Title = "Select a \".csv\" file";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // calendarPicturebox
            // 
            this.calendarPicturebox.BackColor = System.Drawing.Color.White;
            this.calendarPicturebox.Location = new System.Drawing.Point(832, 131);
            this.calendarPicturebox.Name = "calendarPicturebox";
            this.calendarPicturebox.Size = new System.Drawing.Size(194, 29);
            this.calendarPicturebox.TabIndex = 45;
            this.calendarPicturebox.TabStop = false;
            this.calendarPicturebox.Visible = false;
            // 
            // emailPicturebox
            // 
            this.emailPicturebox.BackColor = System.Drawing.Color.White;
            this.emailPicturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailPicturebox.Location = new System.Drawing.Point(830, 249);
            this.emailPicturebox.Name = "emailPicturebox";
            this.emailPicturebox.Size = new System.Drawing.Size(197, 21);
            this.emailPicturebox.TabIndex = 46;
            this.emailPicturebox.TabStop = false;
            this.emailPicturebox.Visible = false;
            // 
            // passwordPicturebox
            // 
            this.passwordPicturebox.BackColor = System.Drawing.Color.White;
            this.passwordPicturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordPicturebox.Location = new System.Drawing.Point(829, 297);
            this.passwordPicturebox.Name = "passwordPicturebox";
            this.passwordPicturebox.Size = new System.Drawing.Size(197, 21);
            this.passwordPicturebox.TabIndex = 47;
            this.passwordPicturebox.TabStop = false;
            this.passwordPicturebox.Visible = false;
            // 
            // dateEndPicturebox
            // 
            this.dateEndPicturebox.Location = new System.Drawing.Point(953, 193);
            this.dateEndPicturebox.Name = "dateEndPicturebox";
            this.dateEndPicturebox.Size = new System.Drawing.Size(73, 27);
            this.dateEndPicturebox.TabIndex = 48;
            this.dateEndPicturebox.TabStop = false;
            // 
            // topicPicturebox
            // 
            this.topicPicturebox.BackColor = System.Drawing.Color.White;
            this.topicPicturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topicPicturebox.Location = new System.Drawing.Point(365, 111);
            this.topicPicturebox.Name = "topicPicturebox";
            this.topicPicturebox.Size = new System.Drawing.Size(163, 21);
            this.topicPicturebox.TabIndex = 44;
            this.topicPicturebox.TabStop = false;
            this.topicPicturebox.Visible = false;
            // 
            // RandomGroupsOutput
            // 
            this.RandomGroupsOutput.FormattingEnabled = true;
            this.RandomGroupsOutput.Location = new System.Drawing.Point(12, 460);
            this.RandomGroupsOutput.Name = "RandomGroupsOutput";
            this.RandomGroupsOutput.Size = new System.Drawing.Size(588, 121);
            this.RandomGroupsOutput.TabIndex = 49;
            this.RandomGroupsOutput.Visible = false;
            this.RandomGroupsOutput.MouseHover += new System.EventHandler(this.RandomGroupsOutput_MouseHover_1);
            // 
            // selectPictureBox
            // 
            this.selectPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.selectPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectPictureBox.Location = new System.Drawing.Point(182, 27);
            this.selectPictureBox.Name = "selectPictureBox";
            this.selectPictureBox.Size = new System.Drawing.Size(129, 22);
            this.selectPictureBox.TabIndex = 43;
            this.selectPictureBox.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 37;
            this.iconPictureBox2.Location = new System.Drawing.Point(50, 62);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(38, 37);
            this.iconPictureBox2.TabIndex = 51;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.Visible = false;
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.iconPictureBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.CommentDots;
            this.iconPictureBox4.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 33;
            this.iconPictureBox4.Location = new System.Drawing.Point(710, 345);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(33, 33);
            this.iconPictureBox4.TabIndex = 53;
            this.iconPictureBox4.TabStop = false;
            this.iconPictureBox4.Visible = false;
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.iconPictureBox5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.iconPictureBox5.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox5.IconSize = 30;
            this.iconPictureBox5.Location = new System.Drawing.Point(710, 249);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(33, 30);
            this.iconPictureBox5.TabIndex = 54;
            this.iconPictureBox5.TabStop = false;
            this.iconPictureBox5.Visible = false;
            // 
            // iconPictureBox6
            // 
            this.iconPictureBox6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.iconPictureBox6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.iconPictureBox6.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox6.IconSize = 30;
            this.iconPictureBox6.Location = new System.Drawing.Point(710, 190);
            this.iconPictureBox6.Name = "iconPictureBox6";
            this.iconPictureBox6.Size = new System.Drawing.Size(33, 30);
            this.iconPictureBox6.TabIndex = 55;
            this.iconPictureBox6.TabStop = false;
            this.iconPictureBox6.Visible = false;
            // 
            // iconPictureBox7
            // 
            this.iconPictureBox7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.iconPictureBox7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.iconPictureBox7.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox7.IconSize = 29;
            this.iconPictureBox7.Location = new System.Drawing.Point(710, 131);
            this.iconPictureBox7.Name = "iconPictureBox7";
            this.iconPictureBox7.Size = new System.Drawing.Size(33, 29);
            this.iconPictureBox7.TabIndex = 56;
            this.iconPictureBox7.TabStop = false;
            this.iconPictureBox7.Visible = false;
            // 
            // iconPictureBox8
            // 
            this.iconPictureBox8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.iconPictureBox8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox8.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconPictureBox8.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox8.IconSize = 27;
            this.iconPictureBox8.Location = new System.Drawing.Point(710, 297);
            this.iconPictureBox8.Name = "iconPictureBox8";
            this.iconPictureBox8.Size = new System.Drawing.Size(33, 27);
            this.iconPictureBox8.TabIndex = 57;
            this.iconPictureBox8.TabStop = false;
            this.iconPictureBox8.Visible = false;
            this.iconPictureBox8.Click += new System.EventHandler(this.iconPictureBox8_Click);
            // 
            // iconPictureBox9
            // 
            this.iconPictureBox9.BackColor = System.Drawing.Color.LightSteelBlue;
            this.iconPictureBox9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox9.IconChar = FontAwesome.Sharp.IconChar.Random;
            this.iconPictureBox9.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox9.IconSize = 44;
            this.iconPictureBox9.Location = new System.Drawing.Point(442, 376);
            this.iconPictureBox9.Name = "iconPictureBox9";
            this.iconPictureBox9.Size = new System.Drawing.Size(44, 55);
            this.iconPictureBox9.TabIndex = 58;
            this.iconPictureBox9.TabStop = false;
            this.iconPictureBox9.Visible = false;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(951, 12);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 37);
            this.resetButton.TabIndex = 50;
            this.resetButton.Text = "reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Visible = false;
            this.resetButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.resetButton_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1091, 627);
            this.Controls.Add(this.iconPictureBox9);
            this.Controls.Add(this.iconPictureBox8);
            this.Controls.Add(this.iconPictureBox7);
            this.Controls.Add(this.iconPictureBox6);
            this.Controls.Add(this.iconPictureBox5);
            this.Controls.Add(this.iconPictureBox4);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.RandomGroupsOutput);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.durationTimer);
            this.Controls.Add(this.TopicListbox);
            this.Controls.Add(this.SubjectInput);
            this.Controls.Add(this.UserPassword);
            this.Controls.Add(this.UserEmail);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.EmailList);
            this.Controls.Add(this.NameList);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.DateStartPicker);
            this.Controls.Add(this.SendMailButton);
            this.Controls.Add(this.MessageText);
            this.Controls.Add(this.MessageInput);
            this.Controls.Add(this.SubjectText);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.emailadressLabel);
            this.Controls.Add(this.GenerateGroupsButton);
            this.Controls.Add(this.AddTopicButton);
            this.Controls.Add(this.ThemeInput);
            this.Controls.Add(this.ParticipantsNmOutput);
            this.Controls.Add(this.participantCountLabel);
            this.Controls.Add(this.topicCountLabel);
            this.Controls.Add(this.ThemeNmOutput);
            this.Controls.Add(this.topicLabel);
            this.Controls.Add(this.participantLabel);
            this.Controls.Add(this.OpenCSVFileButton);
            this.Controls.Add(this.CSVFileInput);
            this.Controls.Add(this.selectPictureBox);
            this.Controls.Add(this.topicPicturebox);
            this.Controls.Add(this.calendarPicturebox);
            this.Controls.Add(this.emailPicturebox);
            this.Controls.Add(this.passwordPicturebox);
            this.Controls.Add(this.dateEndPicturebox);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Generate Groups";
            this.contextMenuStripTopic.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEndPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CSVFileInput;
        private System.Windows.Forms.Button OpenCSVFileButton;
        private System.Windows.Forms.Label TeilnehmerlisteText;
        private System.Windows.Forms.Label topicLabel;
        private System.Windows.Forms.TextBox ThemeNmOutput;
        private System.Windows.Forms.Label topicCountLabel;
        private System.Windows.Forms.Label participantCountLabel;
        private System.Windows.Forms.TextBox ParticipantsNmOutput;
        private System.Windows.Forms.TextBox ThemeInput;
        private System.Windows.Forms.Button AddTopicButton;
        private System.Windows.Forms.Button GenerateGroupsButton;
        private System.Windows.Forms.Label EmailText;
        private System.Windows.Forms.Label PasswordText;
        private System.Windows.Forms.Label SubjectText;
        private System.Windows.Forms.RichTextBox MessageInput;
        private System.Windows.Forms.Label MessageText;
        private System.Windows.Forms.Button SendMailButton;
        private System.Windows.Forms.Label GruppenText;
        private System.Windows.Forms.ListBox NameList;
        private System.Windows.Forms.ListBox EmailList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox UserEmail;
        private System.Windows.Forms.TextBox UserPassword;
        private System.Windows.Forms.TextBox SubjectInput;
        private System.Windows.Forms.DateTimePicker DateStartPicker;
        private System.Windows.Forms.ListBox TopicListbox;
        private System.Windows.Forms.ComboBox durationTimer;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialogFile;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusMessage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTopic;
        private System.Windows.Forms.ToolStripMenuItem toolStripRemove;
        private System.Windows.Forms.PictureBox calendarPicturebox;
        private System.Windows.Forms.PictureBox emailPicturebox;
        private System.Windows.Forms.PictureBox passwordPicturebox;
        private System.Windows.Forms.PictureBox dateEndPicturebox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label ParticipantLabel;
        private System.Windows.Forms.Label participantLabel;
        private System.Windows.Forms.PictureBox topicPicturebox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label emailadressLabel;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.ListBox RandomGroupsOutput;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.PictureBox selectPictureBox;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox8;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox9;
    }
}

