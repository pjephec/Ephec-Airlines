using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Connection;
using Models;

namespace DataAccessLayer {
    public class DALPlannings
    {
        // ADMIN (ADO.NET) - Get une liste de dates (un planning) pour un id de vol donné
        public static List<Models.Planning> GetDateByVolId(int pId) {
            List<Models.Planning> planningList = new List<Models.Planning>();
            SqlCommand command = DatabaseUtils.GetCommandForStoredProcedure("generalAirline.PLA_GetDateByVolId", Connect.AdminConnection);
            command.Parameters.Add(new SqlParameter("@IdVol", pId));

            try {
                using (SqlDataReader reader = command.ExecuteReader()) {
                    if (reader.HasRows) {
                        while (reader.Read()) {
                            planningList.Add(DatabaseUtils.MapReaderToPlannings(reader));
                        }
                    }
                }
            }
            catch (SqlException sqlEx) {
                throw sqlEx;
            }
            catch (Exception ex) {
                throw ex;
            }

            return planningList;
        }
        // ADMIN (ADO.NET) - Get la liste des passagers pour un id de vol et de planning donné
        public static DataSet GetListPassagers(int idVol, int idPla)
        {
            SqlConnection oConnect = new SqlConnection();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataSet dataSetPassagers = new DataSet();

            try {
                SqlCommand command = DatabaseUtils.GetCommandForStoredProcedure("adminAirline.PLAN_FetchListePassagers", Connect.AdminConnection);
                command.Parameters.Add(new SqlParameter("@IdVol", idVol));
                command.Parameters.Add(new SqlParameter("@IdPlan", idPla));
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataSetPassagers, "MonDataSet");
            }
            catch (SqlException sqlEx) {
                throw sqlEx;
            }
            catch (Exception ex) {
                throw ex;
            }
            return dataSetPassagers;
        }
    }
}
