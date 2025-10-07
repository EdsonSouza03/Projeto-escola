using MySql.EntityFrameworkCore.Infrastructure;

internal class ServerVersion
{
    internal static Action<MySQLDbContextOptionsBuilder>? AutoDetect(string? v)
    {
        throw new NotImplementedException();
    }
}