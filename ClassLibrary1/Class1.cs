using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Person
    {
        public Person()
        {
            age = 20;
            name = "madik";
            gender = "men";
        }

        private int age;

        private string name;

        private string gender;

        public int GetAge()
        {
            return age;
        }

        public string GetName()
        {
            return name;
        }

        public string GetGender()
        {
            return gender;
        }
    }
    public class ToGetPerson
    {
        public string GetPerson(Person person)
        {
            string getAll = "name = " + person.GetName() + " , age = " + person.GetAge() + " ,Gender = " + person.GetGender();
            return getAll;
        }
    }
  
}
