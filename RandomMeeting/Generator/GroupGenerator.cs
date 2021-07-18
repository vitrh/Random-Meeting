using EmailSystemLibrary;
using System;
using System.Collections.Generic;

namespace GeneratorLibrary
{
   public class GroupGenerator
   {

        // Assign the people to groups.
        public List<List<Participant>> SplitList<T>(List<Participant> participants ,int num_groups)
        {

            // Final list that contains several lists 
            List<List<Participant>> listResult = new List<List<Participant>>();

            //Copy List of participants 
            List<Participant> tempParticipants = new List<Participant>();

            //Add every participant in tempparticipants list
            foreach (Participant par in participants)
            {
                tempParticipants.Add(par);
            }

            //Add (n =num_groups) lists in listresult 
            for (int i = 0; i <= num_groups-1 ; i++)
            {
                listResult.Add(new List<Participant>());
            }

            int groupSize = participants.Count / num_groups;
            
            //for every templist in listresult do:
            for (int j = 0; j <= num_groups-1 ; j++)
            {
                List<Participant> tempList = new List<Participant>();

                tempList = listResult[j];

                //add the first item in tempparticipants to templist then remove it from tempparticipants

                for (int k = 0; k < groupSize; k++)
                {
                    tempList.Add(tempParticipants[0]);

                    tempParticipants.Remove(tempParticipants[0]);

                }
                listResult[j] = tempList;

            }
            // add each rest participant who didnt get a group to each templist 

            if (tempParticipants.Count != 0)
            {
                groupSize += 1;

                for (int l = 0; l <= tempParticipants.Count-1 ; l++)
                {
                    listResult[l].Add(tempParticipants[l]);
                }

            }
            return listResult;
        }

        //Randomize the participants
        public  List<Participant> Randomize(List<Participant> items)
        {
            List<Participant> randomlist = new List<Participant>();
            
            //Add the participants to the randomlist
            foreach (var item in items)
            {
                randomlist.Add(item);
            }

            Random rand = new Random();

            // For each spot in the list
            // pick a random item to swap into that spot.
            for (int i = 0; i < randomlist.Count - 1; i++)
            {
                int j = rand.Next(i, items.Count);
                var temp = randomlist[i];
                randomlist[i] = randomlist[j];
                randomlist[j] = temp;
            }
            return randomlist;
        }

        
    }
}
