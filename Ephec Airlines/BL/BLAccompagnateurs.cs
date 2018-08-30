using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClient;

namespace BusinessLayer {
    public class BLAccompagnateurs {
        // Insertion d'un voyageur
        public int InsertVoyageur(string pNom, string pPrenom, DateTime date, int pResId) {
            int res = -1;
            try {
                res = EFAccompagnateur.InsertVoyageur(pNom, pPrenom, date, pResId);
            }
            catch (Exception ex) {
                throw ex;
            }
            return res;
        }
        // Insertion d'un voyageur sans prénom
        public int InsertVoyageur(string pNom, DateTime date, int pResId) {
            int res = -1;
            try {
                res = EFAccompagnateur.InsertVoyageur(pNom, date, pResId);
            }
            catch (Exception ex) {
                throw ex;
            }
            return res;
        }

        /*public void GetVoyageurs(ref List<ACC_GetAccompagnateursWithPrice_Result> oList, int pResId) {
            EFAccompagnateur oEf = new EFAccompagnateur();
            try {
                oList = EFAccompagnateur.GetVoyageurs(pResId);
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public void GetVoyageursAvecPrix(ref List<ACC_GetAccompagnateurChiffreParTete_Result> oList, int pResId) {

            EFAccompagnateur oEf = new EFAccompagnateur();
            try {
                oList = EFAccompagnateur.GetVoyageursAvecPrix(pResId);
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public void GetVoyageursAvecPrixData(ref DataView oData, int pResId) {
            DataViw 
            EFAccompagnateur oEf = new EFAccompagnateur();
            try {
                oData = EFAccompagnateur.GetVoyageursAvecPrixData(pResId);
            }
            catch (Exception ex) {
                throw ex;
            }
            return 
        }

        public void DeleteVoyageur(int pVoyId) {
            EFAccompagnateur oEf = new EFAccompagnateur();
            try {
                oEf.DeleteVoyageur(pVoyId);
            }
            catch (Exception ex) {
                throw ex;
            }
        }*/
    }
}
