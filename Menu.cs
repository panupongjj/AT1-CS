using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT1_CS
{
    class Display
    {
        public virtual void displayMenu()
        {
            Console.WriteLine("Students management system");
        }

    }
    class MainMenu : Display
    {
        public override void displayMenu()
        {
            Console.WriteLine("###################################################################");
            Console.WriteLine("################### Students Management System ####################");
            Console.WriteLine("###################################################################");
            Console.WriteLine("\t 1. Display students data system");
            Console.WriteLine("\t 2. Calculation system");
            Console.WriteLine("\t 3. Management system");
            Console.WriteLine("\t ----------------------");
            Console.WriteLine("\t 0. Exit The Program");

        }

    }
    class StudentMenu : Display
    {
        public override void displayMenu()
        {
            Console.WriteLine("###################################################################");
            Console.WriteLine("################## Display Students Data System ###################");
            Console.WriteLine("###################################################################");
            Console.WriteLine("\t 1. Display All Students Data");
            Console.WriteLine("\t 2. Display By Add Filter");
            Console.WriteLine("\t ----------------------");
            Console.WriteLine("\t 9. Back To Previous Menu");
            Console.WriteLine("\t 0. Exit The Program");

        }

    }
    class CalculationMenu : Display
    {
        public override void displayMenu()
        {
            Console.WriteLine("###################################################################");
            Console.WriteLine("####################### Calculation System ########################");
            Console.WriteLine("###################################################################");
            Console.WriteLine("\t 1. Average Of Total Scores");
            Console.WriteLine("\t 2. High And Low Scores");
            Console.WriteLine("\t 3. Student Ages");
            Console.WriteLine("\t ----------------------");
            Console.WriteLine("\t 9. Back To Previous Menu");
            Console.WriteLine("\t 0. Exit The Program");


        }

    }
    class MenagementMenu : Display
    {
        public override void displayMenu()
        {
            Console.WriteLine("###################################################################");
            Console.WriteLine("####################### Management system #########################");
            Console.WriteLine("###################################################################");
            Console.WriteLine("\t 1. Add New Student Data");
            Console.WriteLine("\t 2. Update Student Data");
            Console.WriteLine("\t 3. Delete Student Data");
            Console.WriteLine("\t 4. View Student Data");
            Console.WriteLine("\t ----------------------");
            Console.WriteLine("\t 9. Back To Previous Menu");
            Console.WriteLine("\t 0. Exit The Program");


        }

    }

}
