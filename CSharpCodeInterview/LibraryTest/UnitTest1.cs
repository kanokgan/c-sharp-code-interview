namespace test_library;

using Library;
using Xunit;

public class TestCSharpCodeInterview
{
    [Fact]
    public void TestThing()
    {
        Assert.Equal(42, new Thing().Get(19, 23));
    }
}