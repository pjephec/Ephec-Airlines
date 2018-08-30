using BusinessErrors;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntityClient
{
    public class EFClient
    {
        // CLIENT (E-F) - Get tous les clients
        public static List<CLI_FetchTousClients_Result> FetchTousClients() {

            using (AirlinesEntities context = new AirlinesEntities()) {
                List<CLI_FetchTousClients_Result> listeClients = new List<CLI_FetchTousClients_Result>();
                try {
                    listeClients = context.CLI_FetchTousClients().ToList();
                }
                catch (Exception e) {
                    throw e;
                }
                return listeClients;
            }
        }

        // CLIENT (E-F) - Get 
        public static List<CLI_GetClientMoneyInfo_Result> GetClientMoneyInfo(int idClient, int idReservation) {

            List<CLI_GetClientMoneyInfo_Result> oList = new List<CLI_GetClientMoneyInfo_Result>();
            using (AirlinesEntities oContext = new AirlinesEntities()) {
                try {
                    oList = oContext.CLI_GetClientMoneyInfo(idClient, idReservation).ToList();
                }
                catch (System.Data.Entity.Core.EntityException efEx) {
                    SqlException sqEx = (SqlException)efEx.InnerException;
                    int numErreur = 666;
                    switch (sqEx.Number) {
                        case 2601:
                            numErreur = 3;
                            break;
                        case 51000:
                            numErreur = 4;
                            break;
                        case 52000:
                            numErreur = 7;
                            break;
                        case 53000:
                            numErreur = 3;
                            break;
                        default:
                            numErreur = 666;
                            break;
                    }
                    throw new CustomError(numErreur);
                }
                catch (Exception Ex) {
                    throw Ex;
                }
                return oList;
            }
        }
    }
}
