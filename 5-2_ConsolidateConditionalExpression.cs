/// 合併條件表達式 Consolidate Conditional Expression

public int 計算付費金額(string 職位, string 折扣碼 = string.Empty, bool 是否為VIP = false)
{
    if(職位 == "主任")
    {
        return 原價 * 0.8;
    }
    if(折扣碼 == "我愛一條柴")
    {
        return 原價 * 0.8;
    }
    if(是否為VIP == true)
    {
        return 原價 * 0.8;
    }
    
    return 原價 + 5000;
}