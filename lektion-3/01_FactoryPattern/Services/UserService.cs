using _01_FactoryPattern.Factories;
using Microsoft.Data.SqlClient;

namespace _01_FactoryPattern.Services;

internal class UserService
{

    public void Save()
    {
        using var conn = SqlConnectionFactory.Create("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HansMattin-Lassei\\Documents\\temp.mdf;Integrated Security=True;Connect Timeout=30");
        conn.Open();

        using var cmd = SqlCommandFactory.Create("INSERT INTO Users VALUES ('Hans', 'Mattin-Lassei')", conn);
        cmd.ExecuteNonQuery();
    }

    public void Get()
    {
        using var conn = SqlConnectionFactory.Create("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HansMattin-Lassei\\Documents\\temp.mdf;Integrated Security=True;Connect Timeout=30");
        conn.Open();

        using var cmd = SqlCommandFactory.Create("SELECT * FROM Users", conn);
        var result = cmd.ExecuteReader();

        while(result.HasRows)
        {
            foreach(var row in result)
            {
                
            }
        }
    }
}
