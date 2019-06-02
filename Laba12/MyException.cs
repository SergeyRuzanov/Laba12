using System;

namespace Laba12
{
    class MyException : Exception
    {
        public string Firstname { get; private set; }
        public string Surname { get; private set; }
        public MyException(string msg, string firstname, string surname) : base(msg)
        {
            Firstname = firstname;
            Surname = surname;
        }
    }
}
