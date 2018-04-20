using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyLocate.DependencyInterface
{
    public class Client : IobjectWithTimeProvider
    {
        public ITimeProvider TimeProvider { get; set; }
        public int GetYear()
        {
            return TimeProvider.CurrentDate.Year;
        }
    }
}
