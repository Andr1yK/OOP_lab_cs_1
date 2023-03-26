using OOP_lab_cs_1;
using Xunit;

namespace OOP_lab_cs_1_tests
{
    public class Tests
    {
        [Fact]
        public void Test()
        {
            var line = new Line(1, 2);
            Assert.Equal(-2, line.Root());
        }

        [Fact]
        public void Test2()
        {
            var line = new Line(0, 2);
            Assert.Throws<System.Exception>(() => line.Root());
        }
    }
}