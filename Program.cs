namespace AT1_CS
{
    internal class Program
    {
        static void Main(string[] args)
        {


       
            MainMenu dpMain = new MainMenu();
            StudentMenu dpStMenu = new StudentMenu();
            CalculationMenu dpCalMenu = new CalculationMenu();
            MenagementMenu dpMegMenu = new MenagementMenu();
            
            dpMain.displayMenu();
            dpStMenu.displayMenu();
            dpCalMenu.displayMenu();
            dpMegMenu.displayMenu();

            Database newDB = new Database();
            //newDB.AddStudent();
            newDB.ViewStudent();
            newDB.UpdateStudent();

        }
    }
}
