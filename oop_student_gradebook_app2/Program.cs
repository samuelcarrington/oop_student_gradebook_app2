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
            StreamWriter writer = new StreamWriter("gradebook.txt");
            // Ensure the writer will be closed when no longer used
            using (writer)
                // writer.WriteLine(i);
            writer.WriteLine("{0} {1} - {2} - {3} - {4} - {5} - {6} - {7}",
                myNewStudent1.firstName,
                myNewStudent1.lastName,
                myNewStudent1.score1,
                myNewStudent1.score2,
                myNewStudent1.score3,
                myNewStudent1.score4,
                myNewStudent1.score5,
                myNewStudent1.ScoreAvg());

            Console.WriteLine("More Grades to Enter y/n ?");
            

            String x = Console.ReadLine();


            while (x = y)
            {
                //restart program fn F5
            }
            
            
               
            

        }

       

        //Console.ReadLine();
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

       
        

        public double ScoreAvg()
        {
            double scoreAvg = 1;

            scoreAvg = (_Score1 + _Score2 + _Score3 + _Score4 + _Score5) / 5;
            return scoreAvg;
        }
    }
}
