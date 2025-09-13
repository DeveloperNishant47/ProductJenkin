using Product;
using Xunit;
namespace ProductTest;

public class UnitTest1
{
    [Fact]  //fact is the keyword to initiate the test case.
    public void Test1()
    {
        var result = Prod.Add(2, 7);
        Assert.Equal(9, result);
    }
}