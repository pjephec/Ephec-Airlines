using System;
using System.Collections.Generic;
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
    }
}
