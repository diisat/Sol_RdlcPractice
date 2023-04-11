using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace Datos
{
    public class Connection
    {
        private string Base;
        private string Server;
        private string User;
        private string Password;
        private static Connection Con = null;


        private Connection()
        {
            this.Base = "MyDatabase";
            this.Server = "SETI7742";
            this.User = "test";
            this.Password = "test12";
        }

        public SqlConnection createNewConnection()
        {
            
            
                /**SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = this.Server;
                builder.InitialCatalog = this.Base;
                builder.UserID = this.User;
                builder.Password = this.Password;
                builder.IntegratedSecurity = true;
                var cs = builder.ConnectionString;**/

                SqlConnection sqlConnection = new SqlConnection();

                sqlConnection.ConnectionString = "Server=" + this.Server + "; Database=" + this.Base + "; User Id=" + this.User + "; Password=" + this.Password;


            
            return sqlConnection;
        }

        public static Connection getInstance()
        {
            if (Con == null)
            {
                Con = new Connection();
            }
            return Con;
        }

    }


    
}
