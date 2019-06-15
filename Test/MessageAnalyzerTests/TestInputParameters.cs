using Analyzer.Config;
using Analyzer.Interfaces;
using MessageGenerator.MessageType;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.DummyData;

namespace Test.MessageAnalyzerTests
{
    [TestClass]
    public class TestInputParameters
    {
        void LogMessage(string message) => Console.WriteLine(message);

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullContentTest()
        {
            IReceivedMessageAnalyzer analyzer = new ReceivedMessageAnalyzer(null, LogMessage);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EmptyContentTest()
        {
            IReceivedMessageAnalyzer analyzer = new ReceivedMessageAnalyzer("", LogMessage);
        }

        [TestMethod]
        public void NullLogTest()
        {
            IReceivedMessageAnalyzer analyzer = new ReceivedMessageAnalyzer("var x = 10", null);
            var messages = analyzer.GetMessages(DummyMessage.GenerateDummyMessageOneString, "y = 10").ToList();

            List<InfoMessage> expected = new List<InfoMessage>();
            expected.Add(new InfoMessage("dummy description : var x = 10 ", 1));

            Assert.AreEqual(1, messages.Count(), "When both side consists of same number of messages");
            Assert.AreEqual(expected[0], messages[0], "When first messages are equal in info messages");

        }
    }
}
