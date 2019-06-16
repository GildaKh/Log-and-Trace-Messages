using MessageGenerator.Interfaces.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageGenerator.MessageType
{
    /// <summary>
    /// A message indicating that parameter in scope is not defined.
    /// </summary>
    public sealed class TraceScopeErrorMessage : TraceErrorMessageBase
    {
        private string _paramName;
        public TraceScopeErrorMessage(string description, string paramName) : base(description)
        {
            _paramName = paramName;
        }
        public override string Source => $"Scope file: {_paramName}";
        public override Exception Exception => new Exception(Description);

    }
}
