using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyLocate.DependencyAttribute
{
    [Decorator(typeof(ITimeProvider))]
    //应用Attribute，定义需要将ITimeProvider通过它注入
    class Client
    {
        public int GetYear()
        {
            //与其他注入不同的是，这里使用ITimeProvider来自自己的Attribute
            var porvider = AttributeHelper.Injector<ITimeProvider>(this);
            return porvider.CurrentDate.Year;
        }
    }
}
