using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPracticeProblem
{
    public class InvalidAgeException : Exception
    {
        //public enum ExceptionType
        //{
        //    NullMessage,
        //    EmptyMessage,
        //    InvalidMessage
        //}

        //private readonly ExceptionType type;

        //public InvalidAgeException(ExceptionType type,string message) : base(message)
        //{
        //    this.type = type;
        //}

        public InvalidAgeException(string message) : base(message)
        {
        }
    }
}
