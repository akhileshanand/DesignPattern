namespace AbstracctFactory
{
    public class PetTiger : ITiger
    {
        public void Action()
        {
            Console.WriteLine("I am PetTger");
        }

        public void Speak()
        {
            Console.WriteLine("I work in Circus-Tiger");
        }
    }
}