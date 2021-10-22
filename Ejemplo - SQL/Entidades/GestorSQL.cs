using System;
using System.Data.SqlClient;


namespace Entidades
{
    public class GestorSQL
    {
        private SqlConnection sqlConnection;
        private static string conexion;

        static GestorSQL()
        {
            GestorSQL.conexion = "Server=.;Database=Provincias;Trusted_Connection=True;";
        }
        public GestorSQL()
        {

            this.sqlConnection = new SqlConnection(GestorSQL.conexion);
        }


        public string ObtenerProvincia(int id)
        {
            string returnAux = string.Empty;
            try
            {
                string sentencia = "SELECT * FROM Provincia where id=@id";
                SqlCommand sqlCommand = new SqlCommand(sentencia, this.sqlConnection);
                sqlCommand.Parameters.AddWithValue("id", id);
                this.sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    returnAux = sqlDataReader.GetString(1);
                }
                return returnAux;
            }
            finally
            {
                if (this.sqlConnection != null && sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConnection.Close();
                }
            }
        }


        public static string InsertarProvincia(int id, string objeto)
        {
            string retunrAux = string.Empty;
            using (SqlConnection sqlConnection = new SqlConnection(GestorSQL.conexion))
            {
                string sentencia = "INSERT INTO Provincia (id,descripcion) VALUES (@id,@descripcion)";
                SqlCommand sqlCommand = new SqlCommand(sentencia, sqlConnection);
                sqlCommand.Parameters.AddWithValue("descripcion", objeto);
                sqlCommand.Parameters.AddWithValue("id", id);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                retunrAux = "Se guardo la provincias " + objeto;
            }
            return retunrAux;
        }

    }
}
