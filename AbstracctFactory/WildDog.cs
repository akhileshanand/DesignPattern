namespace AbstracctFactory
{
    class WildDog : IDog
    {
        public void Speak()
        {
           Console.WriteLine("Wild Dog says: Bow-Wow.\n\n");
        }
        public void Action()
        {
            Console.WriteLine("Wild Dogs prefer to roam freely in jungles.\n\n");
        }
    }
}