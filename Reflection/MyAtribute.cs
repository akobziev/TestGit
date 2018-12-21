using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = true)]
    sealed class CustomAttribute : Attribute
    {
        private readonly string realName;

        public CustomAttribute(string realName)
        {
            this.realName = realName;
        }

        public string RealName => realName;
    }
}
