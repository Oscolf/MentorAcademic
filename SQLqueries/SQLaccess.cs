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
    
    public MySqlConnection GetConnection()
    {
        MySqlConnection connect = new MySqlConnection(_connectionString);
        connect.Open();
        return connect;
    }

    public MySqlCommand GetCommand(string commandText)
    {
        MySqlCommand cmd = new MySqlCommand(commandText, GetConnection());
        return cmd;
    }
    
    public void ExecuteNonQuery(string commandText)
    {
        MySqlCommand cmd = GetCommand(commandText);
        cmd.ExecuteNonQuery();
    }
    
    public MySqlDataReader ExecuteReader(string commandText)
    {
        MySqlCommand cmd = GetCommand(commandText);
        return cmd.ExecuteReader();
    }
    
    public DataTable ExecuteDataTable(string commandText)
    {
        MySqlCommand cmd = GetCommand(commandText);
        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
        DataTable dataTable = new DataTable();
        adapter.Fill(dataTable);
        return dataTable;
    }
}