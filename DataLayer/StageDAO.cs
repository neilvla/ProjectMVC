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
    public class StageDAO : IBase<Stage>
    {

        private static StageDAO instance = null;
        public static StageDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new StageDAO();
                return instance;
            }
        }

        public Stage get(int id)
        {
            MySqlConnection cn = Connection.getConnection();
            Stage s = null;

            try
            {
                MySqlCommand cmd = new MySqlCommand("Stage_GetById", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("pid", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                s = null;
                if (reader.Read())
                {
                    s = new Stage()
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
            return s;
        }

        public List<Stage> list()
        {
            MySqlConnection cn = Connection.getConnection();
            List<Stage> stages = null;

            try
            {
                MySqlCommand cmd = new MySqlCommand("Stage_GetAll", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataReader reader = cmd.ExecuteReader();
                stages = new List<Stage>();
                Stage s = null;
                while (reader.Read())
                {
                    s = new Stage()
                    {
                        Id = reader.GetInt32("id"),
                        Name = reader.GetString("name"),
                        Description = reader.GetString("description"),
                        Image = reader.GetString("image"),
                        CreatedDate = reader.GetDateTime("createddate")
                    };
                    stages.Add(s);
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
            return stages;
        }

        public bool save(Stage obj)
        {
            bool res = false;
            try
            {
                MySqlConnection cn = Connection.getConnection();
                MySqlCommand cmd = new MySqlCommand("Stage_Save", cn);
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
