class program // chpter 5 LINQ
    {
        static void Main(string[] args)
        {
            int[] arr = { 20, 80, 100, 121, 245, 23, 88, 90, 91, 27, 345, 78, 93, 13, 9, 11, 201, 7 };

            var great100 = from v in arr
                        where v > 100
                        select v; // when v is true the select the value to foreach

        foreach (var i in great100)
            {
                Console.Write(i + " ");
            }
        Console.WriteLine("\n");

            //filter the even values
            var evenlist = from n in arr
                        where n % 2 == 0
                        select n;

            foreach (var i in evenlist)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }

class program // to asgin average, min and max in a array (integer)
    {
        static void Main(string[] args)
        {
            int[] arr = { 100, 120, 30, 12, 167, 89, 29, 55, 90, 203, 165, 25, 48, 118, 9, 91, 7, 66 };


            var vlist = from v in arr
                        where v < 100
                        orderby v ascending
                        select v;

            Console.Write("The Filtered values: ");
            foreach (var i in vlist)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("The average value in the list : {0}", vlist.Average());
            Console.WriteLine("The maximum value in the list : {0}", vlist.Max());
            Console.WriteLine("The minimum value in the list : {0}", vlist.Min());


            var vlist2 = from v in arr
                        where v >= 80 && v <= 170
                        select v;

            foreach (var i in vlist2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

    }

class program // to asgin average, min and max in a array (integer)
    {
        static void Main(string[] args)
        {

            //use LINQ to query all the vowel values . you may implement your own method to find vowel
            char[] chArr = { 'a', 'b', 'd', 'k', 'E', 'i', 'O', 'f', 'w', 'p', 'u', 'p', 'Q', 'X', 'A', 'Y' };

            var vowelL = from ch in chArr
                        where isVowel(ch)
                        select ch;

            foreach (var c in vowelL)
            {
                Console.Write(c + "  ");
            }
            Console.WriteLine();


        }

        static bool isVowel(char c) //if c is a vowel value then return true 
        {
            bool flag = false;
            switch (char.ToUpper(c))
            {
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    flag = true;
                    break;

            }
            return flag;

        }

    }

class program // code that cover a lot of things about LINQ
    {
        static void Main(string[] args)
        {

            // initialize array of employees
            var employees = new[] {
            new Employee("Jason", "Red", 5000M),
            new Employee("Ashley", "Green", 7600M),
            new Employee("Matthew", "Indigo", 3587.5M),
            new Employee("James", "Indigo", 4700.77M),
            new Employee("Luke", "Indigo", 6200M),
            new Employee("Jason", "Blue", 3200M),
            new Employee("Wendy", "Brown", 4236.4M)};

            // display all employees
            Console.WriteLine("Original array:");
            foreach (var element in employees)
            {
                Console.WriteLine(element);
            }

            // filter a range of salaries using && in a LINQ query
            var between4K6K =
            from e in employees
            where (e.MonthlySalary >= 4000M) && (e.MonthlySalary <= 6000M)
            select e;

            // display employees making between 4000 and 6000 per month
            Console.WriteLine("\nEmployees earning in the range " +
            $"{4000:C}-{6000:C} per month:");
            foreach (var element in between4K6K)
            {
                Console.WriteLine(element);
            }

            // order the employees by last name, then first name with LINQ

            var nameSorted =
            from e in employees
            orderby e.LastName, e.FirstName
            select e;

            // header
            Console.WriteLine("\nFirst employee when sorted by name:");

            // attempt to display the first result of the above LINQ query
            if (nameSorted.Any())
            {
                Console.WriteLine(nameSorted.First());
            }
            else
            {
                Console.WriteLine("not found");
            }

            // use LINQ to select employee last names
            var lastNames =
            from e in employees
            select e.LastName;

            // use method Distinct to select unique last names
            Console.WriteLine("\nUnique employee last names:");
            foreach (var element in lastNames.Distinct())
            {
                Console.WriteLine(element);
            }

            // use LINQ to select first and last names
            var names =
            from e in employees
            select new { e.FirstName, e.LastName };

            // display full names
            Console.WriteLine("\nNames only:");
            foreach (var element in names)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();

        }
        class Employee
        {
            public string FirstName { get; } // read-only auto-implemented property
            public string LastName { get; } // read-only auto-implemented property
            private decimal monthlySalary; // monthly salary of employee

            // constructor initializes first name, last name and monthly salary
            public Employee(string firstName, string lastName,
            decimal monthlySalary)
            {
                FirstName = firstName;
                LastName = lastName;
                MonthlySalary = monthlySalary;
            }

            // property that gets and sets the employee's monthly salary
            public decimal MonthlySalary
            {
                get
                {
                    return monthlySalary;
                }
                set
                {
                    if (value >= 0M) // validate that salary is nonnegative
                    {
                        monthlySalary = value;
                    }
                }
            }

            // return a string containing the employee's information
            public override string ToString() =>
            $"{FirstName,-10} {LastName,-10} {MonthlySalary,10:C}";
        }

    }

class program 
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[10];

            //when is created the system will assign a particular size of the list
            //the of the list is auto extended by the system 
            List<int> ls = new List<int>();
            ls.Add(10);
            ls.Add(20);
            ls.Add(30);
            ls.Add(40);
            Console.WriteLine("List content after inserting 4 values : ");
            foreach (var i in ls)
            {
                Console.Write(i + "   ");
            }
            Console.WriteLine();

            ls.Insert(0, 5); //0 is the index or the position to insert and 5 is the value to insert
            Console.WriteLine("List AFTER inserting value in position 0:");
            foreach (var i in ls)
            {
                Console.Write(i + "   ");
            }
            Console.WriteLine();

        }

    }

class program 
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[10];

            //when is created the system will assign a particular size of the list
            //the of the list is auto extended by the system 
            List<int> ls = new List<int>();
            ls.Add(10);
            ls.Add(20);
            ls.Add(30);
            ls.Add(40);
            Console.WriteLine("List content after inserting 4 values : ");
            foreach (var i in ls)
            {
                Console.Write(i + "   ");
            }
            Console.WriteLine();

            ls.Insert(0, 5); //0 is the index or the position to insert and 5 is the value to insert
                            // ls -> 5 , 10, 20 , 30 , 40
            Console.WriteLine("List AFTER inserting value in position 0:");
            foreach (var i in ls)
            {
                Console.Write(i + "   ");
            }
            Console.WriteLine();

            // ls -> 5 , 10, 20 , 30 , 40
            Console.WriteLine(ls[2]);  //20 to be displayed


            ls.Remove(40);  //remove the value of 40
            Console.WriteLine("List AFTER removing value 40:");
            foreach (var i in ls)
            {
                Console.Write(i + "   ");
            }
            Console.WriteLine();

            ls.RemoveAt(0);
            Console.WriteLine("List AFTER removing AT position 0:");
            foreach (var i in ls)
            {
                Console.Write(i + "   ");
            }
            Console.WriteLine();

            // int [] arr = new int [] { 1, 2, 3, 4, 5};
            List<int> ls2 = new List<int>() { 1, 2, 3, 4, 5 };

            List<int> ls3 = new List<int>(ls);

        }

    }

class program 
    {
        static void Main(string[] args)
        {
            // create a new List of strings
            var items = new List<string>();

            // display List’s Count and Capacity before adding elements
            Console.WriteLine("Before adding to items: " +
            $"Count = {items.Count}; Capacity = {items.Capacity}");

            items.Add("red"); // append an item to the List          
            items.Insert(0, "yellow"); // insert the value at index 0

            // display List’s Count and Capacity after adding two elements
            Console.WriteLine("After adding two elements to items: " +
            $"Count = {items.Count}; Capacity = {items.Capacity}");

            // display the colors in the list
            Console.Write(
            "\nDisplay list contents with counter-controlled loop:");
            for (var i = 0; i < items.Count; i++)
            {
                Console.Write($" {items[i]}");
            }

            // display colors using foreach 
            Console.Write("\nDisplay list contents with foreach statement:");
            foreach (var item in items)
            {
                Console.Write($" {item}");
            }

            items.Add("green"); // add "green" to the end of the List
            items.Add("yellow"); // add "yellow" to the end of the List

            // display List’s Count and Capacity after adding two more elements
            Console.WriteLine("\n\nAfter adding two more elements to items: " +
            $"Count = {items.Count}; Capacity = {items.Capacity}");

            // display the List
            Console.Write("List with two new elements:");
            foreach (var item in items)
            {
                Console.Write($" {item}");
            }

            items.Remove("yellow"); // remove the first "yellow"

            // display the List
            Console.Write("\n\nRemove first instance of yellow:");
            foreach (var item in items)
            {
                Console.Write($" {item}");
            }

            items.RemoveAt(1); // remove item at index 1

            // display the List
            Console.Write("\nRemove second list element (green):");
            foreach (var item in items)
            {
                Console.Write($" {item}");
            }

            // display List’s Count and Capacity after removing two elements
            Console.WriteLine("\nAfter removing two elements from items: " +
            $"Count = {items.Count}; Capacity = {items.Capacity}");

            // check if a value is in the List
            Console.WriteLine("\n\"red\" is " +
            $"{(items.Contains("red") ? string.Empty : "not ")}in the list");

            items.Add("orange"); // add "orange" to the end of the List
            items.Add("violet"); // add "violet" to the end of the List
            items.Add("blue"); // add "blue" to the end of the List

            // display List’s Count and Capacity after adding three elements
            Console.WriteLine("\nAfter adding three more elements to items: " +
            $"Count = {items.Count}; Capacity = {items.Capacity}");

            // display the List
            Console.Write("List with three new elements:");
            foreach (var item in items)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine();

        }

    }

class program 
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>() { 8, 2, 4, 6, 8, 10, 11 };
            num.Add(18);
            num.Insert(1, 111); //insert value at position 1
            num.Remove(4); //remove first occurence of 4
            num.RemoveAt(6); // remove at index location 
            int value = num.IndexOf(8, 0); // find the location of 8 starting position 0
            num.RemoveAt(value);
            Console.WriteLine(value);

        }

    }

class program 
    {
        static void Main(string[] args)
        {
            // populate a List of strings 
            var items = new List<string>();
            items.Add("aQua"); // add "aQua" to the end of the List
            items.Add("RusT"); // add "RusT" to the end of the List
            items.Add("yElLow"); // add "yElLow" to the end of the List
            items.Add("rEd"); // add "rEd" to the end of the List

            // display initial List
            Console.Write("items contains:");
            foreach (var item in items)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine(); // output end of line

            // convert to uppercase, select those starting with "R" and sort
            var startsWithR =
            from item in items
            let uppercaseString = item.ToUpper()
            where uppercaseString.StartsWith("R")
            orderby uppercaseString
            select uppercaseString;

            // display query results
            Console.Write("results of query startsWithR:");
            foreach (var item in startsWithR)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine(); // output end of line

            items.Add("rUbY"); // add "rUbY" to the end of the List      
            items.Add("SaFfRon"); // add "SaFfRon" to the end of the List

            // display initial List
            Console.Write("items contains:");
            foreach (var item in items)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine(); // output end of line

            // display updated query results
            Console.Write("results of query startsWithR:");
            foreach (var item in startsWithR)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine(); // output end of line

        }

    }