using TravisTest;
using Xunit;

namespace TravisTestTests
{
    public class Class1Test
    {
        [Fact]
        public void TestMethod1()
        {
            Class1 c = new Class1();

            Assert.Equal(123, c.Method1());
        }
    }
}
