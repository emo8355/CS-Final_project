using System;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Collections;
/// <summary>
/// Summary description for Class1
/// </summary>
/// 

namespace CS_FinalProject_HL_SZ
{
	public class Database
	{
		static private readonly string connectionString = "Server=tcp:szbcitcshl.database.windows.net,1433;Initial Catalog=library;Persist Security Info=False;User ID=adp001;Password=Admin001;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
		private SqlConnection cnn = new SqlConnection(connectionString);
		private SqlCommand command;
		private SqlDataAdapter insert = new SqlDataAdapter();
		private SqlDataReader dataReader;
		public Database()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public void ConfirmConnect()
		{
			cnn.Open();
			MessageBox.Show("Connect confirm");
			cnn.Close();
		}

		public void testWrite()
        {
			cnn.Open();
			string sql = "Insert into category (name) values ('comic')";
			command = new SqlCommand(sql, cnn);
			insert.InsertCommand = new SqlCommand(sql, cnn);
			insert.InsertCommand.ExecuteNonQuery();
			MessageBox.Show("data inserted");
			command.Dispose();
			cnn.Close();
		}

		public ListDictionary testRead()
        {
			cnn.Open();
			string sql = "select * from category";
			command = new SqlCommand(sql, cnn);
			dataReader = command.ExecuteReader();
			ListDictionary DataList = new ListDictionary();
			while (dataReader.Read())
				DataList.Add(dataReader.GetValue(0), dataReader.GetValue(1));
			command.Dispose();
			cnn.Close();

			return DataList;
		}
	}
}