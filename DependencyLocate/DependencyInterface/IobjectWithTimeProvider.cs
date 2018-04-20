using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyLocate.DependencyInterface
{
    //定义需要注入ITimeProvider的类型
    interface IobjectWithTimeProvider
    {
        ITimeProvider TimeProvider { get; set; }
    }
}
