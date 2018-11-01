using DataLayer;
using EntityLayer;
using LibraryLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class IllnessBL
    {
        private static IllnessBL instance = null;
        public static IllnessBL Instance
        {
            get
            {
                if (instance == null)
                    instance = new IllnessBL();
                return instance;
            }
        }

        public Illness get(int id)
        {
            return IllnessDAO.Instance.get(id);
        }

        public List<Illness> list()
        {
            return IllnessDAO.Instance.list();
        }

        public bool save(ref BaseResult baseResult, Illness obj)
        {
            return IllnessDAO.Instance.save(ref baseResult, obj);
        }
    }
}
