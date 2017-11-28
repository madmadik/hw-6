using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using ConsoleApp1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            ToGetPerson getPerson= new ToGetPerson();

            string getAll=getPerson.GetPerson(person);

            Console.WriteLine(getAll);

            Class2 info = new Class2();

            Console.WriteLine(info.GetNumber()+" + " +info.GetCity());

            Console.ReadLine();
        }
    }
}
