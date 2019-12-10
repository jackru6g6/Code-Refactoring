/// 以管道取代循環 (Replace Loop with Pipeline)

public void DoSomething(List<string> allName)
{
    List<string> name = new List<string>();
    name = allName.Where(t => t == "傑克").toList();
}