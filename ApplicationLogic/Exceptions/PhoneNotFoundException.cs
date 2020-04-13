using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLogic.Exceptions
{
    public class PhoneNotFoundException : Exception
    {
        public string Name { get; private set; }
        public PhoneNotFoundException(string name) : base($"Phone with name {name} was not found")
        {
        }
    }
}
