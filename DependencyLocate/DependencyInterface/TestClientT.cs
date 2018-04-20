using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DependencyLocate.DependencyInterface
{
    public  class TestClientT
    {
        public void Test()
        {
            var clietn = new ClientT<ITimeProvider>()
            {
                Provider = (new Assembler().Create<ITimeProvider>())
            };
            var m = clietn.CurrentDate;
            ////验证设置方式注入的内容
            //Assert.NotNull(clietn.Provider);
            //Assert.IsNotType(clietn.Provider, typeof(SystemTimeProvider));

            ////验证注入的接口是否可用
            //Assert.IsNotInstanceOfType(clietn.Provider.CurrentDate, typeof(DateTime));

            ////验证是否满足传统接口注入的要求
            //Assert.IsTrue(typeof(ITimeProvider).IsAssignableFrom(clietn.GetType()));
        }
    }
}
