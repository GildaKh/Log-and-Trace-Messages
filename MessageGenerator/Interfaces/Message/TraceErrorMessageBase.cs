﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageGenerator.Interfaces.Message
{
    /// <summary>
    /// A message base for messages lead to error.
    /// </summary>
    public abstract class TraceErrorMessageBase : TraceMessageBase
    {
        public abstract Exception Exception { get; }

        public virtual string Message => Exception.Message;
        public virtual string Source => Exception.Source;

        public TraceErrorMessageBase(string description) : base(description)
        {
        }

        public override string ToString() => $"DependecyManager Error: {Description}";
    }
}
