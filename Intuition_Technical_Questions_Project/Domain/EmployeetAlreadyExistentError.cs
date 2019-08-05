using Intuition.Technical.Questions.Core;
using System.Net;

namespace Intuition.Technical.Questions.Question1
{
    //The request could not be completed due to a conflict with the current state of the resource. 
    //This code is only allowed in situations where it is expected that the user might be able to resolve the conflict and resubmit the request.
    public class EmployeetAlreadyExistentError : ErrorMessage
    {
        public EmployeetAlreadyExistentError()
            : base(409, HttpStatusCode.Conflict.ToString())
        {
        }

        public EmployeetAlreadyExistentError(string message)
            : base(409, HttpStatusCode.Conflict.ToString(), message)
        {
        }
        public EmployeetAlreadyExistentError(int statusCode, string message)
            : base(statusCode, HttpStatusCode.Conflict.ToString(), message)
        {
        }
    }
}
