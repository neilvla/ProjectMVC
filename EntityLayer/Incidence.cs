using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class Incidence: Base
    {
        public string Subject { get; set; }
        public string Description { get; set; }
        public List<IncidenceDetail> listIncidence { get; set; }
        public User objUser { get; set; }

    }
}
