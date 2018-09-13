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

    }
}
