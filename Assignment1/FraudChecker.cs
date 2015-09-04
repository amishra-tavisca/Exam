using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AssignmentA
{
    public class FraudChecker
    {
        public bool IsFraudBooking( Booking booking )
        {
            
            /*
             
            int i=0;
            Type t = typeof(FraudCharacteristics);
            foreach (MethodInfo methodInfo in t)
            {

                if (methodInfo.Invoke(FraudCharacteristics, null) == true)
                    i++;
            }
            if (i >= 2)
                return true;
            return false;
             */

            return true;
        }
    }
    
}
