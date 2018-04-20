using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DependencyLocate.DependencyInject
{
    public class TestClent
    {
        [Fact]
        public void TestMethod1()
        {
            ITimeProvider timeProvider = (new Assembler()).Create<ITimeProvider>();
            Assert.NotNull(timeProvider);//确认可以正常获得抽象类型实例
            Client client = new Client(timeProvider);
            //在构造函数中注入
            var m = client.GetYear();

        }
    }

}
