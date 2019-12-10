/// 提煉類別 (Extract Class)

public static Main()
{
    學生會 雄獅資訊會 = new 學生會();

    雄獅資訊會.會員.Add(應徵("00F549", "QAM", 25, "PG"));
    雄獅資訊會.會員.Add(應徵("00D468", "SCM", 32, "PG"));
    雄獅資訊會.會員.Add(應徵("00D046", "QAM", 35, "SA"));
}

public 人 應徵(string t學號, string t組別, int t年齡, string t職位)
{
    人 某人 = new 人();
    某人.學號 = t學號;
    某人.組別 = t組別;
    某人.年齡 = t年齡;
    某人.職位 = t職位;

    return 某人;
}