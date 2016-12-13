using Xunit;

namespace TravisTestTests
{
    public class Test
    {
        [Fact]
        public void PassingTest()
        {
            Assert.True(true);
        }

        [Fact]
        public void TestUsingAssemblyCSharp()
        {
            ConfigNode node = new ConfigNode("NODE");
            node.AddValue("someValue", "someData");

            Assert.Equal("someData", node.GetValue("someValue"));
        }
    }
}
