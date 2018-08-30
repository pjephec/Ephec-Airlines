using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer {
    public class BLTranches {
        // ADMIN (ADO.NET) -- Get tranches en fonction d'un vol
        public static DataTable GetTrancheParVol(int pId) {
            return DALTranches.GetTrancheParVol(pId);
        }
    }
}
