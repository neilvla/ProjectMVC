using AgroAppWS.Models;
using BusinessLayer;
using EntityLayer;
using LibraryLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AgroAppWS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Prueba1", "Prueba2" };
        }

        [HttpGet("Test")]
        public ActionResult<IEnumerable<string>> GetTest()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost("file")]
        public async Task<IActionResult> Upload([FromBody] ProfilePhotoUpload photo)
        {
            //if (CheckIfImageFile(file))
            //{
            //    return await WriteFile(file);
            //}

            //return "Invalid image file";
            return Ok(new { respuesta = "Correcto" });
        }



        [HttpPost("newfile")]
        //[HttpPost("images/upload")]
        public ActionResult<Response<bool>> uploadImage()
        {
            var newFileName = "";
            BaseResult baseResult = new BaseResult();
            string PathDB = string.Empty;
            StringValues userid = "0", subject = "", description = "";
            bool result = false;

            if (HttpContext.Request.Form.Files != null)
            {
                var fileName = string.Empty;

                var files = HttpContext.Request.Form.Files;

                HttpContext.Request.Form.TryGetValue("userid", out userid);
                HttpContext.Request.Form.TryGetValue("subject", out subject);
                HttpContext.Request.Form.TryGetValue("description", out description);

                List<IncidenceDetail> detail = new List<IncidenceDetail>();
                foreach (var file in files)
                {
                    if (file.Length > 0)
                    {
                        //Getting FileName
                        fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');

                        //Assigning Unique Filename (Guid)
                        var myUniqueFileName = Convert.ToString(Guid.NewGuid());

                        //Getting file Extension
                        var FileExtension = Path.GetExtension(fileName);

                        // concating  FileName + FileExtension
                        newFileName = myUniqueFileName + FileExtension;

                        // Combines two strings into a path.
                        //fileName = Path.Combine(_environment.WebRootPath, "images") + $@"\{newFileName}";
                        //fileName = "C:\\recursos\\agroappresource\\images\\incidents" + $@"\{newFileName}";
                        fileName = "H:\\root\\home\\neilvla-001\\www\\site1\\recursos\\agroappresource\\images\\incidents" + $@"\{newFileName}";                        

                        detail.Add(new IncidenceDetail { Image = newFileName });

                        using (FileStream fs = System.IO.File.Create(fileName))
                        {
                            file.CopyTo(fs);
                            fs.Flush();
                        }
                    }
                }
                User objUser = new User() { Id = Convert.ToInt32(userid.ToString()) };                

            Incidence incidence = new Incidence()
                {
                    Subject = subject.ToString(),
                    Description = description.ToString(),
                    listIncidence = detail,
                    objUser = objUser
                };
                result = IncidenceBL.Instance.save(ref baseResult, incidence);
            }
            return new Response<bool>
            {
                TypeResult = baseResult.Type,
                Result = result
            };
        }

    }
}
