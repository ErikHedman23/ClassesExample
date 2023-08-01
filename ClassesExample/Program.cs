

//Instance of a class (use a class to make a person)

using ClassesExample;

//Make an Instance of Classroom class so we can use the list it holds as a property
var classroom = new Classroom();

Person erik = new Person();

//Dot notation to fill the properties
erik.Name = "Erik";
erik.Age = 23;
erik.IsMarried = true;
erik.HairColor = "Brown";

classroom.OurClass.Add(erik); //adding to the list in OurClass



//Object Initializer syntax
var john = new Person()  //Calling the constructor
{
    Name = "John", 
    Age = 25, 
    HairColor = "Brown", 
    IsMarried = false

};
classroom.OurClass.Add(john);



//Custom Constructor
var ross = new Person("Ross", 34, true, "brown");

//Console.WriteLine($"This is {erik.Name} and {john.Name} here to help.");
classroom.OurClass.Add(ross);

//Since all the instances are now in our list and the GetDetails method calls the Greet method from Person
//we will now see every single person's greeting
classroom.GetDetails();