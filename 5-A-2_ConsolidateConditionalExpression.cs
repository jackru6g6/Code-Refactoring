/// 合併條件表達式 Consolidate Conditional Expression

public int 計算付費金額(string 職位, string 折扣碼 = string.Empty, bool 是否為VIP = false)
{
    var 就是i打折 = (職位 == "主任") || (折扣碼 == "我愛一條柴") || (是否為VIP == true);

    if(就是i打折 == true)
    {
        return 原價 * 0.8;
    }
    
    return 原價 + 5000;
}