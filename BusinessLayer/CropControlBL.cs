using DataLayer;
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

        public short getStatusCropControlByUser(ref BaseResult baseResult, int userid)
        {
            return CropControlDAO.Instance.getStatusByUser(ref baseResult, userid);
        }
    }
}
