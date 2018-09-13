using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryLayer
{
    public class BaseResult
    {
        public BaseResult()
        {
        }

        public BaseResult(int type, string message, Exception error)
        {
            Type = type;
            Message = message;
            Error = error;
        }

        public int Type { get; set; }
        public string Message { get; set; }
        public Exception Error { get; set; }
    }
}
