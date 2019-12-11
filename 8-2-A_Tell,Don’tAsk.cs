/// Tell,Don’t Ask、善用getter/setter，並非濫用

class 住址
{
    string 縣市 {get;set;}
    string 鄉鎮區 {get;set;}
    string 街 {get;set;}
}

class 居民
{
    住址 居住地 = new 住址();

    public bool 是否居住石潭街()
    {
        return this.居住地.街 == "石潭街";
    }
}


void Main()
{
    List<居民> 雄獅村 = new List<居民>{new 居民(),new 居民(),new 居民(),new 居民()};

    foreach(var 人 in 雄獅村)
    {
        if(人.是否居住石潭街())
        {
            ///都更...
        }
    }
}