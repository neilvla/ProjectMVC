using DataLayer;
using EntityLayer;
using LibraryLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class IncidenceBL
    {
        private static IncidenceBL instance = null;
        public static IncidenceBL Instance
        {
            get
            {
                if (instance == null)
                    instance = new IncidenceBL();
                return instance;
            }
        }

        public List<Incidence> listByUser(ref BaseResult baseResult, int userid)
        {
            return IncidenceDAO.Instance.listByUser(ref baseResult, userid);
        }

        public bool save(ref BaseResult baseResult, Incidence obj)
        {
            return IncidenceDAO.Instance.save(ref baseResult, obj);
        }

        public List<IncidenceDetail> listDetail(ref BaseResult baseResult, int incidenceid)
        {
            return IncidenceDAO.Instance.listDetail(ref baseResult, incidenceid);
        }
    }
}
