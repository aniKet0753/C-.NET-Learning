using System;

namespace FirstProgram
{
    class Const1
    {
        int i;
        public Const1()
        {
            i = 23;
            Console.WriteLine("Value of i is: " + i);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Const1 obj = new Const1();
            
        }
    }
}
