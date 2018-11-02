using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class IncidenceResponse : Base
    {
        public string Subject { get; set; }
        public string Description { get; set; }
        public Incidence objIncidence { get; set; }
    }
}
