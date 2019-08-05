using System;
using System.Collections.Generic;
using System.Text;

namespace Intuition.Technical.Questions.Question1
{
    public class EmployeetNotFoundException : Exception
    {
        public EmployeetNotFoundException()
        {
        }

        public EmployeetNotFoundException(string message)
            : base(message)
        {
        }

        public EmployeetNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
