using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgroAppWS.Models;
using BusinessLayer;
using EntityLayer;
using LibraryLayer;
using Microsoft.AspNetCore.Mvc;

namespace AgroAppWS.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PrivateController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("saveUser")]
        public ActionResult<Response<bool>> saveUser(User u)
        {
            BaseResult baseResult = new BaseResult();
            bool res = UserBL.Instance.save(ref baseResult, u);
            return new Response<bool>
            {
                TypeResult = baseResult.Type,
                Result = res
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

        [HttpGet("incidentsByUser/{userid}")]
        public ActionResult<Response<Incidence>> incidentsByUser(int userid)
        {
            BaseResult baseResult = new BaseResult();
            List<Incidence> incidences = IncidenceBL.Instance.listByUser(ref baseResult, userid);
            return new Response<Incidence>
            {
                TypeResult = baseResult.Type,
                ListResult = incidences
            };
        }

        [HttpGet("incidenceDetail/{incidenceid}")]
        public ActionResult<Response<IncidenceDetail>> incidenceDetail(int incidenceid)
        {
            BaseResult baseResult = new BaseResult();
            List<IncidenceDetail> incidences = IncidenceBL.Instance.listDetail(ref baseResult, incidenceid);
            return new Response<IncidenceDetail>
            {
                TypeResult = baseResult.Type,
                ListResult = incidences
            };
        }

        [HttpPut("savecropcontrol")]
        public ActionResult<Response<bool>> saveCropControl(CropControl cropControl)
        {
            BaseResult baseResult = new BaseResult();
            bool res = CropControlBL.Instance.save(ref baseResult, cropControl);
            return new Response<bool>
            {
                TypeResult = baseResult.Type,
                Result = res
            };
        }

        [HttpGet("getcropcontrol/{userid}")]
        public ActionResult<Response<CropControl>> getCropControlByUser(int userid)
        {
            BaseResult baseResult = new BaseResult();
            CropControl cropControl = CropControlBL.Instance.getControlByUser(ref baseResult, userid);

            return new Response<CropControl>
            {
                TypeResult = baseResult.Type,
                Result = cropControl
            };
        }

    }
}
