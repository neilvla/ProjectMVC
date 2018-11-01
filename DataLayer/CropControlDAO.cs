using EntityLayer;
using LibraryLayer;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataLayer
{
    public class CropControlDAO
    {
        private static CropControlDAO instance = null;
        public static CropControlDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CropControlDAO();
                return instance;
            }
        }

        public bool save(ref BaseResult baseResult, CropControl obj)
        {
            bool res = false;
            try
            {
                MySqlConnection cn = Connection.getConnection();
                MySqlCommand cmd = new MySqlCommand("CropControl_Save", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("pid", obj.Id);
                cmd.Parameters.AddWithValue("pcropid", obj.Crop.Id);
                cmd.Parameters.AddWithValue("puserid", obj.User.Id);
                cmd.Parameters.AddWithValue("pdescription", obj.Description);
                cmd.Parameters.AddWithValue("pstartdate", obj.StartDate);
                cmd.Parameters.AddWithValue("pnumHes", obj.NumberHectares);

                cmd.ExecuteNonQuery();
                res = true;

            }
            catch (Exception ex)
            {
                baseResult = new BaseResult((Int16)Resource.EnumTypeResult.Error, "Ha ocurrido un error", ex);
            }
            return res;
        }

        public short getStatusByUser(ref BaseResult baseResult, int userid)
        {
            MySqlConnection cn = Connection.getConnection();
            short status = 0;

            try
            {
                MySqlCommand cmd = new MySqlCommand("Get_Control_Status", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("pstatus", status).Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("puid", userid);
                cmd.ExecuteNonQuery();
                status = Convert.ToInt16(cmd.Parameters["pstatus"].Value);
            }
            catch (Exception ex)
            {
                baseResult = new BaseResult((Int16)Resource.EnumTypeResult.Error, "Ha ocurrido un error", ex);
            }
            finally
            {
                cn.Close();
            };
            return status;
        }

        public CropControl getControlByUser(ref BaseResult baseResult, int userid)
        {
            MySqlConnection cn = Connection.getConnection();
            CropControl cropControl = null;
            try
            {
                MySqlCommand cmd = new MySqlCommand("Control_GetByUser", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("puserid", userid);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    cropControl = new CropControl()
                    {
                        Id = reader.GetInt32("id"),
                        Description = reader.GetString("description"),
                        StartDate = reader.GetDateTime("startDate"),
                        NumberHectares = reader.GetDecimal("numberHectares")
                    };
                }

            }
            catch (Exception ex)
            {
                baseResult = new BaseResult((Int16)Resource.EnumTypeResult.Error, "Ha ocurrido un error", ex);
            }
            finally
            {
                cn.Close();
            };
            return cropControl;
        }

        public List<ControlSequence> getControlSequences()
        {
            List<ControlSequence> controlSequences = null;
            MySqlConnection cn = Connection.getConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand("ControlSequence_GetAll", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataReader reader = cmd.ExecuteReader();
                controlSequences = new List<ControlSequence>();
                ControlSequence controlSeq = null;
                Phase phase = null;
                Stage stage = null;
                Task task = null;
                while (reader.Read())
                {
                    phase = new Phase() { Name = reader.GetString("phasename") };
                    stage = new Stage() { Name = reader.GetString("stagename") };
                    task = new Task() { Name = reader.GetString("taskname") };

                    controlSeq = new ControlSequence()
                    {
                        Phase = phase,
                        Stage = stage,
                        Task = task
                    };
                    controlSequences.Add(controlSeq);
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
            return controlSequences;
        }

        public bool saveControlSequence(ref BaseResult baseResult, int phaseid, int stageid, int taskid)
        {
            bool res = false;
            try
            {
                MySqlConnection cn = Connection.getConnection();
                MySqlCommand cmd = new MySqlCommand("ControlSequence_Save", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("pphaseid", phaseid);
                cmd.Parameters.AddWithValue("pstageid", stageid);
                cmd.Parameters.AddWithValue("ptaskid", taskid);
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
