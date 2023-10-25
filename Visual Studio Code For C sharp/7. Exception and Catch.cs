class program // exception formating chp6
    {
        static void Main(string[] args)
        {
            try
            {
                int n1, n2;
                Console.WriteLine("Enter value 1: "); //y
                n1 = int.Parse(Console.ReadLine()); //unhandled exception 


                Console.WriteLine("Enter value 2: ");
                n2 = int.Parse(Console.ReadLine());

                Console.WriteLine("The values entered: {0}   {1}", n1, n2);

                double answer = n1 / n2;  // error is divide by zero
            }
            //catch (Exception e) //mother of exception or we can use FormatException
            //{
            //    Console.WriteLine(e.Message);
            //}
            catch (FormatException e) 
            {
                Console.WriteLine("please enter integer value");
                Console.WriteLine(e.Message);
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("please don't enter zero for second value");
            Console.WriteLine(e.Message);
            }
        }

    }

class program // exception formating enter the value until the user enter the true value
    {
        static void Main(string[] args)
        {
            bool flag = false; // using do while loop
            do
            {
                try
                {
                    int n1, n2;
                    Console.WriteLine("Enter value 1: "); //y
                    n1 = int.Parse(Console.ReadLine()); //unhandled exception 


                    Console.WriteLine("Enter value 2: ");
                    n2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("The values entered: {0}   {1}", n1, n2);

                    double answer = n1 / n2; //divide by zero
                    flag = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Please enter integer value");
                    Console.WriteLine(e.Message);
                    flag = false;
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("please don't enter zero for second value");
                    Console.WriteLine(e.Message);
                    flag = false;
                }
            } while (!flag); //while true the code go to do, if while false the code stop. the flag is false. !flag not false

        }

    }

class program // exception formating excercise array
    { 
        static void Main(string[] args)
        {


            int[] arr = { 10, 20, 30, 40, 50 };
            //Prompt the user which index value of the array needs to be displayed using WriteLine
            //Look for possible exeception in the above scenario
            try
            {
                int index;
                Console.WriteLine("Please enter index that you want to view: ");
                index = int.Parse(Console.ReadLine());
                if (index < 0 && index > 4)
                {
                    throw new IndexOutOfRangeException();
                }
                Console.WriteLine("The value is : {0}", arr[index]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Bye Bye !");

            }

        }

    }

