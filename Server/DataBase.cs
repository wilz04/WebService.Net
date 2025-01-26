using System;

using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace Server 
{
	/// <summary>
	/// Descripción breve de Class1.
	/// </summary>
	public class DataBase
	{
		private MySqlConnection cnx;
		public DataBase()
		{
			//cnx = new MySqlConnection("server=localhost;user id=root; password=123; database=consultas; pooling=false");
      cnx = new MySqlConnection("server = localhost; user id = root; password = root; database = consultas; pooling = false");
			
		}
		
		public DataSet Select(string sql)
		{
			try
			{
				cnx.Open();
				DataSet ds = new DataSet();
				MySqlCommand cmd = new MySqlCommand(sql, cnx);
				MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
				adapter.Fill(ds);
				cnx.Close();
				return ds;
			}
			catch (Exception exc)
			{
				cnx.Close();
				throw new Exception("Error obteniendo las llaves foráneas DBManager.GetForeignKeys", exc);
			}
			return null;
		
		}
	}
}
