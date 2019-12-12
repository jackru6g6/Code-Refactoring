///字面常數 (Literal Constants)
public void 計算圓面積(int 半徑)
{
    var 園面積功率pi = 3.14;

    園面積 = 半徑*半徑*園面積功率pi;
}


 public enum EnumDiscountCodeFlag : int
    {
        [Description("符合")]
        Conform = 0,
        [Description("折扣密碼不符合")]
        NoContainPassword = 2,
        [Description("超出活動預算上限")]
        OverBudgetAmountLimit = 3,
        [Description("折扣碼尚未開始")]
        DiscountCodeNotStarted = 1,
        [Description("折扣碼已過期")]
        DiscountCodeExpired = 4,
        [Description("折扣碼取得錯誤")]
        GetDiscountCodeError = 5,
    }