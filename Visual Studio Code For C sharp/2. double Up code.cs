class Program //doubleup without the refferent, ans=15
    {
        static void Main(string[] args)
        {
            int v1 =15;
            DoubleUp(v1);
            Console.WriteLine("V1 value in main : {0}" , v1);
        }   

        static void DoubleUp (int v1 )
        {
            v1 = v1 * 2;
        }

    }

class Program   //doubleup with the refferent, ans=30
    {
        static void Main(string[] args)
        {
            int v1 =15;
            DoubleUp(ref v1);
            Console.WriteLine("V1 value in main : {0}" , v1);
        }   

        static void DoubleUp (ref int v1 )
        {
            v1 = v1 * 2;
        }

    }

class Program   //with using out, ans=30
    {
        static void Main(string[] args)
        {
            int v1;
            DoubleUp(out v1);
            Console.WriteLine("V1 value in main : {0}" , v1);
        }   

        static void DoubleUp (out int v1 )
        {
            v1= 15; //iniliase the value for v1
            v1 = v1 * 2;
        }

    }

class Program   //Expression Bodies Methods - Single Line
    {
    static void Main(string[] args)
        {
            Display();
            Display2();
        }

    static void Display()
        {
            Console.WriteLine("Welcome to C# Programming");
        }

    //Expression Bodied Methods - Single Line 
    static void Display2() => Console.WriteLine("Welcome to C# Programming");


    static int Power2(int n) => n * n;

    static int Power2b(int n)
        {
            return (n * n);
        }

    }

class Program   //excersice 1
        //Implement a program that shall prompt user for the initial value of their account (base)
        //Create one method that shall calculate accrued/accumulated interest of 5% to the base value  every time  it is called
    {
        static void Main(string[] args)
            {
                double amount;
                Console.WriteLine("Please enter the base value of your money: ");
                amount = double.Parse(Console.ReadLine());

                CalCulate_Interest(ref amount);
                Console.WriteLine($"The amount after 1st interest : {amount}");

                CalCulate_Interest(ref amount);
                Console.WriteLine($"The amount after 2nd interest : {amount}");
            }

        static void CalCulate_Interest(ref double base1)
        {
            base1 = base1 + (base1 * 0.05);
        }

    }

