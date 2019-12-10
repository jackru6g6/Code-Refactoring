/// 提煉函式 (Extract Method)

public class 總經理
{
    public void 命令底下(){}
    public void 管理營運(){}
}

public class 總務
{
    public void 收錢(){}
    public void 打電話叫便當(){}
}

public class 程式設計師
{
    public void 修程式(){}
}






public class 員工
{
    public string 名子 {get;set;}
    public string 公司電話 {get;set;}
    public string 分機號碼 {get;set;}

    public string 取得電話號碼()
    {
        return $"{公司電話}-{分機號碼}";
    }
}





public class 員工
{
    public 員工()
    {
        電話 = new 公司分機();
    }
    public string 名子 {get;set;}
    public 公司分機 電話 {get;set;} = new 公司分機();

    public string 取得電話號碼()
    {
        return 電話.取得電話號碼();
    }
}

public class 公司分機
{
    public string 公司電話 {get;set;}
    public string 分機號碼 {get;set;}

    public string 取得電話號碼()
    {
        return $"{電話.公司電話}-{電話.分機號碼}";
    }
}