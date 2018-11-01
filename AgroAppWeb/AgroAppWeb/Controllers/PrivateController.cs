using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AgroAppWeb.Middleware;
using BusinessLayer;
using EntityLayer;
using LibraryLayer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            BaseResult baseResult = new BaseResult();
            Administrator a = HttpContext.Session.GetObject<Administrator>("UserSession");
            u.CreatedBy = a.Id;
            if (!u.Image.Equals(""))
                u.Image = uploadImage(u.Image, "users");

            UserBL.Instance.save(ref baseResult, u);
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
            BaseResult baseResult = new BaseResult();
            Administrator a = HttpContext.Session.GetObject<Administrator>("UserSession");
            p.CreatedBy = a.Id;
            if (!p.Image.Equals(""))
                p.Image = uploadImage(p.Image, "phases");
            PhaseBL.Instance.save(ref baseResult, p);
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
            IEnumerable<SelectListItem> stages = StageBL.Instance.list().Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            });
            ViewData["Stages"] = stages;
            return View(t);
        }

        public IActionResult TaskSave(EntityLayer.Task t)
        {
            BaseResult baseResult = new BaseResult();
            Administrator a = HttpContext.Session.GetObject<Administrator>("UserSession");
            t.CreatedBy = a.Id;
            TaskBL.Instance.save(ref baseResult, t);
            return RedirectToAction("TaskForm");
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
            BaseResult baseResult = new BaseResult();
            Administrator a = HttpContext.Session.GetObject<Administrator>("UserSession");
            p.CreatedBy = a.Id;
            if (!p.Image.Equals(""))
                p.Image = uploadImage(p.Image, "stages");
            StageBL.Instance.save(ref baseResult, p);
            return RedirectToAction("StageForm");
        }

        [ActionName("Illnesses")]
        public IActionResult IllnessView()
        {
            Administrator a = HttpContext.Session.GetObject<Administrator>("UserSession");
            ViewData["admin"] = a;
            List<Illness> illnesses = IllnessBL.Instance.list();
            return View(illnesses);
        }

        [ActionName("IllnessForm")]
        public IActionResult IllnessFormView(int id)
        {
            Administrator u = HttpContext.Session.GetObject<Administrator>("UserSession");
            ViewData["admin"] = u;
            Illness illness = IllnessBL.Instance.get(id);
            return View(illness);
        }
        public IActionResult IllnessSave(Illness i)
        {
            BaseResult baseResult = new BaseResult();
            Administrator a = HttpContext.Session.GetObject<Administrator>("UserSession");
            i.CreatedBy = a.Id;
            if (!i.Image.Equals(""))
                i.Image = uploadImage(i.Image, "illnesses");
            IllnessBL.Instance.save(ref baseResult, i);
            return RedirectToAction("IllnessForm");
        }
        public IActionResult ControlSequence()
        {
            Administrator u = HttpContext.Session.GetObject<Administrator>("UserSession");
            ViewData["admin"] = u;
            List<ControlSequence> controlSequences = CropControlBL.Instance.getControlSequences();
            return View(controlSequences);
        }
        public IActionResult ControlSequenceForm()
        {
            Administrator u = HttpContext.Session.GetObject<Administrator>("UserSession");
            ViewData["admin"] = u;
            IEnumerable<SelectListItem> phases = PhaseBL.Instance.list().Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            });
            ViewData["Phases"] = phases;
            IEnumerable<SelectListItem> stages = StageBL.Instance.list().Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            });
            ViewData["Stages"] = stages;
            IEnumerable<SelectListItem> tasks = TaskBL.Instance.list().Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            });
            ViewData["Tasks"] = tasks;
            return View();
        }

        public IActionResult SaveSequence(int phaseid, int stageid, int taskid)
        {
            BaseResult baseResult = new BaseResult();
            CropControlBL.Instance.saveControlSequence(ref baseResult, phaseid, stageid, taskid);
            return RedirectToAction("Controlsequence");
        }
        private string uploadImage(string image, string type)
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
                        //fileName = "C:\\recursos\\agroappresource\\images\\" + type + $@"\{newFileName}";
                        fileName = "H:\\root\\home\\neilvla-001\\www\\site1\\recursos\\agroappresource\\images\\" + type + $@"\{newFileName}";

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