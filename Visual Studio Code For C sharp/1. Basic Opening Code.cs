//opening code
class Program
{
    static void Main(string[] args)
    {


    }

    static void Multiply (int n1, double dn2)
    {
       
    }


}

//first static void-returntype name
        //static void Main(string[] args)
        {
            Display();


        }

        static void Display()
        {
            Console.WriteLine("Welcome to C# programming!");
        }


//second
        //static void Main(string[] args)
        {
            double p;

            p = GetPi();
            Console.WriteLine($"The pi value is : {p}");
      

        }

      static double GetPi()
        {
            double pi = 3.142;
            return pi; 
        }


//third
        //static void Main(string[] args)
        {
            int v = 9;

            Power2(v);

            Power2(12);


        }
        static void Power2(int n)
        {
            int answer = n * n;
            Console.WriteLine("Power of 2 : {0}", answer);

        }


//4th or last method 
      //static void Main(string[] args)
        {
  
            
            int solution = Add(12, 34);
            Console.WriteLine("The outcome of addiiton : {0}", solution);

        }

        static int Add (int v1, int v2)
        {
            int answer = v1 + v2;
            return answer; 
        }








//floor
        Console.WriteLine($"Math.Floor(9.2) = {Math.Floor(9.2)}");
Console.WriteLine($"Math.Floor(-9.8) = {Math.Floor(-9.8)}");
Console.WriteLine($"Math.Max(2.3, 12.7) = {Math.Max(2.3, 12.7)}");
Console.WriteLine($"Math.Max(-2.3, -12.7) = {Math.Max(-2.3, -12.7)}");
Console.WriteLine($"Math.Min(2.3, 12.7) = {Math.Min(2.3, 12.7)}");
Console.WriteLine($"Math.Pow(2.0, 3.0) = {Math.Pow(2.0, 3.0)}");
Console.WriteLine($"Math.Pow(9.0, 0.5) = {Math.Pow(9.0, 0.5)}");
Console.WriteLine($"Math.Sqrt(900.0) = {Math.Sqrt(900.0)}");

//exercise chp2

 //static void Main(string[] args) not included in 2022 visual studio
{
    //Prompt users to enter three integer values
    //Implement a method that shall the largest values and return the result
    //Implement a method to check whether the 3 integer values entered contain any even value and return the boolean result

    int v1, v2, v3, largestValue;
    bool evenVal;
    Console.WriteLine("Enter Value 1: ");
    v1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Value 2: ");
    v2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Value 3: ");
    v3 = int.Parse(Console.ReadLine());

    largestValue = Largest(v1, v2, v3);
    //Console.WriteLine("The largest value entered: {0}", largestValue);
    Console.WriteLine($"The largest value entered: {largestValue}");

    evenVal = CheckEven(v1, v2, v3);
    if (evenVal)
    {
        Console.WriteLine("There is a even value");
    }
    else
        Console.WriteLine("There is NO even value");


}
static int Largest(int n1, int n2, int n3)
{
    int large = n1;

    if (n2 >= large)
        large = n2;

    if (n3 >= large)
        large = n3;

    return large;
}

static bool CheckEven(int n1, int n2, int n3)
{
    bool check = false;
    if (n1 % 2 == 0)
    {
        check = true;
    }
    else if (n2 % 2 == 0)
    {
        check = true;
    }
    else if (n3 % 2 == 0)
    {
        check = true;
    }
    return check;
}


//overloaded fuction
class Program
    {
        static void Main(string[] args)
        {

            Add(30, 20);
            Add(2.3, 10.4);
            Add(4, 9.888);
            Add(9.888, 4);
        }

        static void Add (int v1 , int v2)
        {
            Console.WriteLine("Integer Add");
            Console.WriteLine($"The addition outcome: {v1 + v2}");
        }

        static void Add(double v1, double v2)
        {

            Console.WriteLine("Double Add");
            Console.WriteLine($"The addition outcome: {v1 + v2}");
        }
        static void Add(int v1, double v2)
        {

            Console.WriteLine("Mixed Add");
            Console.WriteLine($"The addition outcome: {v1 + v2}");
        }
        static void Add(int v1, int v2, int v3)
        {

            Console.WriteLine("3 integers Add");
            Console.WriteLine($"The addition outcome: {v1 + v2 + v3}");
        }

    }


    //Multiply
    class Program
{
    static void Main(string[] args)
    {
        Multiply(dn2: 9.9999, n1: 56); // named arguments


    }

    static void Multiply (int n1, double dn2)
    {
       double answer = n1 * dn2;
        Console.WriteLine($"answer : {answer}");
    }


}

//parameter jumbling
class Program
{
    static void Main(string[] args)
    {
        Add(n3: 3.3, n2: 2.2, n1: 1.1);
        Add(n2: 2.2, n1: 1.1, n3: 3.3);
        Add(1.1, n3: 3.3, n2: 2.2);
    }

    static void Add (double n1, double n2, double n3)
    {
        Console.WriteLine($"n1: {n1} , n2: {n2} , n3: {n3}");
    }


}

//other example
class Program
{
    static void Main(string[] args)
    {
        Add(); //n1:1.1, n2:2.2 and n3:3.3
        Add(8.77);//n1:8.77, n2:2.2 and n3:3.3
        Add(8.77, 11.666, 21.945); //n1:8.77, n2:11.666 and n3:21.945

        Add(n2: 4.4, n3: 5.5); //n1: 1.1, n2: 4.4, n3:5.5
        Add(n3: 8.8); //n1: 1.1, n2: 2.2, n3 : 8.8
    }

    static void Add (double n1 = 1.1, double n2 = 2.2, double n3 = 3.3) // optional parameters
    {
        Console.WriteLine($"n1: {n1} , n2: {n2} , n3: {n3}");
    }


}

//other example
class Program
{
    static void Main(string[] args)
    {
        PrintOrderDetails("Gift Shop", 31, "Red Mug");
        PrintOrderDetails(orderNum: 31, productName: "Red Mug", sellerName: "Gift Shop");
        PrintOrderDetails(productName: "Red Mug", sellerName: "Gift Shop", orderNum: 31);
        PrintOrderDetails("David", 115);
        PrintOrderDetails("Jenny Lim", orderNum: 455, productName: "mouse");
        //PrintOrderDetails(sellerName: "Robert", 888, productName: "Pencil"); cannot use this

    }

    static void PrintOrderDetails(string sellerName = "No", int orderNum = 0, string productName = "None")
    {
        Console.WriteLine($"Seller: {sellerName}, Order #: {orderNum}, Product: {productName}");
    }


}

//pass by value
class Program
{
    static void Main(string[] args)
    {
        int v1 = 12;
        DoubleUp(v1);
        Console.WriteLine(v1); // this is 12 is v1 in the main
    }

    static void DoubleUp(int v1)
    {
       v1 = v1 * 2; //v1 is empty but recalled v1 in main then v1 = 12
    }


}
