using System;

namespace Begetter.Attributes
{

    [AttributeUsage(AttributeTargets.Property)]
    public class DefaultValueAttribute : Attribute
    {
        public object Value { get; set; }
        public DefaultValueAttribute(object value)
        {
            Value = value;
        }
    }
}
