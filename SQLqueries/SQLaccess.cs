using System.Data;
using MySql.Data.MySqlClient;

namespace SQLqueries;

public class SqlQueries
{
    private string _connectionString;

    public string ConnectionString
    {
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Connection string cannot be null or empty.");
            _connectionString = value;
        }
    }
    
    public SqlQueries(string connection)
    {
        ConnectionString = connection;
    }
    private MySqlCommand Get_Command(string commandText)
    {
        MySqlCommand cmd = new MySqlCommand(commandText, Get_Connection());
        return cmd;
    }
    public MySqlConnection Get_Connection()
    {
        MySqlConnection connect = new MySqlConnection(_connectionString);
        connect.Open();
        return connect;
    }

    public void GetCommand_and_ExecuteNonQuery(string commandText)
    {
        MySqlCommand cmd = Get_Command(commandText);
        cmd.ExecuteNonQuery();
    }
    
    public MySqlDataReader ExecuteReader(string commandText)
    {
        MySqlCommand cmd = Get_Command(commandText);
        return cmd.ExecuteReader();
    }
    
    public DataTable Execute_Data_Table(string commandText)
    {
        MySqlCommand cmd = Get_Command(commandText);
        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
        DataTable dataTable = new DataTable();
        adapter.Fill(dataTable);
        return dataTable;
    }
}