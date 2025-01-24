using DevOps_Web.Services;

namespace DevOps_Web.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var test = new TestService();
        var result = test.add(1, 2);
        Assert.Equal(3, result);
    }
}