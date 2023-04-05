using Microsoft.Data.SqlClient;

namespace _01_FactoryPattern.Factories;

internal class SqlConnectionFactory
{
    public static SqlConnection Create(string connectionString)
    {
        return new SqlConnection(connectionString);
    }
}
