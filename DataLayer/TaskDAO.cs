using EntityLayer;
using LibraryLayer;
using LibraryLayer.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataLayer
{
    public class TaskDAO : IBase<Task>
    {
        private static TaskDAO instance = null;
        public static TaskDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaskDAO();
                return instance;
            }
        }

        public Task get(int id)
        {
            MySqlConnection cn = Connection.getConnection();
            Task t = null;

            try
            {
                MySqlCommand cmd = new MySqlCommand("Phase_GetById", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("pid", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                t = null;
                if (reader.Read())
                {
                    t = new Task()
                    {
                        Id = reader.GetInt32("id"),
                        Name = reader.GetString("name"),
                        Description = reader.GetString("description"),
                        //Image = reader.GetString("image"),
                        Status = reader.GetByte("status")
                    };
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            };
            return t;
        }

        public List<Task> list()
        {
            MySqlConnection cn = Connection.getConnection();
            List<Task> tasks = null;

            try
            {
                MySqlCommand cmd = new MySqlCommand("Task_GetAll", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataReader reader = cmd.ExecuteReader();
                tasks = new List<Task>();
                Task t = null;
                while (reader.Read())
                {
                    t = new Task()
                    {
                        Id = reader.GetInt32("id"),
                        Name = reader.GetString("name"),
                        Description = reader.GetString("description"),
                        //Image = reader.GetString("image"),
                        CreatedDate = reader.GetDateTime("createddate")
                    };
                    tasks.Add(t);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            };
            return tasks;
        }

        public bool save(Task obj)
        {
            throw new NotImplementedException();
        }
    }
}
