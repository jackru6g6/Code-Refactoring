/// 分解條件表達式 (Decompose Conditional)

public int 計算付費金額(string 職位, string 折扣碼 = string.Empty, bool 是否為VIP = false)
{
    if((職位 == "主任" && 折扣碼 == "我愛一條柴") || 是否為VIP = true)
    {
        return 原價 * 0.8;
    }
    else
    {
        return 原價 + 5000;
    }
}