using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT1_CS
{
    class GeneralMethod
    {

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
                // Use Revers logic if the user input can convert to int or float that mean is not string
                if (!isNumerical) { check = false; }

            }
            return userInput;
        }

        public string inputPhoneChecker(string strPrint)
        {
            bool check = true;
            bool isNumerical;
            string userInput = "";
            int outputNumber;

            while (check)
            {   
                //Console.Clear();
                Console.Write("\n" + strPrint);
                userInput = Console.ReadLine();
                isNumerical = int.TryParse(userInput, out outputNumber);
                // user input have to be a number and this method will return string(number)
                if (isNumerical) { check = false; }
            }

            return userInput;
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
                isDate = DateTime.TryParse(userInput, out dDate);
                if (isDate)
                {
                    userInput = String.Format("{0:d/MM/yyyy}", dDate);
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
