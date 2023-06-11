namespace structGo;


public struct firstStruct 
{
    public firstStruct(string name, int age)
    {
        Name = name;
        Age = age;
        firstStruct.numInstances++;
    }

    public static int numInstances = 0;
    public string Name { get; set;}
    public int Age { get; set; }

    public override string ToString() => $"My name is {Name} and I am {Age} years old";
}