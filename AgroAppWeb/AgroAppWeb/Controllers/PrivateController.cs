using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AgroAppWeb.Middleware;
using BusinessLayer;
using EntityLayer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace AgroAppWeb.Controllers
{
    [SessionTimeoutAttribute]
    public class PrivateController : Controller
    {
        [ActionName("Home")]
        public IActionResult HomeView()
        {
            Administrator a = HttpContext.Session.GetObject<Administrator>("UserSession");
            ViewData["admin"] = a;
            return View();
        }

        [ActionName("Users")]
        public IActionResult UserView()
        {
            Administrator a = HttpContext.Session.GetObject<Administrator>("UserSession");
            ViewData["admin"] = a;
            List<User> users = UserBL.Instance.list();
            return View(users);
        }

        [ActionName("UserForm")]
        public IActionResult UserFormView(int id)
        {
            Administrator u = HttpContext.Session.GetObject<Administrator>("UserSession");
            ViewData["admin"] = u;
            User user = UserBL.Instance.get(id);
            return View(user);
        }

        public IActionResult UserSave(User u)
        {
            Administrator a = HttpContext.Session.GetObject<Administrator>("UserSession");
            u.CreatedBy = a.Id;
            u.Image = uploadImage(u.Image);
            UserBL.Instance.save(u);
            return RedirectToAction("UserForm");
        }

        [ActionName("Phases")]
        public IActionResult PhaseView()
        {
            Administrator a = HttpContext.Session.GetObject<Administrator>("UserSession");
            ViewData["admin"] = a;
            List<Phase> phases = PhaseBL.Instance.list();
            return View(phases);
        }

        [ActionName("PhaseForm")]
        public IActionResult PhaseFormView(int id)
        {
            Administrator a = HttpContext.Session.GetObject<Administrator>("UserSession");
            ViewData["admin"] = a;
            Phase p = PhaseBL.Instance.get(id);
            return View(p);
        }

        public IActionResult PhaseSave(Phase p)
        {
            Administrator a = HttpContext.Session.GetObject<Administrator>("UserSession");
            p.CreatedBy = a.Id;
            p.Image = uploadImage(p.Image);
            PhaseBL.Instance.save(p);
            return RedirectToAction("PhaseForm");
        }

        [ActionName("Tasks")]
        public IActionResult TaskView()
        {
            Administrator a = HttpContext.Session.GetObject<Administrator>("UserSession");
            ViewData["admin"] = a;
            List<EntityLayer.Task> tasks = TaskBL.Instance.list();
            return View(tasks);
        }

        [ActionName("TaskForm")]
        public IActionResult TaskFormView(int id)
        {
            Administrator a = HttpContext.Session.GetObject<Administrator>("UserSession");
            ViewData["admin"] = a;
            EntityLayer.Task t = TaskBL.Instance.get(id);
            return View(t);
        }

        [ActionName("Stages")]
        public IActionResult StageView()
        {
            Administrator a = HttpContext.Session.GetObject<Administrator>("UserSession");
            ViewData["admin"] = a;
            List<Stage> phases = StageBL.Instance.list();
            return View(phases);
        }

        [ActionName("StageForm")]
        public IActionResult StageFormView(int id)
        {
            Administrator a = HttpContext.Session.GetObject<Administrator>("UserSession");
            ViewData["admin"] = a;
            Stage p = StageBL.Instance.get(id);
            return View(p);
        }

        public IActionResult StageSave(Stage p)
        {
            Administrator a = HttpContext.Session.GetObject<Administrator>("UserSession");
            p.CreatedBy = a.Id;
            p.Image = uploadImage(p.Image);
            StageBL.Instance.save(p);
            return RedirectToAction("StageForm");
        }

        private string uploadImage(string image)
        {
            var newFileName = image;
            string PathDB = string.Empty;
            if (HttpContext.Request.Form.Files != null)
            {
                var fileName = string.Empty;                

                var files = HttpContext.Request.Form.Files;

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
                        fileName = "C:\\recursos\\agroappresource\\images\\users" + $@"\{newFileName}";

                        // if you want to store path of folder in database
                        PathDB = "" + newFileName;

                        using (FileStream fs = System.IO.File.Create(fileName))
                        {
                            file.CopyTo(fs);
                            fs.Flush();
                        }
                    }
                }
            }
            return newFileName;
        }
    }
}