using structGo;
using RecordsGo;




firstStruct Bob = new firstStruct("Bob", 23);
firstStruct Dip = new firstStruct("dsob", 123);
firstStruct Bwiwlib = new firstStruct("Bo223b", 23);
Bob.Age = 2323;



// System.Console.WriteLine(Bob);
// System.Console.WriteLine(firstStruct.numInstances);


Dictionary<string, int> ourMenu = new Dictionary<string, int>()
{
    { "Hot Dog", 20 },
    { "Bong Water", 25 },
    { "Spice Cake", 12 }
};

Dictionary<string, int> wowSoupMenu = new Dictionary<string, int>()
{
    { "Hot Dog", 20 },
    { "Bong Water", 25 },
    { "Spice Cake", 12 }
};

firstRecord lezGo =  new firstRecord(ourMenu);
firstRecord letsGo = lezGo with { };
System.Console.WriteLine(letsGo == lezGo);





