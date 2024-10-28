using Microsoft.Data.SqlClient;
using System.Data;

namespace Funky.Inventory.WPF.Core;

public interface IContext
{
    string? ConnectionString { get; }
    IDbConnection Connection { get; }
}

public abstract class BaseContext(string? connectionString) : IContext
{
    public string? ConnectionString { get; } = connectionString;
    public virtual IDbConnection Connection => new SqlConnection(ConnectionString);
}
