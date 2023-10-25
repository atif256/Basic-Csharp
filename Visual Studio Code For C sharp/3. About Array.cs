class Program //array using loop and displaying array using loop
    {
    static void Main(string[] args)
    {
        int[] arr1;
        int[] arr2 = new int[] { 2, 4, 6, 8, 10 };
        int[] arr3 = { 1, 3, 5, 7, 9 };
        arr1 = new int[3];

        //Console.WriteLine("Enter Value 1:");
        //arr1[0] = int.Parse(Console.ReadLine());

        //Console.WriteLine("Enter Value 2:");
        //arr1[1] = int.Parse(Console.ReadLine());

        //Console.WriteLine("Enter Value 3:");
        //arr1[2] = int.Parse(Console.ReadLine());

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter Value 1:");
            arr1[i] = int.Parse(Console.ReadLine());
        }

        //use loop
        //Console.WriteLine(arr1[0]);
        //Console.WriteLine(arr1[1]);
        //Console.WriteLine(arr1[2]);
        for (int i = 0; i < 3; i++)
            Console.WriteLine(arr1[i] + " ");
            Console.WriteLine();
    }

    }

class Program //filtering and operat with array 12
    {
    static void Main(string[] args)
    {
        int[] arr = { 10, 11, 100, 99, 13, 14, 75, 23, 87, 102, 187, 99, 18 };
        int even = 0;

        for ( int i = 0; i < arr.Length; i++) //using normal loop if
        {
            if (arr[i] % 2 ==0)
                even++;
        }

        Console.WriteLine("The total of even number in the array is : {0}", even);

        int odd = 0;
        foreach(int value in arr) // simple method other than above, or the shorter method to check the array by using the foreach lopp
        {
            if (value % 2 ==1)
            {
                odd++;
            }
        }

        Console.WriteLine("The total of the odd number in the array is: {0}", odd);
    }

    }

class Program //exercise 1
              //Write a program that shall user to enter 6 character value and store the values into array
              //Calculate the total of vowel values entered
    {
    static void Main(string[] args)
    {
        char[] ch = new char[6];
        
        for (int i=0; i<ch.Length; i++)
        {
            Console.WriteLine("Please enter the base value of your money: ");
            ch[i] = char.Parse(Console.ReadLine());

        }

        int vowel = 0;
        foreach (char chvalue in ch)
        {
            switch (chvalue)
            {
                case 'a': 
                case 'e':
                case 'i':
                case 'o': 
                case 'u':
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    vowel++;
                    break;
            }

        }
        Console.WriteLine("The number of vowel : {0}", vowel);


    }

    }

class Program //exercise 2
              //Replacing odd number of integer array with - 111.Given array values: 2,5,8,9,10,6,9
              //Displaying the reverse order of an array 9, 5, 12, 1, 3 ,6, 4
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 2, 5, 8, 9, 10, 6, 9 };

                for (int i = 0; i  < arr1.Length; i++)
                {
                    if (arr1[i] % 2 == 1)
                        arr1[i] = -111;
                }

                foreach (int i in arr1)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();


                            //reversed display
                int[] arr2 = new int[] { 9, 5, 12, 1, 3, 6, 4 };

                // index 0 --> 6
                // index 6 , 5, 4, 3, 2 , 1, 0   arr2[index]

                for (int i = arr2.Length - 1; i >=0; i--)
                {
                    Console.Write(arr2[i] + " ");
                }
                Console.WriteLine();
        }

    }

class program //passing value @ increamnet
    {
        static void Main(string[] args)
        {
            int[] values = { 10, 20, 30, 40, 50, 60, 70, 80 };

            DoubleUp(values);

            foreach (int i in values)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

        }


        static void DoubleUp(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * 2;
            }
        }
    }

