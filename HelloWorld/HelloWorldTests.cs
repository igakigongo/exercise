using Xunit;

namespace HelloWorld;

public class HelloWorldTests
{
    [Fact]
    public void Say_hi_()
    {
        Assert.Equal("Hello, World!", HelloWorld.Hello());
    }
}
