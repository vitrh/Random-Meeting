using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;


namespace ControllerLibrary
{
    public class Controller
    {
        /// <summary>
        /// Checks if the E-Mails are valid in the csv file.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public string IsValidEmail(string email)
        {
            try
            {
                var address = new MailAddress(email);
                return email;
            } 
            catch
            {
                return null;

            } 
        }

      
    }
}
