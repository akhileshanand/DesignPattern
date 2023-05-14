﻿using SimplefactoryDesignPatterns;
using SimpleFactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    public class DogFactory : IAnimalFactoryy
    {

        public override IAnimal CreateAnimal()
        {
            return new Dog();
        }

    }
}
