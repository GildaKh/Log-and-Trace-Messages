using MessageGenerator.Interfaces.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageGenerator.MessageType
{
    /// <summary>
    /// A message indicating a warning.
    /// </summary>
    public sealed class WarningMessage: MessageBase
    {
        public WarningMessage(string description) : base(description)
        {
        }

        public override string ToString() => $"DependecyManager Warning: {Description}";
    }
}
