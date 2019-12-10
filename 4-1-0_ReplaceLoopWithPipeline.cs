/// 以管道取代循環 (Replace Loop with Pipeline)

public void DoSomething(List<string> allName)
{
    List<string> name = new List<string>();

    for(var i; i <= allName.Count; i++)
    {
        if(allName[i] == "傑克")
        {
            name.Add(allName[i]);
        }
    }
}