using DataLayer;
using EntityLayer;
using LibraryLayer;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class UserBL
    {
        private static UserBL instance = null;
        public static UserBL Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserBL();
                return instance;
            }
        }

        public User validateUser(ref BaseResult baseResult, string email, string pass)
        {
            return UserDAO.Instance.validate(ref baseResult, email, pass);
        }

        public User get(int id)
        {
            return UserDAO.Instance.get(id);
        }

        public List<User> list()
        {
            return UserDAO.Instance.list();
        }

        public bool save(ref BaseResult baseResult, User obj)
        {
            return UserDAO.Instance.save(ref baseResult, obj);
        }
    }
}
