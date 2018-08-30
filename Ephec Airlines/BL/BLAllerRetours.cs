using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClient;

namespace BusinessLayer {
    public class BLAllerRetours {
        public void ARInsert(int pResIdAller, int pResIdRetour) {
            try {
                EFAllerRetour.ArInsert(pResIdAller, pResIdRetour);
            }
            catch (Exception ex) {
                throw ex;
            }
        }
    }
}
