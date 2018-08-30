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
        // get dates de vol par id
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
        // get dates d'un vol
        public static List<PLA_GetDateByVolIdDateCritere_Result> GetDatesVol(int pId, DateTime dateCr) // selectionner les vols retours apres la date aller
        {
            List<PLA_GetDateByVolIdDateCritere_Result> oList = new List<PLA_GetDateByVolIdDateCritere_Result>();
            try {
                oList = EFPlanning.GetDatesVol(pId, dateCr);
            }
            catch (Exception ex) {
                throw ex;
            }
            return oList;
        }
        // Get des places restantes
        public void GetNbPlacesRestantesNEW(int pVolId, int pPlaId, out int nbPlRes) {
            try {
                nbPlRes = EFPlanning.GetNbPlacesRestantesNEW(pVolId, pPlaId);
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        // get des dates d'un même vol avec un id
        public List<PLA_GetDatesMemeVolWithPlaId_Result> GetDatesMemeVol(int pVolId, int pPlaId) {
            List<PLA_GetDatesMemeVolWithPlaId_Result> oList = new List<PLA_GetDatesMemeVolWithPlaId_Result>();
            try {
                oList = EFPlanning.GetDatesMemeVol(pVolId, pPlaId);
            }
            catch (Exception ex) {
                throw ex;
            }
            return oList;
        }

    }
}
