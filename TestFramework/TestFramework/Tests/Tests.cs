using System;
using System.Globalization;
using System.Threading;
using NUnit.Framework;

namespace NunitTestFramework.Tests
{
    [TestFixture]
    public class Tests
    {
        private static Steps.Steps steps = new Steps.Steps();

        private static bool ReturnNextMonth;


        private const string ErrorPointOfArrivalIsNotCorrect = "Пункт назначения указан неверно.";
        private const string ErrorPointOfArrivalAndDepartIsSame = "Аэропорты вылета и прибытия совпадают.";
        private const string ErrorDateReturn = "Введите дату возврата.";
        private const string ErrorInflants = "Количество младенцев превышает количество сопровождающих их взрослых.";


        #region Dates 
        private static DateTime Department_date = DateTime.Now.AddDays(7);
        private static DateTime Return_date = DateTime.Now.AddDays(8);

        private static DateTime Get_car_date = DateTime.Now.AddDays(7);
        private static DateTime Return_car_date = DateTime.Now.AddDays(8);
        #endregion


        [SetUp]
        public static void Init()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            ReturnNextMonth = Return_date.Year > Department_date.Year || Return_date.Month > Department_date.Month ? true : false;
            steps.InitBrowser();
            steps.InitMainPage();
        }

        [TearDown]
        public static void Cleanup()
        {
            steps.CloseBrowser();
        }

       

        [Test]
        public void TestWithOneAdultSixInflants()
         {
            steps.OpenPage();
            steps.ChooseThePointOfDeparture("Belarus", "Minsk", "Minsk(MSQ)");
            steps.ChooseThePointOfArrival("United Kingdom", "Лондон", "London Gatwick (LGW)");
            //steps.Next();
            steps.SetOneWay();
            steps.SetDateDept(Department_date);
            steps.OpenFormForChooseDetails();
            steps.SetAdultsCount("1 взрослый");
            steps.SetInflant("6 младенцев");
            steps.SetClass("Эконом");
            steps.ContinAfterSetDetails();
            steps.SearchFlights();
            Assert.True(steps.GetErrorOfCountInflants(ErrorInflants));
        }


        [Test]
        public void TestTripWithChildren()
        {
            steps.OpenPage();
            steps.ChooseThePointOfDeparture("Belarus", "Minsk", "Minsk (MSQ)");
            steps.ChooseThePointOfArrival("Ukraine", "Kiev", "Kiev - Boryspil Int'l (KBP)");
            //steps.Next();
            steps.SetDateDept(Department_date);
            steps.SetDateReturn(Return_date, ReturnNextMonth);
            steps.OpenFormForChooseDetails();
            steps.SetAdultsCount("1 взрослый");
            steps.SetChildren("1 ребёнок");
            steps.SetClass("Эконом");
            steps.ContinAfterSetDetails();
            steps.SearchFlights();
            Assert.True(steps.HasFlightsList(true));
        }


        [Test]
        public void TestSearchFlightsInOneWay()
        {
            steps.OpenPage();
            steps.ChooseThePointOfDeparture("Belarus", "Minsk", "Minsk(MSQ)");
            steps.ChooseThePointOfArrival("Russian Federation", "Санкт-Петербург", "Санкт-Петербург - Пулково Интернационал (LED)");
            steps.Next();
            steps.SetOneWay();
            steps.SetDateDept(Department_date);
            steps.SetDateReturn(Return_date, ReturnNextMonth);
            steps.OpenFormForChooseDetails();
            steps.SetAdultsCount("1 взрослый");
            steps.SetClass("Эконом");
            steps.ContinAfterSetDetails();
            steps.SearchFlights();
            Assert.True(steps.HasFlightsList(true));
        }

        [Test]
        public void TestSearchFlights()
        {
            steps.OpenPage();
            steps.ChooseThePointOfDeparture("Belarus", "Minsk", "Minsk(MSQ)");
            steps.ChooseThePointOfArrival("Russian Federation", "Санкт-Петербург", "Санкт-Петербург - Пулково Интернационал (LED)");
            steps.Next();
            steps.SetDateDept(Department_date);
            steps.SetDateReturn(Return_date, ReturnNextMonth);
            steps.OpenFormForChooseDetails();
            steps.SetAdultsCount("1 взрослый");
            steps.SetClass("Эконом");
            steps.ContinAfterSetDetails();
            steps.SearchFlights();
            Assert.True(steps.HasFlightsList(true));

        }



        [Test]
        public void TestDateRentCar()
        {
            steps.OpenPage();
            steps.RentCar();
            steps.SetGettingCarInform("London Gatwick", Get_car_date, "11:30");
            steps.SetReturnCarWithoutDate("London Gatwick","12:30");
            steps.SetTypeCar("Компакт");
            steps.SearchCars();
            Assert.IsTrue(steps.GetErrorNotDefinedDateReturnOfCar(ErrorDateReturn));
        }


        [Test]
        public void TestRentCar()
        {
            steps.OpenPage();
            steps.RentCar();
            steps.SetGettingCarInform("London Gatwick", Get_car_date, "08:00");
            steps.SetReturnCarInform("London Gatwick", Return_car_date, "15:00");
            steps.SetTypeCar("Компакт");
            steps.SearchCars();            
            Assert.IsTrue(steps.HasCarsList());
        }

        [Test]
        public void TestSameDestination()
        {
            steps.OpenPage();
            steps.ChooseThePointOfDeparture("Russian Federation", "Москва", "Domodedovo(DME)");
            steps.ChooseThePointOfArrival("Russian Federation", "Москва", "Domodedovo(DME)");
            steps.Next();
            steps.SetOneWay();
            steps.SetDateDept(Department_date);
            steps.SetDateReturn(Return_date, ReturnNextMonth);
            steps.SearchFlights();
            Assert.IsTrue(steps.GetErrorSameAirport(ErrorPointOfArrivalAndDepartIsSame));
           
        }

        [Test]
        public void TestHotel()
        {
            steps.OpenPage();
            steps.HotelClick();
            steps.HotelSetPlace("Москва");
            steps.HotelSetDateArriv(Department_date);
            steps.HotelSetDateDepart(Return_date);
            steps.SearchHotels();
            Assert.True(steps.HasListOfHotels(true));
        }




        [Test]
        public void TestAirportExisting()
        {
            steps.OpenPage();
            steps.EnterRoute("Minsk", "Grodno");
            steps.SetOneWay();
            steps.SetDateDept(Department_date);
            steps.SearchFlights();
            Assert.IsTrue(steps.GetErrorDestination(ErrorPointOfArrivalIsNotCorrect));
        }

    }
}