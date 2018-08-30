using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClient {
    public class EFVol {
        // Get informations pour la combobox du choix des vols
        public static List<VOL_SelectAllListChoix_Result> GetVolsSelectionAll()
        {
            List<VOL_SelectAllListChoix_Result> list = new List<VOL_SelectAllListChoix_Result>();
            using (AirlinesEntities oContext = new AirlinesEntities()) {
                try {
                    list = oContext.VOL_SelectAllListChoix().ToList();
                }
                catch (Exception Ex) {
                    throw Ex;
                }
            }
            return list;
        }
        public static VOL_SelectAllListChoixRetour_Result GetVolRetour(int pVolIdDepart, int pVolIdRetour) //pour la combo box de choix de vols
        {
            using (AirlinesEntities oContext = new AirlinesEntities()) {
                List<VOL_SelectAllListChoixRetour_Result> oList = new List<VOL_SelectAllListChoixRetour_Result>();
                VOL_SelectAllListChoixRetour_Result oVol = new VOL_SelectAllListChoixRetour_Result();
                try {
                    oList = oContext.VOL_SelectAllListChoixRetour(pVolIdDepart, pVolIdRetour).ToList();
                    oVol = oList[0]; //il existe un et un seul vol retour 
                }
                catch (Exception Ex) {
                    throw Ex;
                }
                return oVol;
            }
        }
    }
}
