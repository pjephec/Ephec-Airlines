using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models {
    public class Vol {
        public int IdVol { get; set; }   
        public string Code { get; set; }
        public int IdVilleDepart { get; set; }
        public int IdVilleArrivee { get; set; }
        public int NbPlacesDispo { get; set; }
    }
}
