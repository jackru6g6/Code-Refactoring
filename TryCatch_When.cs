void 呼叫API()
{
    var times = 0;
    try
    {
        查詢公車時刻();
    }
    catch(逾時例外 tException)
    {
        if(times++ < 3)
        {
            等待10秒();
        }
        else
        {
            throw;
        }
    }
}

void 呼叫API()
{
    var times = 0;
    try
    {
        查詢公車時刻();
    }
    catch(逾時例外 tException) when(times++ < 3)
    {
        等待10秒();
    }
}