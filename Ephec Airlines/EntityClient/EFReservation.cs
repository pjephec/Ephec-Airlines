using BusinessErrors;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClient {
    public class EFReservation {
        // Get reservation client via un ID
        public static List<RES_GetResByClientId_Result> GetResClient(int idClient) {
            using (AirlinesEntities oContext = new AirlinesEntities()) {
                List<RES_GetResByClientId_Result> oList = new List<RES_GetResByClientId_Result>();
                try {
                    oList = oContext.RES_GetResByClientId(idClient).ToList();
                }
                catch (Exception Ex) {
                    throw Ex;
                }
                return oList;
            }
        }

        // Insertion d'une réservation
        public static int InsertRes(int pCliId, int pPlaId) {
            int res = -1;
            using (AirlinesEntities oContext = new AirlinesEntities()) {
                List<RES_GetResByClientId_Result> oList = new List<RES_GetResByClientId_Result>();
                try {
                    oContext.RES_Insert(pCliId, pPlaId);
                    res = oContext.SaveChanges(); // compte le nombre de row affectés
                }
                catch (EntityException efEx) {
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
                            // sMessage = exSQL.Number + " - " + exSQL.Message;
                            break;
                    }
                    throw new CustomError(numErreur);
                }
                catch (Exception Ex) {
                    throw Ex;
                }
                return res;
            }
        }
        // Get réservation Aller
        public static RES_GetAller_Result GetResAller(DateTime pDateResRetour, int pCliId, int pVilIdDep, int pViIdRet) {

            using (AirlinesEntities oContext = new AirlinesEntities()) {
                List<RES_GetAller_Result> oList = new List<RES_GetAller_Result>();
                RES_GetAller_Result oAller = new RES_GetAller_Result();
                oAller = null; //si on ne retourne pas de vol aller...
                int datediff = 0;
                try {
                    oList = oContext.RES_GetAller(pDateResRetour, pCliId, pVilIdDep, pViIdRet).ToList();
                    if (oList != null) {
                        foreach (RES_GetAller_Result oResult in oList) {
                            if (oResult.Column1 > datediff) //Column1=datediff
                            {
                                datediff = oResult.Column1.Value;
                                oAller = oResult;
                            }
                        }
                    }
                }
                catch (Exception Ex) {
                    throw Ex;
                }
                return oAller;
            }
        }

        // Get reservations en fonction d'un id client et planning
        public static int GetResId(int pCliId, int pPlaId) {
            using (AirlinesEntities oContext = new AirlinesEntities()) {
                int result = 0;
                try {
                    result = (Int32)oContext.RES_GetResId(pCliId, pPlaId).FirstOrDefault();
                }
                catch (Exception Ex) {
                    throw Ex;
                }
                return result;
            }
        }
        // Get le prix total de la réservation
        public Nullable<decimal> GetResPrixTotal(int pResId) {
            decimal? res;
            using (AirlinesEntities oContext = new AirlinesEntities()) {
                List<RES_GetResByClientId_Result> oList = new List<RES_GetResByClientId_Result>();
                try {
                    res = (decimal?)oContext.RES_GetPrixTotal(pResId).FirstOrDefault();
                }
                catch (EntityException efEx) {
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
                            // sMessage = exSQL.Number + " - " + exSQL.Message;
                            break;
                    }
                    throw new CustomError(numErreur);
                }
                catch (Exception Ex) {
                    throw Ex;
                }
                return res;
            }
        }


    }
}
