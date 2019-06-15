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
    public abstract class MessageBase
    {
        protected readonly string Description;
        public MessageBase(string _desc)
        {
            Description = _desc;
        }
    }
}
