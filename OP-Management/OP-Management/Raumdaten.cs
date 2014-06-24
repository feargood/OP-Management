using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_Management
{
    class Raumdaten
    {
        public const String TABELLEN_NAME = "Raumdaten";

        public const String RAUM_SPALTE1 = "Raumnummer";
        public const String RAUM_SPALTE2 = "Herzop";
        
        

        private int Raumnummer; 
        private bool Herzop;
       

        public Raumdaten()
        {

        }

        public Raumdaten(DataRow dr)
        {
            if (dr != null)
            {
                this.Raumnummer = Convert.ToInt32(dr[RAUM_SPALTE1]);
                this.Herzop = Convert.ToBoolean(dr[RAUM_SPALTE2]);
                
            }
        }

        public int getRaumnummer()
        {
            return Raumnummer;
        }
        public bool getHerzop()
        {
            return Herzop;
        }
    }
}
