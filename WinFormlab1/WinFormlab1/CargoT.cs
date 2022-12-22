using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WinFormlab1
{
    
        

        public enum CargoType
        {
            Car,
            Truck,
            Bus
        }
        public enum CargoMark
        {
            BMW,
            AUDI,
            SKODA
        }

    public class CargoT
        {
            private string firstPlace;
            private string lastPlace;
            decimal? totalPrice;
            int? numberOfDelivery;
            string carCallPrice;
            DateTime dateTime = new DateTime();
            private CargoMark cargoMark;
            private CargoType cargoType;
            private int? amountOfCar;
            /*private string pressRadioButt1;
            private string pressRadioButt2;
            private string pressRadioButt3;*/


        // Mandatory ingredients

        public int? AmountOfCar 
        { 
            get { return amountOfCar; } 
            set { amountOfCar = value; } 
        }
        public string FirstPlace
         {
                get { return firstPlace; }
                set { firstPlace = value; }
         }
        public string LastPlace
         {
            get { return lastPlace; }
            set { lastPlace = value; }
        }
        public decimal? TotalPrice
          {
                get { return totalPrice; }
                set { totalPrice = value; }
          }
        public int? NumberOfDelivery { 
            get { return numberOfDelivery; }
            set { numberOfDelivery = value; }
        }
        public string CarCallPrice
        {
            get { return carCallPrice; }
            set
            {
                carCallPrice = value;
            }
        }

        /*public string PressRadioButt1
    {
            get { return pressRadioButt1; }
            set { pressRadioButt1 = value; }
        }
        public string PressRadioButt2
    {
        get { return pressRadioButt2; }
        set { pressRadioButt2 = value; }
    }
    public string PressRadioButt3
    {
        get { return pressRadioButt3; }
        set { pressRadioButt3 = value; }
    }*/
        public CargoMark mark {
            get; set;
        }
        public CargoType type
        {
            get; set;
        }

        public DateTime Date
            {
                get { return dateTime; }
                set { dateTime = value; }
            }


        }
    }


