using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class PhaseBL
    {
        private static PhaseBL instance = null;
        public static PhaseBL Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhaseBL();
                return instance;
            }
        }

        public List<Phase> list()
        {
            return PhaseDAO.Instance.list();
        }

        public Phase get(int id)
        {
            return PhaseDAO.Instance.get(id);
        }
        public bool save(Phase obj)
        {
            return PhaseDAO.Instance.save(obj);
        }
    }
}
