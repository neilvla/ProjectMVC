using EntityLayer;
using LibraryLayer;
using LibraryLayer.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DataLayer
{
    public class UserDAO : IBase<User>
    {
        private static UserDAO instance = null;
        public static UserDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserDAO();
                return instance;
            }
        }


        public User get(int id)
        {
            MySqlConnection cn = Connection.getConnection();
            User u = null;

            try
            {
                MySqlCommand cmd = new MySqlCommand("User_GetById", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                u = null;
                if (reader.Read())
                {
                    UserType ut = new UserType()
                    {
                        Id = reader.GetInt32("userTypeId"),
                        Name = reader.GetString("usertypename")
                    };
                    u = new User()
                    {
                        Id = reader.GetInt32("id"),
                        Name = reader.GetString("name"),
                        LastName = reader.GetString("lastname"),
                        Email = reader.GetString("email"),
                        UserType = ut,
                        Image = reader.GetString("image"),
                        Password = reader.GetString("password")
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
            return u;
        }

        public List<User> list()
        {
            MySqlConnection cn = Connection.getConnection();
            List<User> users = null;

            try
            {
                MySqlCommand cmd = new MySqlCommand("User_GetAll", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataReader reader = cmd.ExecuteReader();
                users = new List<User>();
                User u = null;
                while (reader.Read())
                {
                    UserType ut = new UserType()
                    {
                        Id = reader.GetInt32("userTypeId"),
                        Name = reader.GetString("usertypename")
                    };
                    u = new User()
                    {
                        Id = reader.GetInt32("id"),
                        Name = reader.GetString("name"),
                        LastName = reader.GetString("lastname"),
                        Email = reader.GetString("email"),
                        UserType = ut,
                        Image = reader.GetString("image"),
                        CreatedDate = reader.GetDateTime("createddate")
                    };
                    users.Add(u);
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

        public bool save(User obj)
        {
            bool res = false;
            try
            {
                MySqlConnection cn = Connection.getConnection();
                MySqlCommand cmd = new MySqlCommand("User_Save", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("pid", obj.Id);
                cmd.Parameters.AddWithValue("pname", obj.Name);
                cmd.Parameters.AddWithValue("plastname", obj.LastName);
                cmd.Parameters.AddWithValue("pemail", obj.Email);
                cmd.Parameters.AddWithValue("ppassword", obj.Password);
                cmd.Parameters.AddWithValue("pusertypeid", obj.UserType.Id);
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

        public User validate(string email, string pass)
        {
            MySqlConnection cn = Connection.getConnection();
            User u = null;

            try
            {
                MySqlCommand cmd = new MySqlCommand("User_Validate", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("password", pass);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    UserType ut = new UserType()
                    {
                        Id = reader.GetInt32("userTypeId"),
                        Name = reader.GetString("usertypename")
                    };
                    u = new User()
                    {
                        Id = reader.GetInt32("id"),
                        Name = reader.GetString("name"),
                        LastName = reader.GetString("lastname"),
                        Email = reader.GetString("email"),
                        UserType = ut,
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
            return u;
        }
    }
}
