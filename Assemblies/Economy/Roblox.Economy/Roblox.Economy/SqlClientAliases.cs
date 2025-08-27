// This file provides type aliases so existing code written against System.Data.SqlClient
// will compile while the project uses Microsoft.Data.SqlClient under the hood.
// Keep this file scoped to the Economy project to avoid cross-project conflicts.

using SqlConnection = Microsoft.Data.SqlClient.SqlConnection;
using SqlCommand = Microsoft.Data.SqlClient.SqlCommand;
using SqlDataReader = Microsoft.Data.SqlClient.SqlDataReader;
using SqlParameter = Microsoft.Data.SqlClient.SqlParameter;
using SqlTransaction = Microsoft.Data.SqlClient.SqlTransaction;
using SqlBulkCopy = Microsoft.Data.SqlClient.SqlBulkCopy;
using SqlException = Microsoft.Data.SqlClient.SqlException;
using SqlDataAdapter = Microsoft.Data.SqlClient.SqlDataAdapter;

namespace System.Data.SqlClient
{
    // Empty namespace intentionally created to satisfy `using System.Data.SqlClient;`
    // statements in legacy files. Type names are resolved via the using-aliases above.
}
