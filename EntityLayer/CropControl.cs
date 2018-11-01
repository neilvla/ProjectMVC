using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class CropControl
    {
        public int Id { get; set; }
        public String Description { get; set; }
        public Crop Crop { get; set; }
        public User User { get; set; }
        public Decimal NumberHectares { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public short Status { get; set; }
    }
}
