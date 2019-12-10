/// 已衛語句取代嵌套條件表達式 Replace Nested Conditional with Guard Clauses

public int 稅收金額()
{
    if(is超級有錢人)
    {
        return 應收金額 * 100;
    }
    if(is包租公)
    {
        return 應收金額 + 有幾間房 * 75;
    }
    if(is小康家庭)
    {
        return 應收金額;
    }

    return 應收金額;
}