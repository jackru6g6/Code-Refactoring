/// 過長函式 (Long method) 

public static Main()
{
    學生會 雄獅資訊會 = new 學生會();

    人 傑克 = new 人();
    傑克.學號 = "00F549";
    傑克.組別 = "QAM";
    傑克.年齡 = 25;
    傑克.職位 = PG;
    雄獅資訊會.會員.Add(傑克);

    人 藍莓兄 = new 人();
    藍莓兄.學號 = "00D468";
    藍莓兄.組別 = "SCM";
    藍莓兄.年齡 = 32;
    藍莓兄.職位 = PG;
    雄獅資訊會.會員.Add(藍莓兄);

    人 尼克 = new 人();
    尼克.學號 = "00D046";
    尼克.組別 = "QAM";
    尼克.年齡 = 35;
    尼克.職位 = SA;
    雄獅資訊會.會員.Add(尼克);
}