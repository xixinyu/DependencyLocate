using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DependencyLocate.DependencyAttribute
{
    public class TestClient
    {
        [Fact]
        public void Test1()
        {
            Assert.True(new Client().GetYear() > 0);
        }
    }
}
