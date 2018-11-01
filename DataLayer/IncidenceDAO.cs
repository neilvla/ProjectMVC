﻿using EntityLayer;
using LibraryLayer;
using LibraryLayer.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataLayer
{
    public class IncidenceDAO : IBase<Incidence>
    {
        private static IncidenceDAO instance = null;
        public static IncidenceDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new IncidenceDAO();
                return instance;
            }
        }

        public Incidence get(int id)
        {
            throw new NotImplementedException();
        }
        public List<Incidence> list()
        {
            throw new NotImplementedException();
        }

        public bool save(ref BaseResult baseResult, Incidence obj)
        {
            bool res = false;
            MySqlConnection cn = null;
            try
            {
                cn = Connection.getConnection();
                MySqlCommand cmd = new MySqlCommand("Incidence_Save", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("pid", obj.Id);
                cmd.Parameters["pid"].Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("psubject", obj.Subject);
                cmd.Parameters.AddWithValue("pdescription", obj.Description);
                cmd.Parameters.AddWithValue("puserid", obj.objUser.Id);

                cmd.ExecuteNonQuery();

                int incidenceid = Convert.ToInt32(cmd.Parameters["pid"].Value);                

                foreach (IncidenceDetail item in obj.listIncidence)
                {
                    cmd = new MySqlCommand("IncidenceDetail_Save", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("pimage", item.Image);
                    cmd.Parameters.AddWithValue("pincidenceid", incidenceid);
                    cmd.ExecuteNonQuery();
                }

                res = true;

            }
            catch (Exception ex)
            {
                baseResult = new BaseResult((Int16)Resource.EnumTypeResult.Error, "Ha ocurrido un error", ex);
            }
            finally
            {
                cn.Close();
            }
            return res;
        }

        public List<Incidence> listByUser(ref BaseResult baseResult, int userid)
        {
            MySqlConnection cn = Connection.getConnection();
            List<Incidence> incidents = null;

            try
            {
                MySqlCommand cmd = new MySqlCommand("Incidents_GetByUser", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("puserid", userid);
                MySqlDataReader reader = cmd.ExecuteReader();
                incidents = new List<Incidence>();
                Incidence s = null;
                while (reader.Read())
                {
                    s = new Incidence()
                    {
                        Id = reader.GetInt32("id"),
                        Subject = reader.GetString("subject"),
                        Description = reader.GetString("description"),
                        CreatedDate = reader.GetDateTime("createddate")
                    };
                    incidents.Add(s);
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
            return incidents;
        }

        public List<IncidenceDetail> listDetail(ref BaseResult baseResult, int incidenceid)
        {
            MySqlConnection cn = Connection.getConnection();
            List<IncidenceDetail> detail = null;

            try
            {
                MySqlCommand cmd = new MySqlCommand("Incidence_Detail", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("pincidenceid", incidenceid);
                MySqlDataReader reader = cmd.ExecuteReader();
                detail = new List<IncidenceDetail>();
                IncidenceDetail s = null;
                while (reader.Read())
                {
                    s = new IncidenceDetail()
                    {
                        Id = reader.GetInt32("id"),
                        Image = reader.GetString("image")
                    };
                    detail.Add(s);
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
            return detail;
        }

    }
}
