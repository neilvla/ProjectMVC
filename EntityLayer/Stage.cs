using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class Stage : Base
    {
        public string Name { get; set; }
        public string Description { get; set; }
        private string _image;
        public string Image
        {
            get
            {
                _image = (!String.IsNullOrEmpty(_image) ? _image : "");
                return _image;
            }
            set
            {
                _image = value;
            }
        }
    }
}
