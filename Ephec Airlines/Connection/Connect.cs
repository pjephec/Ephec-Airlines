using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    public sealed class Connect
    { 
        private const string CLIENT_CONNECTION_STRING = "Data Source=(local);Initial Catalog=Airlines;User ID=clientAirline;Password= ;";
        private const string ADMIN_CONNECTION_STRING = "Data Source=(local);Initial Catalog=Airlines;User ID=adminAirline;Password= ;";

        private static SqlConnection ConnectAdmin;
        private static SqlConnection ConnectClient;

        public static SqlConnection AdminConnection
        {
            get
            {
                if (ConnectAdmin == null || ConnectAdmin.State != ConnectionState.Open)
                {
                    ConnectAdmin = new SqlConnection();
                    ConnectAdmin.ConnectionString = ADMIN_CONNECTION_STRING;
                    ConnectAdmin.Open();
                }
                return ConnectAdmin;
            }
        }
        public static SqlConnection LecteurConnection
        {
            get
            {
                if (ConnectClient == null || ConnectClient.State != ConnectionState.Open)
                {
                    ConnectClient = new SqlConnection();
                    ConnectClient.ConnectionString = CLIENT_CONNECTION_STRING;
                    ConnectClient.Open();
                }
                return ConnectClient;
            }
        }
    }
}
