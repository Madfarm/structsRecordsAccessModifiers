## Structs
Like a class but meant for smaller data-centric things
-  a value type which means it offers better performance versus reference types like classes


get and set are accessors that allow to access and modify properties respectively

overriding ToString() method will allow to control what is printed when that type is referenced

public struct firstStruct 
{
    public firstStruct(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set;}
    public int Age { get; set; }

    public override string ToString() => $"My name is {Name} and I am {Age} years old";
}


firstStruct Bob = new firstStruct("Bob", 23);
Bob.Age = 2323;
System.Console.WriteLine(Bob);

output ========> My name is Bob and I am 2323 years old 


## Static 
Static classes cannot be instantiated 

static members must be accessed via the class/struct name not the instance name, and no matter how many instances of that class/struct there are there is only one copy of that static property



################## Side Note #########################
dictionaries can be initialized with keys and values as such:

Dictionary<string, int> ourMenu = new Dictionary<string, int>()
{
    { "Hot Dog", 20 },
    { "Bong Water", 25},
    { "Spice Cake", 12}
};

## Records
Immutable structs/classes
- provided with special syntax and behavior for working with data models

The record modifier instructs the compiler to synthesize members that are useful for types whose primary role is storing data. These members include an overload of ToString() and members that support value equality.

Good to use when:
- need a value equality
- immutable


== is automatically changed to a value equality checker
ToString() is overrided to return all public properties

the with operator lets you copy records

an exact copy,
firstRecord letsGo = lezGo with { };

recordName nameOfRef = existingRecord with { changes go here };
