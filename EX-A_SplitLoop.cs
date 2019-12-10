/// 拆分循環 (Split Loop)


class 男女費用
{
    int 男生花費 {get; set;}
    int 女生花費 {get; set;}
}


public void 計算金額(List<男女費用> allAmounts)
{
    int 男生總費用 = 0;
    
    foreach(var i in allAmounts)
    {
        男生總費用 += i.男生花費;
    }


    int 女生總費用 = 0;

    foreach(var i in allAmounts)
    {
        女生總費用 += i.女生花費;
    }


    上報費用總和 = 男生總費用 + 女生總費用;
}


