using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SqlWrapper
{
    public class SqlWrapper<T> : ISqlWrapper<T> where T : class, new()
    {
        private readonly SqlConnection _sqlConnection;

        public SqlWrapper(string connectionString)
        {
            _sqlConnection = new SqlConnection(connectionString);
        }

        public void Create(T data)
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        // TODO:
        public void Read()
        {
            _sqlConnection.Open();
            List<T> result = new List<T>();

            using (var command = new SqlCommand())
            {
                command.Connection = _sqlConnection;
                command.CommandType = CommandType.Text;
                command.CommandText =
                    $@"
                        SELECT *
                        FROM {nameof(T)}
                    ";

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    
                }
            }

            _sqlConnection.Close();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        #region IDisposable

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
