using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageGenerator.Interfaces.Message
{
    /// <summary>
    /// A message base for all the message types.
    /// </summary>
    public abstract class TraceMessageBase
    {
        protected readonly string Description;
        public TraceMessageBase(string _desc)
        {
            Description = _desc;
        }
    }
}
