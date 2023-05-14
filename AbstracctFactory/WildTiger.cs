namespace AbstracctFactory
{
    public class WildTiger : ITiger
    {
        public void Action()
        {
            Console.WriteLine("I am wildTiger");
        }

        public void Speak()
        {
            Console.WriteLine("I Roam in Jungle");
        }
    }
}