using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Group_6_DIS_Spring_2024
{
    internal class DriverBehaviour
    {
       //declared 4 behaviours
        Boolean isPassengerPresent, isInvolvedInRoadRage;
        int numberOfTickets, experienceInDriving;

        // declaring getter and setter
        public Boolean setIsPassengerPresent(Boolean isPassengerPresent)
        {
            return this.isPassengerPresent = isPassengerPresent;
        } 
        
        public Boolean getIsPassengerPresent()
        {
            return this.isPassengerPresent;
        }

        public Boolean setIsInvolvedInRoadRage(Boolean isInvolvedInRoadRage)
        {
            return this.isInvolvedInRoadRage = isInvolvedInRoadRage;
        }

        public int getNumberOfTickets()
        {
            return numberOfTickets;
        }

        public int setNumberOfTickets(int numberOfTickets)
        {
            return this.numberOfTickets=numberOfTickets;
        }

        public int getExperienceInDriving()
        {
            return numberOfTickets;
        }

        public int setExperienceInDriving(int experienceInDriving)
        {
           return this.experienceInDriving = experienceInDriving;
        }

        }



       
     
    }
}
