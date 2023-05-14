using SimpleFactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplefactoryDesignPatterns
{
    public class Dog : IAnimal
    {
        public Dog() { }

        public void Speak()
        {
            Console.WriteLine("Dog says:- bow bow");
        }
        public void Action()
        {
            Console.WriteLine("Dog barks");
        }

    }
}
