// See https://aka.ms/new-console-template for more information
using AbstracctFactory;

namespace AbstracctFactory
{
    public class clinet3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clinet3");
            IAnimalFactory wildAnimalFactory = new WildAnimalFactory();
            ITiger wildTiger = wildAnimalFactory.GetTiger();
            wildTiger.Action();
            wildTiger.Speak();
           IDog wildDog= wildAnimalFactory.GetDog();
            wildDog.Action();
            wildDog.Speak();


            IAnimalFactory petAnimal = new PetAnimalFactory();
            IDog petDog = petAnimal.GetDog();
            petDog.Action();
            petDog.Speak();
        }
    }
}