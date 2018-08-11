using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class Administrator : Base
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

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
