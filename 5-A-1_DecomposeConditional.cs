/// 分解條件表達式 (Decompose Conditional)

public int 計算付費金額(string 職位, string 折扣碼 = string.Empty, bool 是否為VIP = false)
{
    if(是否可以打折(職位, 折扣碼, 是否為VIP))
    {
        return 折扣價();
    }
    else
    {
        return 加收價();
    }
}


private bool 是否可以打折(string 職位, string 折扣碼 = string.Empty, bool 是否為VIP = false)
{
    return ((職位 == "主任" && 折扣碼 == "我愛一條柴") || 是否為VIP = true);
}


private int 折扣價()
{
    return 原價 * 0.8;
}


private int 加收價()
{
    return 原價 + 5000;
}