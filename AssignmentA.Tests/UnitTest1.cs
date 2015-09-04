using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AssignmentA;

namespace AssignmentA.Tests
{
    [TestClass]
    public class TestFraudCharacteristics
    {
        [TestMethod]
        public void Test_IsCustomerNotTheOwnerOfCard_ResultsTrue_ForDifferentNames()
        {
            Card card = new Card();
            card.NameOnCard = "Sonu"; 
            Booking demoBooking = new Booking();
            demoBooking.TravelerName="Abhi";
            demoBooking.Card = card;
            Assert.IsTrue(FraudCharacteristics.IsCustomerNotTheOwnerOfCard(demoBooking)); 
        }

        [TestMethod]
        public void Test_IsCustomerNotTheOwnerOfCard_ResultsFalse_ForSameNames()
        {
            Card card = new Card();
            card.NameOnCard = "Abhi";
            Booking demoBooking = new Booking();
            demoBooking.TravelerName = "Abhi";
            demoBooking.Card = card;
            Assert.IsFalse(FraudCharacteristics.IsCustomerNotTheOwnerOfCard(demoBooking));
        }

        [TestMethod]
        public void Test_IsInternationalBooking_ResultsFalse_ForSameCountryCode()
        {
            City sourceCity = new City();
            sourceCity.CountryCode = "IND";
            City destinationCity = new City();
            destinationCity.CountryCode = "IND";
            Booking demoBooking = new Booking();
            demoBooking.Origin = sourceCity;
            demoBooking.Destination = destinationCity;
            Assert.IsFalse(FraudCharacteristics.IsInternationalBooking(demoBooking));
        }

        [TestMethod]
        public void Test_IsInternationalBooking_ResultsTrue_ForDifferentCountryCode()
        {
            City sourceCity = new City();
            sourceCity.CountryCode = "IND";
            City destinationCity = new City();
            destinationCity.CountryCode = "USA";
            Booking demoBooking = new Booking();
            demoBooking.Origin = sourceCity;
            demoBooking.Destination = destinationCity;
            Assert.IsTrue(FraudCharacteristics.IsInternationalBooking(demoBooking));
        }

        [TestMethod]
        public void Test_IsAmountMoreThan1000Usd_ResultsTrue_ForForAmount5000()
        {           
            Booking demoBooking = new Booking();
            demoBooking.TotalFare = 5000; 
            Assert.IsTrue(FraudCharacteristics.IsAmountMoreThan1000Usd(demoBooking));
        }


        [TestMethod]
        public void Test_IsAmountMoreThan1000Usd_ResultsFalse_ForForAmount800()
        {
            Booking demoBooking = new Booking();
            demoBooking.TotalFare = 800;
            Assert.IsFalse(FraudCharacteristics.IsAmountMoreThan1000Usd(demoBooking));
        }
        
        [TestMethod]
        public void Test_IsOneWayBooking_ResultsTrue_ForFalseValueOfIsRoundTrip()
        {
            Booking demoBooking = new Booking();
            demoBooking.IsRoundTrip = false;
            Assert.IsTrue(FraudCharacteristics.IsOneWayBooking(demoBooking));
        }

        [TestMethod]
        public void Test_IsOneWayBooking_ResultsFalse_ForTrueValueOfIsRoundTrip()
        {
            Booking demoBooking = new Booking();
            demoBooking.IsRoundTrip = true;
            Assert.IsFalse(FraudCharacteristics.IsOneWayBooking(demoBooking));
        }

     
        [TestMethod]
        public void Test_IsBookingForFraudDestinations_ResultsTrue_ForNigeria()
        {
            City sourceCity = new City();
            sourceCity.CountryCode = "Nigeria";            
            Booking demoBooking = new Booking();
            demoBooking.Destination = sourceCity;           
            Assert.IsTrue(FraudCharacteristics.IsBookingForFraudDestinations(demoBooking));
        }

        [TestMethod]
        public void Test_IsBookingForFraudDestinations_ResultsTrue_ForIndia()
        {
            City sourceCity = new City();
            sourceCity.CountryCode = "India";
            Booking demoBooking = new Booking();
            demoBooking.Destination = sourceCity;
            Assert.IsFalse(FraudCharacteristics.IsBookingForFraudDestinations(demoBooking));
        }

    }
}
