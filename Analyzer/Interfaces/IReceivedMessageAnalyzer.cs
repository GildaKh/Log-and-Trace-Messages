using MessageGenerator.Interfaces.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer.Interfaces
{
    /// <summary>
    /// An Interface that Recieves all the violations and generates message respectively.
    /// </summary>
    public interface IReceivedMessageAnalyzer
    {
         IEnumerable<TraceMessageBase> GetMessages(Func<IEnumerable<string>> receivedValues, string successCriteria);
    }
}
