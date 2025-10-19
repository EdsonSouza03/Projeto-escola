using Microsoft.EntityFrameworkCore.Infrastructure;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

internal class ServerVersion
{
    internal static Action<MySQLDbContextOptionsBuilder>? AutoDetect(string? v)
    {
        throw new NotImplementedException();
    }

    internal static Action<MySqlDbContextOptionsBuilder> AutoDetect(Microsoft.EntityFrameworkCore.ServerVersion? cdbConnectionString)
    {
        throw new NotImplementedException();
    }

    internal static Action<MySqlDbContextOptionsBuilder> AutoDetect(object connectionString2)
    {
        throw new NotImplementedException();
    }

    
    internal static Action<MySqlDbContextOptionsBuilder> AutoDetect(object connectionString1)
    {
        throw new NotImplementedException();
    }
}