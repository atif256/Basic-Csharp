class program // Reading and selecting specific char in file
    {
        static void Main(string[] args)
        {
            string path = @"D:\tempC\names.txt";
            //string path = "D:\\tempC\\names.txt";
            using (StreamReader rd = new StreamReader(path))
            {
                string line;

                while ((line = rd.ReadLine()) != null)
                {
                    string[] sp = line.Split(','); // split the data by , sp : David Lee (0) | 901229087773 (1) | Kedah (2)
                    int month = int.Parse(sp[1].Substring(2, 2)); // sp[1] is refer to number part //Substring will take out 12 from 90"12"29087773 (1)
                    switch (month)
                    {
                        case 1:
                            Console.WriteLine("{0} Born in January", sp[0]); // sp[0] is the first array refer to names
                            break;
                        case 2:
                            Console.WriteLine("{0} Born in February", sp[0]);
                            break;
                        case 3:
                            Console.WriteLine("{0} Born in March", sp[0]);
                            break;
                        case 4:
                            Console.WriteLine("{0} Born in April", sp[0]);
                            break;
                        case 5:
                            Console.WriteLine("{0} Born in May", sp[0]);
                            break;
                        case 6:
                            Console.WriteLine("{0} Born in June", sp[0]);
                            break;
                        case 7:
                            Console.WriteLine("{0} Born in July", sp[0]);
                            break;
                        case 8:
                            Console.WriteLine("{0} Born in August", sp[0]);
                            break;
                        case 9:
                            Console.WriteLine("{0} Born in September", sp[0]);
                            break;
                        case 10:
                            Console.WriteLine("{0} Born in October", sp[0]);
                            break;
                        case 11:
                            Console.WriteLine("{0} Born in November", sp[0]);
                            break;
                        case 12:
                            Console.WriteLine("{0} Born in December", sp[0]);
                            break;
                    }


                }
            }

        }
    }

class program // Reading and selecting specific char in file AND UPPER CASE THE INDEX
    {
        static void Main(string[] args)
        {
            string path = @"D:\tempC\TopFive.csv";
            //string path = "D:\\tempC\\TopFive.csv"; they are the same

            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null) //line: Rank, Title, Artist
                    {
                        if (line.IndexOf("Rank") != -1) line = line.ToUpper(); //line: RANK, TITLE, ARTIS

                        if (line.IndexOf("Sia") != -1) line += " ft.Sean Paul"; // add ft.Sean Paul

                        string[] sub = line.Split(','); //line: RANK (0) ,TITLE (1) , ARTIST (2)
                        line = String.Format("{0,-30} {1,-20}", sub[1], sub[2]); // TITLE ARTIST BECAUSE sub[1] = TITLE, sub[2] = ARTIST
                        Console.WriteLine(line); //TITLE , ARTIST
                    }
                }
            }
            catch (Exception error)
            { Console.WriteLine(error.Message); }


        }
    }
