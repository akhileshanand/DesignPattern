﻿// See https://aka.ms/new-console-template for more information
using SimpleFactoryPattern;



namespace SimplefactoryDesignPatterns
{
    public class Client
    {
       
        static void Main(string[] args)
        {
            // // Simple factory Design Pattern
            ISimplefactory simplefactory = new SimpleFactory();
            Console.WriteLine("Enter your choice 0 for dog , 1 for Tiger");
            string b1 = Console.ReadLine();
            IAnimal preferredAnimal = simplefactory.CreateAnimal(b1);
            preferredAnimal.Speak();
            preferredAnimal.Action();
            preferredAnimal.Species();
            Console.WriteLine("Hello, World!");

            //FactoryMethod Design Pattern 
            //IAnimalFactoryy dogFactory = new DogFactory();
            //IAnimal adog = dogFactory.CreateAnimal();
            //adog.Action();
            //adog.Speak();
        }
    }
}