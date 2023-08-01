using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExample
{
    public class Classroom
    {
        //Properties can be of type List and Array
        public List<Person> OurClass { get; set; } = new List<Person>();

        //Method in class (non static)
        public void GetDetails()
        {
            //Looping through every person in our List property called "OurClass"
            foreach(Person person in OurClass)
            {
                //Calling method from Person class using variable called "person".  Not to be confused with type person
                //"person" takes the place of every thing in th "OurClass" list when 
                person.Greet();
            }
        }
    }
}
