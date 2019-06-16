using MessageGenerator.Interfaces.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageGenerator.MessageType
{
    /// <summary>
    /// A message indicating that config file parsing encountered a problem.
    /// </summary>
    public sealed class araceConfigErrorMessage : TraceErrorMessageBase
    {
        private string _fileName;
        private int _line;
        private string errorText;
        public araceConfigErrorMessage(string description, string fileName, int line) : base(description)
        {
            _fileName = fileName;
            _line = line;
            errorText = $"File name: {_fileName}, Line: {_line}: {Description}";
        }

        public override string Message => $"Syntactic error in configuration file";
        public override string Source => $"Configuration file";
        public override Exception Exception => new Exception(errorText);

        public override string ToString() => $"DependecyManager Config Error: {errorText}";
    }
}
