using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClient {
    public class EFPlanning {
        public static List<PLA_GetDateByVolId_Result> GetDatesVol(int pId) {
            using (AirlinesEntities oContext = new AirlinesEntities()) {
                List<PLA_GetDateByVolId_Result> oList = new List<PLA_GetDateByVolId_Result>();
                try {
                    oList = oContext.PLA_GetDateByVolId(pId).ToList();

                }
                catch (Exception Ex) {
                    throw Ex;
                }
                return oList;
            }
        }

        public static List<PLA_GetDateByVolIdDateCritere_Result> GetDatesVol(int pId, DateTime dateCr) {
            using (AirlinesEntities oContext = new AirlinesEntities()) {
                List<PLA_GetDateByVolIdDateCritere_Result> oList = new List<PLA_GetDateByVolIdDateCritere_Result>();
                try {
                    oList = oContext.PLA_GetDateByVolIdDateCritere(pId, dateCr).ToList();
                }
                catch (Exception Ex) {
                    throw Ex;
                }
                return oList;
            }
        }

        public static int GetNbPlacesRestantesNEW(int volId, int plaId) {
            int nbPlacesRestantes;
            using (AirlinesEntities oContext = new AirlinesEntities()) {
                try {
                    nbPlacesRestantes = oContext.VOL_PLA_GetNbPlacesRestantesNEW(volId, plaId).FirstOrDefault().Value;
                }
                catch (Exception Ex) {
                    throw Ex;
                }
                return nbPlacesRestantes;
            }
        }

        public static List<PLA_GetDatesMemeVolWithPlaId_Result> GetDatesMemeVol(int volId, int plaId) {
            List<PLA_GetDatesMemeVolWithPlaId_Result> oListDates = new List<PLA_GetDatesMemeVolWithPlaId_Result>();
            using (AirlinesEntities oContext = new AirlinesEntities()) {
                try {
                    oListDates = oContext.PLA_GetDatesMemeVolWithPlaId(volId, plaId).ToList();
                }
                catch (Exception Ex) {
                    throw Ex;
                }
                return oListDates;
            }
        }
    }
}
