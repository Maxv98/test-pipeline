using test_application;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("Hello, World!", Messager.SayHello());
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal("Hello, John!", Messager.SayHello("John"));
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal("Goodbye, World!", Messager.SayGoodbye());
        }

        [Fact]
        public void Test4()
        {
            Assert.Equal("Goodbye, John!", Messager.SayGoodbye("John"));
        }
    }
}