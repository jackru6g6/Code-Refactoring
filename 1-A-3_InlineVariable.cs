///內聯變量 (Inline Variable)
public int 需繳納金額_改善前(){
    var 繳納價錢 = 總金額 - 折扣金額;
    retunr 繳納價錢; 
}


public int 需繳納金額_改善後(){
    retunr (總金額 - 折扣金額); 
}