/// Tell,Don’t Ask、善用getter/setter，並非濫用

class 菜單類別
{
    string 下酒菜_TW {get;set;}
    string 下酒菜_EN {get;set;} 
}


class 客人類別 
{
    string 語系;
    菜單類別 菜單 = new 菜單類別();

    public string 取得菜單()
    {
        if(語系 == "TW")
        {
            return 菜單.下酒菜_TW;
        }
        else
        {
            return 菜單.下酒菜_EN;
        }
    }
}


void Main()
{
    ///客人到餐廳
    客人類別 Jack = new 客人類別();

    ///客人拿餐單
    Jack.取得菜單();
}