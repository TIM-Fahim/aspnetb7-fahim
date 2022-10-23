using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Reflection;
using System.Reflection;

namespace Assignment04
{
    public class MyORM<G, T> : IMyORM
    {
        private string _connectionString = "$Server=.\\SQLEXPRESS;Database=DevSkill;User Id=sa;Password=root123;";

        private SqlCommand PrepareCommand(string sql, Dictionary<string, object> parameters, CommandType commandType)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = _connectionString;

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = sql;
            sqlCommand.CommandType = commandType;

            if (parameters != null)
            {
                foreach (var item in parameters)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(item.Key, item.Value));
                }
            }

            return sqlCommand;
        }

        public async Task ExecuteCommandAsync(string command,
            Dictionary<string, object> parameters, CommandType commandType)
        {
            using SqlCommand sqlCommand = PrepareCommand(command, parameters, commandType);

            try
            {
                if (sqlCommand.Connection.State != System.Data.ConnectionState.Open)
                    sqlCommand.Connection.Open();

                int impact = await sqlCommand.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }
        public async Task<List<Dictionary<string, object>>> GetDataAsync(string command,
            Dictionary<string, object> parameters, CommandType commandType)
        {
            using SqlCommand sqlCommand = PrepareCommand(command, parameters, commandType);
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();

            try
            {
                if (sqlCommand.Connection.State != System.Data.ConnectionState.Open)
                    sqlCommand.Connection.Open();

                using SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();

                while (reader.Read())
                {
                    Dictionary<string, object> row = new Dictionary<string, object>();
                    for (var i = 0; i < reader.FieldCount; i++)
                    {
                        row.Add(reader.GetName(i), reader.GetValue(i));
                    }

                    rows.Add(row);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {

            }

            return rows;
        }
        public void Insert(T item)
        {
            Type type = item.GetType();
            string className = item.GetType().Name;
            /*List<Type> properyTypes =*/
             PropertyInfo[] properties =  type.GetProperties();
            string sqlTble = $"INSERT INTO {className} (";
            string colums = "";
            for (int i = 0; i <=properties.Length; i++)
            {
                if (i == properties.Length)
                {
                    colums += ")";
                    break;
                }
                colums += properties[i].Name;
                if (i < properties.Length - 1)
                    colums += ", ";
            }

            string values = "VALUES (";
            for (int i = 0; i <= properties.Length; i++)
            {
                if (i == properties.Length)
                {
                    values += ")";
                    break;
                }
                values += properties[i].GetValue(properties.GetType());
                if (i < properties.Length - 1)
                    colums += ", ";
            }

            string sql = sqlTble + colums + values;

            _ = ExecuteCommandAsync(sql, null, CommandType.Text);
        }
        public void Update(T item)
        {

        }
        public void Delete(T item)
        {

        }
        public void Delete(G id)
        { 
        
        }
        public Course GetById(G id)
        {
            return new Course();
;        }
        public List<Course> GetAll()
        {
            return null;
        }
    }
}
