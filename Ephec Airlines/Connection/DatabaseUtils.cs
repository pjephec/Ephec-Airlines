using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessErrors;
using EntityClient;
using Models;


namespace Connection
{
    public class DatabaseUtils
    {
        public static SqlCommand GetCommandForStoredProcedure(string procedure, SqlConnection connection) { 
            SqlCommand command = new SqlCommand();
            try { 
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = procedure;
            }
            catch (SqlException sqle) { 
                throw new CustomError(sqle.ErrorCode);
            }
            return command;
        }

        public static SqlDataAdapter GetAdapterForStoredProcedure(string procedure, SqlConnection connection) {
            SqlCommand command = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            try {
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = procedure;

                adapter.SelectCommand = command;
            }
            catch (SqlException sqle) {
                throw new CustomError(sqle.ErrorCode);
            }
            return adapter;
        }

        public static Models.Vol MapReaderToVols(SqlDataReader reader) {
            Models.Vol vol = new Models.Vol {
                IdVol = Convert.ToInt32(reader["VOL_ID"]),
                Code = reader["VOL_CODE"].ToString(),
                IdVilleDepart = Convert.ToInt32(reader["VOL_ID_VILLE_DEP"].ToString()),
                IdVilleArrivee = Convert.ToInt32(reader["VOL_ID_VILLE_ARR"].ToString()),
                NbPlacesDispo = Convert.ToInt32(reader["VOL_PLACES_DISP"].ToString())
            };
            return vol;
        }

        public static Models.Planning MapReaderToPlannings(SqlDataReader reader) {
            Models.Planning planning = new Models.Planning {
                IdPlan = Convert.ToInt32(reader["PLAN_ID"]),
                DateVol = Convert.ToDateTime(reader["PLAN_VOL_DATE"].ToString()),
                IdVol = Convert.ToInt32(reader["PLAN_VOL_ID"].ToString())
            };
            return planning;
        }

        /*public static List<String> MapNamesToList(SqlDataReader clientObjects) {
            List<String> clientNames = new List<String>();
            foreach (Client client in clientObjects)
                clientNames.Add(client.CLIENT_NOM + client.CLIENT_PRENOM);
            return clientNames;
        }*/

    }
}
