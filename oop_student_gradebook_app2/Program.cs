using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace oop_student_gradebook_app2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Object Oriented Project STUDENT GRADEBOOK APPLICATION 
                Create a console application that will record the homework scores for each student. 
                Define a class student that contains the following information: First Name, Last Name, 
                a score for each of 5 homework assignments, and the average of those assignments. 
                Declare two constructors, including one default constructor. Create a method that will calculate 
                the average of the 5 homework assignments. The application should accept all inputs from a user 
                and then write all of the information to a text file. Make sure the user can input as many 
                students as they want and then can open up the text file to see all of the information.
            */

       
            {
                Student myNewStudent = new Student();

                Console.WriteLine("Student's First Name:");
                String fn = Console.ReadLine();
                Console.WriteLine("Student's Last Name:");
                String ln = Console.ReadLine();
                Console.WriteLine("Homework 1 Score:");
                double s1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Homework 2 Score");
                double s2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Homework 3 Score");
                double s3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Homework 4 Score");
                double s4 = int.Parse(Console.ReadLine());
                Console.WriteLine("Homework 5 Score");
                double s5 = int.Parse(Console.ReadLine());

                Student myNewStudent1 = new Student(fn, ln, s1, s2, s3, s4, s5);

                // Create a StreamWriter instance
                // Ensure the writer will be closed when no longer used

                // Output the header.
                using (StreamWriter s_w = new StreamWriter("gradebook.txt"))
                {   
                    s_w.WriteLine("FirstName \t LastName \t Avg.Score \t Score1 \t Score2 \t Score3 \t Score4 \t Score5");
                }

                // Output the first student.
                // Append to header.
                using (StreamWriter s_w = new StreamWriter("gradebook.txt", true))
                {
                    for (int i = 0; i < 1; i++)
                    {
                        s_w.WriteLine("{0} \t {1} \t {2} \t {3} \t {4} \t {5} \t {6} \t {7}",
                        (myNewStudent1.firstName).PadRight(10, ' '),
                        (myNewStudent1.lastName).PadRight(10, ' '),
                        (myNewStudent1.ScoreAvg()).ToString().PadRight(10, ' '),
                        (myNewStudent1.score1).ToString().PadRight(10, ' '),
                        (myNewStudent1.score2).ToString().PadRight(10, ' '),
                        (myNewStudent1.score3).ToString().PadRight(10, ' '),
                        (myNewStudent1.score4).ToString().PadRight(10, ' '),
                        (myNewStudent1.score5).ToString().PadRight(10, ' '));
                    }
                }
            }
            Console.Write("Continue? y / n : ");    // After each student, the user should be prompted.
            string ans = Console.ReadLine();        // whether or not they would like to continue.
            Console.WriteLine();                    // Skip line
            if (ans != "n")     // If no, exit. Otherwise, Enter another Student. 
            {
                // Enter additional students
                string ans2;
                do
                {
                    Student myNewStudent = new Student();

                    Console.WriteLine("Student's First Name:");
                    String fn = Console.ReadLine();
                    Console.WriteLine("Student's Last Name:");
                    String ln = Console.ReadLine();
                    Console.WriteLine("Homework 1 Score:");
                    double s1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Homework 2 Score");
                    double s2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Homework 3 Score");
                    double s3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Homework 4 Score");
                    double s4 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Homework 5 Score");
                    double s5 = int.Parse(Console.ReadLine());

                    Student myNewStudent1 = new Student(fn, ln, s1, s2, s3, s4, s5);

                    // Create a StreamWriter instance
                    // Ensure the writer will be closed when no longer used

                    // Output the additional students.
                    // Append to previous students
                    using (StreamWriter s_w = new StreamWriter("gradebook.txt", true))
                    {
           
                        for (int i = 0; i < 1; i++)
                        {
                            s_w.WriteLine("{0} \t {1} \t {2} \t {3} \t {4} \t {5} \t {6} \t {7}",
                            (myNewStudent1.firstName).PadRight(10, ' '),
                            (myNewStudent1.lastName).PadRight(10, ' '),
                            (myNewStudent1.ScoreAvg()).ToString().PadRight(10, ' '),
                            (myNewStudent1.score1).ToString().PadRight(10, ' '),
                            (myNewStudent1.score2).ToString().PadRight(10, ' '),
                            (myNewStudent1.score3).ToString().PadRight(10, ' '),
                            (myNewStudent1.score4).ToString().PadRight(10, ' '),
                            (myNewStudent1.score5).ToString().PadRight(10, ' '));
                        }
                    }
                    Console.Write("Continue? y / n : ");    // After each student, the user should be prompted.
                    ans2 = Console.ReadLine();               // whether or not they would like to continue.
                    Console.WriteLine();                    // Skip line
                } while (ans2 != "n");                       // If no, exit. Otherwise, Enter another Student.   
            }
        }
    }
    class Student 
    {
        // Field firstName
        private string _firstName;
        // Field lastName
        private string _lastName;
        // Field Score1
        private double _Score1 = 0;
        // Field Score2
        private double _Score2 = 0;
        // Field Score3
        private double _Score3 = 0;
        // Field Score4
        private double _Score4 = 0;
        // Field Score5
        private double _Score5 = 0;
        // Field _scoreAvg
        private double _scoreAvg = 0;
        //private List<string> student;

        // First Name, Last Name, a score for each of 5 homework assignments, 
        // and the average of those assignments.
        public string firstName{ get { return _firstName;} set { _firstName = value; } }
        public string lastName { get { return _lastName; } set { _lastName = value; } }
        public double score1 { get { return _Score1; } set { _Score1 = value; } }
        public double score2 { get { return _Score2; } set { _Score2 = value; } }
        public double score3 { get { return _Score3; } set { _Score3 = value; } }
        public double score4 { get { return _Score4; } set { _Score4 = value; } }
        public double score5 { get { return _Score5; } set { _Score5 = value; } }
        public double scoreAvg { get { return _scoreAvg; } set { _scoreAvg = value; } }

        // Default constructor
        public Student()
        {
            _firstName = "";
            _lastName = "";
            _Score1 = 15;
            _Score2 = 15;
            _Score3 = 15;
            _Score4 = 15;
            _Score5 = 15;
            _scoreAvg = 15;
        }

        // Constructor with parameters
        public Student(string fn, string ln, double s1, double s2, double s3, double s4, double s5)
        {
            _firstName = fn;
            _lastName = ln;
            _Score1 = s1;
            _Score2 = s2;
            _Score3 = s3;
            _Score4 = s4;
            _Score5 = s5;
        }

        // Create a method that will calculate the average of the 5 homework assignments.
        public double ScoreAvg()
        {
            double scoreAvg = 1;
            scoreAvg = (_Score1 + _Score2 + _Score3 + _Score4 + _Score5) / 5;
            return scoreAvg;
        }
    }
}
