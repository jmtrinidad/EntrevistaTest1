using EntrevistaTest1.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace EntrevistaTest1.DataAccess.Data
{
    public class DataAccess
    {
        public List<Address> GetAddressesAC()
        {
            List<Address> addresses = new List<Address>();
            try
            {
                using (var connection = new SqlConnection(Connection.ConnectionStringAC))
                {
                    connection.Open();
                    var query = "Select Direccion From Cliente";
                    using (var command = new SqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader["Direccion"] != DBNull.Value)
                                {
                                    var addess = new Address
                                    {
                                        Direction = reader["Direccion"].ToString(),
                                    };

                                    addresses.Add(addess);
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                return null;
            }
            return addresses;
        }
        public List<Address> GetAddressesEntrevista1Test()
        {
            List<Address> addresses = new List<Address>();

            try
            {
                using (var connection = new SqlConnection(Connection.ConnectionStringEntrevista1Test))
                {
                    connection.Open();
                    var query = "Select Id, Address From Tb_Address";
                    using (var command = new SqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader["Address"] != DBNull.Value)
                                {
                                    var addess = new Address
                                    {
                                        Direction = reader["Address"].ToString(),
                                        Id = Convert.ToInt32(reader["Id"].ToString()),
                                    };

                                    addresses.Add(addess);
                                }

                            }
                        }
                    }

                }
            }
            catch
            {
                return null;
            }
            return addresses;
        }
        public List<Address> GetAddressesEntrevista1TestWithFilter(string filter)
        {
            List<Address> addresses = new List<Address>();

            try
            {
                using (var connection = new SqlConnection(Connection.ConnectionStringEntrevista1Test))
                {
                    connection.Open();
                    //var query = "Select Id, Address From Tb_Address";
                    using (var command = new SqlCommand("uspFilterAddress", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        //HICE UNA CONTENACION PARA EL Like, CUANDO ENVIO LA VARIABLE SIN
                        // EL SIGNO DE % NO FUNCIONA EL FILTRO
                        command.Parameters.AddWithValue("@address", $"%{filter}%");
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader["Address"] != DBNull.Value)
                                {
                                    var addess = new Address
                                    {
                                        Direction = reader["Address"].ToString(),
                                        Id = Convert.ToInt32(reader["Id"].ToString()),
                                    };
                                    addresses.Add(addess);
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                return null;
            }
            return addresses;
        }
        public bool CreateAddress(List<Address> addresses)
        {
            var result = false;
            SqlTransaction transaction = null;
            try
            {
                using (var connection = new SqlConnection(Connection.ConnectionStringEntrevista1Test))
                {
                    connection.Open();
                    transaction = connection.BeginTransaction();
                    foreach (var item in addresses)
                    {
                        //var query = "INSERT  Into Tb_Address (Address) Values (@address)";
                        if (!string.IsNullOrEmpty(item.Direction))
                        {
                            using (var command = new SqlCommand("uspInsertAddress", connection, transaction))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@address", item.Direction);
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                    transaction.Commit();
                    result = true;
                } 
            }
            catch
            {
                transaction.Rollback();
                return false;
            }
            return result;
        }
        public bool CreateTokens(List<Token> tokens)
        {
            var result = false;
            SqlTransaction transaction = null;
            try
            {
                using (var connection = new SqlConnection(Connection.ConnectionStringEntrevista1Test))
                {
                    connection.Open();
                    transaction = connection.BeginTransaction();
                    foreach (var item in tokens)
                    {
                        var query = "INSERT  Into Tb_Tokens (AddressID,Token) Values (@addressID,@token)";
                        if (!string.IsNullOrEmpty(item.Tokens))
                        {
                            using (var command = new SqlCommand(query, connection, transaction))
                            {
                                //command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@addressID", item.DirectionId);
                                command.Parameters.AddWithValue("@token", item.Tokens);
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                    transaction.Commit();
                    result = true;
                }
            }
            catch
            {
                transaction.Rollback();
                return result;
            }
            return result;
        }
    }
}
