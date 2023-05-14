using SimpleFactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    public abstract class IAnimalFactoryy
    {
        public IAnimal GetAnimal()
        {
            IAnimal animal = CreateAnimal();
            animal.Speak();
            animal.Action();
            return animal;
        }
        public abstract IAnimal CreateAnimal();
    }
}
