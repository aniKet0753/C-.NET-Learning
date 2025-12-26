using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp2
{
    class Consturctor
    {
        int o;
        public Consturctor(int i)
        {
            o = i;
            Console.WriteLine("vale of i is :" + i);
        }
        public void Display()
        {
            Console.WriteLine("value of o is :" + o);
        }
        static void Main(string[] args)
        {
            Consturctor pi = new Consturctor(230);
            pi.Display();

        }
    }
}
