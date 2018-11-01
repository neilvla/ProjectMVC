using DataLayer;
using EntityLayer;
using LibraryLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class CropControlBL
    {
        private static CropControlBL instance = null;
        public static CropControlBL Instance
        {
            get
            {
                if (instance == null)
                    instance = new CropControlBL();
                return instance;
            }
        }
        public bool save(ref BaseResult baseResult, CropControl obj)
        {
            return CropControlDAO.Instance.save(ref baseResult, obj);
        }
        public short getStatusCropControlByUser(ref BaseResult baseResult, int userid)
        {
            return CropControlDAO.Instance.getStatusByUser(ref baseResult, userid);
        }

        public CropControl getControlByUser(ref BaseResult baseResult, int userid)
        {
            return CropControlDAO.Instance.getControlByUser(ref baseResult, userid);
        }

        public bool saveControlSequence(ref BaseResult baseResult, int phaseid, int stageid, int taskid)
        {
            return CropControlDAO.Instance.saveControlSequence(ref baseResult, phaseid, stageid, taskid);
        }

        public List<ControlSequence> getControlSequences()
        {
            return CropControlDAO.Instance.getControlSequences();
        }
    }
}
