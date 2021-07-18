using EmailSystemLibrary;
using GeneratorLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using ControllerLibrary;
using System.Text.RegularExpressions;
using System.DirectoryServices;

namespace RandomMeetingApp
{
    public partial class Form1 : Form
    {
        #region Global instances

        public List<Participant> partList = new List<Participant>();  // Global List of Participants

        private ICSFileGenerator _icsfilegenerator = new ICSFileGenerator();

        public GroupGenerator _generategroups = new GroupGenerator();

        public List<Participant> randomlist = new List<Participant>(); //randomisierte liste

        public List<List<Participant>> listResult = new List<List<Participant>>();

        public LinkGenerator _generateLink = new LinkGenerator();

        public Controller _controller = new Controller();

        public List<string> topiclist = new List<string>();

        List<Participant> outputlist = new List<Participant>();
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        #region Buttons
        /// <summary>
        /// Opens a file dialog to select a csv file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenCSVFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialogFile.ShowDialog() == DialogResult.OK)
            {
                EmailList.Items.Clear();
                NameList.Items.Clear();
                CSVFileInput.PlaceholderText = openFileDialogFile.FileName;
                CSVFileInput.Text = openFileDialogFile.FileName;

                var filePath = openFileDialogFile.FileName;
                CsvReader csv = new CsvReader();
                // filepath + den character für die Split methode
                partList = csv.ReadFile(filePath, ';');


                foreach (var item in partList)
                {
                    NameList.Items.Add(item.Name);
                    EmailList.Items.Add(item.Email);

                }
                ParticipantsNmOutput.Text = partList.Count.ToString(); // Length = counter
            }
        }


        /// <summary>
        /// Button Event for sending the E-Mail
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SendMailButton_Click(object sender, EventArgs e)
        {
            Meeting _meeting = new Meeting();
            Mail _mail = new Mail();
            Regex email_validation_regex = new Regex(@"^[_A-Za-z0-9-\\+]+(\\.[_A-Za-z0-9-]+)*@htw-berlin.de$");
            Match match = email_validation_regex.Match(UserEmail.Text);

            #region Error Input Handling
            if (DateStartPicker.Value < DateTime.Now.AddMinutes(5))
            {
                errorProvider1.SetError(calendarPicturebox, "Your Date is set too short! Please put a minimum of 5 minutes.");
                calendarPicturebox.BackColor = Color.Red;
                MessageBox.Show("Set a date!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (durationTimer.Text == "")
            {
                errorProvider1.SetError(dateEndPicturebox, "Please select a duration for the Meeting");
                dateEndPicturebox.BackColor = Color.Red;
            }
            else if (UserEmail.Text == "" && UserPassword.Text == "")
            {
                errorProvider1.SetError(emailPicturebox, "Please enter your E-Mail.");
                errorProvider1.SetError(passwordPicturebox, "Please enter your password.");
                emailPicturebox.BackColor = Color.Red;
                passwordPicturebox.BackColor = Color.Red;
            }
            else if (UserEmail.Text == "")
            {
                errorProvider1.SetError(emailPicturebox, "Please enter your E-Mail.");
                emailPicturebox.BackColor = Color.Red;

            }
            else if (UserPassword.Text == "")
            {
                errorProvider1.SetError(passwordPicturebox, "Please enter your password.");
                passwordPicturebox.BackColor = Color.Red;
            }
            #endregion
            #region E-Mail Login Validation        
            else if (match.Success)
            {
                _meeting.Organizer = new MailAddress(UserEmail.Text);
                _meeting.Password = UserPassword.Text;

                if (Mail.EmailPwTrue(_meeting) == true) // E-Mail + Password validation
                {
                    _meeting.DateStart = DateStartPicker.Value; // global
                    _meeting.DateEnd = DateStartPicker.Value.AddMinutes(int.Parse(durationTimer.Text)); // global
                    _meeting.Subject = SubjectInput.Text; // global
                    _meeting.BodyText = MessageInput.Text; // global
                                                           // Schleife für Location und Description


                    int num_theme = TopicListbox.Items.Count;
                    int group_num = 1;

                    foreach (var list in listResult)
                    {

                        for (int i = 0; i < num_theme; i++)
                        {
                            
                            _meeting.Description = topiclist[group_num];
                            _meeting.GroupNumber = "Deine Gruppe: " + group_num.ToString(); 
                           // _meeting.Description = "Deine Gruppe: " + group_num.ToString();


                        }
                        group_num++;
                        outputlist = list;
                        _meeting.Location = _generateLink.generateLink(_meeting, durationTimer.Text).ToString();
                        foreach (var participant in outputlist)
                        {
                            for (int i = 0; i < num_theme; i++)
                            {

                                _meeting.Message = _mail.bodyTextBuilder(_meeting);
                            }

                            Mail.SendEmail(_meeting, participant, _icsfilegenerator.CreateICS(_meeting));

                        }
                       
                    }


                }
                else
                {
                    MessageBox.Show("E-Mail or Password wrong!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                errorProvider1.SetError(emailPicturebox, "Your Email Domain should be '@htw-berlin.de' !");
                emailPicturebox.BackColor = Color.Red;
            }
            #endregion

        }
        private void GenerateGroupsButton_Click(object sender, EventArgs e)
        {
            topiclist.Clear();
            int num_groups = int.Parse(ThemeNmOutput.Text);
            int num_theme = TopicListbox.Items.Count;

            int group_num = 0;

            //randomize the global list (partlist)
            randomlist = _generategroups.Randomize(partList);

            //split randomize ist to smaller (n = num_groups) lists 
            listResult = _generategroups.SplitList<Participant>(randomlist, num_groups);

            RandomGroupsOutput.Items.Clear();

            foreach (var list in listResult)
            {
                outputlist = list;

                foreach (var participant in outputlist)
                {
                    //Add the topics to topiclist 
                    for (int i = 0; i < num_theme; i++)
                    {
                        topiclist.Add(TopicListbox.Items[i].ToString());
                    }
                    //Display of every group with the topic and the members name and email

                    RandomGroupsOutput.Items.Add("Group: " + (group_num + 1) + " | Topic: " + topiclist[group_num] +  " | Name: " + participant.Name + " | E-Mail: " + participant.Email);

                }
                group_num++;
            }


            #region Error handling
            if (EmailList.Items.Count == 0 && NameList.Items.Count == 0)
            {
                errorProvider1.SetError(selectPictureBox, "Please select a \".csv\"- File!");
                selectPictureBox.BackColor = Color.Red;

            }
            else if (EmailList.Items.Count > 0)
            {
                ControlCsv(EmailList);

            }
             if (TopicListbox.Items.Count == 0)
            {
                errorProvider1.SetError(topicPicturebox, "Please enter atleast one topic!");
                topicPicturebox.BackColor = Color.Red;
            }
            #endregion

            #region Visualization event
            else if (EmailList.Visible == true)
            {
                iconPictureBox7.Show();
                iconPictureBox6.Show();
                dateLabel.Show();
                durationLabel.Show();
                DateStartPicker.Show();
                durationTimer.Show();
                calendarPicturebox.Show();
                groupLabel.Show();
                RandomGroupsOutput.Show();
                

            }
            #endregion

        }
        #endregion
        #region Error handling
        /// <summary>
        /// Checks if the csv format is right. 
        /// </summary>
        /// <param name="lb"></param>
        public void ControlCsv(ListBox lb)
        {
            for (int i = 0; i < lb.Items.Count; i++)
            {
                string message = _controller.IsValidEmail(lb.Items[i].ToString());
                if (message == null)
                {

                    MessageBox.Show("Some items in for .csv file are wrong! Please correct it! 'Names;E-Mail' ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    #region Visualization event
                    partList.Clear();

                    EmailList.Items.Clear();
                    NameList.Items.Clear();
                    TopicListbox.Items.Clear();
                    GenerateGroupsButton.Hide();
                    iconPictureBox2.Hide();
                    TopicListbox.Hide();
                    topicLabel.Hide();
                    topicPicturebox.Hide();
                    ThemeInput.Hide();
                    AddTopicButton.Hide();
                    iconPictureBox9.Hide();

                    participantCountLabel.Hide();
                    ParticipantsNmOutput.Hide();
                    topicCountLabel.Hide();
                    ThemeNmOutput.Hide();

                    ParticipantsNmOutput.Text = partList.Count.ToString();
                    ThemeNmOutput.Text = partList.Count.ToString();

                    EmailList.Hide();
                    NameList.Hide();
                    nameLabel.Hide();
                    emailLabel.Hide();
                    participantLabel.Hide();

                    #endregion
                    break;
                }
            }
        }
        #endregion
        #region Mouse hover event
        /// <summary>
        /// change StatusLabel message, when mouse hovers over ThemeInput textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThemeInput_MouseHover(object sender, EventArgs e)
        {
            statusMessage.Text = "Use this text field to add your topics.";

        }


        /// <summary>
        /// change StatusLabel message, when mouse hovers over Durchsuchen button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenCSVFileButton_MouseHover(object sender, EventArgs e)
        {
            statusMessage.Text = "Choose your .csv file.";
        }
        /// <summary>
        ///change StatusLabel message, when mouse hovers over TopicListbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopicListbox_MouseHover(object sender, EventArgs e)
        {
            statusMessage.Text = "Your added topics.";
        }
        /// <summary>
        /// change StatusLabel message, when mouse hovers over DateStartpicker calender
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateStartPicker_MouseHover(object sender, EventArgs e)
        {
            statusMessage.Text = "Select the date and start time for the meeting.";
        }
        /// <summary>
        /// change StatusLabel message, when mouse hovers over Duration dropbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void durationTimer_MouseHover(object sender, EventArgs e)
        {
            statusMessage.Text = "Select the meeting duration";
        }
        /// <summary>
        /// change StatusLabel message, when mouse hovers over E-Mail textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailInput_MouseHover(object sender, EventArgs e)
        {
            statusMessage.Text = "From which mail do you want to send the invitations? Enter it in this text field.";
        }
        /// <summary>
        /// change StatusLabel message, when mouse hovers over Password textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordInput_MouseHover(object sender, EventArgs e)
        {
            statusMessage.Text = "Enter the password from your mail";
        }
        /// <summary>
        /// change StatusLabel message, when mouse hovers over Subject textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubjectInput_MouseHover(object sender, EventArgs e)
        {
            statusMessage.Text = "Enter the subject";
        }
        /// <summary>
        /// change StatusLabel message, when mouse hovers over Message textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MessageInput_MouseHover(object sender, EventArgs e)
        {
            statusMessage.Text = "If you want you can add some marginal info for the meeting";
        }
        /// <summary>
        /// change StatusLabel message, when mouse hovers over SendMail button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SendMailButton_MouseHover(object sender, EventArgs e)
        {
            statusMessage.Text = "Click the button to send the invitations.";
        }
        /// <summary>
        /// change StatusLabel message, when mouse hovers over groups preview box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void RandomGroupsOutput_MouseHover_1(object sender, EventArgs e)
        {
            statusMessage.Text = "Preview box to view the groups.";
        }
        /// <summary>
        /// change StatusLabel message, when mouse hovers over GenerateGroups button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateGroupsButton_MouseHover(object sender, EventArgs e)
        {
            statusMessage.Text = "Click the button to generate the groups.";
        }
        /// <summary>
        /// change StatusLabel message, when mouse hovers over Enter button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTopicButton_MouseHover(object sender, EventArgs e)
        {
            statusMessage.Text = "Click the button to add the topic.";
        }
        /// <summary>
        /// change StatusLabel message, when mouse hovers over 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThemeNmOutput_MouseHover(object sender, EventArgs e)
        {
            statusMessage.Text = "";
        }
        /// <summary>
        /// change StatusLabel message, when mouse hovers over NameListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameList_MouseHover(object sender, EventArgs e)
        {
            statusMessage.Text = "List of participant names.";
        }
        /// <summary>
        /// change StatusLabel message, when mouse hovers over EmaiListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailList_MouseHover(object sender, EventArgs e)
        {
            statusMessage.Text = "List of participant mails";
        }
        #endregion
        #region Mouse leave event
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThemeInput_MouseLeave(object sender, EventArgs e)
        {
            statusMessage.Text = "";
        }
        /// <summary>
        /// delete statusLabel message, when the mouse is not pointing to the Durchsuchen button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenCSVFileButton_MouseLeave(object sender, EventArgs e)
        {
            statusMessage.Text = "";
        }
        /// <summary>
        ///  delete statusLabel message, when the mouse is not pointing to the NameListbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameList_MouseLeave(object sender, EventArgs e)
        {
            statusMessage.Text = "";
        }
        /// <summary>
        /// delete statusLabel message, when the mouse is not pointing to the EmailListbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailList_MouseLeave(object sender, EventArgs e)
        {
            statusMessage.Text = "";
        }
        /// <summary>
        /// delete statusLabel message, when the mouse is not pointing to the Enter button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTopicButton_MouseLeave(object sender, EventArgs e)
        {
            statusMessage.Text = "";
        }
        /// <summary>
        /// delete statusLabel message, when the mouse is not pointing to the TopicListbox 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopicListbox_MouseLeave(object sender, EventArgs e)
        {
            statusMessage.Text = "";
        }
        /// <summary>
        /// delete statusLabel message, when the mouse is not pointing to the GenerateGroups button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateGroupsButton_MouseLeave(object sender, EventArgs e)
        {
            statusMessage.Text = "";
        }
        /// <summary>
        /// delete statusLabel message, when the mouse is not pointing to the DateStartPicker calender
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateStartPicker_MouseLeave(object sender, EventArgs e)
        {
            statusMessage.Text = "";
        }
        /// <summary>
        /// delete statusLabel message, when the mouse is not pointing to the Duration dropbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void durationTimer_MouseLeave(object sender, EventArgs e)
        {
            statusMessage.Text = "";

        }
        /// <summary>
        /// delete statusLabel message, when the mouse is not pointing to the E-Mail textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailInput_MouseLeave(object sender, EventArgs e)
        {
            statusMessage.Text = "";
        }
        /// <summary>
        /// delete statusLabel message, when the mouse is not pointing to the Password textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordInput_MouseLeave(object sender, EventArgs e)
        {
            statusMessage.Text = "";
        }
        /// <summary>
        /// delete statusLabel message, when the mouse is not pointing to the Subject textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubjectInput_MouseLeave(object sender, EventArgs e)
        {
            statusMessage.Text = "";
        }
        /// <summary>
        /// delete statusLabel message, when the mouse is not pointing to the Message textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MessageInput_MouseLeave(object sender, EventArgs e)
        {
            statusMessage.Text = "";
        }
        /// <summary>
        /// delete statusLabel message, when the mouse is not pointing to the SendMail button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SendMailButton_MouseLeave(object sender, EventArgs e)
        {
            statusMessage.Text = "";
        }
        /// <summary>
        /// delete statusLabel message, when the mouse is not pointing to the Groups preview listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RandomGroupsOutput_MouseLeave(object sender, EventArgs e)
        {
            statusMessage.Text = "";
        }

        #endregion
        #region Error provider
        /// <summary>
        /// If the User selects a file, the ErrorProvider will turn back to default.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CSVFileInput_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(selectPictureBox, null);
            selectPictureBox.BackColor = DefaultBackColor;
            #region Visible changes csv File
            NameList.Show();
            nameLabel.Show();
            emailLabel.Show();
            EmailList.Show();
            participantLabel.Show();
            resetButton.Show();

            #endregion
            //if csv is changed clear data
            TopicListbox.Items.Clear();
            ParticipantsNmOutput.Clear();
            ThemeNmOutput.Clear();
            RandomGroupsOutput.Items.Clear();
        }
        /// <summary>
        /// If the User add one topic/theme, the ErrorProvider will turn back to default.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThemeNmOutput_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(topicPicturebox, null);
            topicPicturebox.BackColor = DefaultBackColor;
            
            
            //when 1 topic is added, shows generate group button
            if (ThemeNmOutput.Text == "1")
            {
                GenerateGroupsButton.Show();
                iconPictureBox9.Show();
            }
               
        }
        /// <summary>
        /// If the User changed the date value, the ErrorProvider will turn back to default.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateStartPicker_ValueChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(calendarPicturebox, null);
            calendarPicturebox.BackColor = DefaultBackColor;
        }
        /// <summary>
        /// If the User changed the duration, the ErrorProvider will turn back to default.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void durationTimer_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(dateEndPicturebox, null);
            dateEndPicturebox.BackColor = DefaultBackColor;

            //show Mailvalidation when duration is picked and emallist is visible
            if (EmailList.Visible == true)
            {
                iconPictureBox5.Show();
                iconPictureBox8.Show();
                emailadressLabel.Show();
                emailPicturebox.Show();
                UserEmail.Show();
                PasswordText.Show();
                UserPassword.Show();
                passwordPicturebox.Show();
            }

        }
        /// <summary>
        /// If the User changed the E-Mail input, the ErrorProvider will turn back to default.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserEmail_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(emailPicturebox, null);
            emailPicturebox.BackColor = DefaultBackColor;

            if (UserPassword.Text != String.Empty)
            {
                iconPictureBox4.Show();
                SubjectText.Show();
                SubjectInput.Show();
                MessageText.Show();
                MessageInput.Show();
            }

        }
        /// <summary>
        /// If the User changed the password input, the ErrorProvider will turn back to default.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserPassword_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(passwordPicturebox, null);
            passwordPicturebox.BackColor = DefaultBackColor;

            if (EmailList.Visible == true)//only show buttons when emaillist is visible
            {
                if (UserEmail.Text != String.Empty)
                {
                    iconPictureBox4.Show();
                    SubjectText.Show();
                    SubjectInput.Show();
                    MessageText.Show();
                    MessageInput.Show();
                }
                
            }

        }
        #endregion
        #region Events listbox
        /// <summary>
        /// Adds an item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTopicButton_Click(object sender, EventArgs e)
        {
            if (int.Parse(ParticipantsNmOutput.Text) > TopicListbox.Items.Count)
            {
                if (ThemeInput.Text != "")
                {
                TopicListbox.Items.Add(ThemeInput.Text);
                ThemeInput.PlaceholderText = "";
                ThemeInput.Text = "";
                }
            ThemeNmOutput.Text = TopicListbox.Items.Count.ToString(); // Length = counter
               
            }
            else
            {
                MessageBox.Show("Number of topics can not be more than number of participants.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusMessage.Text = "Number of topics can not be more than number of participants.";
                ThemeInput.Clear();
            }


        }
        /// <summary>
        /// With enter you can insert an item to the Topic List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThemeInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.Parse(ParticipantsNmOutput.Text) > TopicListbox.Items.Count)
                {
                    if (ThemeInput.Text != "")
                    {
                        TopicListbox.Items.Add(ThemeInput.Text);
                        ThemeInput.PlaceholderText = "";
                        ThemeInput.Text = "";
                    }
                    ThemeNmOutput.Text = TopicListbox.Items.Count.ToString(); // Length = counter

                }
                else
                {
                    MessageBox.Show("Number of topics can not be more than number of participants.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    statusMessage.Text = "Number of topics can not be more than number of participants.";
                    ThemeInput.Clear();
                }
            }
        }
        /// <summary>
        /// On Mousebutton Rightclick a Context Menu opens with a Remove Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopicListbox_MouseDown(object sender, MouseEventArgs e)
        {
            TopicListbox.SelectedIndex = TopicListbox.IndexFromPoint(e.X, e.Y);
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStripTopic.Show(TopicListbox, new Point(e.X, e.Y));
                contextMenuStripTopic.ItemClicked += new ToolStripItemClickedEventHandler(contextMenuStripTopic_ItemClicked);
            }

        }
        /// <summary>
        /// Removes an item in a Listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextMenuStripTopic_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            if (e.ClickedItem.Text == "Remove")
            {
                TopicListbox.Items.Remove(TopicListbox.SelectedItem);
                ThemeNmOutput.Text = TopicListbox.Items.Count.ToString();
                RandomGroupsOutput.Items.Clear();
                topiclist.Clear();
            }

        }



        #endregion
        #region Visualization event 
        /// <summary>
        /// change visiblity
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailList_VisibleChanged(object sender, EventArgs e)
        {
            if (EmailList.Visible == true)
            {
                topicLabel.Show();
                ThemeInput.Show();
                AddTopicButton.Show();
                TopicListbox.Show();
                participantCountLabel.Show();
                ParticipantsNmOutput.Show();
                topicCountLabel.Show();
                ThemeNmOutput.Show();
                topicPicturebox.Show();
            }
        }

        private void SubjectInput_TextChanged(object sender, EventArgs e)
        {
            if (EmailList.Visible == true)
            {
                MessageText.Show();
                MessageInput.Show();
                SendMailButton.Show();
              
            }
        }


        #endregion
        /// <summary>
        /// hide and reset items with reset button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_MouseClick(object sender, MouseEventArgs e)
        {

            // clear everything first before hide?
            CSVFileInput.Clear();
            NameList.Items.Clear();
            EmailList.Items.Clear();
            TopicListbox.Items.Clear();
            ParticipantsNmOutput.Clear();
            ThemeNmOutput.Clear();
            RandomGroupsOutput.Items.Clear();
            SubjectInput.Clear();
            MessageInput.Clear();
            UserEmail.Clear();
            UserPassword.Clear();
            durationTimer.ResetText();
            passwordPicturebox.ResetText();

            //clear csv textbox

            CSVFileInput.ResetText();
            selectPictureBox.ResetText();

            //hide and clear namelist box
            NameList.Hide();
          
            nameLabel.Hide();
            participantLabel.Hide();

            //hide and clear emaillist box
            EmailList.Hide();
            
            emailLabel.Hide();

            //hide and clear topic buttons
            topicCountLabel.Hide();
            topicLabel.Hide();
            AddTopicButton.Hide();
            ThemeInput.Hide();
            TopicListbox.Hide();
            
            topicPicturebox.Hide();

            //hide and clear groupbutton and preview box
            GenerateGroupsButton.Hide();
            ParticipantsNmOutput.Hide();
        
            ThemeNmOutput.Hide();
            
            
            RandomGroupsOutput.Hide();
            groupLabel.Hide();
            participantCountLabel.Hide();

            //Hide Calender and Mail
            MessageText.Hide();
            dateLabel.Hide();
            durationLabel.Hide();
            emailLabel.Hide();
            PasswordText.Hide();
            DateStartPicker.Hide();
            SubjectText.Hide();
            calendarPicturebox.Hide();
           
            SubjectInput.Hide();
        

            MessageInput.Hide();
           
            MessageText.Hide();
            SendMailButton.Hide();
            emailadressLabel.Hide();
            emailPicturebox.Hide();
         
            UserEmail.Hide();
            
            
            UserPassword.Hide();
            
            passwordPicturebox.Hide();
            durationTimer.Hide();
            
            dateEndPicturebox.Hide();
            emailPicturebox.ResetText();
        

            //hide reset button
            resetButton.Hide();

            // Hide all Icons
            iconPictureBox2.Hide();
            iconPictureBox4.Hide();
            iconPictureBox5.Hide();
            iconPictureBox6.Hide();
            iconPictureBox7.Hide();
            iconPictureBox8.Hide();
            iconPictureBox9.Hide();
        }

        private void iconPictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
