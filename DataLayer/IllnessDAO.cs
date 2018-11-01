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
    public class IllnessDAO : IBase<Illness>
    {
        private static IllnessDAO instance = null;
        public static IllnessDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new IllnessDAO();
                return instance;
            }
        }
        public Illness get(int id)
        {
            MySqlConnection cn = Connection.getConnection();
            Illness illness = null;

            try
            {
                MySqlCommand cmd = new MySqlCommand("Illness_GetById", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("pid", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    IllnessType it = new IllnessType()
                    {
                        Id = reader.GetInt32("illnessTypeId"),
                        Name = reader.GetString("illnesstypename")
                    };
                    illness = new Illness()
                    {
                        Id = reader.GetInt32("id"),
                        Name = reader.GetString("name"),     
                        Description = reader.GetString("description"),
                        IllnessType = it,
                        Image = reader.GetString("image")
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
            return illness;
        }

        public List<Illness> list()
        {
            MySqlConnection cn = Connection.getConnection();
            List<Illness> illnesses = null;

            try
            {
                MySqlCommand cmd = new MySqlCommand("Illness_GetAll", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataReader reader = cmd.ExecuteReader();
                illnesses = new List<Illness>();
                Illness illness = null;
                while (reader.Read())
                {
                    IllnessType it = new IllnessType()
                    {
                        Id = reader.GetInt32("illnessTypeId"),
                        Name = reader.GetString("illnesstypename")
                    };
                    illness = new Illness()
                    {
                        Id = reader.GetInt32("id"),
                        Name = reader.GetString("name"),
                        Description = reader.GetString("description"),
                        IllnessType = it,
                        Image = reader.GetString("image"),
                        CreatedDate = reader.GetDateTime("createddate")
                    };
                    illnesses.Add(illness);
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
            return illnesses;
        }

        public bool save(ref BaseResult baseResult, Illness obj)
        {
            bool res = false;
            try
            {
                MySqlConnection cn = Connection.getConnection();
                MySqlCommand cmd = new MySqlCommand("Illness_Save", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("pid", obj.Id);
                cmd.Parameters.AddWithValue("pname", obj.Name);
                cmd.Parameters.AddWithValue("pdescription", obj.Description);
                cmd.Parameters.AddWithValue("pillnesstypeid", obj.IllnessType.Id);
                cmd.Parameters.AddWithValue("pimage", obj.Image);
                cmd.Parameters.AddWithValue("pcreatedby", obj.CreatedBy);
                cmd.Parameters.AddWithValue("pstatus", obj.Status);

                cmd.ExecuteNonQuery();
                res = true;

            }
            catch (Exception ex)
            {
                baseResult = new BaseResult((Int16)Resource.EnumTypeResult.Error, "Ha ocurrido un error", ex);
            }
            return res;
        }
    }
}
