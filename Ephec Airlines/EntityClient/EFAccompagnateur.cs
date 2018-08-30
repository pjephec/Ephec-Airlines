using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClient;

namespace EntityClient {
    public class EFAccompagnateur {
        public static int InsertVoyageur(string pNom, string pPrenom, DateTime date, int pResId) {
            int res = -1;
            using (AirlinesEntities oContext = new AirlinesEntities()) {
                try {
                    oContext.ACC_Insert(pNom, pPrenom, date, pResId);
                    oContext.RES_UpdateReservationResId(pResId); //activer le trigger pour calculer réservation
                    res = oContext.SaveChanges(); // compte le nombre de row affectés
                }
                catch (Exception Ex) {
                    throw Ex;
                }
                return res;
            }
        }

        public static int InsertVoyageur(string pNom, DateTime date, int pResId) {
            int res = -1;
            using (AirlinesEntities oContext = new AirlinesEntities()) {
                try {
                    oContext.ACC_InsertNullPrenom(pNom, date, pResId);
                    oContext.RES_UpdateReservationResId(pResId); //activer le trigger pour calculer réservation
                    res = oContext.SaveChanges(); // compte le nombre de row affectés
                }
                catch (Exception Ex) {
                    throw Ex;
                }
                return res;
            }
        }

        public static DataView GetVoyageursAvecPrixData(int ResId) {
            DataTable oDataTable = new DataTable();
            oDataTable.Columns.Add("ACC_ID", typeof(Int32));
            oDataTable.Columns.Add("ACC_NOM", typeof(string));
            oDataTable.Columns.Add("ACC_PRENOM", typeof(string));
            oDataTable.Columns.Add("ACC_DATE_NAISSANCE", typeof(DateTime));
            oDataTable.Columns.Add("TRA_PRIX", typeof(decimal));
            using (AirlinesEntities oContext = new AirlinesEntities()) {
                try {
                    oContext.ACC_GetAccompagnateurChiffreParTete(ResId).ToList();
                    foreach (ACC_GetAccompagnateurChiffreParTete_Result oRow in oContext.ACC_GetAccompagnateurChiffreParTete(ResId)) {
                        oDataTable.Rows.Add(oRow.ACC_ID, oRow.ACC_NOM, oRow.ACC_PRENOM, oRow.ACC_DATE_NAISSANCE, oRow.TRA_PRIX);
                    }
                }
                catch (Exception Ex) {
                    throw Ex;
                }
                return oDataTable.DefaultView;
            }
        }
        // On fait un get des données des voyageurs pour une réservation
        public static List<ACC_GetAccompagnateurChiffreParTete_Result> GetVoyageursAvecPrix(int ResId) {
            List<ACC_GetAccompagnateurChiffreParTete_Result> oList = new List<ACC_GetAccompagnateurChiffreParTete_Result>();
            using (AirlinesEntities oContext = new AirlinesEntities()) {
                try {
                    oContext.ACC_GetAccompagnateurChiffreParTete(ResId);
                    oList = oContext.ACC_GetAccompagnateurChiffreParTete(ResId).ToList();
                }
                catch (Exception Ex) {
                    throw Ex;
                }
                return oList;
            }
        }
    }
}
