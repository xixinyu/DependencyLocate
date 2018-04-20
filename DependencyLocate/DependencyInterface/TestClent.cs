using Xunit;

namespace DependencyLocate.DependencyInterface
{
    public class TestClent
    {
        [Fact]
        public void TestMethod1()
        {
            ITimeProvider timeProvider =
                (new Assembler()).Create<ITimeProvider>();

            Assert.NotNull(timeProvider); //确认可以正常获得抽象类型实例

            IobjectWithTimeProvider objectWithProvider = new Client();
            objectWithProvider.TimeProvider = timeProvider; //通过接口方式注入

        }
    }
}
