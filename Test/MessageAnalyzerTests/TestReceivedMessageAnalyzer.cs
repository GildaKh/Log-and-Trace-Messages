using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Analyzer.Config;
using Analyzer.Interfaces;
using MessageGenerator.Interfaces.Message;
using MessageGenerator.MessageType;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.DummyData;

namespace Test.MessageAnalyzerTests
{
    [TestClass]
    public class TestReceivedMessageAnalyzer
    {
        void LogMessage(string message) => Console.WriteLine(message);

        [TestMethod]
        public void InfoMessageTest()
        {
            IReceivedMessageAnalyzer analyzer = new ReceivedMessageAnalyzer("var x = 10", LogMessage);
            var messages = analyzer.GetMessages(DummyMessage.GenerateDummyMessagesAllString, "y = 10").ToList();

            List<TraceInfoMessage> expected = new List<TraceInfoMessage>();
            expected.Add(new TraceInfoMessage("dummy description : var x = 10 ", 1));
            expected.Add(new TraceInfoMessage("dummy description : var x = 10 ", 1));
          

            Assert.AreEqual(expected.Count(), messages.Count(), "When both side consists of same number of messages");
            Assert.AreEqual(expected[0], messages[0], "When first messages are equal in info messages");
            Assert.AreEqual(expected[1], messages[1], "When second messages are equal in info messages");
        }
    }
}
