namespace RecordsGo;

public record firstRecord
{
    public firstRecord(Dictionary<string, int> menu)
    {   
        Menu = menu;
    }   

    public Dictionary<string, int> Menu {get; init;}

}