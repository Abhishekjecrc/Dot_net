using System;

namespace ConsoleApp2
{
    class Program
    {
        int num;
        string name;
        Program()
        {
            Console.WriteLine("Constructor Called");
        }
        Program(String name, int num)
        {
            this.name = name;
            this.num = num;
        }
        
        static void Main(string[] args)
        {
            Program p1 = new Program();
            Console.WriteLine(p1.name);
            Console.WriteLine(p1.num);
            Program p2 = new Program("Prog", 10);
            Console.WriteLine("Name = " + p2.name +
                             " and Num = " + p2.num);

        }
    }
}
