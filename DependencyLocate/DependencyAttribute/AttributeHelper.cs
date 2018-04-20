using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyLocate.DependencyAttribute
{
    public static class AttributeHelper
    {
        public static T Injector<T>(object target) where T : class
        {
            if (target == null) throw new ArgumentNullException("target");
            return (T)(((DecoratorAttribute[])
                    target.GetType().GetCustomAttributes(typeof(DecoratorAttribute), false))
                .Where(x => x.Type == typeof(T)).FirstOrDefault()
                .Injector);
        }
    }
}
