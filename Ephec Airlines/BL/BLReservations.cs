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

        public int InsertRes(int pCliId, int pPlaId) {
            int res = -1;
            try {
                res = EFReservation.InsertRes(pCliId, pPlaId);
            }
            catch (Exception ex) {
                throw ex;
            }
            return res;
        }

        public RES_GetAller_Result GetResAller(DateTime pDateResRetour, int pCliId, int pVilIdDep, int pViIdRet) {
            RES_GetAller_Result oAller = new RES_GetAller_Result();
            try {
                oAller = EFReservation.GetResAller(pDateResRetour, pCliId, pVilIdDep, pViIdRet);
            }
            catch (Exception ex) {
                throw ex;
            }
            return oAller;
        }

        // Get reservations en fonction d'un id
        public int GetResId(int pCliId, int pPlaId) {
            int res = 0;
            try {
                res = EFReservation.GetResId(pCliId, pPlaId);
            }
            catch (Exception ex) {
                throw ex;
            }
            return res;
        }

        // Get le prix d'une réservation
        public decimal? GetResPrixTotal(int pResId) {
            decimal? res = 0;
            EFReservation oEf = new EFReservation();
            try {
                res = oEf.GetResPrixTotal(pResId);
            }
            catch (Exception ex) {
                throw ex;
            }
            return res;
        }

        // Delete une réservation avec Id
        public static void DeleteResId(int pResId) {
            EFReservation oEf = new EFReservation();
            try {
                oEf.DeleteResId(pResId);
            }
            catch (Exception ex) {
                throw ex;
            }
        }
    }
}
