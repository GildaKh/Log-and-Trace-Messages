using MessageGenerator.Interfaces.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageGenerator.MessageType
{
    /// <summary>
    /// A message indicating information.
    /// </summary>
    public sealed class InfoMessage: MessageBase
    {
        private int _code;
        public InfoMessage(string description, int code) : base(description)
        {
            _code = code;
        }

        public override string ToString() => $"DependecyManager Info: \"{Description}\" for code: {_code}";

        public bool Equals(InfoMessage other)
        {
            if (object.ReferenceEquals(other, null))
            {
                return object.ReferenceEquals(this, null);
            }
            return string.Equals(Description, other.Description)
                && string.Equals(_code, other._code);
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is InfoMessage && Equals((InfoMessage)obj);
        }
        public static bool operator ==(InfoMessage left, InfoMessage right)
        {
            if (object.ReferenceEquals(left, null))
            {
                return object.ReferenceEquals(right, null);
            }
            return left.Equals(right);
        }
        public static bool operator !=(InfoMessage left, InfoMessage right)
        {
            return !left.Equals(right);
        }
    }
}
