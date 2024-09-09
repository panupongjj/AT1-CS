
using System.Data;
using System;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Numerics;
using Microsoft.VisualBasic;


namespace AT1_CS
{
    class Database
    {
        public SqlConnection cnn;
        public string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AT1_CS_DB;Integrated Security=True;";
        public GeneralMethod gnMt = new GeneralMethod();

        // Creating a new student to the database
        public void ViewStudent()
        {
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string selectQuery = "SELECT * FROM StudentTB";
            SqlCommand commandR = new SqlCommand(selectQuery, cnn);
            SqlDataReader reader = commandR.ExecuteReader();

            Console.WriteLine("\nStudents:");
            Console.WriteLine("---------");
            Console.WriteLine("Student ID, Student Name, Phone Number, Email, Date of birth, Enrolment Date, Enrolment Cert, Total Score");
            Console.WriteLine("-------------------------");
            while (reader.Read())
            {
                Console.WriteLine($"{reader["StudentId"]}, {reader["FullName"]}, {reader["Phone"]}, {reader["Email"]}, {reader["DoB"]}, {reader["EnrolmentDate"]}, {reader["EnrolmentCert"]}, {reader["TotalScore"]}");
            }
            reader.Close();
            cnn.Close();
        }

        public void AddStudent()
        {
            string strPrint = "";

            strPrint = "Enter student FullName: ";
            string FullName = gnMt.inputStringChecker(strPrint);

            strPrint = "Enter student Phone: ";
            string Phone = gnMt.inputPhoneChecker(strPrint);

            strPrint = "Enter student Email: ";
            string Email = gnMt.inputStringChecker(strPrint);

            strPrint = "Enter student DoB: ";
            string DoB = gnMt.inputDateChecker(strPrint);

            strPrint = "Enter student EnrolmentDate: ";
            string EnrolmentDate = gnMt.inputDateChecker(strPrint);

            strPrint = "Enter student EnrolmentCert: ";
            string EnrolmentCert = gnMt.inputStringChecker(strPrint);

            strPrint = "Enter student TotalScore: ";
            float TotalScore = gnMt.inputScoreChecker(strPrint);

            cnn = new SqlConnection(connectionString);
            cnn.Open();

            // INSERT INT *tablename (col1, col2, ... ) VALUES (val1, val2, ...)
            string insertquery = "INSERT INTO " +
                "studentTB (FullName, Phone, Email, DoB, EnrolmentDate, EnrolmentCert, TotalScore) " +
                "VALUES (@FullName, @Phone, @Email, @DoB, @EnrolmentDate, @EnrolmentCert, @TotalScore) ";

            SqlCommand command = new SqlCommand(insertquery, cnn);
            command.Parameters.AddWithValue("@FullName", FullName);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@DoB", DoB);
            command.Parameters.AddWithValue("@EnrolmentDate", EnrolmentDate);
            command.Parameters.AddWithValue("@EnrolmentCert", EnrolmentCert);
            command.Parameters.AddWithValue("@TotalScore", TotalScore);

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
                Console.WriteLine("Student added successfully.");
            else
                Console.WriteLine("Failed to add student.");

            cnn.Close();

        }

        public void UpdateStudent()
        {
            string strPrint = "";

            strPrint = ("Enter the student ID to update: ");
            int studentId = gnMt.inputIntChecker(strPrint);
            viewStudentbyID(studentId);

            strPrint = "Enter student FullName: ";
            string FullName = gnMt.inputStringChecker(strPrint);

            strPrint = "Enter student Phone: ";
            string Phone = gnMt.inputPhoneChecker(strPrint);

            strPrint = "Enter student Email: ";
            string Email = gnMt.inputStringChecker(strPrint);

            strPrint = "Enter student DoB: ";
            string DoB = gnMt.inputDateChecker(strPrint);

            strPrint = "Enter student EnrolmentDate: ";
            string EnrolmentDate = gnMt.inputDateChecker(strPrint);

            strPrint = "Enter student EnrolmentCert: ";
            string EnrolmentCert = gnMt.inputStringChecker(strPrint);

            strPrint = "Enter student TotalScore: ";
            float TotalScore = gnMt.inputScoreChecker(strPrint);

            cnn = new SqlConnection(connectionString);
            cnn.Open();

            string updateQuery = "UPDATE studentTB SET " +
                "FullName = @FullName, Phone = @Phone, Email = @Email, DoB = @DoB, EnrolmentDate = @EnrolmentDate, EnrolmentCert = @EnrolmentCert, TotalScore = @TotalScore " +
                "WHERE StudentId = @StudentId";
            
            SqlCommand command = new SqlCommand(updateQuery, cnn);
            command.Parameters.AddWithValue("@FullName", FullName);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@DoB", DoB);
            command.Parameters.AddWithValue("@EnrolmentDate", EnrolmentDate);
            command.Parameters.AddWithValue("@EnrolmentCert", EnrolmentCert);
            command.Parameters.AddWithValue("@TotalScore", TotalScore);
            
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
                Console.WriteLine("\nStudent updated successfully.");
            else
                Console.WriteLine("\nStudent not found.");
            
            cnn.Close();
            
        }
        public void viewStudentbyID(int StudentId)
        {

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string selectQuery = "SELECT * FROM StudentTB  StudentId = @StudentId";
            SqlCommand commandR = new SqlCommand(selectQuery, cnn);
            SqlDataReader reader = commandR.ExecuteReader();

            Console.WriteLine("\nStudents:");
            Console.WriteLine("---------");
            Console.WriteLine("Student ID, Student Name, Phone Number, Email, Date of birth, Enrolment Date, Enrolment Cert, Total Score");
            Console.WriteLine("-------------------------");
            while (reader.Read())
            {
                if (reader.Read())
                {
                    Console.WriteLine($"{reader["StudentId"]}, {reader["FullName"]}, {reader["Phone"]}, {reader["Email"]}, {reader["DoB"]}, {reader["EnrolmentDate"]}, {reader["EnrolmentCert"]}, {reader["TotalScore"]}");
                }
                else {
                    Console.WriteLine("\nNo Student found with the given Id.");
                }
            }
            reader.Close();
            cnn.Close();
        }
        public void DeleteStudent() {
            
            cnn = new SqlConnection(connectionString);
            cnn.Open();

        }


    }
}
