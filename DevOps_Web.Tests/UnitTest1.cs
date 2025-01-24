using DevOps_Web.Services;

namespace DevOps_Web.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var test = new TestService();
        var result = test.Add(1, 2);
        Assert.Equal(3, result);
    }

    [Fact]
    private void SampleTestMethod()
    {
        var test = new TestService();

        var res = test.Add(10, 5);
        Assert.Equal(15, res);
    }

    [Fact]
    private void SampleTestBoolean()
    {
        var res = true;
        Assert.True(res);
    }

    [Fact]
    private void SampleThrowException()
    {
        var test = new TestService();
        // InvalidOperationException invalidOperationException = Assert.Throws<InvalidOperationException>(() => status);
        // Assert.Equal("Invalid response status. Expected: success, fail, error", invalidOperationException.Message);
        // Assert.IsType<InvalidOperationException>(result);
        var exception = Assert.Throws<Exception>(test.TestException);

        Assert.Equal("Testing exception", exception.Message);
    }
}