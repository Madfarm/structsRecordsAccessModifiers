namespace RecordsGo;

public record firstRecord
{
    public firstRecord(Dictionary<string, int> menu)
    {   
        Menu = menu;
    }   

    public Dictionary<string, int> Menu {get; init;}


    public override string ToString()
    {
        string output = "";

        foreach (KeyValuePair<string, int> kvp in Menu)
        {
            output += $"${kvp.Value} - {kvp.Key}" + "\n";
        }

        return output;
    }
   
}