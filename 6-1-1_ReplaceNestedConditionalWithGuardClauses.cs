/// 已衛語句取代嵌套條件表達式 Replace Nested Conditional with Guard Clauses

public int 稅收金額()
{
    int 繳納金額 = 0;
    
    if(is超級有錢人)
    {
        繳納金額 = 應收金額 * 100;
    }
    else if(is包租公)
    {
        繳納金額 = 應收金額 + 有幾間房 * 75;
    }
    else if(is小康家庭)
    {
        繳納金額 = 應收金額;
    }
    else
    {
        繳納金額 = 應收金額 * 0.8;
    }

    return 繳納金額;
}