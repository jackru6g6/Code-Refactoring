/// 將查詢函數與修改函數分離 (Separate Query from Modifier)

public void 寄送電子信件給該訂單下單者(string 訂單號碼)
{
    var 下單者電子信箱 = 查詢信箱(訂單號碼);
    
    寄送信件(下單者電子信箱);
}