class program // getter and satter
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
            //stud1.SetAge(20);
            stud1.Age = 20;

            //string na = stud1.name;
            string na = stud1.GetName();
            string idee = stud1.GetId();
            //int ag = stud1.GetAge();
            int ag = stud1.Age;
            Console.WriteLine($"Name {na} , Id: {idee}, Age: {ag}");


            Student stud2 = new Student("Jenny Lim", "H1111", 24); //overloaded to assing the values

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

            //To set and get age --> Public Name Property method
            public int Age
            {
                get
                {
                    return age;
                }
                set
                {
                    age = value;
                }
            }



            //methods

            public Student()
            {
                name = "Empty";
                id = "Empty";
                age = -111;
                Console.WriteLine("Object created");

            }
            public Student(string name, string id, int age)
            {
                this.name = name;
                this.id = id;
                this.age = age;
            }

            public void Display()
            {
                Console.WriteLine($"Name: {name} , ID: {id}, Age:{age}");
            }

            public void SetName(string name)
            {
                this.name = name;
            }
            public void SetId(string id)
            {
                this.id = id;
            }
            //public void SetAge(int ag)
            //{
            //    age = ag;
            //}

            public string GetName()
            {
                return name;
            }

            public string GetId()
            {
                return id;
            }
            //public int GetAge()
            //{
            //    return age;
            //}
        }

    }

class program // without setter and getter more shorter
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student(); //instatiation / creating an object stud1 with Student class
            stud1.Display();
        
            stud1.Name = "David";
            stud1.SetId("A1234");
            stud1.Age = 20;

            string na = stud1.Name;
            string idee = stud1.GetId();
            int ag = stud1.Age;
            Console.WriteLine($"Name {na} , Id: {idee}, Age: {ag}");


            Student stud2 = new Student("Jenny Lim", "H1111", 24); //overloaded to assing the values

            stud1.Display();

        }

        public class Student
        {
            public string Name { get; set; }
            private string id;
            private int age;

            //To set and get age --> Public Name Property method
            public int Age //name property
            {
                get
                {
                    return age;
                }
                set
                {
                    age = value;
                }
            }



            //methods

            public Student()
            {
                Name = "Empty";
                id = "Empty";
                age = -111;
                Console.WriteLine("Object created");

            }
            public Student(string name, string id, int age)
            {
                Name = name;
                this.id = id;
                this.age = age;
            }

            public void Display()
            {
                Console.WriteLine($"Name: {Name} , ID: {id}, Age:{age}");
            }

            public void SetId(string id)
            {
                this.id = id;
            }

            public string GetId()
            {
                return id;
            }
            
        }
    }

class program // new
    { 
    static void Main(string[] args)
    {
        Student stud1 = new Student(); //instatiation / creating an object stud1 with Student class
        stud1.Display();
        //stud1.name = "David";
        //stud1.id = "A1234";
        //stud1.age = 20;

        //stud1.SetName("David");
        stud1.Name = "David";
        stud1.SetId("A1234");
        //stud1.SetAge(20);
        stud1.Age = 20;

        //string na = stud1.name;
        //string na = stud1.GetName();
        string na = stud1.Name;
        string idee = stud1.GetId();
        //int ag = stud1.GetAge();
        int ag = stud1.Age;
        Console.WriteLine($"Name {na} , Id: {idee}, Age: {ag}");


        Student stud2 = new Student("Jenny Lim", "H1111", 24); //overloaded to assing the values

        stud1.Display();

        PartTime pt1 = new PartTime("Michael Tan", "H8888", 18, "Block c");
        pt1.DisplayP();

    }

    public class Student
    {
        //data  //preserved hidden
        //public string name;
        //public string id;
        //public int age; 
        // private string name;

        //Auto-Implemented properties
        public string Name { get; set; }
        protected string id;
        protected int age;

        //To set and get age --> Public Name Property method
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }



        //methods

        public Student()
        {
            Name = "Empty";
            id = "Empty";
            age = -111;
            Console.WriteLine("Object created");

        }
        public Student(string name, string id, int age)
        {
            Name = name;
            this.id = id;
            this.age = age;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name} , ID: {id}, Age:{age}");
        }

        //public void SetName (string name)
        //{ 
        //    this.name = name;
        //}
        public void SetId(string id)
        {
            this.id = id;
        }
        //public void SetAge(int ag)
        //{
        //    age = ag;
        //}

        //public string GetName()
        //{
        //    return name;
        //}

        public string GetId()
        {
            return id;
        }
        //public int GetAge()
        //{
        //    return age;
        //}
    }

        public class PartTime : Student
        {
            private string roomNo;

            public string RoomNo
            {
                get { return roomNo; }
                set { roomNo = value; }
            }

            public void DisplayP()
            {
                Console.WriteLine($"Name: {Name}, Id: {id} , Age: {age}, Room No: {roomNo}");
            }

            public PartTime(string na, string idee, int ag, string ron)
            {

                Name = na;
                id = idee;
                age = ag;
                roomNo = ron;
            }
        }
    }

class program // poligon class
    {
        static void Main(string[] args)
            {
                Rectangle rect = new Rectangle();
                Triangle cone = new Triangle();

                rect.setValues(4, 5);
                cone.setValues(4, 5);

                Console.WriteLine("Rectangle Area: " + rect.area());
                Console.WriteLine("\nTriangle Area: " + cone.area());
            }
            public class Polygon
            {
                protected int width, height;

                public void setValues(int width, int height)
                {
                    this.width = width;
                    this.height = height;
                }
            }

            public class Rectangle : Polygon
            {
                public int area() { return (width * height); }
            }

            public class Triangle : Polygon
            {
                public int area() { return ((width * height) / 2); }
            }
    }

class program // overloaded parent
    { 
        static void Main(string[] args)
        {
            Daughter anna = new Daughter();
            Son brad = new Son();
            Son carl = new Son(100);

        }
        public class Parent
        {
            public Parent()
            {
                Console.WriteLine("Parent Called");
            }

            public Parent(int num)
            {
                Console.WriteLine("Parent+ Called: " + num);
            }
        }

        public class Daughter : Parent
        {
            public Daughter()
            { Console.WriteLine("\tDaughter Called\n"); }
        }

        public class Son : Parent
        {
            public Son()
            { Console.WriteLine("\tSon Called\n"); }

            public Son(int num) : base(num)
            { Console.WriteLine("\tSon+ Called: " + num); }
        }
    }

class program // overloaded
    {
        static void Main(string[] args)
        {
            Man henry = new Man(); 

            Malay enri = new Malay(); // Malay class

            henry.speak(); //under Man class
            henry.speak("It's a beautiful evening"); //under Man class

            enri.speak("Selamat Pagi"); //Malay class

            ((Man)enri).speak("Selamat Datang ke Malaysia"); //calling the Man speak

        }
        public class Man
        {
            public void speak()
            {
                Console.Write("Hello: ");
            }

            public void speak(string message) //overloded speak
            {
                Console.WriteLine(message + "! Wow !\n");
            }
        }

        public class Malay : Man //malay is inherit in man
        {
            public new void speak(string message)
            {
                base.speak();
                Console.WriteLine(message);
            }
        }
    }

class program // example of polymorphism / virtual class
    {
        static void Main(string[] args)
        {

            Pigeon joey = new Pigeon();
            Chicken lola = new Chicken();

            describe(joey);
            describe(lola);
            Console.ReadKey();
        }

        static void describe(Bird obj)
        {
            obj.talk();
            obj.fly();
        }

        public class Bird
        {
            public virtual void talk()
            { Console.WriteLine("A Bird Talks..."); }

            public virtual void fly()
            { Console.WriteLine("A Bird Flies...\n"); }
        }

        public class Pigeon : Bird
        {
            public override void talk()
            { Console.WriteLine("Pigeon Says: Coo! Coo!"); }

            public override void fly()
            {
                Console.WriteLine("A Pigeon Flies Away...");
                base.fly();
            }
        }

        public class Chicken : Bird
        {
            public override void talk()
            { Console.WriteLine("Chicken Says: Cluck! Cluck!"); }

            public override void fly()
            {
                Console.WriteLine("I'm A Chicken - I Can't Fly!");
                base.fly();
            }
        }
    }

