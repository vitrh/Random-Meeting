using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;

namespace GeneratorLibrary
{
    public class Meeting
    {
        //properties
        private DateTime dateStart;
        private DateTime dateEnd;
        private string description;
        private string groupNumber;
        private string zoomLink;
        private string message;
        private string password;
        private MailAddress organizer;
        private string subject;
        private string bodytext;
        /// <summary>
        /// Starting Date for the Meeting 
        /// </summary>
        public DateTime DateStart { get { return dateStart; } set { dateStart = value; } }
        /// <summary>
        /// When should the Meeting end in Minutes
        /// </summary>
        public DateTime DateEnd { get { return dateEnd; } set { dateEnd = value; } }
        /// <summary>
        /// Topic 
        /// </summary>
        public string Description { get { return description;  } set { description = value; } }
        /// <summary>
        /// Groupnumber
        /// </summary>
        public string GroupNumber { get; set; }
        /// <summary>
        /// Link
        /// </summary
        public string Location { get { return zoomLink; } set { zoomLink = value; } }
        /// <summary>
        /// Organizer - E-Mail of the Program User
        /// </summary>
        public MailAddress Organizer { get { return organizer; } set { organizer = value; } }
        /// <summary>
        /// Password 
        /// </summary>
        public string Password { get { return password; } set { password = value; } }
        /// <summary>
        /// Betreff
        /// </summary>
        public string Subject { get { return subject; } set { subject = value; } }
        /// <summary>
        /// Message from the GUI
        /// </summary>
        public string BodyText { get { return bodytext; } set { bodytext = value; } }
        /// <summary>
        /// E-Mail Message
        /// </summary>
        public string Message { get { return message; } set { message = value; } }
        //constructor
        public Meeting()
        {

        }
    }
}
