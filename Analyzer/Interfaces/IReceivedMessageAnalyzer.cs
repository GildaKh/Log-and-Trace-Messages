using MessageGenerator.Interfaces.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer.Interfaces
{
    public interface IReceivedMessageAnalyzer
    {
         IEnumerable<MessageBase> GetMessages(Func<IEnumerable<string>> receivedValues, string successCriteria);
    }
}
