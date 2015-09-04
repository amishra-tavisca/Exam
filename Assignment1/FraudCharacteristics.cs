using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentA
{
    public class FraudCharacteristics
    {
        public static bool IsCustomerNotTheOwnerOfCard(Booking booking)
        {
            if (!((booking.TravelerName.ToUpper()).Equals(booking.Card.NameOnCard.ToUpper()))) 
            return true;
            return false;
        }

        public static bool IsInternationalBooking(Booking booking)
        {
            if (!((booking.Origin.CountryCode.ToUpper()).Equals(booking.Destination.CountryCode.ToUpper())))
            return true;
            return false;
        }

        public static bool IsAmountMoreThan1000Usd(Booking booking)
        {
            if(booking.TotalFare>1000)
            return true;
            return false;
        }

        public static bool IsOneWayBooking(Booking booking)
        {
            if(booking.IsRoundTrip.Equals(false))
            return true;
            return false;
        }

        public static bool IsBookingForFraudDestinations(Booking booking)
        {
            if(FraudDestinations.IsFraudDestination(booking.Destination.CountryCode).Equals(true))            
            return true;
            return false;
        }


        public static bool IsTravelWithin48Hours(Booking booking)
        {
            if ((booking.TravelDate.Hour - booking.BookingDate.Hour)<=48)           
            return true;
            return false;
        }
        public static bool IsLotsOfBookingsWithSameCard(Booking booking)
        {
            
            return true;
        }

    }
}
