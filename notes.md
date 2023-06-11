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

