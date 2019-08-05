using System;
using System.Collections.Generic;

namespace Intuition.Technical.Questions.Core
{
    [Serializable]
    public class Result<T, M>
    {
        public bool Success;
        public T Data;
        public IList<M> Errors;
    }
}
