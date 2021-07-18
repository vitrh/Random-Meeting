using System;
using System.Collections.Generic;
using System.Text;

namespace EmailSystemLibrary
{
    /// <summary>
    /// Participant class.
    /// </summary>
    public class Participant
    {
      
        /// Properties
        public string Name { get; set; }
        public string Email { get; set; }

        /// Constructor
        public Participant()
        {

        }
        public Participant(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }
    }
}
