using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyLocate.DependencySetter
{
    public  class Client
    {
        public ITimeProvider TimeProvider { get; set; }
        public int GetYear()
        {
            return TimeProvider.CurrentDate.Year;
        }
    }
}
