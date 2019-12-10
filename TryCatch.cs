public string 取得字串第4個字母(string 字串)
{
    return 字串[3];
}


public string 取得字串第4個字母(string 字串)
{
    try
    {
        return 字串[3];
    }
    catch
    {
        return "";
    }
}


public string 取得字串第4個字母(string 字串)
{
    try
    {
        if(字串.Length>4)
        {
            return 字串[3];
        }
        return "";
    }
    catch
    {
        return "";
    }
}