using DataLayer;
using EntityLayer;
using LibraryLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class TaskBL
    {
        private static TaskBL instance = null;
        public static TaskBL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaskBL();
                return instance;
            }
        }

        public List<Task> list()
        {
            return TaskDAO.Instance.list();
        }

        public Task get(int id)
        {
            return TaskDAO.Instance.get(id);
        }

        public bool save(ref BaseResult baseResult, Task obj)
        {
            return TaskDAO.Instance.save(ref baseResult, obj);
        }
    }
}
