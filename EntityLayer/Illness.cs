using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class Illness:Base
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public String Image { get; set; }
        public IllnessType IllnessType { get; set; }
    }
}
