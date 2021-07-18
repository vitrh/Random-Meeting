using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.IO;
using GeneratorLibrary;


namespace EmailSystemLibrary
{
    public class Mail
    {
        
        /// <summary>
        /// Sends the Mail
        /// </summary>
        /// <param name="_meeting"></param>
        /// <param name="_participant"></param>
        /// <param name="icsFile"></param>
        public static void SendEmail(Meeting _meeting, Participant _participant, string icsFile)
        {
             SmtpClient mClient = new SmtpClient("mail.htw-berlin.de", 25);

            string username = _meeting.Organizer.ToString();
            // username@htw-mail.de -> split[0] = username !
            NetworkCredential auth = new NetworkCredential(username.Split('@')[0], _meeting.Password); // Very important, HTW Auth needs Username and not the E-Mail!
            MailMessage Mailmsg = new MailMessage();

            Mailmsg.From = _meeting.Organizer;

            Mailmsg.To.Add(_participant.Email);
            // Organizer becomes copy of all sended E-Mails with cc
            Mailmsg.CC.Add(_meeting.Organizer);
     
            Mailmsg.Subject = _meeting.Subject;
            Mailmsg.Body = _meeting.Message;

            mClient.Credentials = auth;
            mClient.EnableSsl = true;

            var calendarBytes = Encoding.UTF8.GetBytes(icsFile);
            MemoryStream ms = new MemoryStream(calendarBytes);
            Mailmsg.Attachments.Add(new Attachment(ms, "invite.ics", "text/calendar"));
            mClient.Send(Mailmsg);
            mClient.Dispose();
        }
        /// <summary>
        /// Checks if the User Email and Password is true.
        /// </summary>
        /// <param name="_meeting"></param>
        /// <returns></returns>
        public static bool EmailPwTrue(Meeting _meeting)
        {
            SmtpClient mClient = new SmtpClient("mail.htw-berlin.de", 25);
            string username = _meeting.Organizer.ToString();
            NetworkCredential auth = new NetworkCredential(username.Split('@')[0], _meeting.Password);
            MailMessage Mailmsg = new MailMessage();
            Mailmsg.From = _meeting.Organizer;
            Mailmsg.To.Add("thong44@hotmail.de"); // E-Mail for testing auth
            Mailmsg.CC.Add(_meeting.Organizer);
            Mailmsg.Subject = "Random Meeting App";
            Mailmsg.Body = "Someone logged in your Account with the Random-Meeting App.";
            mClient.Credentials = auth;
            mClient.EnableSsl = true;
     
            try
            {
                // mClient.SendAsync(Mailmsg, Mailmsg.Subject);
                mClient.Send(Mailmsg);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Put everything together in one string for the E-Mail Message
        /// </summary>
        /// <param name="_m"></param>
        /// <returns></returns>
        public string bodyTextBuilder(Meeting _m)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(_m.BodyText); // globale message
            sb.AppendLine("");
            sb.AppendLine(_m.GroupNumber); // Group number
            sb.AppendLine("");
            sb.AppendLine(_m.Location); // Link + Invite Text

            return sb.ToString();
        }
    }
}



