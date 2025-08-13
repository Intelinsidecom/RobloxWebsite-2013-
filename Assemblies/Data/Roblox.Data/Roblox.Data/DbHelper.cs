using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Roblox.EventLog;

namespace Roblox.Data;

public class DbHelper : IDisposable
{
	public string CommandText { get; set; }

	public CommandType CommandType { get; set; } = (CommandType)1;


	public string ConnectionString { get; set; }

	public string DatabaseName { get; set; }

	public DataSet Dataset { get; set; }

	public string Password { get; set; }

	public string ServerName { get; set; }

	public SqlConnection SQLConnection { get; private set; }

	public SqlCommand SQLCommand { get; private set; }

	public SqlDataAdapter SQLAdapter { get; private set; }

	public SqlParameterCollection SQLParameters
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			if (SQLCommand == null)
			{
				SQLCommand = new SqlCommand();
			}
			return SQLCommand.Parameters;
		}
	}

	public string UserName { get; set; }

	public bool UseTrustedConnection { get; set; }

	public DbHelper()
	{
	}//IL_0002: Unknown result type (might be due to invalid IL or missing references)


	public DbHelper(string connectionString)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		ConnectionString = connectionString;
	}

	public DbHelper(string serverName, string databaseName, bool useTrustedConnection)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		ServerName = serverName;
		DatabaseName = databaseName;
		UseTrustedConnection = useTrustedConnection;
		BuildConnectionString();
	}

	public DbHelper(string serverName, string databaseName, string username, string password)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		ServerName = serverName;
		DatabaseName = databaseName;
		UserName = username;
		Password = password;
		BuildConnectionString();
	}

	private void BuildConnectionString()
	{
		string authentication = ";Trusted_Connection=yes";
		if (!UseTrustedConnection)
		{
			authentication = $";User ID={UserName};Password={Password}";
		}
		ConnectionString = $"Data Source={ServerName};Initial Catalog={DatabaseName}{authentication}";
	}

	private void PrepareSQLCommand()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (SQLConnection == null)
		{
			SQLConnection = new SqlConnection(ConnectionString);
		}
		if (SQLCommand == null)
		{
			SQLCommand = new SqlCommand();
		}
		((DbCommand)SQLCommand).CommandText = CommandText;
		((DbCommand)SQLCommand).CommandType = CommandType;
		SQLCommand.Connection = SQLConnection;
	}

	public void Connect()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		if (string.IsNullOrWhiteSpace(ConnectionString))
		{
			throw new ApplicationException("ConnectionString must be specified before connecting.");
		}
		if (SQLConnection == null)
		{
			SQLConnection = new SqlConnection();
		}
		((DbConnection)SQLConnection).ConnectionString = ConnectionString;
		((DbConnection)SQLConnection).Open();
	}

	public void Disconnect()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if ((int)((DbConnection)SQLConnection).State != 0)
		{
			((DbConnection)SQLConnection).Close();
		}
	}

	public virtual SqlDataReader ExecuteSQLReader(string commandText, CommandType commandType)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		//IL_0060: Expected O, but got Unknown
		if (commandText != string.Empty)
		{
			CommandText = commandText;
		}
		CommandType = commandType;
		PrepareSQLCommand();
		try
		{
			if ((int)((DbConnection)SQLConnection).State == 0 || (int)((DbConnection)SQLConnection).State == 16)
			{
				Connect();
				return SQLCommand.ExecuteReader();
			}
			return SQLCommand.ExecuteReader();
		}
		catch (SqlException val)
		{
			SqlException sqlException = val;
			StaticLoggerRegistry.Instance.Error((Exception)(object)sqlException);
			throw sqlException;
		}
	}

	public object ExecuteSQLScalar(string commandText, CommandType commandType)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		//IL_0068: Expected O, but got Unknown
		if (commandText != string.Empty)
		{
			CommandText = commandText;
		}
		CommandType = commandType;
		PrepareSQLCommand();
		try
		{
			if ((int)((DbConnection)SQLConnection).State == 0 || (int)((DbConnection)SQLConnection).State == 16)
			{
				try
				{
					Connect();
					return ((DbCommand)SQLCommand).ExecuteScalar();
				}
				finally
				{
					Disconnect();
				}
			}
			return ((DbCommand)SQLCommand).ExecuteScalar();
		}
		catch (SqlException val)
		{
			SqlException eSQL = val;
			StaticLoggerRegistry.Instance.Error((Exception)(object)eSQL);
			throw eSQL;
		}
	}

	public int ExecuteSQLNonQuery(string commandText, CommandType commandType)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		//IL_0068: Expected O, but got Unknown
		if (commandText != string.Empty)
		{
			CommandText = commandText;
		}
		CommandType = commandType;
		PrepareSQLCommand();
		try
		{
			if ((int)((DbConnection)SQLConnection).State == 0 || (int)((DbConnection)SQLConnection).State == 16)
			{
				try
				{
					Connect();
					return ((DbCommand)SQLCommand).ExecuteNonQuery();
				}
				finally
				{
					Disconnect();
				}
			}
			return ((DbCommand)SQLCommand).ExecuteNonQuery();
		}
		catch (SqlException val)
		{
			SqlException eSQL = val;
			StaticLoggerRegistry.Instance.Error((Exception)(object)eSQL);
			throw eSQL;
		}
	}

	public DataSet ExecuteSQLDataset(string commandText, CommandType commandType, string tableName)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0074: Expected O, but got Unknown
		if (commandText != string.Empty)
		{
			CommandText = commandText;
		}
		CommandType = commandType;
		PrepareSQLCommand();
		SQLAdapter = new SqlDataAdapter(SQLCommand);
		Dataset = new DataSet();
		try
		{
			if (tableName != "")
			{
				((DbDataAdapter)SQLAdapter).Fill(Dataset, tableName);
			}
			else
			{
				((DataAdapter)SQLAdapter).Fill(Dataset);
			}
		}
		catch (SqlException val)
		{
			SqlException sqlException = val;
			StaticLoggerRegistry.Instance.Error((Exception)(object)sqlException);
			throw sqlException;
		}
		return Dataset;
	}

	public static ICollection<T> BuildIDCollection<T>(SqlDataReader reader)
	{
		ICollection<T> result = new List<T>();
		while (((DbDataReader)reader).Read())
		{
			result.Add((T)Convert.ChangeType(((DbDataReader)reader)["ID"], typeof(T)));
		}
		return result;
	}

	public void Dispose()
	{
		((MarshalByValueComponent)(object)Dataset)?.Dispose();
		((Component)(object)SQLAdapter)?.Dispose();
		((Component)(object)SQLCommand)?.Dispose();
		((Component)(object)SQLConnection)?.Dispose();
	}
}
