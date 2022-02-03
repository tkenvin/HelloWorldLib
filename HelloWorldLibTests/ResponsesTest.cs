using HelloWorldLib;
using Xunit;

namespace HelloWorldLibTest
{
    public class ResponsesTest
    {
        [Fact]
        public void Hello_Correct()
        {
            var responses = new Responses();
            Assert.Equal("Hello", responses.Hello());
        }

        [Fact]
        public void World_Correct()
        {
            var responses = new Responses();
            Assert.Equal("World", responses.World());
        }
    }
}
