using System;

namespace C_____learning
{
    
    internal class AttributeInfoAttribute : Attribute
    {
        internal string name;
        internal string date_creation;
        public AttributeInfoAttribute(string name, string date_creation)
        {
            this.name = name;
            this.date_creation = date_creation;
        }
    }
}