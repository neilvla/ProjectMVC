using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class Task : Base
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Stage Stage { get; set; }
    }
}
