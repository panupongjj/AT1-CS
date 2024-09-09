

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
            Console.Clear();
            Console.WriteLine("###################################################################");
            Console.WriteLine("##################[ Students Management System ]###################");
            Console.WriteLine("###################################################################");
            Console.WriteLine("\t 1. Display students data system");
            Console.WriteLine("\t 2. Calculation system");
            Console.WriteLine("\t 3. Management system");
            Console.WriteLine("\n\t ----------------------");
            Console.WriteLine("\t 0. Exit The Program");
            Console.WriteLine("###################################################################");
        }

    }
    class StudentMenu : Display
    {
        public override void displayMenu()
        {
            Console.Clear();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+++++++++++++++++[ Display Students Data System ]++++++++++++++++++");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("\t 1. Display All Students Data");
            Console.WriteLine("\t 2. Display By Student ID");
            Console.WriteLine("\n\t ----------------------");
            Console.WriteLine("\t 9. Back To Previous Menu");
            Console.WriteLine("\t 0. Exit The Program");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

        }

    }
    class CalculationMenu : Display
    {
        public override void displayMenu()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("----------------------[ Calculation System ]-----------------------");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("\t 1. Average Of Total Scores");
            Console.WriteLine("\t 2. High And Low Scores");
            Console.WriteLine("\t 3. Student Ages");
            Console.WriteLine("\n\t ----------------------");
            Console.WriteLine("\t 9. Back To Previous Menu");
            Console.WriteLine("\t 0. Exit The Program");
            Console.WriteLine("-------------------------------------------------------------------");


        }

    }
    class MenagementMenu : Display
    {
        public override void displayMenu()
        {
            Console.Clear();
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("**********************[ Management system ]************************");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("\t 1. Add New Student Data");
            Console.WriteLine("\t 2. Update Student Data");
            Console.WriteLine("\t 3. Delete Student Data");
            Console.WriteLine("\t 4. View Student Data");
            Console.WriteLine("\n\t ----------------------");
            Console.WriteLine("\t 9. Back To Previous Menu");
            Console.WriteLine("\t 0. Exit The Program");
            Console.WriteLine("*******************************************************************");


        }

    }

}
