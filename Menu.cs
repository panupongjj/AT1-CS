

namespace AT1_CS
{
    class Display
    {
        public Display() { }
        public virtual void displayMenu()
        {
            Console.WriteLine("Students management system");
        }

    }
    class MainMenu : Display
    {
        string manuName;
        string manuSymbol;
        public MainMenu(string manuSymbol, string manuName) { 
            this.manuName = manuName;
            this.manuSymbol = manuSymbol;
        }
        public override void displayMenu()
        {
            Console.Clear();
            string symL = string.Concat(Enumerable.Repeat(this.manuSymbol, 70));
            string symS = string.Concat(Enumerable.Repeat(this.manuSymbol, 20));
            string text = "[ " + this.manuName + " ]";
            Console.WriteLine(symL);
            Console.WriteLine(symS + text+ symS);
            Console.WriteLine(symL);
            Console.WriteLine("\t 1. Display students data system");
            Console.WriteLine("\t 2. Calculation system");
            Console.WriteLine("\t 3. Management system");
            Console.WriteLine("\n\t ----------------------");
            Console.WriteLine("\t 0. Exit The Program");
            Console.WriteLine(symL);
        }

    }
    class StudentMenu : Display
    {
        string manuName;
        string manuSymbol;
        public StudentMenu(string manuSymbol, string manuName)
        {
            this.manuName = manuName;
            this.manuSymbol = manuSymbol;
        }
        public override void displayMenu()
        {
            Console.Clear();
            string symL = string.Concat(Enumerable.Repeat(this.manuSymbol, 70));
            string symS = string.Concat(Enumerable.Repeat(this.manuSymbol, 19));
            string text = "[ " + this.manuName + " ]";
            Console.WriteLine(symL);
            Console.WriteLine(symS + text + symS);
            Console.WriteLine(symL);
            Console.WriteLine("\t 1. Display All Students Data");
            Console.WriteLine("\t 2. Display By Student ID");
            Console.WriteLine("\n\t ----------------------");
            Console.WriteLine("\t 9. Back To Previous Menu");
            Console.WriteLine("\t 0. Exit The Program");
            Console.WriteLine(symL);

        }

    }
    class CalculationMenu : Display
    {
        string manuName;
        string manuSymbol;
        public CalculationMenu(string manuSymbol, string manuName)
        {
            this.manuName = manuName;
            this.manuSymbol = manuSymbol;
        }
        public override void displayMenu()
        {
            Console.Clear();
            string symL = string.Concat(Enumerable.Repeat(this.manuSymbol, 70));
            string symS = string.Concat(Enumerable.Repeat(this.manuSymbol, 24));
            string text = "[ " + this.manuName + " ]";
            Console.WriteLine(symL);
            Console.WriteLine(symS + text + symS);
            Console.WriteLine(symL); 
            Console.WriteLine("\t 1. Average Of Total Scores");
            Console.WriteLine("\t 2. High And Low Scores");
            Console.WriteLine("\t 3. Student Ages");
            Console.WriteLine("\n\t ----------------------");
            Console.WriteLine("\t 9. Back To Previous Menu");
            Console.WriteLine("\t 0. Exit The Program");
            Console.WriteLine(symL);


        }

    }
    class MenagementMenu : Display
    {
        string manuName;
        string manuSymbol;
        public MenagementMenu(string manuSymbol, string manuName)
        {
            this.manuName = manuName;
            this.manuSymbol = manuSymbol;
        }
        public override void displayMenu()
        {
            Console.Clear();
            string symL = string.Concat(Enumerable.Repeat(this.manuSymbol, 71));
            string symS = string.Concat(Enumerable.Repeat(this.manuSymbol, 25));
            string text = "[ " + this.manuName + " ]";
            Console.WriteLine(symL);
            Console.WriteLine(symS + text + symS);
            Console.WriteLine(symL);
            Console.WriteLine("\t 1. Add New Student Data");
            Console.WriteLine("\t 2. Update Student Data");
            Console.WriteLine("\t 3. Delete Student Data");
            Console.WriteLine("\t 4. View Student Data");
            Console.WriteLine("\n\t ----------------------");
            Console.WriteLine("\t 9. Back To Previous Menu");
            Console.WriteLine("\t 0. Exit The Program");
            Console.WriteLine(symL);


        }

    }

}
