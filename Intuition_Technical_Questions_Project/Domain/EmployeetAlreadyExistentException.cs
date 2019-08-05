using System;
using System.Collections.Generic;
using System.Text;

namespace Intuition.Technical.Questions.Question1
{
    public class EmployeetAlreadyExistentException : Exception
    {
        public EmployeetAlreadyExistentException()
        {
        }

        public EmployeetAlreadyExistentException(string message)
            : base(message)
        {
        }

        public EmployeetAlreadyExistentException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
