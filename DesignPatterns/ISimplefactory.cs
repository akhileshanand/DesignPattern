using SimpleFactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SimplefactoryDesignPatterns
{
    public abstract class ISimplefactory
    {
        public abstract IAnimal CreateAnimal(string b1);

        public void SomeMethod()
        {
            Console.WriteLine("Something");
        }
    }
    public class SimpleFactory : ISimplefactory
    {
        public override IAnimal CreateAnimal(string b1)
        {
            IAnimal animal = null;
           
            switch(b1)
            {
                case "0":
                    animal = new Dog();
                    break;
                case "1":
                    animal = new Tiger();
                    break;
                default:
                    Console.WriteLine("you must enter 0 or 1");
                    throw new Exception("Exception");
            }
             return animal;
        }
    }
}
