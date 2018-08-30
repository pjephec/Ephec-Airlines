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
    }
}
