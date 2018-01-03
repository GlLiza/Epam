using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Linq;

namespace NunitTestFramework.Steps
{
    public class Steps
    {
        IWebDriver driver;
        Pages.MainPage mainPage;

        public void InitBrowser()
        {
            driver = Driver.DriverInstance.GetInstance();
        }

        public void InitMainPage()
        {
            mainPage = new Pages.MainPage(driver);
        }

        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
        }

        public void OpenPage()
        {
            mainPage.OpenPage();
        }

        public void HotelClick()
        {
            mainPage.HotelOpenForm();
        }

        public void RentCar()
        {
            mainPage.RentCarOpenForm();
        }


        public void EnterRoute(string fromAirport, string toAirport)
        {
            mainPage.SetFromAirport(fromAirport);
            mainPage.SetToAirport(toAirport);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public void Next()
        {
            mainPage.ClickNextButton();
        }

        public void ChooseThePointOfDeparture(string fromCountry, string fromCity, string fromAirport)
        {
            mainPage.OpenFormForChooseFrom();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            mainPage.SelectFromCountry(fromCountry);
            mainPage.SelectFromCity(fromCity);
            mainPage.SelectFromAirport(fromAirport);
            mainPage.ChooseFromAirport();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public void ChooseThePointOfArrival(string toCountry, string toCity, string toAirport)
        {
            mainPage.OpenFormForChooseTo();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            mainPage.SelectToCountry(toCountry);
            mainPage.SelectToCity(toCity);
            mainPage.SelectToAirport(toAirport);
            mainPage.ChooseToAirport();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public void SearchFlights()
        {
            mainPage.SearchFlight();
        }

        public void SetDateDept(DateTime departmentDate)
        {
            mainPage.SelectDatesTo();
            if (departmentDate.Year > DateTime.Now.Year || departmentDate.Month > DateTime.Now.Month)
            {
                mainPage.SelectMonthNextTo();
            }
            mainPage.SetDateTo(departmentDate);
        }

        public void SetDateReturn(DateTime returnDate, bool returnNextMonth)
        {
            mainPage.SelectDatesBack();
            if (returnNextMonth)
            {
                mainPage.SelectMonthNextBack();
            }
            mainPage.SetDateBack(returnDate);
        }

        public void SetAdultsCount(string adultsCount)
        {
            mainPage.ChooseAdultsCount(adultsCount);
        }
        public void SetClass(string typeClass)
        {
            mainPage.ChooseCabin(typeClass);
           
        }
        public void SetChildren(string countChildren)
        {
            mainPage.TripWithChildren();
            mainPage.ChooseChildrenCount(countChildren);
        }
        public void SetInflant(string countInflant)
        {
            mainPage.TripWithChildren();
            mainPage.ChooseInflantCount(countInflant);
        }

        public void OpenFormForChooseDetails()
        {
            mainPage.OpenFormForChooseDetails();           
        }
        public void ContinAfterSetDetails()
        {
            mainPage.ContinueAfterChooseDetails();
        }

        public void SetOneWay()
        {
            mainPage.SetTypeWay();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }


        #region Car
        public void SetGettingCarInform(string place, DateTime getDate, string time)
        {
            mainPage.SetPlaceGettingCar(place);
            mainPage.OpenCalenderGettingCar();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            if (getDate.Year > DateTime.Now.Year || getDate.Month > DateTime.Now.Month)
            {
                mainPage.SelectNextMonthGettingCar();
            }
            mainPage.SetDateGettingCar(getDate);

            mainPage.SelectTimeGettingCar(time);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public void SetReturnCarInform(string place, DateTime retDate, string time)
        {
            mainPage.SetPlaceReturnCar(place);
            mainPage.OpenCalenderReturnCar();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            if (retDate.Year > DateTime.Now.Year || retDate.Month > DateTime.Now.Month)
            {
                mainPage.SelectNextMonthReturnCar();
            }
            mainPage.SetDateReturnCar(retDate);

            mainPage.SelectTimeReturnCar(time);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public void SetReturnCarWithoutDate(string place,string time)
        {
            mainPage.SetPlaceReturnCar(place);
            mainPage.SelectTimeReturnCar(time);
        }

        public void SetTypeCar(string type)
        {
            mainPage.SelectTypeCar(type);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }
        public void SearchCars()
        {
            mainPage.SearchCars();
           
        }

       

        #endregion


        #region Hotel

        public void HotelSetDateArriv(DateTime arrivalDate)
        {
            if (arrivalDate.Year > DateTime.Now.Year || arrivalDate.Month > DateTime.Now.Month)
            {
                mainPage.SelectNextMonthArrival();
            }
            mainPage.SetDateArrival(arrivalDate);
        }
        public void HotelSetDateDepart(DateTime departmentDate)
        {

            mainPage.OpenCalenderDeparture();
            if (departmentDate.Year > DateTime.Now.Year || departmentDate.Month > DateTime.Now.Month)
            {
                mainPage.SelectNextMonthDepart();
            }
            mainPage.SetDateDepart(departmentDate);
        }

        public void HotelSetPlace(string placeName)
        {
            mainPage.SetPlacePoint(placeName);
        }

        public void SearchHotels()
        {
            mainPage.SearchHotels();
        }

        #endregion

        #region Error message
        public bool GetErrorDestination(string message)
        {
            return mainPage.GetErrorDestinationNotFound(message);
        }

        public bool GetErrorSameAirport(string message)
        {
            return mainPage.GetErrorPointOfArrivalAndDepart(message);
        }

        public bool GetErrorNotDefinedDateReturnOfCar(string message)
        {
            return mainPage.GetErrorDateOfReturnCar(message);
        }

        public bool GetErrorOfCountInflants(string message)
        {
            // return mainPage.GetErrorCountOfInflantsAndAdults(message);
            return false;
        }

        #endregion

        #region HasContent
        public bool HasFlightsList(bool isMainPage)
        {
            foreach (var windowHandle in driver.WindowHandles)
            {
                if (isMainPage)
                {
                    if (windowHandle != driver.CurrentWindowHandle)
                    {
                        driver.SwitchTo().Window(windowHandle);
                        IWebElement dynamicElement = (new WebDriverWait(driver, TimeSpan.Parse("60"))).Until(ExpectedConditions.ElementExists(mainPage.GetFlightsListContainer()));
                        return mainPage.GetFlightsListElement(dynamicElement).Count() > 0;
                    }
                }
                if (!isMainPage)
                {
                    IWebElement dynamicElement = (new WebDriverWait(driver, TimeSpan.Parse("60"))).Until(ExpectedConditions.ElementExists(mainPage.GetFlightsListContainer()));
                    return mainPage.GetFlightsListElement(dynamicElement).Count() > 0;
                }

            }
            return false;
        }

        public bool HasCarsList()
        {
            IWebElement dynamicElement = mainPage.GetCarListContainer();
            if (dynamicElement != null)
                return true;
            else return false;

          
        }

        public bool HasListOfHotels(bool isMainPage)
        {
            foreach (var windowHandle in driver.WindowHandles)
            {
                if (isMainPage)
                {
                    if (windowHandle != driver.CurrentWindowHandle)
                    {
                        driver.SwitchTo().Window(windowHandle);
                        IWebElement dynamicElement = (new WebDriverWait(driver, TimeSpan.Parse("60"))).Until(ExpectedConditions.ElementExists(mainPage.GetHotelsListContainer()));
                        return mainPage.GetHotelListElement(dynamicElement).Count() > 0;
                    }
                }
                if (!isMainPage)
                {
                    IWebElement dynamicElement = (new WebDriverWait(driver, TimeSpan.Parse("60"))).Until(ExpectedConditions.ElementExists(mainPage.GetHotelsListContainer()));
                    return mainPage.GetHotelListElement(dynamicElement).Count() > 0;
                }

            }
            return false;
        }
        #endregion
    }
}