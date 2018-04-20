using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyLocate.DependencyAttribute
{
    public class TimeProvider : ITimeProvider
    {
        public DateTime CurrentDate { get { return DateTime.Now; } }
    }
}
