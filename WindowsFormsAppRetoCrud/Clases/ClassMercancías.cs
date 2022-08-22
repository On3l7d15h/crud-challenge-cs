using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsAppRetoCrud.Clases
{
    class ClassMercancías
    {
        //Variable Global, url de la conexión
        private static string stringConnection = @"server=DESKTOP-P7DTNEB\SQLEXPRESS ; database=miPrimeraVez ; integrated security = true";

        public static DataTable leerDatos()
        {
            SqlConnection conn = new SqlConnection(stringConnection);
            SqlCommand comm = new SqlCommand("Select * From Mercancías", conn);
            DataTable dtMercancías = new DataTable();

            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(comm);
                da.Fill(dtMercancías);
            }
            catch(Exception e)
            { }
            finally
            {
                conn.Close();
            }

            return dtMercancías;
        }

        public static bool insertarDatos(string descripción, int existencia, string comentario, string status, bool noEsEliminable)
        {
            bool answer;
            SqlConnection conn = new SqlConnection(stringConnection);
            SqlCommand comm = new SqlCommand("Insert Into Mercancías Values(@descripción, @existencia, @comentario, @status, @noEsEliminable);", conn);
            comm.Parameters.AddWithValue("@descripción", descripción);
            comm.Parameters.AddWithValue("@existencia", existencia);
            comm.Parameters.AddWithValue("@comentario", comentario);
            comm.Parameters.AddWithValue("@status", status);
            comm.Parameters.AddWithValue("@noEsEliminable", noEsEliminable);

            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                answer = true;
            }
            catch(Exception e)
            {
                answer = false;
            }
            finally
            {
                conn.Close();
            }

            return answer;
        }


        public static bool actualizarDatos(string descripción, int existencia, string comentario, string status, bool noEsEliminable, int ID)
        {
            bool answer;
            SqlConnection conn = new SqlConnection(stringConnection);
            SqlCommand comm = new SqlCommand("Update Mercancías Set Descripción = @descripción, Existencia = @existencia, Comentario = @comentario, Status = @status, NoEliminable = @noEsEliminable Where IdMercancía = @ID", conn);
            comm.Parameters.AddWithValue("@descripción", descripción);
            comm.Parameters.AddWithValue("@existencia", existencia);
            comm.Parameters.AddWithValue("@comentario", comentario);
            comm.Parameters.AddWithValue("@status", status);
            comm.Parameters.AddWithValue("@noEsEliminable", noEsEliminable);
            comm.Parameters.AddWithValue("@ID", ID);

            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                answer = true;
            }
            catch (Exception e)
            {
                answer = false;
            }
            finally
            {
                conn.Close();
            }

            return answer;
        }


        public static bool eliminarDatos(int ID)
        {
            bool answer;
            SqlConnection conn = new SqlConnection(stringConnection);
            SqlCommand comm = new SqlCommand("Delete from Mercancías Where IdMercancía = @ID", conn);
            comm.Parameters.AddWithValue("@ID", ID);

            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                answer = true;
            }
            catch (Exception e)
            {
                answer = false;
            }
            finally
            {
                conn.Close();
            }

            return answer;
        }
    }
}
