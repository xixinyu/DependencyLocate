using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DependencyLocate.DependencySetter
{
    public class TestClent
    {
        [Fact]
        public void TestMethod1()
        {
            var clent = new Client() { TimeProvider = (new Assembler()).Create<ITimeProvider>() };
            var result = clent.GetYear();
        }

    }
}
