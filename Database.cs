
using System.Data;
using System;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Numerics;
using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Concurrent;


namespace AT1_CS
{
    // Database class created for storing the method that dealing with database
    class Database
    {
        SqlConnection cnn = new SqlConnection();
        GeneralMethod gnMt = new GeneralMethod();
        string connectionString;
        string tagetTable;
        public Database(String tagetTable, string connectionString) { 
            this.tagetTable = tagetTable;
            this.connectionString = connectionString;
        }
        public void ViewStudent()
        {
            cnn = new SqlConnection(this.connectionString);
            cnn.Open();
            string selectQuery = $"SELECT * FROM {this.tagetTable}";
            SqlCommand commandR = new SqlCommand(selectQuery, cnn);
            SqlDataReader reader = commandR.ExecuteReader();

            Console.WriteLine("\nStudents:");
            Console.WriteLine("---------");
            Console.WriteLine("Student ID, Student Name, Phone Number, Email, Date of birth, Enrolment Date, Enrolment Cert, Total Score");
            Console.WriteLine("-------------------------");
            while (reader.Read())
            {
                string readerDob = GetDateWithOutTime("" + reader["DoB"]);
                string readerEnroDate = GetDateWithOutTime("" + reader["EnrolmentDate"]);
                Console.WriteLine($"{reader["StudentId"]}, {reader["FullName"]}, {reader["Phone"]}, {reader["Email"]}, {readerDob}, {readerEnroDate}, {reader["EnrolmentCert"]}, {reader["TotalScore"]}");
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
            int Phone = gnMt.inputPhoneChecker(strPrint);

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
            
            cnn = new SqlConnection(this.connectionString);
            cnn.Open();

            // INSERT INT *tablename (col1, col2, ... ) VALUES (val1, val2, ...)
            string insertquery = "INSERT INTO " +
                $"{this.tagetTable} (FullName, Phone, Email, DoB, EnrolmentDate, EnrolmentCert, TotalScore) " +
                "VALUES (@FullName, @Phone, @Email, @DoB, @EnrolmentDate, @EnrolmentCert, @TotalScore) ";
            SqlCommand command = new SqlCommand(insertquery, cnn);
            command.Parameters.AddWithValue("@FullName", FullName);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@DoB", DoB );
            command.Parameters.AddWithValue("@EnrolmentDate", EnrolmentDate);
            command.Parameters.AddWithValue("@EnrolmentCert", EnrolmentCert);
            command.Parameters.AddWithValue("@TotalScore", TotalScore);
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
                Console.WriteLine("\n Student added successfully.");
            else
                Console.WriteLine("Failed to add student.");

            cnn.Close();

        }
        public void UpdateStudent()
        {
            string strPrint = "";
            int StudentId = ViewStudentbyID("UPDATE");

            strPrint = "Enter student FullName: ";
            string FullName = gnMt.inputStringChecker(strPrint);

            strPrint = "Enter student Phone: ";
            int Phone = gnMt.inputPhoneChecker(strPrint);

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

            cnn = new SqlConnection(this.connectionString);
            cnn.Open();

            string updateQuery = $"UPDATE {this.tagetTable} SET " +
                "FullName = @FullName, Phone = @Phone, Email = @Email, DoB = @DoB, EnrolmentDate = @EnrolmentDate, EnrolmentCert = @EnrolmentCert, TotalScore = @TotalScore " +
                "WHERE StudentId = @StudentId";
            
            SqlCommand command = new SqlCommand(updateQuery, cnn);
            command.Parameters.AddWithValue("@StudentId", StudentId);
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
        public int ViewStudentbyID(string msg)
        {
            string strPrint = "";

            strPrint = ("Enter the student ID for "+msg+": ");
            int StudentId = gnMt.inputIntChecker(strPrint);
            cnn = new SqlConnection(this.connectionString);
            cnn.Open();
            string selectQuery = $"SELECT * FROM {this.tagetTable} WHERE StudentId = @StudentId";
            SqlCommand commandR = new SqlCommand(selectQuery, cnn);
            commandR.Parameters.AddWithValue("@StudentId", StudentId);
            SqlDataReader reader = commandR.ExecuteReader();

            Console.WriteLine("\nStudents:");
            Console.WriteLine("---------");
            Console.WriteLine("Student ID, Student Name, Phone Number, Email, Date of birth, Enrolment Date, Enrolment Cert, Total Score");
            Console.WriteLine("-------------------------");
            while (reader.Read())
            {
                string readerDob = GetDateWithOutTime("" + reader["DoB"]);
                string readerEnroDate = GetDateWithOutTime("" + reader["EnrolmentDate"]);
                Console.WriteLine($"{reader["StudentId"]}, {reader["FullName"]}, {reader["Phone"]}, {reader["Email"]}, {readerDob}, {readerEnroDate}, {reader["EnrolmentCert"]}, {reader["TotalScore"]}");
            }
            reader.Close();
            cnn.Close();

            return StudentId;

        }
        public void DeleteStudent() {

            int StudentId = ViewStudentbyID("DELETE");
            cnn = new SqlConnection(this.connectionString);
            cnn.Open();
            string deleteQuery = $"DELETE FROM {this.tagetTable} WHERE StudentId = @StudentId";
            SqlCommand command = new SqlCommand(deleteQuery, cnn);
            command.Parameters.AddWithValue("@StudentId", StudentId);

            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                Console.WriteLine("\nStudent deleted successfully.");
            }
            else
            {
                Console.WriteLine("\nEmployee not found.");
            }
            cnn.Close();
        }
        public void AvgOfTotalScore()
        {
            cnn = new SqlConnection(this.connectionString);
            cnn.Open();
            string selectQuery = $"SELECT CAST(AVG(TotalScore) as decimal(10,2)) as avgTotal FROM {this.tagetTable}";
            SqlCommand commandR = new SqlCommand(selectQuery, cnn);
            SqlDataReader reader = commandR.ExecuteReader();

            Console.WriteLine("\nAverage Of Total Scores :");
            Console.WriteLine("---------------------------");
           
            while (reader.Read())
            {
                //Console.WriteLine($"{reader["StudentId"]}, {reader["FullName"]}, {reader["Phone"]}, {reader["Email"]}, {reader["DoB"]}, {reader["EnrolmentDate"]}, {reader["EnrolmentCert"]}, {reader["TotalScore"]}");
                Console.WriteLine($"{reader["avgTotal"]}");
            }
            reader.Close();
            cnn.Close();
        }
        public void MinMaxOfTotalScore()
        {
            cnn = new SqlConnection(this.connectionString);
            cnn.Open();
            string selectQuery = "SELECT CAST(MAX(TotalScore) as decimal(10, 2)) as maxTotal," +
                " CAST(MIN(TotalScore) as decimal(10, 2)) as mixTotal " +
                $" FROM {this.tagetTable}";
            SqlCommand commandR = new SqlCommand(selectQuery, cnn);
            SqlDataReader reader = commandR.ExecuteReader();

            Console.WriteLine("\nHigh And Low Of Total Scores :");
            Console.WriteLine("---------------------------");

            while (reader.Read())
            {
                //Console.WriteLine($"{reader["StudentId"]}, {reader["FullName"]}, {reader["Phone"]}, {reader["Email"]}, {reader["DoB"]}, {reader["EnrolmentDate"]}, {reader["EnrolmentCert"]}, {reader["TotalScore"]}");
                Console.WriteLine($"High Scores: {reader["maxTotal"]}");
                Console.WriteLine($"Low Scores: {reader["mixTotal"]}");
            }
            reader.Close();
            cnn.Close();
        }
        public void StudentAges()
        {
            string strPrint = "";

            //strPrint = ("Enter the student ID for " + msg + ": ");
            //int StudentId = gnMt.inputIntChecker(strPrint);
            cnn = new SqlConnection(this.connectionString);
            cnn.Open();
            string selectQuery = $"SELECT StudentId,FullName,DoB FROM {this.tagetTable}";
            SqlCommand commandR = new SqlCommand(selectQuery, cnn);
            SqlDataReader reader = commandR.ExecuteReader();

            Console.WriteLine("\nStudents:");
            Console.WriteLine("---------");
            Console.WriteLine("Student ID, Student Name,Date of birth, Age");
            Console.WriteLine("-------------------------");
            while (reader.Read())
            {
                string readerDob = GetDateWithOutTime(""+reader["DoB"]);
                int age = CalAge(readerDob);

                Console.WriteLine($"{reader["StudentId"]} {reader["FullName"]}, {readerDob}, {age}");
            }
            reader.Close();
            cnn.Close();
        }
        static int CalAge(string DoB) {
            System.DateTime moment = System.DateTime.Now;
            int currentYear = moment.Year;
            
            string[] subs = DoB.Split('/');
            int studentYear = Int32.Parse(subs[2]);
    
            return currentYear- studentYear;
        }
        static string GetDateWithOutTime(string date)
        {
            // Data from database was returened in {dd/mm/yyyy 00:00:00:} format
            // Need Just dd/mm/yyyy format to display and calculation
            string[] subs = date.Split(' ');
            return subs[0];
        }
    }
}

//CREATE TABLE[dbo].[StudentTB] (
//    [StudentId]     INT IDENTITY(1, 1) NOT NULL,
//    [FullName]      NVARCHAR (50)   NOT NULL,
//    [Phone]         INT             NOT NULL,
//    [Email]         NVARCHAR (50)   NOT NULL,
//    [DoB]           DATE            NOT NULL,
//    [EnrolmentDate] DATE            NOT NULL,
//    [EnrolmentCert] NVARCHAR (50)   NOT NULL,
//    [TotalScore]    DECIMAL (10, 2) NOT NULL,
//    PRIMARY KEY CLUSTERED ([StudentId] ASC)
//);