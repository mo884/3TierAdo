global using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace _3TierAdo.DAL
{
    public class DBManger
    {
        SqlConnection sqlConnection;
        SqlDataAdapter dataAdapter;
        SqlCommand sqlCommand;
        DataTable dataTable;
        public DBManger()
        {
            try
            {
                sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["pubs"].ConnectionString;
                sqlCommand = new SqlCommand(string.Empty,sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter = new SqlDataAdapter(sqlCommand);
                dataTable = new ();

            }
            catch (Exception ex)
            {

                
            }
        }

        
        public DataTable ExecuteTable( string spName)
        {
            try
            {
                dataTable.Clear();
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = spName;
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {

                
            }
           
            return new DataTable(){ };
        }
        public DataTable ExecuteTable(string spName, Dictionary<string, object> parameterList)
        {
            try
            {
                dataTable.Clear();
                sqlCommand.Parameters.Clear();
                foreach (KeyValuePair<string, object> item in parameterList)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(item.Key, item.Value));
                }
                sqlCommand.CommandText = spName;
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {


            }

            return new DataTable() { };
        }
        public object ExecuteScalar(string spName)
        {
            Object retObject = new();
            try
            {
                dataTable.Clear();
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = spName;

                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();
                retObject = sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {

               

            }
            finally
            {
                sqlConnection.Close();
            }
            return retObject;
        }

        public int ExecuteNonQuery(string spName)
        {
            int returnRow = -1;
            try
            {
                dataTable.Clear();
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = spName;

                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();
                returnRow = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {



            }
            finally
            {
                sqlConnection.Close();
            }
            return returnRow;
        }
        public int ExecuteNonQuery(string spName ,Dictionary<string,object>parameterList)
        {
            int returnRow = -1;
            try
            {
                dataTable.Clear();
                sqlCommand.Parameters.Clear();
                foreach (KeyValuePair<string,object> item in parameterList)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(item.Key, item.Value));
                }
                sqlCommand.CommandText = spName;

                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();
                returnRow = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {



            }
            finally
            {
                sqlConnection.Close();
            }
            return returnRow;
        }
    }
}
