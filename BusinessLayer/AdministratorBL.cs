using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class AdministratorBL
    {
        private static AdministratorBL instance = null;
        public static AdministratorBL Instance
        {
            get
            {
                if (instance == null)
                    instance = new AdministratorBL();
                return instance;
            }
        }
        public Administrator validateUser(string email, string pass)
        {
            return AdministratorDAO.Instance.validate(email, pass);
        }
    }
}
