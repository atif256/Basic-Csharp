class program //append the file
    {
        static void Main(string[] args)
        {
            string path = "D:\\tempC\\PRAC2.txt";

            if (File.Exists(path)) // if  thefile already existed yhen return true
            {
                string txt2 = "\r\nI feel good. 'Cause I just know feeling of you. Give it to me baby.";
                File.AppendAllText(path, txt2); // this is to add existing txtfile
            }
            else
            {
                

                string txt = "Close your eyes. Come to me";
                txt = txt + "\r\nFeel all right. Just dance with me all through the night.\r\nTurn it out. Close to you.";


                try
                {
                    File.WriteAllText(path, txt);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }


        }

        

    }


class program //append other file txt
    {
        static void Main(string[] args)
        {
            string path = @"D:\\tempC\\makanan.txt";

        
            if (File.Exists(path)) 
            {
                string[] food2 = { " Pizza", "Chicken Rice", "Fried Rice" };
                File.AppendAllLines(path, food2);
            }
            else
            {
                string[] food = { "Laksa", "Roti Canai", "Mee Goreng", "Roti Capati" };

                File.WriteAllLines(path, food);

            }


        }


    }

class program //reading file both 2 . txt file that we create
    {
        static void Main(string[] args)
        {
            string path = @"D:\\tempC\\makanan.txt";
            string path2 = @"D:\\tempC\\PRAC1.txt";


            //Read from the file -- getting contentor data  out from the file

            string svalue = File.ReadAllText(path2);
            Console.WriteLine(svalue);
            Console.WriteLine("\n");

            string[] foodList = File.ReadAllLines(path);

            foreach (var f in foodList)
            {
                Console.Write( f + "\n");
            }
            Console.WriteLine();
        }


    }

class program //filestream writer
    {
        static void Main(string[] args)
        {
            string path = "D:\\tempC\\visit.txt";
            
            if (File.Exists(path)) 
            {
                using (StreamWriter wr2 = new StreamWriter(path, true)) 
                {
                    wr2.WriteLine("Tugu Negara");
                    wr2.WriteLine("Bird Park");
                }
            }
            else 
            {
                using (StreamWriter wr = new StreamWriter(path))
                {
                    wr.WriteLine("Zoo Negara");
                    wr.WriteLine("Muzium Negara");
                    wr.WriteLine("Gua Tempurung");
                    wr.WriteLine("Batu Caves");
                }
            }
            


        }


    }

class program //filestream Reading
    {
        static void Main(string[] args)
        {
            string path = "D:\\tempC\\visit.txt";
            //string path2 = @"D:\\tempC\\PRAC1.txt";

            string line;
            using (StreamReader rd =  new StreamReader(path)) 
            {
                //line = rd.ReadLine(); //rd is connector
                //Console.WriteLine(line);

                //line = rd.ReadLine();
                //Console.WriteLine(line);

                //line = rd.ReadLine();
                //Console.WriteLine(line);

                //line = rd.ReadLine();
                //Console.WriteLine(line);

                //line = rd.ReadLine();
                //Console.WriteLine(line);

                //line = rd.ReadLine();
                //Console.WriteLine(line); using for loop is better

                //for (int i = 1; i <= 6;  i++) // not so good ways to read
                //{
                //    line = rd.ReadLine();
                //    Console.WriteLine(line);
                //}

                while ((line = rd.ReadLine())!=null) // better ways to read
                {
                    Console.WriteLine(line);
                }

            }
            

        }


    }

class program //other example of better ways of filestream Reading
    {
        static void Main(string[] args)
        {
            //string path = "D:\\tempC\\visit.txt";
            string path2 = @"D:\\tempC\\PRAC1.txt";

            string line;
            using (StreamReader rd =  new StreamReader(path2)) 
            {
                while ((line = rd.ReadLine())!=null) // better ways to read
                {
                    Console.WriteLine(line);
                }

            }
            

        }


    }

class program // Reading and selecting specific char in file
{
    static void Main(string[] args)
    {
        string path = "D:\\tempC\\sfile.txt";
        List<string> Lnames = new List<string>();
        string line;
        using (StreamReader rd = new StreamReader(path))
        {

            while ((line = rd.ReadLine()) != null)
            {
                if (line.StartsWith("L"))
                {
                    //Console.WriteLine(line);
                    Lnames.Add(line);
                }

            }

            foreach (var n in Lnames)
            {
                Console.Write(n + "  ");
            }
            Console.WriteLine();
        }


    }
}

