using Microsoft.Data.SqlClient;

namespace productWebApi.Context
{
    public sealed class DbContext
    {
        public static SqlConnection connection = new SqlConnection("Server=.;Database=ExampleForDapper;Trusted_Connection=True;TrustServerCertificate=True;");
        public static SqlConnection? Context { get; set; } = connection;
    }
}