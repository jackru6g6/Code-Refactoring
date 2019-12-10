/// 以管道取代循環 (Replace Loop with Pipeline)

public void DoSomething(List<string> allName)
{
    List<string> name = new List<string>();

    foreach(var j in allName)
    {
        if(j == "傑克")
        {
            name.Add(j);
        }
    }
}