class Program //normal multidimension array
    {
        static void Main(string[] args)
        {
            int[,] marr = new int[2, 3]; //created a multidimensional with 2 rows and 3 columns
            marr[0, 0] = 10;
            marr[0, 1] = 20;
            marr[0, 2] = 30;
            marr[1, 0] = 40;
            marr[1, 1] = 50;
            marr[1, 2] = 60;

            for (int r = 0; r < 2; r++)
            {
                for (int c = 0; c < 3; c++) //nested for loop
                {
                    Console.Write(marr[r, c] + " ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int r = 0; r < 2; r++)
            {
                for (int c = 0; c < 3; c++) //nested for loop
                {
                    Console.Write(marr[r, c] + " ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int[,] marr2 = new int[,] { { 10, 20, 30, 40 }, { 50, 60, 70, 80 } }; // 2 row 44 column

            for (int r = 0; r < 2; r++) // (int r = 0; r < marr2.GetLength(0); r++)
            {
                for (int c = 0; c < 4; c++) //nested for loop or (int c = 0; c < marr2.GetLength(1); c++)
                {
                    Console.Write(marr2[r, c] + " ");

                }
                Console.WriteLine();
            }

            //for (int r = 0; r < marr2.GetLength(0); r++)
            //{
            //    for (int c = 0; c < marr2.GetLength(1); c++)
            //    {
            //        Console.Write(marr2[r, c] + " ");
            //    }

            //    Console.WriteLine();
            //}

        }

    }

class program //jarr array
    {
        static void Main(string[] args)
        {
            int[][] jarr = new int[3][]; // declaring and preparing a space of 3 rows for the array
            jarr[0] = new int[2];
            jarr[1] = new int[4];
            jarr[2] = new int[1];

            int[][] jarr2 = new int[3][] { new int[] { 20, 40 }, new int[] { 50, 60, 70, 80 }, new int[] { 90 } }; // know the value upfront

            foreach (var row in jarr2)
                foreach (var v in row)
                {
                    Console.WriteLine(v);
                }
                Console.WriteLine();

            for (int r = 0; r <jarr2.GetLength(0); r++) // this is to display the jarr array
            {
                for (int c = 0; c < jarr2[r].Length; c++) // some is new in here
                {
                    Console.Write(jarr2[r][c] + " ");
                }
                Console.WriteLine();
            }
                

        }
    }

class program //Class of public and private for object oriented
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student(); //instatiation /creating 
            
            stud1.SetName("David");
            stud1.SetId("A1234");
            stud1.SetAge(20);

            //string na = stud1.SetName()
            //string na = stud1.name;
            string na = stud1.GetName();
            string idee = stud1.GetId();
            int ag = stud1.GetAge();
            Console.WriteLine($"Name {na} , Id: {idee}, Age: {ag}");
            Console.WriteLine(); // paragraph
            stud1.Display();
            
        }

        public class Student
        {
            // data must preserved hidden
            private string name;
            private string id;
            private int age;


            // method

            public void Display()
            {
                Console.WriteLine($"Name: {name}, ID: {id}, Age:{age}");
            }

            public void SetName (string na)
            {
                name = na;
            }

            public void SetId(string idee)
            {
                id = idee;
            }

            public void SetAge(int ag)
            {
                age = ag;
            }

            public string GetName()
            {
                return name;
            }

            public string GetId()
            {
                return id;
            }

            public int GetAge()
            {
                return age;
            }
        }
    }

class program // same as above but with constructer part  
    {
        static void Main(string[] args)
            {
                Student stud1 = new Student(); //instatiation / creating an object stud1 with Student class
                            stud1.Display();
                //stud1.name = "David";
                //stud1.id = "A1234";
                //stud1.age = 20;

                stud1.SetName("David");
                stud1.SetId("A1234");
                stud1.SetAge(20);

                //string na = stud1.name;
                string na = stud1.GetName();
                string idee = stud1.GetId();
                int ag = stud1.GetAge();
                Console.WriteLine($"Name {na} , Id: {idee}, Age: {ag}");


                stud1.Display();

            }

        public class Student
            {
                //data  //preserved hidden
                //public string name;
                //public string id;
                //public int age; 
                private string name;
                private string id;
                private int age;



                //methods
                            public Student()
                {
                    name = "Empty";
                    id = "Empty";
                    age = -111; 

                }

                public void Display()
                {
                    Console.WriteLine($"Name: {name} , ID: {id}, Age:{age}");
                }

                public void SetName (string na)
                {
                    name = na;
                }
                public void SetId(string idee)
                {
                    id = idee;
                }
                public void SetAge(int ag)
                {
                    age = ag;
                }

                public string GetName()
                {
                    return name;
                }

                public string GetId()
                {
                    return id;
                }
                public int GetAge()
                {
                    return age;
                }
            }

    }

