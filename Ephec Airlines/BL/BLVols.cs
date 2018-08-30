using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Models;
using EntityClient;

namespace BusinessLayer
{
    public class BLVols
    {
        // Admin
        public static DataSet GetInfos() {
            return DALVols.GetInfos();
        }

        public static List<Models.Vol> GetTousVols() {
            return DALVols.GetAllVols();
        }

        public static DataSet GetInfosFiltre(string filter) {
            return DALVols.GetInfosFiltre(filter);
        }

        public static void GetStatsVol(int idVol, int idPlan, out int nbPassagers, out int nbPlacesDisp, out decimal tauxOqp, out decimal ca) {
            DALVols.GetStatsVol(idVol, idPlan, out nbPassagers, out nbPlacesDisp, out tauxOqp, out ca);
        }

        public static DataSet GetCaTrancheVol(int idPlan) {
            return DALVols.GetCaTrancheVol(idPlan);
        }

        // User

        public static List<VOL_SelectAllListChoix_Result> GetVolsSelectionAll() {
            return EFVol.GetVolsSelectionAll();
        }
        
        public static VOL_SelectAllListChoixRetour_Result GetVolRetour(int pVolIDep, int pVolIdRet) {
            try {
                return EFVol.GetVolRetour(pVolIDep, pVolIdRet);
            }
            catch (Exception ex) {
                throw ex;
            }
        }
    }
}
