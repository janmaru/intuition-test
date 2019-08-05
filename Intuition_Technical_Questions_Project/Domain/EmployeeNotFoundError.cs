using Intuition.Technical.Questions.Core;
using System.Net;

namespace Intuition.Technical.Questions.Question1
{
      public class EmployeeNotFoundError : ErrorMessage
    {
        public EmployeeNotFoundError()
            : base(404, HttpStatusCode.Conflict.ToString())
        {
        }

        public EmployeeNotFoundError(string message)
            : base(404, HttpStatusCode.Conflict.ToString(), message)
        {
        }

        public EmployeeNotFoundError(int statusCode, string message)
            : base(statusCode, HttpStatusCode.Conflict.ToString(), message)
        {
        }
    }
}
