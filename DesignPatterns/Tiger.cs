using SimpleFactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplefactoryDesignPatterns
{
    public class Tiger : IAnimal
    {
        public Tiger() { }

        public void Speak()
        {
            Console.WriteLine("Tiger says:- halum");
        }
        public void Action()
        {
            Console.WriteLine("tiger roar");
        }

    }
}
