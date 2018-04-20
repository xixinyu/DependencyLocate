using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyLocate.DependencyAttribute
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public sealed class DecoratorAttribute : Attribute
    {
        //实现客户类型实际需要的抽象类型的实体类型实例，即待注入客户类型的内容
        public readonly object Injector;
        readonly Type type;

        public DecoratorAttribute(Type type)
        {
            if (type == null) throw new ArgumentNullException("type");
            this.type = type;

            Injector = (new Assembler()).Create(this.type);
        }

        //客户类型需要的抽象对象类型
        public Type Type { get { return this.type; } }
    }
}
