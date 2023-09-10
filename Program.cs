using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathname = @"C:\Users1\alhadss\Desktop1\newfolder\ellh.txt";

            FileStream fs = File.Create(pathname);//task1
            fs.Close();

            File.Delete(pathname); //task2

            try
            {
                if (File.Exists(pathname))//task3
                {
                    Console.WriteLine($"A file created with name {Path.GetFileName(pathname)}");
                }
                else
                {
                    throw new Exception("File Does not exist  ");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "some error  occured");
            }


            File.WriteAllText(pathname, "EtttE");//task4

            var x = File.ReadAllText(pathname);//task5
            Console.WriteLine(x);

            Console.WriteLine("          ");
            Console.WriteLine("          ");



            Program n = new Program();
            n.task6();
            n.task7();
            n.task8();  
            n.task9();
            n.task10();
            n.task11();
            n.task12();
            n.task13();
            n.task14();
            n.task15();

        }






        public void task6()
        {
            string createdfile = @"C:\Users1\alhadss\Desktop1\newfolder\newfile.txt";
            int n = 0; //task6
            FileStream fs1 = File.Create(createdfile);
            fs1.Close();

            Console.WriteLine("Input num of elements ");
            bool a = int.TryParse(Console.ReadLine(), out int number);





            while (n != number)
            {
                Console.WriteLine("Input line : " + (n));

                string input = Console.ReadLine();
                n++;
                File.AppendAllText(createdfile, input + "\n");
            }
            var y = File.ReadAllText(createdfile);

            Console.WriteLine("   ");
            Console.WriteLine(y);
        }

        public void task7()
        {
            string createdfile = @"C:\Users1\alhadss\Desktop1\newfolder\newfile2.txt";
            int n = 0; //task7
            FileStream fs1 = File.Create(createdfile);
            fs1.Close();
            Console.WriteLine("Input the filter word :");
            string filtword = Console.ReadLine();

            Console.WriteLine("Input num of elements ");
            bool a = int.TryParse(Console.ReadLine(), out int number);





            while (n != number - 1)
            {
                Console.WriteLine("Input line : " + (n));

                string input = Console.ReadLine();
                if (input.Contains(filtword))
                {
                    continue;
                }

                n++;
                File.AppendAllText(createdfile, input + "\n");

            }
            Console.WriteLine("     ");
            var y = File.ReadAllText(createdfile);
            Console.WriteLine(y);
        }


        public void task8()
        {
            List<string> Elements = new List<string>();
            string createdfile = @"C:\Users1\alhadss\Desktop1\newfolder\newfile3.txt";
            int n = 0; //task8
            if (!File.Exists(createdfile))
            {
                FileStream fs1 = File.Create(createdfile);
                fs1.Close();

            }


           
            Console.WriteLine("Input num of elements ");
            bool a = int.TryParse(Console.ReadLine(), out int number);





            while (n != number)
            {
                Console.WriteLine("Input line : " + (n));

                string input = Console.ReadLine();
                n++;
                Elements.Add(input);
            }
            File.AppendAllLines(createdfile,Elements); ;
            var y = File.ReadAllText(createdfile);

            Console.WriteLine("   ");
            Console.WriteLine(y);
        }


        public void task9()
        {
            try
            {
                string oldfile = @"C:\Users1\alhadss\Desktop1\newfolder\newfile3.txt";
                var y = File.ReadAllText(oldfile);
                Console.WriteLine("Old file content :" + "\n" + y);
                string newfile = @"C:\Users1\alhadss\Desktop1\newfolder\newfile4.txt";

                if(File.Exists(newfile))
                {
                    throw new Exception("File EXISTS");
                }

                File.Copy(oldfile, newfile);

                var z = File.ReadAllText(newfile);
                Console.WriteLine("New File content :" + "\n"+z );
            }
            catch (Exception ex)
            {
                Console.WriteLine( ex.Message);
            }

        }


        public void task10()
        {
            try
            {
                string originfile = @"C:\Users1\alhadss\Desktop1\newfolder\origfile.txt";
                var y = File.ReadAllText(originfile);
                Console.WriteLine("orig file content :" + "\n" + y);
                string destinationfile = @"C:\Users1\alhadss\Desktop1\newfolder\destfile.txt";

                if (File.Exists(destinationfile))
                {
                    throw new Exception("File EXISTS");
                }

                File.Move(originfile, destinationfile);

                var z = File.ReadAllText(destinationfile);
                Console.WriteLine("dest File content :" + "\n" + z);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }



        public void task11()
        {
            string fileforread = @"C:\Users1\alhadss\Desktop1\newfolder\newfile3.txt";
            var readlines= File.ReadAllLines (fileforread);
            var readtext= File.ReadAllText (fileforread);
            Console.WriteLine(  "All file text: ");
            Console.WriteLine(readtext);

            Console.WriteLine("  ");
            Console.WriteLine( "First line of file :"+readlines[0]);


        }

        public void task12()
        {

            string createdfile = @"C:\Users1\alhadss\Desktop1\newfolder\newfile.txt";
            int n = 0; 
            FileStream fs1 = File.Create(createdfile);
            fs1.Close();

            Console.WriteLine("Input num of elements ");
            bool a = int.TryParse(Console.ReadLine(), out int number);





            while (n != number)
            {
                Console.WriteLine("Input line : " + (n));

                string input = Console.ReadLine();
                n++;
                File.AppendAllText(createdfile, input + "\n");
            }
            var y = File.ReadAllText(createdfile);

            Console.WriteLine("   ");
            Console.WriteLine(y);
            Console.WriteLine("     ");
            var z=File.ReadAllLines(createdfile);
            Console.WriteLine( "File's last line is " +z[z.Length - 1]);

        }

          public void task13()
        {


            string createdfile = @"C:\Users1\alhadss\Desktop1\newfolder\newfile.txt";
            int n = 0;
            FileStream fs1 = File.Create(createdfile);
            fs1.Close();

            Console.WriteLine("Input num of elements ");
            bool a = int.TryParse(Console.ReadLine(), out int number);



            

            while (n != number)
            {
                Console.WriteLine("Input line : " + (n));

                string input = Console.ReadLine();
                n++;
                File.AppendAllText(createdfile, input + "\n");
            }
            


            Console.WriteLine("   ");
            

            
            Console.WriteLine("     ");

            Console.WriteLine("Input the line which content you want to display ");
            bool b = int.TryParse(Console.ReadLine(), out int inputdisplay);
            
            var z = File.ReadAllLines(createdfile);
            Console.WriteLine($"The content  of line  {inputdisplay} is  " + z[inputdisplay]);

        }

        public void task14()
        {


            string createdfile = @"C:\Users1\alhadss\Desktop1\newfolder\newfile.txt";
            int n = 0;
            FileStream fs1 = File.Create(createdfile);
            fs1.Close();

            Console.WriteLine("Input num of elements ");
            bool a = int.TryParse(Console.ReadLine(), out int number);





            while (n != number)
            {
                Console.WriteLine("Input line : " + (n));

                string input = Console.ReadLine();
                n++;
                File.AppendAllText(createdfile, input + "\n");
            }
           

            Console.WriteLine("   ");
         
            Console.WriteLine("     ");
            var z = File.ReadAllLines(createdfile);

            Console.WriteLine("Input last how many of lines you want to display  :  ");
            bool b = int.TryParse(Console.ReadLine(), out int inputlines);
            for (int i=z.Length-1;i>=(z.Length-inputlines);i--)
            {
                Console.WriteLine($"Line  {z.Length-i}  " + z[i]);
            }
        }


        public void task15()
        {


            string file= @"C:\Users1\alhadss\Desktop1\newfolder\newfile3.txt";
            var c= File.ReadAllLines(file);
            var b = File.ReadAllText(file);
            Console.WriteLine("Content of my file :");
            Console.WriteLine("               ");
            
            Console.WriteLine(b);
            Console.WriteLine("           ");
            Console.WriteLine("The number of lines :" + c.Length);


        }




    }
}