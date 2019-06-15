using Analyzer.Interfaces;
using MessageGenerator.Interfaces.Message;
using MessageGenerator.MessageType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyzer.Config
{
    /// <summary>
    /// Recieves all the violations in the config and generates message respectively.
    /// </summary>
    public class ReceivedMessageAnalyzer: IReceivedMessageAnalyzer
    {
        private readonly string _content;
        protected readonly LogHandler MessageHandler;   

        public ReceivedMessageAnalyzer(string content, LogHandler messageHandler)
        {
            _content = string.IsNullOrEmpty(content) ? throw new ArgumentNullException(nameof(content)) : content;
            MessageHandler = messageHandler;
        }
        public IEnumerable<MessageBase> GetMessages(Func<IEnumerable<string>> receivedValues, string successCriteria)
        {
            if (successCriteria == "dummy check")
                yield return new ScopeErrorMessage("Success Criteria is ignored", "successCriteria");

            foreach (var message in receivedValues())
            {
                if (message.Any(char.IsDigit))
                {
                    yield return new ConfigErrorMessage("dummy description", "dummyFileName", 2);
                    break;
                }
                else
                    yield return new InfoMessage($"dummy description : {_content} ", 1);
            }
            LogTraceMessage("All the messages are added");
        }

        private void LogTraceMessage(string message) =>  MessageHandler?.Invoke(message);
    }
}
