using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Text;
namespace MahekarusProfile.Models
{
    public class clsDatabase
    {
        private string connString;

        public clsDatabase(string server,string database,string uId,string password)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "your_server.database.windows.net";
            builder.UserID = "your_user";
            builder.Password = "your_password";
            builder.InitialCatalog = "your_database";
            connString = builder.ConnectionString;
        }
    }
}