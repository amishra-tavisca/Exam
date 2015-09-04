using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentA
{
    public class FraudDestinations
    {
        static public List<string> fraudDestinationsList = new List<string>()
        {
	        "Nigeria",
	        "Somalia",	        
	    };
        
        public void AddFraudDestination(string Destination)
        {
            fraudDestinationsList.Add(Destination);
        }


        public void RemoveFraudDestination(string Destination)
        {
            fraudDestinationsList.Remove(Destination);
        }


        public static bool IsFraudDestination(string Destination)
        {
            foreach (string destinationElement in fraudDestinationsList)
            {
                if ((destinationElement.ToUpper()).Equals(Destination.ToUpper())) 
                {
                    return true;
                }
            }
            return false;
        }
    }
}
