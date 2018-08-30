using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClient;
using BusinessErrors;
using DataAccessLayer;

namespace BusinessLayer {
    public class BLClients {
        // Client (EF)
        public static List<CLI_FetchTousClients_Result> GetAllClients() {
            return EFClient.FetchTousClients();
        }

        public static List<CLI_GetClientMoneyInfo_Result> GetClientMoneyInfo(int idClient, int idReservation) {
            return EFClient.GetClientMoneyInfo(idClient, idReservation);
        }


    }
}
