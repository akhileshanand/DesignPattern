namespace AbstracctFactory
{
    public class PetDog : IDog
    {
        public void Action()
        {
            Console.WriteLine("I am Pet dog");
        }

        public void Speak()
        {
            Console.WriteLine("I play with my owner");
        }
    }
}