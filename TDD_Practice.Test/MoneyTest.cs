namespace TDD_Practice.Test
{
    public class MoneyTest
    {
        [Fact]
        public void TestMultiplication()
        {
            var five = new Dollar(5);
            five.Times(2);
            Assert.Equal(10, five.amount);
        }
    }
}