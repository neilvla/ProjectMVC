using AgroAppWS.Middleware;
using AgroAppWS.Models;
using BusinessLayer;
using EntityLayer;
using LibraryLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AgroAppWS.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        //[HttpPost]
        //[ActionName("Post")]
        //public ActionResult<User> validateUser([FromBody]User u)
        //{
        //    return UserBL.Instance.validateUser(u.Email, u.Password);
        //}
        [HttpPost("validateUser")]
        public ActionResult<Response<User>> validateUser(User u)
        {
            BaseResult baseResult = new BaseResult();
            User user = UserBL.Instance.validateUser(ref baseResult, u.Email, u.Password);
            return new Response<User>
            {
                TypeResult = baseResult.Type,
                Result = user
            };
        }

        [HttpGet("stages")]
        public ActionResult<Response<Stage>> stages()
        {
            BaseResult baseResult = new BaseResult();
            List<Stage> stages = StageBL.Instance.list();
            return new Response<Stage>
            {
                TypeResult = baseResult.Type,
                ListResult = stages
            };
        }

        [HttpGet("getstatuscropcontrol/{userid}")]
        public ActionResult<Response<short>> getStatusCropControlByUser(int userid)
        {
            BaseResult baseResult = new BaseResult();
            short status = CropControlBL.Instance.getStatusCropControlByUser(ref baseResult, userid);

            return new Response<short>
            {
                TypeResult = baseResult.Type,
                Result = status
            };
        }
        [HttpPost("images/upload")]
        public async Task<string> uploadImage(IFormFile file)
        {
            if (CheckIfImageFile(file))
            {
                return await WriteFile(file);
            }

            return "Invalid image file";
        }

        private bool CheckIfImageFile(IFormFile file)
        {
            byte[] fileBytes;
            using (var ms = new MemoryStream())
            {
                file.CopyTo(ms);
                fileBytes = ms.ToArray();
            }

            return WriterHelper.GetImageFormat(fileBytes) != WriterHelper.ImageFormat.unknown;
        }

        /// <summary>
        /// Method to write file onto the disk
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public async Task<string> WriteFile(IFormFile file)
        {
            string fileName;
            try
            {
                var extension = "." + file.FileName.Split('.')[file.FileName.Split('.').Length - 1];
                fileName = Guid.NewGuid().ToString() + extension; //Create a new Name 
                                                                  //for the file due to security reasons.
                var path = Path.Combine(Directory.GetCurrentDirectory(), "C:\\recursos\\agroappresource\\images\\incidents", fileName);

                using (var bits = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(bits);
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }

            return fileName;
        }

        //[HttpPost("images/upload")]
        //public ActionResult<ResponseUpload> uploadImage(String image)
        //{
        //    var newFileName = image;
        //    string PathDB = string.Empty;
        //    if (HttpContext.Request.Form.Files != null)
        //    {
        //        var fileName = string.Empty;

        //        var files = HttpContext.Request.Form.Files;

        //        foreach (var file in files)
        //        {
        //            if (file.Length > 0)
        //            {
        //                //Getting FileName
        //                fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');

        //                //Assigning Unique Filename (Guid)
        //                var myUniqueFileName = Convert.ToString(Guid.NewGuid());

        //                //Getting file Extension
        //                var FileExtension = Path.GetExtension(fileName);

        //                // concating  FileName + FileExtension
        //                newFileName = myUniqueFileName + FileExtension;

        //                // Combines two strings into a path.
        //                //fileName = Path.Combine(_environment.WebRootPath, "images") + $@"\{newFileName}";
        //                fileName = "C:\\recursos\\agroappresource\\images\\incidents" + $@"\{newFileName}";

        //                // if you want to store path of folder in database
        //                PathDB = "" + newFileName;

        //                using (FileStream fs = System.IO.File.Create(fileName))
        //                {
        //                    file.CopyTo(fs);
        //                    fs.Flush();
        //                }
        //            }
        //        }
        //    }
        //    return new ResponseUpload { Message = "Hola", Path = "Path" };
        //}
    }

}