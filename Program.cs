using System.Diagnostics;
using System.Runtime.InteropServices;

namespace AT1_CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Display Class 
            MainMenu dpMain = new MainMenu();
            StudentMenu dpStMenu = new StudentMenu();
            CalculationMenu dpCalMenu = new CalculationMenu();
            MenagementMenu dpMegMenu = new MenagementMenu();
            
            //General Class
            GeneralMethod gnMt = new GeneralMethod();
            
            //Database class
            Database db = new Database();


            bool checke = true;
            bool checkb_sub = true;
            int userInput_sub = 0;

            Database newDB = new Database();

            while (checke) {
                string strPrint = "";
                dpMain.displayMenu();
                strPrint = ("Enter the select number: ");
                int userInput = gnMt.inputIntChecker(strPrint);
                switch (userInput) {
                    case 1:
                        checkb_sub = true;
                        while (checkb_sub)
                        {
                            //Console.ReadLine();
                            Console.Clear();
                            dpStMenu.displayMenu();
                            strPrint = ("Enter the select number: ");
                            userInput_sub = gnMt.inputIntChecker(strPrint);
                            switch (userInput_sub)
                            {
                                case 1:
                                    db.ViewStudent();
                                    Console.WriteLine("\nPress enter to continue . . . .");
                                    Console.ReadLine();
                                    break;
                                case 2:
                                    db.ViewStudentbyID("VIEW");
                                    Console.WriteLine("\nPress enter to continue . . . .");
                                    Console.ReadLine();
                                    break;
                                case 9:
                                    checkb_sub = false;
                                    break;
                                case 0:
                                    checkb_sub = false;
                                    checke = false;
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;

                    case 2:
                        checkb_sub = true;
                        while (checkb_sub)
                        {
                            //Console.ReadLine();
                            Console.Clear();
                            dpCalMenu.displayMenu();
                            strPrint = ("Enter the select number: ");
                            userInput_sub = gnMt.inputIntChecker(strPrint);
                            switch (userInput_sub)
                            {
                                case 1:
                                    db.AvgOfTotalScore();
                                    Console.WriteLine("\nPress enter to continue . . . .");
                                    Console.ReadLine();
                                    break;
                                case 2:
                                    db.MinMaxOfTotalScore();
                                    Console.WriteLine("\nPress enter to continue . . . .");
                                    Console.ReadLine();
                                    break;
                                case 3:
                                    db.StudentAges();
                                    Console.WriteLine("\nPress enter to continue . . . .");
                                    Console.ReadLine();
                                    break;
                                case 9:
                                    checkb_sub = false;
                                    break;
                                case 0:
                                    checkb_sub = false;
                                    checke = false;
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    
                    
                    case 3:
                        checkb_sub = true;
                        while (checkb_sub)
                        {
                            //Console.ReadLine();
                            Console.Clear();
                            dpMegMenu.displayMenu();
                            strPrint = ("Enter the select number: ");
                            userInput_sub = gnMt.inputIntChecker(strPrint);
                            switch (userInput_sub)
                            {
                                case 1:
                                    db.AddStudent();
                                    Console.WriteLine("\nPress enter to continue . . . .");
                                    Console.ReadLine();
                                    break;
                                case 2:
                                    db.UpdateStudent();
                                    Console.WriteLine("\nPress enter to continue . . . .");
                                    Console.ReadLine();
                                    break;
                                case 3:
                                    db.DeleteStudent();
                                    Console.WriteLine("\nPress enter to continue . . . .");
                                    Console.ReadLine();
                                    break;
                                case 4:
                                    db.ViewStudent();
                                    Console.WriteLine("\nPress enter to continue . . . .");
                                    Console.ReadLine();
                                    break;
                                case 9:
                                    checkb_sub = false;
                                    break;
                                case 0:
                                    checkb_sub = false;
                                    checke = false;
                                    break;
                                default:
                                    break;

                            }
                        }
                        break;

                    case 0:
                        checke = false;
                        break;
                    default:
                        break;

                }
                  



            }
            


        }
    }
}
