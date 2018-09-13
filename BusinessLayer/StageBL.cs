using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class StageBL
    {
        private static StageBL instance = null;
        public static StageBL Instance
        {
            get
            {
                if (instance == null)
                    instance = new StageBL();
                return instance;
            }
        }

        public List<Stage> list()
        {
            return StageDAO.Instance.list();
        }

        public Stage get(int id)
        {
            return StageDAO.Instance.get(id);
        }
        public bool save(Stage obj)
        {
            return StageDAO.Instance.save(obj);
        }
    }
}
