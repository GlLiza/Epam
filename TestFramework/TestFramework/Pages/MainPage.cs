using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace NunitTestFramework.Pages
{
    public class MainPage
    {

        private const string BASE_URL = "http://www.lufthansa.com";

        #region Switching between panels

        [FindsBy(How = How.Id, Using = "flightmanager-tab-1")]
        private IWebElement buttonSelectTicket;


        [FindsBy(How = How.Id, Using = "flightmanager-tab-2")]
        private IWebElement buttonSelectCar;


        [FindsBy(How = How.Id, Using = "flightmanager-tab-3")]
        private IWebElement buttontSelectHotel;

        #endregion


        #region Route Elements

        [FindsBy(How = How.Id, Using = "flightmanagerFlightsFormOrigin")]
        private IWebElement inputFromAirport;

        [FindsBy(How = How.Id, Using = "flightmanagerFlightsFormDestination")]
        private IWebElement inputToAirport;

        [FindsBy(How = How.XPath, Using = "//*[@id='flm - flight - trip - block']/div[1]/div/fieldset/div")]
        private IWebElement selectTypeWay;


        [FindsBy(How = How.Id, Using = "flightmanagerFlightsFormTraveldetailsBtn")]
        private IWebElement buttonDetails;

        [FindsBy(How = How.XPath, Using = ".//*[@id='flm - flight - trip - block']/div[2]/div[2]/button")]
        private IWebElement submitSearchFlight;
       

        #endregion


        #region Select AirportFrom

        [FindsBy(How = How.Id, Using = "flightmanagerFlightsFormOriginAirportAtlasCountry")]
        private IWebElement selectCountryFrom;

        [FindsBy(How = How.Id, Using = "flightmanagerFlightsFormOriginAirportAtlasCity")]
        private IWebElement selectCityFrom;

        [FindsBy(How = How.Id, Using = "flightmanagerFlightsFormOriginAirportAtlasAirport")]
        private IWebElement selectAirportFrom;

        [FindsBy(How = How.XPath, Using = "/html/body/div[18]/div/div/form/div[3]/input")]
        private IWebElement submitAfterChooseAirportFrom;
        
        #endregion

        #region Select AirportTo

        [FindsBy(How = How.Id, Using = "flightmanagerFlightsFormDestinationAirportAtlasCountry")]
        private IWebElement selectCountryTo;

        [FindsBy(How = How.Id, Using = "flightmanagerFlightsFormDestinationAirportAtlasCity")]
        private IWebElement selectCityTo;

        [FindsBy(How = How.Id, Using = "flightmanagerFlightsFormDestinationAirportAtlasAirport")]
        private IWebElement selectAirportTo;
        
        #endregion


        #region Details Elements

        [FindsBy(How = How.Id, Using = "traveldetailsAdults")]
        private IWebElement selectAdultsCount;

        [FindsBy(How = How.Id, Using = "traveldetailsChildrenInfantsExpander")]
        private IWebElement selectPlusChildren;

        [FindsBy(How = How.Id, Using = "traveldetailsChildren")]
        private IWebElement selectChildrenCount;

        [FindsBy(How = How.Id, Using = "traveldetailsInfants")]
        private IWebElement selectInfantsCount;

        [FindsBy(How = How.Id, Using = "traveldetailsCabin")]
        private IWebElement selectCabin;

        [FindsBy(How = How.XPath, Using = "//*[@id=flightmanagerFlightsFormTraveldetailsDialog]/div/div/form/div[2]/input")]
        private IWebElement submitNextDetails;


        

        #endregion

        #region Date Elements

        [FindsBy(How = How.Id, Using = "flightmanagerFlightsFormOutboundDateDisplay")]
        private IWebElement toCalendarOpen;

        [FindsBy(How = How.Id, Using = "flightmanagerFlightsFormInboundDateDisplay")]
        private IWebElement backCalendarOpen;

        [FindsBy(How = How.XPath, Using = ".//*[@id='kosa - cal - modal - 1']/div/div/div[2]/div[1]/div[1]/div[2]/table")]
        private IWebElement toCalendar;

        [FindsBy(How = How.XPath, Using = "//*[@id=kosa - cal - modal - 1]/div/div/div[2]/div[1]/div[2]/div[2]/table")]
        private IWebElement backCalendar;

        [FindsBy(How = How.Id, Using = "flightmanagerFlightsFormOutboundDateDisplaymonth-label0")]
        private IWebElement prevMonthTo;

        [FindsBy(How = How.Id, Using = "flightmanagerFlightsFormOutboundDateDisplaymonth-label1")]
        private IWebElement nextMonthTo;

        [FindsBy(How = How.XPath, Using = "//*[@id=kosa-cal-modal-1]/div/div/div[2]/div[1]/div[1]/div[2]/table/tbody/tr[3]/td[3]")]
        private IWebElement selectDateTo;


        [FindsBy(How = How.Id, Using = "flightmanagerFlightsFormInboundDateDisplaymonth-label0")]
        private IWebElement prevMonthBack;

        [FindsBy(How = How.Id, Using = "flightmanagerFlightsFormInboundDateDisplaymonth-label1")]
        private IWebElement nextMonthBack;

        //[FindsBy(How = How.Id, Using = "//*[@id=kosa - cal - modal - 2]/div/div/div[2]/div[1]/div[1]/div[2]/table/tbody/tr[3]/td[4]")]
        //private IWebElement selectDateBack;
        
        #endregion


        #region Errors Elements
        

        [FindsBy(How = How.XPath, Using = ".//*[@id='flightmanagerFlightsForm']/div[1]/div/ul/li/a")]
        private IWebElement errorDestination;

        [FindsBy(How = How.XPath, Using = "//*[@id='flightmanagerFlightsFormTraveldetailsDialog']/div/div/form/div[1]/div/div[1]/div/ul/li/a")]
        private IWebElement errorOverInflants;

        [FindsBy(How = How.XPath, Using = "//*[@id='flightmanagerCarFormdropoffDateDisplay - msg']")]
        private IWebElement errorDateOfReturnCar;  

        [FindsBy(How = How.XPath, Using = "//*[@id='flightmanagerCarForm']/div[1]/div/ul/li[1]/a")]
        private IWebElement errorTimeOfReturnOfCar;

        [FindsBy(How = How.XPath, Using = " //*[@id='flightmanagerFlightsForm']/div[1]/div/ul/li/a")]
        private IWebElement errorPlaceOfDepartArrive;

       
        #endregion

        #region Buttons

        [FindsBy(How = How.Id, Using = "flightmanagerFlightsFormAirportAtlasOrigin")]
        private IWebElement buttonChooseFrom;
     

        [FindsBy(How = How.Id, Using = "flightmanagerFlightsFormAirportAtlasDestination")]
        private IWebElement buttonChooseTo;



        [FindsBy(How = How.XPath, Using = ".//*[@id='flm-flight-trip-block-show']")]
        private IWebElement buttonNext;



        #endregion

        #region Rent Car Elements
        
        [FindsBy(How = How.Id, Using = "flightmanagerCarFormpickup-location-name")]
        private IWebElement inputPlaceOfObtaining;

        [FindsBy(How = How.Id, Using = "flightmanagerCarFormpickupDateDisplay")]
        private IWebElement calenderRentOpen;

        [FindsBy(How = How.Id, Using = "flightmanagerCarFormpickupDateDisplaymonth-label0")]
        private IWebElement prevMonthGetting;

        [FindsBy(How = How.Id, Using = "flightmanagerCarFormpickupDateDisplaymonth-label1")]
        private IWebElement nextMonthGetting;

        [FindsBy(How = How.Id, Using = ".//*[@id='kosa - cal - modal - 3']/div/div/div[2]/div[1]/div[1]/div[2]/table/tbody")]
        private IWebElement calenderRent;

        [FindsBy(How = How.Id, Using = "flightmanagerCarFormpickup-time")]
        private IWebElement timeGetting;



        [FindsBy(How = How.Id, Using = "flightmanagerCarFormdropoff-location-name")]
        private IWebElement inputPlaceOfReturn;

        [FindsBy(How = How.Id, Using = "flightmanagerCarFormdropoffDateDisplay")]
        private IWebElement calenderReturnOpen;

        [FindsBy(How = How.XPath, Using = "//*[@id='kosa - cal - modal - 4']/div/div/div[2]/div[1]/div[1]/div[2]/table")]
        private IWebElement calenderReturn;

        [FindsBy(How = How.Id, Using = "flightmanagerCarFormdropoffDateDisplaymonth-label0")]
        private IWebElement prevMonthReturn;

        [FindsBy(How = How.Id, Using = "flightmanagerCarFormdropoffDateDisplaymonth-label1")]
        private IWebElement nextMonthReturn;

        [FindsBy(How = How.Id, Using = "flightmanagerCarFormdropoff-time")]
        private IWebElement timeReturn;


        [FindsBy(How = How.Id, Using = "flightmanagerCarFormCarCategory")]
        private IWebElement selectTypeCar;

        [FindsBy(How = How.XPath, Using = "//*[@id='flightmanagerCarForm']/div[4]/div[2]/button")]
        private IWebElement searchCar;

        #endregion

        #region Search Hotel
        [FindsBy(How = How.Id, Using = "flightmanagerHotelFormdestination-name")]
        private IWebElement inputPlace;

        [FindsBy(How = How.Id, Using = "flightmanagerHotelFormCheckinDateDisplay")]
        private IWebElement calenderArriveOpen;

        [FindsBy(How = How.Id, Using = "flightmanagerHotelFormCheckinDateDisplaymonth-label0")]
        private IWebElement prevMonthArrive;

        [FindsBy(How = How.Id, Using = "flightmanagerHotelFormCheckinDateDisplaymonth-label1")]
        private IWebElement nextMonthArrive;

        [FindsBy(How = How.XPath, Using = "//*[@id='kosa - cal - modal - 5']/div/div/div[2]/div[1]/div[1]/div[2]/table")]
        private IWebElement calenderArrive;



        [FindsBy(How = How.Id, Using = "flightmanagerHotelFormCheckoutDateDisplay")]
        private IWebElement calenderDeparturуOpen;

        [FindsBy(How = How.Id, Using = "flightmanagerHotelFormCheckoutDateDisplaymonth-label0")]
        private IWebElement prevMonthDeparturу;

        [FindsBy(How = How.Id, Using = "flightmanagerHotelFormCheckoutDateDisplaymonth-label1")]
        private IWebElement nextMonthDeparturу;

        [FindsBy(How = How.XPath, Using = "//*[@id='kosa - cal - modal - 6']/div/div/div[2]/div[1]/div[1]/div[2]/table")]
        private IWebElement calendarDeparturу;

        [FindsBy(How = How.XPath, Using = "//*[@id='flightmanagerHotelForm']/div[4]/div[2]/button")]
        private IWebElement buttonSearchHotel;    

        #endregion

        







        private IWebDriver driver;
        private SelectElement select;

        public IWebElement CalenderArrive { get => calenderArrive; set => calenderArrive = value; }

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }

        public void RentCarOpenForm()
        {
            buttonSelectCar.Click();
        }

        public void TicketOpenForm()
        {
            buttonSelectTicket.Click();
        }

        public void HotelOpenForm()
        {
            buttontSelectHotel.Click();
        }
        public void SetFromAirport(string fromAirport)
        {
            inputFromAirport.SendKeys(fromAirport);
        }
        public void SetToAirport(string toAirport)
        {
            inputToAirport.SendKeys(toAirport);
        }


        public void SetTypeWay()
        {
            driver.FindElement(By.CssSelector("#lhfaToggleRoundtrip")).Click();
          
        }
        public void SearchFlight()
        {
            //submitSearchFlight.Click();
            driver.FindElement(By.CssSelector("#flm-flight-trip-block > div:nth-child(2) > div.start-search.col-md-3.col-lg-4.continue-wrapper > button")).Submit();

        }

        public void ClickNextButton()
        {
            buttonNext.Click();
        }


        #region Select AirportFrom Info

        public void OpenFormForChooseFrom()
        {
            buttonChooseFrom.Click();

        }
        public void SelectFromCountry(string fromCountry)
        {
            selectCountryFrom.SendKeys(fromCountry);
        }
        public void SelectFromCity(string fromCity)
        {
            selectCityFrom.SendKeys(fromCity);
        }
        public void SelectFromAirport(string fromAirport)
        {
            selectAirportFrom.SendKeys(fromAirport);
        }
        public void ChooseFromAirport()
        {
            driver.FindElement(By.CssSelector("body > div.airport-atlas.modal.in > div > div > form > div.modal-footer.lid > input")).Submit();
          
        }

        #endregion

        #region Select AirportTo Info
        public void OpenFormForChooseTo()
        {
            buttonChooseTo.Click();
        }
        public void SelectToCountry(string toCountry)
        {
            selectCountryTo.SendKeys(toCountry);
        }
        public void SelectToCity(string toCity)
        {
            selectCityTo.SendKeys(toCity);
        }
        public void SelectToAirport(string toAirport)
        {
            selectAirportTo.SendKeys(toAirport);
        }
        public void ChooseToAirport()
        {
            driver.FindElement(By.CssSelector("body > div.airport-atlas.modal.in > div > div > form > div.modal-footer.lid > input")).Submit();

        }
        #endregion



        #region Select Details
        public void OpenFormForChooseDetails()
        {
            buttonDetails.Click();
        }

        public void ChooseAdultsCount(string adultsCount)
        {
            select = new SelectElement(selectAdultsCount);
            select.SelectByText(adultsCount);
        }

        public void ChooseCabin(string typeCabin)
        {
            select = new SelectElement(selectCabin);
            select.SelectByText(typeCabin);
        }

        public void ChooseChildrenCount(string childrenCount)
        {
            select = new SelectElement(selectChildrenCount);
            select.SelectByText(childrenCount);
        }

        public void ChooseInflantCount(string inflantCount)
        {
            select = new SelectElement(selectInfantsCount);
            select.SelectByText(inflantCount);
        }

        public void TripWithChildren()
        {
            selectPlusChildren.Click();
        }

        public void ContinueAfterChooseDetails()
        {
            submitNextDetails.Click();
        }

        #endregion

        #region Select DateTo
        public void SelectDatesTo()
        {
            toCalendarOpen.Click();
        }
        public void SetDateTo(DateTime toDate)
        {
            string date = toDate.Day.ToString();
            IWebElement toCalenda= driver.FindElement(By.CssSelector("#kosa-cal-modal-1 > div > div > div.date > div.months-wrapper > div:nth-child(1) > div.month-table"));

            foreach (var c in toCalenda.FindElements(By.TagName("tr")))
            {
                foreach (var d in c.FindElements(By.TagName("td")))
                {
                    if (d.Text.Contains(date))
                    {
                        d.Click();
                        return;
                    }
                }
            }
        }
        public void SelectMonthPrevTo()
        {
            prevMonthTo.Click();
        }
        public void SelectMonthNextTo()
        {
            nextMonthTo.Click();
        }
        #endregion


        #region Select DateBack
        public void SelectDatesBack()
        {
            backCalendarOpen.Click();
        }
        public void SetDateBack(DateTime backDate)
        {
            string date = backDate.Day.ToString();
            foreach (var c in backCalendar.FindElements(By.TagName("tr")))
            {
                foreach (var d in c.FindElements(By.TagName("td")))
                {
                    if (d.Text.Contains(date))
                    {
                        d.Click();
                        return;
                    }
                }
            }
        }
        public void SelectMonthPrevBack()
        {
            prevMonthBack.Click();
        }
        public void SelectMonthNextBack()
        {
            nextMonthBack.Click();
        }

        #endregion


        public By GetFlightsListContainer()
        {
            return By.XPath("//*[@id='page']/cont-ffpp/cont-avails");
        }

        public IEnumerable<IWebElement> GetFlightsListElement(IWebElement dynamicElement)
        {
            return dynamicElement.FindElements(By.XPath("//*[@id='page']/cont-ffpp/cont-avails/pres-avails/div[2]/cont-avail[1]/pres-avail/div/pres-avail-info/div"));
        }









        #region Error messages

        public bool GetErrorDestinationNotFound(string errorMessage)
        {
            return errorDestination.Text == errorMessage;
        }

       

        public bool GetErrorPointOfReturnOfCar(string errorMessage)
        {
            return errorDateOfReturnCar.Text == errorMessage;
        }

        public bool GetErrorPointOfArrivalAndDepart(string errorMessage)
        {
            return errorPlaceOfDepartArrive.Text == errorMessage;
        }

        public bool GetErrorTimeOfReturnCar(string errorMessage)
        {
            return errorTimeOfReturnOfCar.Text == errorMessage;
        }

        public bool GetErrorDateOfReturnCar(string errorMessage)
        {
            return errorTimeOfReturnOfCar.Text == errorMessage;
        }

        public bool GetErrorCountOfInflantsAndAdults(string errorMessage)
        {
            return errorTimeOfReturnOfCar.Text == errorMessage;
        }
        #endregion


        #region Rent cars

        public void SetPlaceGettingCar(string gettingPlaceCar)
        {
            inputPlaceOfObtaining.SendKeys(gettingPlaceCar);
        }
        public void OpenCalenderGettingCar()
        {
            calenderRentOpen.Click();
        }
        public void SelectPrevMonthGettingCar()
        {
            prevMonthGetting.Click();
        }
        public void SelectNextMonthGettingCar()
        {
            nextMonthGetting.Click();
        }
        public void SetDateGettingCar(DateTime dateGetting)
        {
            string date = dateGetting.Day.ToString();
            foreach (var c in calenderRent.FindElements(By.TagName("tr")))
            {
                foreach (var d in c.FindElements(By.TagName("td")))
                {
                    if (d.Text.Contains(date))
                    {
                        d.Click();
                        return;
                    }
                }
            }
        }
        public void SelectTimeGettingCar(string timGetting)
        {
            timeGetting.SendKeys(timGetting);
        }

        public void SetPlaceReturnCar(string returnPlaceCar)
        {
            inputPlaceOfReturn.SendKeys(returnPlaceCar);
        }

        public void OpenCalenderReturnCar()
        {
            calenderReturnOpen.Click();
        }
        public void SelectPrevMonthReturnCar()
        {
            prevMonthReturn.Click();
        }
        public void SelectNextMonthReturnCar()
        {
            nextMonthReturn.Click();
        }
        public void SetDateReturnCar(DateTime dateReturn)
        {
            string date = dateReturn.Day.ToString();
            foreach (var c in calenderReturn.FindElements(By.TagName("tr")))
            {
                foreach (var d in c.FindElements(By.TagName("td")))
                {
                    if (d.Text.Contains(date))
                    {
                        d.Click();
                        return;
                    }
                }
            }
        }
        public void SelectTimeReturnCar(string timeReturn)
        {
            timeGetting.SendKeys(timeReturn);
        }

        public void SelectTypeCar(string typeCar)
        {
            selectTypeCar.SendKeys(typeCar);
        }
        public void SearchCars()
        {
            searchCar.Submit();
        }


        public By GetCarListContainer()
        {
            return By.XPath("//*[@id='car - list']");
        }       

        public IEnumerable<IWebElement> GetCarsListElement(IWebElement dynamicElement)
        {
            return dynamicElement.FindElements(By.XPath("//*[@id='car - list']/li[1]"));
        }
        #endregion


        #region Hotel
        public void SetPlacePoint(string place)
        {
            inputPlace.SendKeys(place);
        }

        public void OpenCalenderArrival()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            calenderArriveOpen.Click();
        }
        public void SelectPrevMonthArrival()
        {
            prevMonthArrive.Click();
        }
        public void SelectNextMonthArrival()
        {
            nextMonthArrive.Click();
        }
        public void SetDateArrival(DateTime dateArrival)
        {
            IWebElement calender = driver.FindElement(By.CssSelector("#kosa-cal-modal-5 > div > div > div.date > div.months-wrapper > div:nth-child(1) > div.month-table > table"));
            string date = dateArrival.Day.ToString();
            foreach (var c in calender.FindElements(By.TagName("tr")))
            {
                foreach (var d in c.FindElements(By.TagName("td")))
                {
                    if (d.Text.Contains(date))
                    {
                        d.Click();
                        return;
                    }
                }
            }
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public void OpenCalenderDeparture()
        {
          
            calenderDeparturуOpen.Submit();
           
        }

        public void SelectPrevMonthDepart()
        {
            prevMonthDeparturу.Click();
        }
        public void SelectNextMonthDepart()
        {
            nextMonthDeparturу.Click();
        }
        public void SetDateDepart(DateTime dateDepar)
        {
            IWebElement calender = driver.FindElement(By.CssSelector("#kosa-cal-modal-6 > div > div > div.date > div.months-wrapper > div:nth-child(1) > div.month-table > table"));
            string date = dateDepar.Day.ToString();
            foreach (var c in calender.FindElements(By.TagName("tr")))
            {
                foreach (var d in c.FindElements(By.TagName("td")))
                {
                    if (d.Text.Contains(date))
                    {
                        d.Click();
                        return;
                    }
                }
            }

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }
       
     
        public void SearchHotels()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            buttonSearchHotel.Submit();
        }

        public By GetHotelsListContainer()
        {
            return By.Id("search_results_table");
        }

        public IEnumerable<IWebElement> GetHotelListElement(IWebElement dynamicElement)
        {
            return dynamicElement.FindElements(By.Id("search_results_table"));
        }

        #endregion
    }
}