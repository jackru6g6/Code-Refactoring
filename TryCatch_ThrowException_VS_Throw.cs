void Main()
{
    TestThrow();
    TestThrowEx();
}


static void ThrowException()
{
    throw new Exception();
}

static void TestThrow()
{
    try
    {
        try
        {
            ThrowException();
        }
        catch (Exception)
        {
            throw;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("TestThrow");
        Console.WriteLine(ex.StackTrace);
        Console.WriteLine(new string('=',50));
    }
}


static void TestThrowEx()
{
    try
    {
        try
        {
            ThrowException();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("TestThrowEx");
        Console.WriteLine(ex.StackTrace);
        Console.WriteLine(new string('=', 50));
    }
}