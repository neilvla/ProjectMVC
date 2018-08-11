using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class Base
    {
        public int Id { get; set; }
        public short Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
