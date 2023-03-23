using Microsoft.Data.SqlClient;

namespace P230_Pronia


{
    class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-TT4OA8L\SQLEXSPRESS;Initial Catalog=Test;Integrated Security=True");

        public void openConnection()
        {
            if(sqlConnection.State == System.Data.ConnectionState.Closed) 
            {
                sqlConnection.Close();
            
            }
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}
