using System;

namespace ConsoleApp3
{
    class Program
    {
        private string month;
        private int year;

        // declaring Copy constructor 
        public Program(Program s)
        {
            month = s.month;
            year = s.year;
        }

        // Instance constructor 
        public Program(string month, int year)
        {
            this.month = month;
            this.year = year;
        }

        public string Details
        {
            get
            {
                return "Month: " + month.ToString() +
                         "\nYear: " + year.ToString();
            }
        }
        private Program()
        {
        }
        public static int count_g; 
        public static int g_Count()
        {
            return ++count_g;
        }
        static Program()
        {
 
            Console.WriteLine("Static Constructor");
        }        
        public Program(int i)
        {
            Console.WriteLine("Instance Constructor " + i);
        }
        public string Program_detail(string name, int id)
        {
            return "Name:" + name + " id:" + id;
        }
        static void Main(string[] args)
        {
            Program g1 = new Program("June", 2018);
 
            Program g2 = new Program(g1);

            Console.WriteLine(g2.Details);
            Program.count_g = 99;
            Program.g_Count();
            Console.WriteLine(Program.count_g);
            Program.g_Count();
            Console.WriteLine(Program.count_g);
            Program obj = new Program(1);

            Console.WriteLine(obj.Program_detail("GFG", 1));
            Program obj1 = new Program(2);
            Console.WriteLine(obj1.Program_detail("GeeksforGeeks", 2));
        }
    }
}
