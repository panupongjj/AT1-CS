﻿using System.Diagnostics;
using System.Runtime.InteropServices;

namespace AT1_CS
{   
    // This is the main of the system created for control working flow of the program 
    internal class Program
    {   
        public Program() { 

        }
        static void Main(string[] args)
        {
            //Display Class pass Parameter for display ( Symbol , MenuName)
            MainMenu        dpMain      = new MainMenu("+", "Students Management System");
            StudentMenu     dpStMenu    = new StudentMenu("-", "Display Students Data System");
            CalculationMenu dpCalMenu   = new CalculationMenu("*", "Calculation System");
            MenagementMenu  dpMegMenu   = new MenagementMenu("/", "Management system");
            
            //General Class
            GeneralMethod gnMt = new GeneralMethod();

            //Database class
            string connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AT1_CS_DB;Integrated Security=True;";
            string tagetTable = "StudentTB";
            Database db = new Database(tagetTable, connection);

            //Control flow valiable
            bool checke = true;
            bool checkb_sub = true;
            int userInput_sub = 0;

            while (checke) {
                string strPrint = "";
                //Display Students Management System
                dpMain.displayMenu();
                strPrint = ("Enter the select number: ");
                int userInput = gnMt.inputIntChecker(strPrint);
                switch (userInput) {
                    case 1:
                        //Display Students Data System
                        checkb_sub = true;
                        while (checkb_sub)
                        {
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
                        //Display Calculation System
                        checkb_sub = true;
                        while (checkb_sub)
                        {
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
                        //Display Management system
                        checkb_sub = true;
                        while (checkb_sub)
                        {
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
