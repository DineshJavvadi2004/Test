using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPs
{
    class Program
    {
      /*  static void Main(string[] args)
        {

            Square s = new Square();
            s.length = 4;
            s.Display();
        }
    */
    }

    class Square
    {

        public double length = 10;

        public double GetArea()
        {
            return length * length;
        }

        public void Display()
        {

            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("area: {0}", GetArea());
        }
    }
}
