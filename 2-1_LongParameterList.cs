class 公司
{
    public void 應徵員工(string 國家, string 城市, string 名子, int 年齡, string 性別, bool 是否結婚, int 薪資要求, int? 三節獎金, string 應徵職位) {}
}


public Main()
{
    var 雄獅資訊 = new 公司();

    雄獅資訊.應徵員工("台灣", "淡水市", "傑克", 25, "男", false, 50000, 25000, "PG");
}