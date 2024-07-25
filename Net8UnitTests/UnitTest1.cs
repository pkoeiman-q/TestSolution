using NetStandardLibrary;

namespace Net8UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // arrange
            TestObject testObject = new();
            int numberToMatch = 123;

            // act
            int test = testObject.GiveNumberToTest();

            // assert
            Assert.Equal(numberToMatch, test);
        }
    }
}