using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClient;

namespace BusinessLayer {
    public class BLReservations {
        public static List<RES_GetResByClientId_Result> GetResClient(int idClient) {
            List<RES_GetResByClientId_Result> oEf = new List<RES_GetResByClientId_Result>();
            try {
                oEf = EFReservation.GetResClient(idClient);
            }
            catch (Exception ex) {
                throw ex;
            }
            return oEf;
        }
    }
}
