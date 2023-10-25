class program // string manipulation ex1
    {
        static void Main(string[] args)
        {
            char[] characterArray =
            {'b', 'i', 'r', 't', 'h', ' ', 'd', 'a', 'y'};
            string originalString = "Welcome to C# programming!";
            string string1 = originalString;
            string string2 = new string(characterArray); //string2 birthday (as string)
            string string3 = new string(characterArray, 6, 3); //d[6] a[7] y[8]  //at position 6 of characterArray 'd'- day(string3)
            var string4 = new string('C', 5); //repeat 5 times of C and create a string named string4

            Console.WriteLine($"string1 = \"{string1}\"\n" +
            $"string2 = \"{string2}\"\n" +
            $"string3 = \"{string3}\"\n" +
            $"string4 = \"{string4}\"\n");


        }
    }

class program // string manipulation ex2
    {
        static void Main(string[] args)
        {
            string string1 = "hello there";
            char [] characterArray = new char[5];

            Console.WriteLine($"string1: \"{string1}\""); // output string1

            // test Length property                                     
            Console.WriteLine($"Length of string1: {string1.Length}");

            // loop through characters in string1 and display reversed
            Console.Write("The string reversed is: ");

            for (int i = string1.Length - 1; i >= 0; --i)
            {
                Console.Write(string1[i]);
            }

            // copy characters from string1 into characterArray
            // string1: hello there
            // (0 (position of string1 to copy) , characterArray, 0 (position of characterArray), how many to copy)
            string1.CopyTo(0, characterArray, 0, characterArray.Length);
            Console.Write("\nThe character array is: "); // 'h' 'e' 'l' 'l' 'o'

            foreach (var element in characterArray) // using foreach to display the array
            {
                Console.Write(element);
            }


        }
    }

class program // string manipulation ex3
    {
        static void Main(string[] args)
        {
            var string1 = "hello";
            var string2 = "good bye";
            var string3 = "Happy Birthday";
            var string4 = "happy birthday";

            // output values of four strings
            Console.WriteLine($"string1 = \"{string1}\"" +
            $"\nstring2 = \"{string2}\"" +
            $"\nstring3 = \"{string3}\"" +
            $"\nstring4 = \"{string4}\"\n");

            // test for equality using Equals method
            if (string1.Equals("hello"))
            {
                Console.WriteLine("string1 equals \"hello\"");
            }
            else
            {
                Console.WriteLine("string1 does not equal \"hello\"");
            }

            // test for equality with ==
            if (string1 == "hello")
            {
                Console.WriteLine("string1 equals \"hello\"");
            }
            else
            {
                Console.WriteLine("string1 does not equal \"hello\"");
            }

            // test for equality comparing case
            if (string.Equals(string3, string4)) // static method
            {
                Console.WriteLine("string3 equals string4");
            }
            else
            {
                Console.WriteLine("string3 does not equal string4");
            }

            // test CompareTo
            Console.WriteLine(
            $"\nstring1.CompareTo(string2) is {string1.CompareTo(string2)}");
            Console.WriteLine(
            $"string2.CompareTo(string1) is {string2.CompareTo(string1)}");
            Console.WriteLine(
            $"string1.CompareTo(string1) is {string1.CompareTo(string1)}");
            Console.WriteLine(
            $"string3.CompareTo(string4) is {string3.CompareTo(string4)}");
            Console.WriteLine(
            $"string4.CompareTo(string3) is {string4.CompareTo(string3)}");


        }
    }

class program // string manipulation ex4
    {
        static void Main(string[] args)
        {
            string[] strings = { "started", "starting", "ended", "ending" };

            // test every string to see if it starts with "st"
            foreach (var element in strings)
            {
                if (element.StartsWith("st"))
                {
                    Console.WriteLine($"\"{element}\" starts with \"st\"");
                }
            }

            Console.WriteLine();

            // test every string to see if it ends with "ed"
            foreach (var element in strings)
            {
                if (element.EndsWith("ed"))
                {
                    Console.WriteLine($"\"{element}\" ends with \"ed\"");
                }
            }


        }
    }

class program // string index manipulation (location of array, element and string)
    {
        static void Main(string[] args)
        {
            //IndexOf -> position / index of the value to be searched in the string
            //0:H 1:e 2:l 3:l 4:o 5:H 6:e 7:l 8:l 9:o 10:y 11:o 12:H 13:o 14:w 15:a 16:r 17:e 18:y 19:o 20:u
            string str = "HelloHelloyoHowareyou";
            char[] chr = { 'h', 'l', 'P' };

            Console.WriteLine("LastIndexof 'c'");
            //0:H 1:e 2:l 3:l 4:o 5:H 6:e 7:l 8:l 9:o 10:y 11:o 12:H 13:o 14:w 15:a 16:r 17:e 18:y 19:o 20:u
            Console.WriteLine($"Length : {str.Length}"); //-> 
            Console.WriteLine($"{str.LastIndexOf('o')}"); //-> 19
            Console.WriteLine($"{str.LastIndexOf('o', 18)}"); // from 0, 18 behind direction -> 
            Console.WriteLine($"{str.LastIndexOf('H', 6, 3)}"); // 3 positions ending at 6 -> 4 ,5 6, 
            Console.WriteLine("");

            Console.WriteLine("Indexof 'c'");
            //0:H 1:e 2:l 3:l 4:o 5:H 6:e 7:l 8:l 9:o 10:y 11:o 12:H 13:o 14:w 15:a 16:r 17:e 18:y 19:o 20:u
            Console.WriteLine($"{str.IndexOf('e')}");
            Console.WriteLine($"{str.IndexOf('e', 2)}"); //position 2 onwards -> 6
            Console.WriteLine($"{str.IndexOf('e', 3, 2)}");//starting at 3 -> 2 positions -> -1 (not found)
            Console.WriteLine("");

            Console.WriteLine("Indexof String");
            //0:H 1:e 2:l 3:l 4:o 5:H 6:e 7:l 8:l 9:o 10:y 11:o 12:H 13:o 14:w 15:a 16:r 17:e 18:y 19:o 20:u
            Console.WriteLine($"{str.IndexOf("Hello")}");
            Console.WriteLine($"{str.IndexOf("Hello", 2)}"); //From 2 --> 5
            Console.WriteLine($"{str.IndexOf("Hello", 2, 5)}"); //starting at 2-> 5 positions -> -1
            Console.WriteLine("");

            Console.WriteLine("LastIndexof String");
            //0:H 1:e 2:l 3:l 4:o 5:H 6:e 7:l 8:l 9:o 10:y 11:o 12:H 13:o 14:w 15:a 16:r 17:e 18:y 19:o 20:u
            Console.WriteLine($"{str.LastIndexOf("Hello")}"); // -> 5
            Console.WriteLine($"{str.LastIndexOf("Hello", 4)}"); //up to 4 -> from 0 up to 4
            Console.WriteLine($"{str.LastIndexOf("Hello", 4, 5)}"); //5 positions ending at 4 -> 4 3 2 1 0
            Console.WriteLine("");

            Console.WriteLine("IndexofAny String");
            //chr h l p 
            //0:H 1:e 2:l 3:l 4:o 5:H 6:e 7:l 8:l 9:o 10:y 11:o 12:H 13:o 14:w 15:a 16:r 17:e 18:y 19:o 20:u
            Console.WriteLine($"{str.IndexOfAny(chr)}"); // first occurence of h l or p
            Console.WriteLine($"{str.IndexOfAny(chr, 10)}"); //position 10 onwards -> -1
            Console.WriteLine("");

            Console.WriteLine("LastIndexofAny String");
            //chr h l p 
            //0:H 1:e 2:l 3:l 4:o 5:H 6:e 7:l 8:l 9:o 10:y 11:o 12:H 13:o 14:w 15:a 16:r 17:e 18:y 19:o 20:u

            Console.WriteLine($"{str.LastIndexOfAny(chr)}"); // From behind the first occurence of h l or p
            Console.WriteLine($"{str.LastIndexOfAny(chr, 7)}"); //starting 0 to 7 (up to 7) -> 1

            Console.WriteLine("\n");


        }
    }

class program // string manipulation (substring)
    {
        static void Main(string[] args)
        {
            //0:H 1:e 2:l 3:l 4:o 5:H 6:e 7:l 8:l 9:o 10:y 11:o 12:H 13:o 14:w 15:a 16:r 17:e 18:y 19:o 20:u
            string str = "HelloHelloyoHowareyou";

            //substring method is extract sub part of the string

            string sub1 = str.Substring(12);
            Console.WriteLine(sub1);


            string sub2 = str.Substring(12, 3);

            Console.WriteLine(sub2);


        }
    }

class program // string manipulation (split substring) exercises
    {
        static void Main(string[] args)
        {
            //Extract the IC components into sub parts according DOB , State No. , Last Ic Number
            string ic = "901223-07-9995";

            string dob = ic.Substring(0, 6);
            int findex = ic.IndexOf('-') + 1;
            string state = ic.Substring(findex, 2);
            int lindex = ic.LastIndexOf('-') + 1;
            string last4 = ic.Substring(lindex, 4);

            Console.WriteLine($"dob part: {dob}");
            Console.WriteLine($"state part: {state}");
            Console.WriteLine($"ic part: {last4}");
            string ic_New = dob + "/" + state + "/" + last4;
            Console.WriteLine($"Ic in slash : {ic_New}");

            string[] icparts = ic.Split('-'); //split

            Console.WriteLine($"dob part: {icparts[0]}");
            Console.WriteLine($"state part: {icparts[1]}");
            Console.WriteLine($"ic part: {icparts[2]}");

            string ic_New2 = String.Join("/", icparts);

            Console.WriteLine($"Ic in slash : {ic_New2}");


        }
    }

class program // string manipulation (split and remove substring) exercises 2
    {
        static void Main(string[] args)
        {
            string car1 = "Ghibli"; //car1 - string 
            string car2 = "GranTurismo";  //car2 - string 
                                        //Car1 -> Ghibli
                                        //Car2 -> GranTurismo

            Console.Write("Original: ");
            Console.WriteLine("\tCar 1: " + car1 + "\t\tCar 2: " + car2);
            //Car1 -> Ghibli
            //Car2 -> GranTurismo

            car1 = String.Copy(car2); //copy value of car2 to car1 
            Console.Write("\nCopied: ");
            Console.WriteLine("\tCar 1: " + car1 + "\tCar 2: " + car2);
            //Car1 -> GranTurismo
            //Car2 -> GranTurismo

            int num = car1.Length; //  11
            char[] model = new char[num]; //create a space an array of character sizeof 11

            car1.CopyTo(0, model, 0, num); //Take Car1 GranTurismo (position 0) G,  model at position 0
                                        //model (array) G r a n T u r i s m o (as array of character)

            Console.Write("\nCharacter Array: ");
            foreach (char c in model) { Console.Write(c + " "); }

            //Car1 -> GranTurismo
            //Car2 -> GranTurismo
            car1 = car1.Remove(4);// in Car1 T is a at position 4 from position remove all.  ->Gran
            Console.WriteLine("\n\nRemoved...\tCar 1: " + car1);
            //Car1 -> Gran
            //Car2 -> GranTurismo


            car1 = car1.Insert(0, "Maserati "); //Car1-> Gran position 0/ G insert Maserati -> Maserati Gran
                                                //car1 -> Maserati Gran  
            car1 = car1.Insert(13, "Cabrio"); //Car1 13 next to n of Gran to insert Cabrio
                                            // Car1 -> Maserati GranCabrio
            Console.WriteLine("\nInserted...\tCar 1: " + car1);

            car1 = car1.Replace("GranCabrio", "Quattroporte");  //replace the value of GranCabrio with a new value

            //car1 Maserati Quattroporte
            Console.WriteLine("\nReplaced...\tCar 1: " + car1);

        }
    }

class program // currency symbol added decimal
    {
        static void Main(string[] args)
        {
            double val = 3.40121;
            //double val = 3.4;
            Console.WriteLine(val.ToString("C"));
            Console.WriteLine(val.ToString("0.####")); // show 4 decimal only
            Console.WriteLine(val.ToString("0.0000"));  // show 4 decimal place but add 0000
            Console.WriteLine(val.ToString("G")); // G is general number format as same as 3.40121
            Console.Write(String.Format("\nCurrency:\t {0:C}", val));

        }

    }

class program // Decimal  place manipulation
    {
        static void Main(string[] args)
        {
            double val = 3.40121;
            Console.WriteLine(val.ToString("C"));
            Console.WriteLine(val.ToString("0.####"));
            Console.WriteLine(val.ToString("0.0000"));
            Console.WriteLine(val.ToString("G"));
            Console.Write(String.Format("\nCurrency:\t {0:C}", val));
            Console.WriteLine();

            double value = 2500.00;

            Console.WriteLine("Value with G: {0:G}", value); //General
            Console.WriteLine("Value with F: {0:F}", value); //Fixed Point
            Console.WriteLine("Value with N: {0:N}", value);//Number with comma separated thousands
            Console.WriteLine("Value with C: {0:C}", value); // To represent currency
            Console.WriteLine("Value with P: {0:P}", value / 1000); //To represent percentage
            Console.WriteLine("Value with 00.000: {0:00000.0000}", value); //To determine precesion point and zero padding 

        }

    }

