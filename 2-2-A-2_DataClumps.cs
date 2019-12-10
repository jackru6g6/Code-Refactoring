public class 員工主檔
{
    string 員工編號 {get;set;}
    string 員工姓名 {get;set;}
    int 薪資 {get;set;}

    異動資料 新增者 {get;set;}
    異動資料 編輯者 {get;set;}
}

public class 申請單主檔
{
    string 申請單編號 {get;set;}
    string 申請員工編號 {get;set;}
    string 項目內容 {get;set;}
    
    異動資料 新增者 {get;set;}
    異動資料 編輯者 {get;set;}
}

public class 異動資料
{
    string 異動員編 {get;set;}
    DateTime 異動日期 {get;set;}
}