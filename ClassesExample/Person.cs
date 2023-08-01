using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExample
{
    public class Person
    {
        //Field - a variable inside of a class - Things that the person could 'have'. Nouns 
        public int money;
        public string clothes;

        //Properties - describe the things you are making Pascal Casing - adjectives of the person - descripters
        public string Name { get; set; } //get == read ; set == write
        public int Age { get; set; }
        public int MyProperty { get; set; }
        public bool IsMarried { get; set; }
        public string HairColor { get; set; }

        //Csontructors

        //Default Constructor

        public Person()//== a new person
        {

        }
        //Custom Constructor
        public Person(string name, int age, bool isMarried, string hairColor)
        {
            Name = name;
            Age = age;
            IsMarried = isMarried;
            HairColor = hairColor;
        }

        //Methods in a Class (non static)

        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {Name}, and I am {Age} years old.");

        }





    }
}
