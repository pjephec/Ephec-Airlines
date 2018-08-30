using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Connection;
using BusinessErrors;
using EntityClient;
using System.Data.SqlClient;
using System.Data;
using Models;

namespace DataAccessLayer
{
    public class DALVols
    {

        // ADMIN (ADO.NET) - Fetch toutes les infos des vols: ID, CODE, LIBELLE VILLE DEP, LIBELLE VILLE ARR, PLACES DISPO
        public static DataSet GetInfos()
        {
            DataSet infosVols = new DataSet();
            SqlDataAdapter oDataAdapter = DatabaseUtils.GetAdapterForStoredProcedure("adminAirline.Vol_FetchVolInfos", Connect.AdminConnection);
            oDataAdapter.Fill(infosVols);
            return infosVols;
        }

        // ADMIN (ADO.NET) - Filtre pour les vols: on ira chercher un match pour chaque info du vol  
        public static DataSet GetInfosFiltre(string filter) //Afficher les infos filtrées
        {
            DataSet filteredVols = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            SqlCommand sqlCommand = DatabaseUtils.GetCommandForStoredProcedure("adminAirline.VOL_FiltrerResultats", Connect.AdminConnection);
            sqlCommand.Parameters.Add(new SqlParameter("@input", filter));
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(filteredVols);

            return filteredVols;
        }

        // ADMIN (ADO.NET) - GET de tous les vols
        public static List<Models.Vol> GetAllVols() {
            List<Models.Vol> listeVols = new List<Models.Vol>();

            try {
                using (SqlCommand command = DatabaseUtils.GetCommandForStoredProcedure("adminAirline.VOL_TousLesVols", Connect.AdminConnection)) {
                    using (SqlDataReader reader = command.ExecuteReader()) {
                        if (reader.HasRows) {
                            while (reader.Read()) {
                                listeVols.Add(DatabaseUtils.MapReaderToVols(reader));
                            }
                        }
                    }
                }
            }
            catch (SqlException sqle) {
                throw new CustomError(sqle.ErrorCode);
            }

            return listeVols;
        }
        // ADMIN (ADO.NET) - Get des détails pour un vol
        public static void GetStatsVol(int idVol, int idPlan, out int nbPassagers, out int nbPlacesDisp, out decimal tauxOqp, out decimal ca) {
            {
                SqlCommand command = DatabaseUtils.GetCommandForStoredProcedure("adminAirline.VOL_PLA_FetchStatistics", Connect.AdminConnection);

                SqlParameter paramNbPassagers = new SqlParameter("@NbPassagers", SqlDbType.Int) {
                    Direction = ParameterDirection.Output
                };
                SqlParameter paramNbPlacesDispo = new SqlParameter("@NbPlacesRestantes", SqlDbType.Int) {
                    Direction = ParameterDirection.Output
                };
                SqlParameter paramTauxOccupation = new SqlParameter("@TauxOccupation", SqlDbType.Decimal) {
                    Direction = ParameterDirection.Output
                };
                SqlParameter paramCA = new SqlParameter("@Ca", SqlDbType.Decimal) {
                    Direction = ParameterDirection.Output
                };

                command.Parameters.Add(new SqlParameter("@IdVol", idVol));
                command.Parameters.Add(new SqlParameter("@IdPlan", idPlan));
                command.Parameters.Add(paramNbPassagers);
                command.Parameters.Add(paramNbPlacesDispo);
                command.Parameters.Add(paramTauxOccupation);
                command.Parameters.Add(paramCA);
                
                try {
                    command.ExecuteNonQuery();
                    nbPassagers = (Int32)paramNbPassagers.Value;
                    nbPlacesDisp = (Int32)paramNbPlacesDispo.Value;
                    tauxOqp = (decimal)paramTauxOccupation.Value;
                    ca = (decimal)paramCA.Value;
                }
                catch (SqlException sqlEx) {
                    throw sqlEx;
                }
                catch (Exception ex) {
                    throw ex;
                }

            }
        }
        // ADMIN (ADO.NET) - Get statistiques générales
        public static DataSet GetCaTrancheVol(int pPlaId) //Afficher les stats generales lorsqu'on load le form
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();

            try {
                SqlCommand command = DatabaseUtils.GetCommandForStoredProcedure("adminAirline.VOL_GetCaParAge", Connect.AdminConnection);
                command.Parameters.Add(new SqlParameter("@IdPlan", pPlaId));
                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "MonDataSet");
            }
            catch (SqlException sqlEx) {
                throw sqlEx;
            }
            catch (Exception ex) {
                throw ex;
            }

            return dataSet;
        }
    }
}
