namespace Library;

using static Newtonsoft.Json.JsonConvert;

public class Thing
{
    public int Get(int left, int right)
    {
        return DeserializeObject<int>($"{left + right}");
    }
}
