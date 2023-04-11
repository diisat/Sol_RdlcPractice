using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class D_Categories
    {
        public DataTable List_ca(string cText)
        {
            SqlDataReader result;
            DataTable myTable = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon = Connection.getInstance().createNewConnection();

                SqlCommand command = new SqlCommand("USP_List_CA", sqlCon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@cText",SqlDbType.VarChar).Value = cText;

                sqlCon.Open();
                result = command.ExecuteReader();
                myTable.Load(result);

                return myTable;
            }
            catch (Exception e)
            {
                throw e;
            } 
            finally { 
                if(sqlCon.State== ConnectionState.Open) sqlCon.Close(); 
            }

        }

        public string save_ca(int option, E_Categories oCa)
        {
            string response = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Connection.getInstance().createNewConnection();
                SqlCommand command = new SqlCommand("USP_Save_ca", sqlCon);
                command.CommandType= CommandType.StoredProcedure;
                command.Parameters.Add("@option", SqlDbType.Int).Value=option;
                command.Parameters.Add("@code_ca", SqlDbType.Int).Value = oCa.code_ca;
                command.Parameters.Add("@description_ca", SqlDbType.VarChar).Value = oCa.description_ca;
                sqlCon.Open();
                response = command.ExecuteNonQuery() == 1 ? "OK" : "No se pudo registrar el proceso" ;


            }
            catch (Exception ex)
            {
                response = ex.Message;
            }
            finally
            {
                if(sqlCon.State== ConnectionState.Open) sqlCon.Close() ;
            }
            return response;

        }


    }
}
