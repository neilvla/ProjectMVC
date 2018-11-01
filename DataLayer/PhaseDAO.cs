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
    public class PhaseDAO : IBase<Phase>
    {
        private static PhaseDAO instance = null;
        public static PhaseDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhaseDAO();
                return instance;
            }
        }

        public Phase get(int id)
        {
            MySqlConnection cn = Connection.getConnection();
            Phase p = null;

            try
            {
                MySqlCommand cmd = new MySqlCommand("Phase_GetById", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("pid", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                p = null;
                if (reader.Read())
                {
                    p = new Phase()
                    {
                        Id = reader.GetInt32("id"),
                        Name = reader.GetString("name"),
                        Description = reader.GetString("description"),                       
                        Image = reader.GetString("image"),
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
            return p;
        }

        public List<Phase> list()
        {
            MySqlConnection cn = Connection.getConnection();
            List<Phase> users = null;

            try
            {
                MySqlCommand cmd = new MySqlCommand("Phase_GetAll", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataReader reader = cmd.ExecuteReader();
                users = new List<Phase>();
                Phase p = null;
                while (reader.Read())
                {
                    p = new Phase()
                    {
                        Id = reader.GetInt32("id"),
                        Name = reader.GetString("name"),
                        Description = reader.GetString("description"),
                        Image = reader.GetString("image"),
                        CreatedDate = reader.GetDateTime("createddate")
                    };
                    users.Add(p);
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
            return users;
        }

        public bool save(ref BaseResult baseResult, Phase obj)
        {
            bool res = false;
            try
            {
                MySqlConnection cn = Connection.getConnection();
                MySqlCommand cmd = new MySqlCommand("Phase_Save", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("pid", obj.Id);
                cmd.Parameters.AddWithValue("pname", obj.Name);
                cmd.Parameters.AddWithValue("pdescription", obj.Description);
                cmd.Parameters.AddWithValue("pimage", obj.Image);
                cmd.Parameters.AddWithValue("pcreatedby", obj.CreatedBy);
                cmd.Parameters.AddWithValue("pstatus", obj.Status);

                cmd.ExecuteNonQuery();
                res = true;

            }
            catch (Exception)
            {

                throw;
            }
            return res;
        }
    }
}
