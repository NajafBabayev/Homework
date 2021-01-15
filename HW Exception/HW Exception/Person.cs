using System;
using System.Collections.Generic;
using System.Text;

namespace HW_Exception
{
    class PersonException : ArgumentException
    {
        public int Value { get; }
        public PersonException(string message, int val)
            : base(message)
        {
            Value = val;
        }
    }
    class Person
    {
        public string Name { get; set; }
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 18)
                    throw new PersonException("Under 18 is not allowed", value);
                else
                    age = value;
            }
        }
    }
}
