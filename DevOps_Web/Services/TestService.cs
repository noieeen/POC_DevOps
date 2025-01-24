namespace DevOps_Web.Services;

public class TestService
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public void TestException()
    {
        throw new Exception("Testing exception");
    }
}