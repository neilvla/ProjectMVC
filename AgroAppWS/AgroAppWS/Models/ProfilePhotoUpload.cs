using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgroAppWS.Models
{
    public class ProfilePhotoUpload
    {
        public IFormFile file { get; set; }
    }
}
