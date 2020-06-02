using SqlWrapper.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SqlWrapper
{
    public class SqlWrapper : ISqlWrapper
    {
        private readonly SqlConnection _sqlConnection;

        public SqlWrapper(string connectionString)
        {
            _sqlConnection = new SqlConnection(connectionString);
        }

        public void Create(Expense data)
        {
            _sqlConnection.Open();



            _sqlConnection.Close();
        }

        public void Delete(Expense data)
        {
            throw new NotImplementedException();
        }

        public Expense Read(int id)
        {
            _sqlConnection.Open();

            Expense result = null;
            using (var command = new SqlCommand())
            {
                command.Connection = _sqlConnection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = 
                    $@"
                        Select *
                        From Expenses
                        Where Id = {id}
                    ";

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result = new Expense
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Comment = reader.GetString(2)
                    };
                }
            }

            _sqlConnection.Close();

            return result;
        }

        public IEnumerable<Expense> Read()
        {
            _sqlConnection.Open();

            List<Expense> result = new List<Expense>();
            using (var command = new SqlCommand())
            {
                command.Connection = _sqlConnection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText =
                    $@"
                        Select *
                        From Expenses
                    ";

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Expense
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Comment = reader.GetString(2)
                    }); 
                }
            }

            _sqlConnection.Close();

            return result;
        }

        public void Update(Expense data)
        {
            throw new NotImplementedException();
        }

        #region IDisposable

        public void Dispose()
        {
            
        }

        #endregion
    }
}
