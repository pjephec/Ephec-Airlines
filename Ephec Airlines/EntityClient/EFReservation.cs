using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClient {
    public static class EFReservation {
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
    }
}
