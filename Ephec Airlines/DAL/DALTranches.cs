using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Connection;

namespace DataAccessLayer {
    public class DALTranches
    {
        // ADMIN (ADO.NET) - Get chaque tranche pour chaque vol
        public static DataTable GetTrancheParVol(int pId) {
            DataTable dataTable = new DataTable();
            DataSet dataSet = new DataSet();

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            SqlCommand command = DatabaseUtils.GetCommandForStoredProcedure("adminAirline.PRI_FetchPrixTranchesVol", Connect.AdminConnection);
            command.Parameters.Add(new SqlParameter("@IdVol", pId));
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataSet, "DataDetPrix");
            dataTable = dataSet.Tables[0];

            return dataTable;
        }
    }
}
