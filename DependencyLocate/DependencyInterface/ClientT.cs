using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyLocate.DependencyInterface
{
    /// <summary>
    /// 通过泛型参数实现接口注入
    /// </summary>
    /// <typeparam name="T">待注入的接口类型</typeparam>
    public class ClientT<T> : ITimeProvider
        where T : ITimeProvider
    {
        /// <summary>
        /// 与设值方式相似的注入入口
        /// </summary>
        public T Provider { get; set; }

        /// <summary>
        /// 类似传统接口注入的实现方式
        /// </summary>
        public DateTime CurrentDate
        {
            get { return Provider.CurrentDate; }
        }
    }
}
