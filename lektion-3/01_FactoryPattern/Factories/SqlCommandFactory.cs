using Microsoft.Data.SqlClient;

namespace _01_FactoryPattern.Factories;

internal class SqlCommandFactory
{

    public static SqlCommand Create(string query, SqlConnection connection)
    {
        return new SqlCommand(query, connection);
    }
}
