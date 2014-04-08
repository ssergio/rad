using System;
using MySql.Data.MySqlClient;
using System.Data;
namespace PConnection
{
	class MainClass
	{
		public static void Main (string[] args)
		{
string connectionString =
				"Server=localhost;" +
				"Database=dbrepaso;" +
				"User Id=root;" +
				"Password=sistemas";
			
			MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
			
			mySqlConnection.Open();
			
			if(mySqlConnection.State == ConnectionState.Open){
				Console.WriteLine ("OK, el estado de la conexión es CONECTADO");}
			else {Console.Write ("Error, NO se ha podido CONECTAR");
			}
			
			mySqlConnection.Close ();
			
			Console.Write (mySqlConnection.State.ToString());		}
	}
}
