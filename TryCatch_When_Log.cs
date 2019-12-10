void 呼叫API()
{
    var times = 0;
    try
    {
        查詢公車時刻();
    }
    catch(Exception tException) when(紀錄Log(tException)){}
    catch(逾時例外 tException) when(times++ < 3)
    {
        等待10秒();
    }
}

bool 紀錄Log(Exception ex)
{
    紀錄Log_Modle(ex);
    return false;
}