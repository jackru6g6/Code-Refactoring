public class 員工主檔
{
    string 員工編號 {get;set;}
    string 員工姓名 {get;set;}
    int 薪資 {get;set;}
    新增編輯資料 新編資料 {get;set;}
}

public class 申請單主檔
{
    string 申請單編號 {get;set;}
    string 申請員工編號 {get;set;}
    string 項目內容 {get;set;}
    新增編輯資料 新編資料 {get;set;}
}

public class 新增編輯資料
{
    string 新增者員編 {get;set;}
    DateTime 新增日期 {get;set;}
    string 編輯者員編 {get;set;}
    DateTime 編輯日期 {get;set;}
}