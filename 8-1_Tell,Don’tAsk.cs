/// Tell,Don’t Ask、善用getter/setter，並非濫用

class 菜單類別
{
    string 下酒菜_TW {get;set;}
    string 下酒菜_EN {get;set;} 
}


class 客人類別 
{
    string 語系 {get;set;}
    菜單類別 菜單 = new 菜單類別();

    public string 取得中文菜單()
    {
        return 菜單.下酒菜_TW;
    }

    public string 取得英文菜單()
    {
        return 菜單.下酒菜_EN;
    }
}


void Main()
{
    ///客人到餐廳
    客人類別 Jack = new 客人類別();

    ///客人拿餐單
    if(Jack.語系 == "TW") 
    {
        Jack.取得中文菜單();
    }
    else 
    {
        Jack.取得英文菜單();
    }
}