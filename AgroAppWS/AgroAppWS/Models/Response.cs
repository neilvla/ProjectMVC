using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgroAppWS.Models
{
    public class Response<T>
    {
        public int TypeResult { get; set; }
        public T Result { get; set; }
        public List<T> ListResult { get; set; }
    }
}
