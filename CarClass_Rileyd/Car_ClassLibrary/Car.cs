using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_ClassLibrary
{   
    public class Car
    {
        //Fields 
        private int _year = 1996;
        private string _make = "cruze";
        private static int _speed;

        //Constructor
        public Car(int year, string model)
        {
            _year = year;
            _speed = 0;
  
         
        }
        // constructor 
        public Car()
        {
            _year = 0;      
            _make = " ";
            _speed = 0;

        }

        // year property
        public int Year
        {
            get { return _year; }

            set { _year = value; }
        }

        // make property 
        public String Make
        {
            get { return _make; }

            set { _make = value; }
        }


        // speed property
        public static int Speed
        
            { get; set; } 
        

        // method to accerlater
        public int accelerateSpeed()
        {    
            Speed +=5;

            return Speed;
        }
        // method to brake
        public int decelerateSpeed()
        {
            Speed -= 5;

            return Speed;
        }
    }

}
