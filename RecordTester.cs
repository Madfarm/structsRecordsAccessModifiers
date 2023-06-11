namespace RecordsGo;

public record firstRecord
{
    public firstRecord(Dictionary<string, int> menu)
    {   
        Menu = menu;
        // dogHatFoodDude = "Woot door bro";
        // hoursOfSexStraight = 12;
    }   

    public Dictionary<string, int> Menu {get; init;}
    // public string dogHatFoodDude {get; init;}
    // public int hoursOfSexStraight {get; init;}

    public override string ToString()
    {
        string output = "Our Menu\n\n";
        foreach(KeyValuePair<string, int> kvp in Menu)
        {
            output += $"${kvp.Value} - {kvp.Key}" + "\n";
        }

       return output;
    }
}