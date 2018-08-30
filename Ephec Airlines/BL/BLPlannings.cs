using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DataAccessLayer;
using System.Data;
using EntityClient;

namespace BusinessLayer {
    public class BLPlannings {
        // ADMIN
        // ADMIN (ADO.NET) - Get des dates pour un id d'un vol donné
        public static List<Models.Planning> GetDatesByVolId(int pId) {
            return DALPlannings.GetDateByVolId(pId);
        }
        // ADMIN (ADO.NET) - Get une liste des passagers pour un id de vol et de planning donné
        public static DataSet GetListePassagers(int pVolId, int pPlaId) {
            return DALPlannings.GetListPassagers(pVolId, pPlaId);
        }

        // USER
        public static List<PLA_GetDateByVolId_Result> GetDatesVol(int pId) {
            List<PLA_GetDateByVolId_Result> oList = new List<PLA_GetDateByVolId_Result>();
            try {
                oList = EFPlanning.GetDatesVol(pId);
            }
            catch (Exception ex) {
                throw ex;
            }
            return oList;
        }

    }
}
