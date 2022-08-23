using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPs
{
    class Abstraction
    {

        static void Main()
        {
            carr obj = new carr();

            obj.TurnOfCar();
        }
    }

    public class carr 
    {
        public void TurnOnCar()
        {
            Console.WriteLine("Turn on the car");
        }

        public void TurnOfCar()
        {
            Console.WriteLine("Turn off the car");
        }

        private void Change_speed()
        {
            Console.WriteLine("car is sppeding");
        }

        public void Move_break_pad()
        {
            Console.WriteLine("car is slowing down");
        }
    }
}
