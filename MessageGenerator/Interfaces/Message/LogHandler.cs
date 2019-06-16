using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageGenerator.Interfaces.Message
{
    /// <summary>
    /// A delegate receives a string message for logging.
    /// </summary>
    /// <param name="message">A message.</param>
    public delegate void LogHandler(string message);
}
