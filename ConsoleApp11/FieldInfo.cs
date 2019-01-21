using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    [AttributeUsage(AttributeTargets.Property)]
    class FieldInfo : System.Attribute
    {
        public string Label { get; private set; }
        public int Size { get; private set; }
        public bool IsPassword { get; private set; }

        public FieldInfo(string label, int size, bool isPassword) : this(label, size)
        {
            IsPassword = isPassword;
        }
        public FieldInfo(string label, int size)
        {
            Label = label;
            Size = size;
        }
    }
}
