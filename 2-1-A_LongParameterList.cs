class 公司
{
    public class 政策
    {
        public string 應徵職位 {get;set;}
        public int 薪資要求 {get;set;}
        public int? 三節獎金 {get;set;}
    }

    public class 個人資料
    {
        public string 國家 {get;set;}
        public string 城市 {get;set;}
        public string 名子 {get;set;}
        public int 年齡 {get;set;}
        public string 性別 {get;set;}
        public bool 是否結婚 {get;set;}
    }

    public void 應徵員工(個人資料 某人, 政策 人資) {}
}


public Main()
{
    var 雄獅資訊 = new 公司();


    var 傑克 = new 個人資料{ 國家 = "台灣",
                            城市 = "淡水市",
                            名子 = "傑克",
                            年齡 = 25,
                            性別 = "男",
                            是否結婚 = false,};
    var 人資通知 = new 政策{ 應徵職位 = "PG",
                            薪資要求 = 50000,
                            三節獎金 = 25000,};

    雄獅資訊.應徵員工(傑克, 人資通知);            


    /// OR ↓
    雄獅資訊.應徵員工(new 個人資料{
                        國家 = "台灣",
                        城市 = "淡水市",
                        名子 = "傑克",
                        年齡 = 25,
                        性別 = "男",
                        是否結婚 = false,
                    },new 政策{
                        應徵職位 = "PG",
                        薪資要求 = 50000,
                        三節獎金 = 25000,
                    });
}