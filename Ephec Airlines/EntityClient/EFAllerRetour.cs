using BusinessErrors;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClient {
    public class EFAllerRetour {
        // Insertion d'un AR
        public static void ArInsert(int pResIdAller, int pResIdRetour) {
            try {
                using (AirlinesEntities oContext = new AirlinesEntities()) {
                    oContext.AR_InsertAR(pResIdAller, pResIdRetour);
                }
            }
            catch (Exception Ex) {
                throw Ex;
            }
        }
        // Suppression d'un AR
        public static void DeleteAr(int pArId) {
            try {
                using (AirlinesEntities oContext = new AirlinesEntities()) {
                    oContext.AR_DeleteARById(pArId);
                }
            }

            catch (EntityException efEx) {
                SqlException sqEx = (SqlException)efEx.InnerException;
                int numErreur = 666;
                switch (sqEx.Number) {
                    case 2601:
                        numErreur = 3;
                        break;
                    case 51000:
                        numErreur = 4;
                        break;
                    case 52000:
                        numErreur = 7;
                        break;
                    case 53000:
                        numErreur = 3;
                        break;
                    default:
                        numErreur = 666;
                        // sMessage = exSQL.Number + " - " + exSQL.Message;
                        break;
                }
                throw new CustomError(numErreur);
            }
            catch (Exception Ex) {
                throw new CustomError(666); ;
            }

        }
    }
}
