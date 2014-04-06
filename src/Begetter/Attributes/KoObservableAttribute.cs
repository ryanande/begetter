using System;

namespace Begetter.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class KoObservableAttribute : Attribute
    {
        public bool IsKoObservable { get; set; }
        public KoObservableAttribute(bool isKoObservable)
        {
            IsKoObservable = isKoObservable;
        }
    }
}
