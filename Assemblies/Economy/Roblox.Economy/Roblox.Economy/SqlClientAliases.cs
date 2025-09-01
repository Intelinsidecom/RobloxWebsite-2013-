// This file provides type aliases so existing code written against Microsoft.Data.SqlClient
// will compile while the project uses Microsoft.Data.SqlClient under the hood.
// Keep this file scoped to the Economy project to avoid cross-project conflicts.

global using SqlConnection = Microsoft.Data.SqlClient.SqlConnection;
global using SqlCommand = Microsoft.Data.SqlClient.SqlCommand;
global using SqlDataReader = Microsoft.Data.SqlClient.SqlDataReader;
global using SqlParameter = Microsoft.Data.SqlClient.SqlParameter;
global using SqlTransaction = Microsoft.Data.SqlClient.SqlTransaction;
global using SqlBulkCopy = Microsoft.Data.SqlClient.SqlBulkCopy;
global using SqlException = Microsoft.Data.SqlClient.SqlException;
global using SqlDataAdapter = Microsoft.Data.SqlClient.SqlDataAdapter;

namespace Microsoft.Data.SqlClient
{
    // Empty namespace intentionally created to satisfy `using Microsoft.Data.SqlClient;`
    // statements in legacy files. Type names are resolved via the using-aliases above.
}

