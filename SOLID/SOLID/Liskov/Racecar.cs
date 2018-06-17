using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Liskov
{
    /// <summary>
    /// Function that have a reference to Car, wouldn't be as to use instances of its derived class. For ex, Racecar...
    /// </summary>
    public class Racecar: ICar
    {
        int raceCarSpeed;
        int luggageCapacity = 5;
        bool itHasRadio = false; 

        public void drive()
        {
            raceCarSpeed = 200;
            Console.WriteLine(raceCarSpeed);
        }

        public void addLuggage() {

            if (luggageCapacity > 10)
            {
                Console.WriteLine("You can carry the luggages");
            }
            else {
                throw new NotSupportedException("No room to carry luggage, sorry."); // it should also violating the single responsibility, I only focus One Principle at the time.
            }
        }

        public void playRadio() {

            if (itHasRadio)
            {
                Console.WriteLine("Enjoy the music");
            }
            else
            {
                throw new NotSupportedException("It doesn't have");
            }

        }
    }
}
