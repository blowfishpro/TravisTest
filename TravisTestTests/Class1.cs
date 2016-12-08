using Xunit;

namespace TravisTestTests
{
    public class Class1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.True(true);
        }

        [Fact]
        public void FailingTest()
        {
            Assert.False(true);
        }
    }
}
