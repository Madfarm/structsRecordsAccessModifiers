namespace RecordsGo;

public record firstRecord
{
    public firstRecord(Dictionary<string, int> menu)
    {   
        Menu = menu;
        dogHatFoodDude = "Woot door bro";
        hoursOfSexStraight = 12;
    }   

    public Dictionary<string, int> Menu {get; init;}
    public string dogHatFoodDude {get; init;}
    public int hoursOfSexStraight {get; init;}   
}