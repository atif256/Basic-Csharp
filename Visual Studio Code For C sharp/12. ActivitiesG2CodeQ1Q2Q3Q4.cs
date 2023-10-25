class Program // Answer for Q1
    {
        static void Main(string[] args)
        {

            char countrycode;
            double time1; double time2;
            
                try
                {
                    Console.WriteLine("Please enter the country code: ");
                    countrycode = char.Parse(Console.ReadLine());
                    

                    if ( countrycode! == 'N')
                    {
                        
                        Console.WriteLine("Please enter time on the call (in minutes): ");
                        time1 = double.Parse(Console.ReadLine());
                        Indonesia(ref time1);
                        Console.WriteLine($"Total charge for N: RM {time1}");
                    }
                    else if (countrycode! == 'S')
                    {

                        Console.WriteLine("Please enter time on the call (in minutes): ");
                        time2 = double.Parse(Console.ReadLine());
                        Singapore(ref time2);
                        Console.WriteLine($"Total charge for S: RM {time2}");
                    }
                    else
                    {
                    Console.WriteLine("Invalid country code. Please enter 'N' for indonesia or 'S' for Singapore");
                    }


                }
                catch (FormatException e)
                {
                    Console.WriteLine("Please enter the valid country code: 'N' for indonesia or 'S' for Singapore");
                    Console.WriteLine(e.Message);
                }


        }
        static void Indonesia(ref double N)
        {
            if (N > 0 && N <= 60)
            {
                N = 0.60 * N;
            }
            if (N > 60 && N <= 90)
            {
                N = 0.50 * N;
            }
            if (N > 90)
            {
                N = 0.40 * N;
            }
        }
        static void Singapore(ref double S)
        {
            if (S > 0 && S <= 60)
            {
                S = 0.60 * S;
            }
            if (S > 60)
            {
                S = (0.60 * S) * 0.95;
            }
        }
    }

using System;

class Program // Answer for Q2
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 23, 11, 15, 8, 200, 7, 88, 65 };
            int[] arr2 = new int[8];

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write($"Enter value {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    arr2[i] = value;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    i--; // Retry input for the same index
                }

            }
            Console.WriteLine("\nArray 2:");
            foreach (var v in arr2)
            {
                Console.Write(v + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\narr1 = {23, 11, 15, 8, 200, 7, 88, 65}:");
            for (int i = arr1.Length - 1; i >= 0; i--)
            {
                
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();

            int evenCount = 0;
            foreach (int value in arr2)
            {
                if (isEven(value))
                {
                    evenCount++;
                }
            }
            Console.WriteLine($"\nNumber of even elements in arr2: {evenCount}");

            bool AreArraysEqual = CompareArr(arr1, arr2);
            Console.WriteLine("\nAre arr1 and arr2 the same? " + (AreArraysEqual ? "Yes" : "No"));
        }

        static bool isEven(int value) 
        {
            return value % 2 == 0;
        }

        static bool CompareArr(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
            {
                return false;
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    return false; 
                }
            }

            return true;
        }
    }

using System; //Q3

class Student
{
    // Private fields
    private int studentID;
    private string name;
    private int intakeYear;
    private int english;
    private int math;
    private int chemistry;
    private int biology;
    private int history;

    // Default constructor
    public Student()
    {
        studentID = 0;
        name = "";
        intakeYear = 0;
        english = 0;
        math = 0;
        chemistry = 0;
        biology = 0;
        history = 0;
    }

    // Overloaded constructor
    public Student(int studentID, string name, int intakeYear)
    {
        this.studentID = studentID;
        this.name = name;
        this.intakeYear = intakeYear;
        english = 0;
        math = 0;
        chemistry = 0;
        biology = 0;
        history = 0;
    }

    // Accessor methods (getters)
    public int GetStudentID()
    {
        return studentID;
    }

    public string GetName()
    {
        return name;
    }

    public int GetIntakeYear()
    {
        return intakeYear;
    }

    public int GetEnglish()
    {
        return english;
    }

    public int GetMath()
    {
        return math;
    }

    public int GetChemistry()
    {
        return chemistry;
    }

    public int GetBiology()
    {
        return biology;
    }

    public int GetHistory()
    {
        return history;
    }

    // Mutator methods (setters)
    public void SetStudentID(int studentID)
    {
        this.studentID = studentID;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public void SetIntakeYear(int intakeYear)
    {
        this.intakeYear = intakeYear;
    }

    public void SetEnglish(int english)
    {
        this.english = english;
    }

    public void SetMath(int math)
    {
        this.math = math;
    }

    public void SetChemistry(int chemistry)
    {
        this.chemistry = chemistry;
    }

    public void SetBiology(int biology)
    {
        this.biology = biology;
    }

    public void SetHistory(int history)
    {
        this.history = history;
    }

    // Method to enter marks
    public void EnterMarks()
    {
        Console.WriteLine("Enter marks for English:");
        english = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter marks for Mathematics:");
        math = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter marks for Chemistry:");
        chemistry = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter marks for Biology:");
        biology = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter marks for History:");
        history = int.Parse(Console.ReadLine());
    }

    public void DisplayGrades() 
    {
        Console.WriteLine("English Grade: " + GetGrade(english));
        Console.WriteLine("Math Grade: " + GetGrade(math));
        Console.WriteLine("Chemistry Grade: " + GetGrade(chemistry));
        Console.WriteLine("Biology Grade: " + GetGrade(biology));
        Console.WriteLine("History Grade: " + GetGrade(history));
    }

    //Method to calculate the average marks
    public double CalculateAverage()
    {
        
        double totalMarks = (GetEnglish() + GetMath() + GetChemistry() + GetBiology() + GetHistory());
        double average = totalMarks / 5;
        return average;
    }


    //Helper method to determine the grade based on marks
    private string GetGrade(int marks)
    {
        if (marks >= 80 && marks <= 100)
            return "A";
        else if (marks >= 60 && marks < 80)
            return "B";
        else if (marks >= 50 && marks < 60)
            return "C";
        else if (marks >= 0 && marks < 50)
            return "D";
        else
            return "The marks is out of range, please enter '0' to '100' only";
    }
}

class Program //Q3 sambungan
{
    static void Main()
    {
        Student student = new Student();

        Console.WriteLine("Enter student details:");
        Console.Write("Student ID: ");
        string SetStudentID = Console.ReadLine();
        Console.Write("Name: ");
        student.SetName(Console.ReadLine());
        Console.Write("Intake Year: ");
        student.SetIntakeYear(int.Parse(Console.ReadLine()));
        student.EnterMarks();
        Console.WriteLine("\nStudent Details:");
        Console.WriteLine("Student ID:" + SetStudentID);
        Console.WriteLine($"Name: {student.GetName()}");
        Console.WriteLine($"Intake Year: {student.GetIntakeYear()}");
        //grades A B C D
        Console.WriteLine("\nGrades for Student:");
        student.DisplayGrades();
        //Average Marks
        Console.WriteLine("\nAverage marks for Student: " + student.CalculateAverage());
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;

class Employee //Q4
{
    public string EmployeeName { get; set; }
    public string ID { get; set; }
    public double Salary { get; set; }
    public string DateJoined { get; set; }
}

class Program
{
    static void Main()
    {
        var empList = new List<Employee>();
        string path = @"D:\tempC\Employee.csv";
        // Read data from Employee.csv
        using (StreamReader reader = new StreamReader(path))
        {
            string line;
            bool firstLine = true; // Add this flag to skip the first line
            while ((line = reader.ReadLine()) != null)
            {
                    if (firstLine)
                    {
                        firstLine = false; // Skip the first line (header)
                        continue;
                    }
                    string[] parts = line.Split(',');
                    if (parts.Length == 4)
                    {
                        var employee = new Employee
                        {
                            EmployeeName = parts[0],
                            ID = parts[1],
                            Salary = double.Parse(parts[2]), 
                            DateJoined = parts[3]
                        };
                        empList.Add(employee);
                    }
            }
        }
  

        // Sort employees by name in ascending order
        var sortedByName = empList.OrderBy(e => e.EmployeeName).ToList();

        // Filter employees who joined before 2003
        var joinedBefore2003 = empList
            .Where(e => int.Parse(e.DateJoined.Substring(e.DateJoined.LastIndexOf('/') + 1)) < 2003)
            .ToList();

        // Filter employees with a salary above 5000.00
        var highSalaryEmployees = empList
            .Where(e => e.Salary > 5000.00)
            .ToList();

        // Display the results
        Console.WriteLine("Employees sorted by name in ascending order:");
        foreach (var employee in sortedByName)
        {
            Console.WriteLine($"{employee.EmployeeName}, {employee.ID}, {employee.Salary}, {employee.DateJoined}");
        }

        Console.WriteLine("\nEmployees who joined before 2003:");
        foreach (var employee in joinedBefore2003)
        {
            Console.WriteLine($"{employee.EmployeeName}, {employee.ID}, {employee.Salary}, {employee.DateJoined}");
        }

        Console.WriteLine("\nEmployees with a salary above 5000.00:");
        foreach (var employee in highSalaryEmployees)
        {
            Console.WriteLine($"{employee.EmployeeName}, {employee.ID}, {employee.Salary}, {employee.DateJoined}");
        }

        // Add two more sets of data to the file
        string newData1 = "Lim Ping Seow,B3345,4500,12/12/2004";
        string newData2 = "Miko Lam,B5534,2500,1/3/2018";

        File.AppendAllLines(path, new[] { newData1, newData2 });

        // Display the updated contents of the file
        Console.WriteLine("\nUpdated contents of Employee.csv:");
        foreach (var line in File.ReadLines(path))
        {
            Console.WriteLine(line);
        }
    }
}
