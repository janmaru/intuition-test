using System;
using System.Collections.Generic;
using System.Text;

namespace Intuition.Technical.Questions.Core
{
    public interface IErrorMessage
    {
        int StatusCode { get; }
        string StatusDescription { get; }
        string Message { get; }
    }
}
