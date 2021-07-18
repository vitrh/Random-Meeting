using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using EmailSystemLibrary;

namespace GeneratorLibrary
{
    public class ICSFileGenerator
                
    {
        
             
      
       /// <summary>
       /// create the ICS File
       /// </summary>
       /// <returns></returns>
        public string CreateICS(Meeting meeting)
        {
            //create a new stringbuilder
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine("BEGIN:VCALENDAR");//start calendar
            
            sb.AppendLine("VERSION:2.0");
            sb.AppendLine("PRODID:-//Google Inc//Google Calendar 70.9054//EN");
            sb.AppendLine("CALSCALE:GREGORIAN");
            sb.AppendLine("METHOD:REQUEST");
            sb.AppendLine("BEGIN:VEVENT");//add the event
            sb.AppendLine("DTSTART:" + meeting.DateStart.ToString("yyyyMMddTHHmm00"));//time for meeting start
            sb.AppendLine("DTEND:" + meeting.DateEnd.ToString("yyyyMMddTHHmm00"));//time for meeting end
            sb.AppendLine("DESCRIPTION:" + meeting.Description);//meeting topic and group nr
            sb.AppendLine("LOCATION:" + meeting.Location);//zoomLink
            sb.AppendLine("UID:" + (Guid.NewGuid().ToString() + meeting.DateStart.ToString("yyyyMMddTHHmm00")));//create unique identifier
            sb.AppendLine("ORGANIZER:MAILTO:" + meeting.Organizer.ToString());//mail adress from organizer
            sb.AppendLine("DTSTAMP:" + meeting.DateStart.ToString("yyyyMMddTHHmm00"));
            sb.AppendLine("END:VEVENT");//end the event

            sb.AppendLine("END:VCALENDAR");//end calendar
            string formalities = sb.ToString();//create a string
            return formalities;
        }   
      
            
        
    }      
}
