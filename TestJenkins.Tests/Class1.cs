using TestJenkins.API;
using Xunit;

namespace Tests
{
    public class Class1
    {


        [Fact]
        public void TestOne()
        {
            var cv = new Something();
            Assert.True(cv.GetSomething());////////////////////////////////////
        }
    }
}
