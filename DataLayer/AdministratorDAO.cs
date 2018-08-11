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
    public class AdministratorDAO : IBase<Administrator>
    {
        private static AdministratorDAO instance = null;
        public static AdministratorDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AdministratorDAO();
                return instance;
            }
        }

        public Administrator get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Administrator> list()
        {
            throw new NotImplementedException();
        }

        public bool save(Administrator obj)
        {
            throw new NotImplementedException();
        }

        public Administrator validate(string email, string pass)
        {
            MySqlConnection cn = Connection.getConnection();
            Administrator a = null;

            try
            {
                MySqlCommand cmd = new MySqlCommand("Adminitrator_Validate", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("pemail", email);
                cmd.Parameters.AddWithValue("ppassword", pass);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    a = new Administrator()
                    {
                        Id = reader.GetInt32("id"),
                        Name = reader.GetString("name"),
                        LastName = reader.GetString("lastname"),
                        Email = reader.GetString("email"),
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
            return a;
        }
    }
}
