﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT1_CS
{
    class GeneralMethod
    {
        public GeneralMethod() { }
        public string inputStringChecker(string strPrint)
        {

            bool check = true;
            bool isNumerical;
            string userInput = "";
            float outputNumber;

            while (check)
            {
                //Console.Clear();
                Console.Write("\n"+strPrint);
                userInput = Console.ReadLine();
                isNumerical = float.TryParse(userInput, out outputNumber);
                // Use Revers logic if the userInput can convert to int or float that mean is not string
                // if not a string will reques user to input it again
                if (!isNumerical) { check = false; }

            }
            return userInput;
        }

        public int inputPhoneChecker(string strPrint)
        {
            bool check = true;
            bool isNumerical;
            string userInput = "";
            int outputNumber = 0;

            while (check)
            {   
                //Console.Clear();
                Console.Write("\n" + strPrint);
                userInput = Console.ReadLine();
                isNumerical = int.TryParse(userInput, out outputNumber);
                // userInput have to be a number if not will reques user to input it again
                if (isNumerical) { check = false; }
            }

            return outputNumber;
        }

        public string inputDateChecker(string strPrint)
        {
            bool check = true;
            bool isDate;
            string userInput = "";
            DateTime dDate;
            while (check)
            {
                //Console.Clear();
                Console.Write("\n" + strPrint);
                userInput = Console.ReadLine();
                // try to convert userInput to any date format 
                // if not a date format will reques user to input it again
                isDate = DateTime.TryParse(userInput, out dDate);
                
                if (isDate)
                {
                    userInput = String.Format("{0:d-MM-yyyy}", dDate);
                    string[] subs = userInput.Split('-');
                    //Conver dd-mm-yyyy to yyyy-mm-dd for database input format
                    userInput = String.Join("-", subs[2], subs[1], subs[0]);
                    check = false;
                }
            }

            return userInput;
        }
        public float inputScoreChecker(string strPrint)
        {

            bool check = true;
            bool isNumerical;
            string userInput = "";
            float outputNumber = 0;

            while (check)
            {
                //Console.Clear();
                Console.Write("\n" + strPrint);
                userInput = Console.ReadLine();
                isNumerical = float.TryParse(userInput, out outputNumber);
                // userInput have to be a number if not will reques user to input it again
                if (isNumerical) { check = false; }
            }
            return (float)System.Math.Round(outputNumber,2) ;
        }
        public int inputIntChecker(string strPrint)
        {

            bool check = true;
            bool isNumerical;
            string userInput = "";
            int outputNumber = 0;

            while (check)
            {   
                //Console.Clear();
                Console.Write("\n" + strPrint);
                userInput = Console.ReadLine();
                isNumerical = int.TryParse(userInput, out outputNumber);
                if (isNumerical) { check = false; }
            }
            return outputNumber;
        }
    }
}
