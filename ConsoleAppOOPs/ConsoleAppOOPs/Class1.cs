using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPs
{
    class Class1
    {
        public string brand = "benz";

        public void Honk() 
        {
            Console.WriteLine("Honk Honk");
        }

    }


    class car : Class1
    {
        public string Model = "s-class";
    }

    class Type : car
    {

        public string type = "coupe";
    }


    class ExcSquare
    {
     /*   static void Main(string[] args)
        {
            Type s = new Type();
            s.Honk();


            Console.WriteLine(s.brand + " " + s.Model);
            Console.WriteLine(s.type);

        }*/
    }
}
