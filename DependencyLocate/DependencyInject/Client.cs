using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyLocate.DependencyInject
{
    public class Client
    {
        ITimeProvider timerprovider;
        public ITimeProvider TimeProvider { get; set; }
        public Client(ITimeProvider timeProvider)
        {
            this.timerprovider = timeProvider;
        }
        public Client()
        {
        }
        public int GetYear()
        {
            return timerprovider.CurrentDate.Year;
        }
    }
}
