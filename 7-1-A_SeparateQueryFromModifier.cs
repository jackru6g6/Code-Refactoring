/// 將查詢函數與修改函數分離 (Separate Query from Modifier)
public string 查詢下單者電子信箱(string 訂單號碼)
{
    return 查詢下單者資料(訂單號碼).電子信箱;
}

public void 寄送信件(string 信箱)
{
    寄送信件(下單者電子信箱);
}


public void 寄送電子信件給該訂單下單者(string 訂單號碼)
{
    寄送信件(查詢下單者電子信箱(訂單號碼));
}