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

        // Get tous les voyageurs et leurs données via un id d'une réservation
        public static DataView GetVoyageursAvecPrixData(int pResId) {
            DataView dataView = new DataView();
            EFAccompagnateur oEf = new EFAccompagnateur();
            try {
                dataView = EFAccompagnateur.GetVoyageursAvecPrixData(pResId);
            }
            catch (Exception ex) {
                throw ex;
            }
            return dataView;
        }

        // Get une liste de voyageurs 
        public static List<ACC_GetAccompagnateurChiffreParTete_Result> GetVoyageursAvecPrix(int pResId) {
            List<ACC_GetAccompagnateurChiffreParTete_Result> oList = new List<ACC_GetAccompagnateurChiffreParTete_Result>();
            try {
                oList = EFAccompagnateur.GetVoyageursAvecPrix(pResId);
            }
            catch (Exception ex) {
                throw ex;
            }
            return oList;
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
