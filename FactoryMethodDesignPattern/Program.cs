// See https://aka.ms/new-console-template for more information
using SimpleFactoryPattern;
using FactoryMethodDesignPattern;


namespace FactoryMethodDesignPattern
{
    public class Client1
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            IAnimalFactoryy dogFactory = new DogFactory();
            //IAnimal adog = dogFactory.CreateAnimal();
            //adog.Action();
            //adog.Speak();   

            //Beautification of factoryMethod
            IAnimal animal=  dogFactory.GetAnimal();
            IAnimalFactoryy tigerFactory = new TigerFactory();
            tigerFactory.GetAnimal();
        }
    }
}