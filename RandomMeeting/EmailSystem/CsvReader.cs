using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EmailSystemLibrary
{
    /// <summary>
    /// Reads the given .csv File
    /// </summary>
    public class CsvReader
    {
        /// <summary>
        /// Reads the file and saves it into a Particpant List
        /// </summary>
        /// <param name="filePath">Path of the file</param>
        /// <returns></returns>
        public List<Participant> ReadFile(string filePath, char charSplit)
        {
            List<Participant> partList = new List<Participant>();

            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine(); // reads every line   
                    var values = line.Split(charSplit); // split every line after the ';'
                    Participant participant = new Participant(); // create an instance of Participant
                    participant.Name = values[0]; // Participant Name
                    participant.Email = values[1]; // Participant E-Mail
                    partList.Add(participant);

                }
                // repeat
            }

            return partList; // returns the List with all given Participants

        }

    }
}
