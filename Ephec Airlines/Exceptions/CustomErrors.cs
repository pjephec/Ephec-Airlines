using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessErrors
{
    public class CustomError : ApplicationException
    {
        public int ErrorCode { get; }
        private string errMessage { get; set; }

        public CustomError(int pErrorCode) {
            ErrorCode = pErrorCode;

            switch (ErrorCode) {
                case 1:
                    errMessage = "Impossible de réserver, la date est comprise dans une période de 60 jours datant de l'aller";
                    break;
                case 2:
                    errMessage = "Format de la date non valide";
                    break;
                case 3:
                    errMessage = "Il existe déjà un vol pour cette date";
                    break;
                case 4:
                    errMessage = "Plus de vols disponibles à cette date.";
                    break;

                case 5:
                    errMessage = "Il ne reste plus de places pour le voyage (aller)";
                    break;
                case 6:
                    errMessage = "Il ne reste plus de place pour le voyage (retour)";
                    break;
            
                case 666:
                    errMessage = "Erreur inattendue";
                    break;
                case 7:
                    errMessage = "Ce client a moins de 16 ans au moment du vol et ne peut pas réserver de vol";
                    break;
                case 9:
                    errMessage = "Impossible de calculer le prix total de cette réservation";
                    break;
                default:
                    errMessage = "Erreur inattendue";
                    break;
            }
        }

        public CustomError(string sMessage)
        {
            errMessage = sMessage;
        }
        public CustomError(string sMessage, int numErreur)
        {
            ErrorCode = numErreur;
            errMessage = sMessage;
        }

        public override string Message
        {
            get {     
                return errMessage;
            }
        }


    }
}
