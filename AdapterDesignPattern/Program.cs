// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using AdapterDesignPattern.Adapter;
using AdapterDesignPattern.Target;

namespace AdapterDesignPattern
{
    public class Client
    {

        static void Main(string[] args)
        {
            IEmployee emp = new EmployeeAdapter();
            string value = emp.GetEmployee();
            Console.WriteLine(value);
        }

    }
}
