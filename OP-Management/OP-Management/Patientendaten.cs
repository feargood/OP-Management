using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_Management
{
    class Patientendaten
    {

        public const String TABELLEN_NAME = "Patientendaten";

        public const String PATIENTEN_SPALTE1 = "Patienten_ID";
        public const String PATIENTEN_SPALTE2 = "Name";
        public const String PATIENTEN_SPALTE3 = "Vorname";
        public const String PATIENTEN_SPALTE4 = "OP_ID";
        

        private int Patienten_ID; 
        private String Name;
        private String Vorname;
        private int OP_ID;
       

        public Patientendaten()
        {

        }

        public Patientendaten(DataRow dr)
        {
            if (dr != null)
            {
                this.Patienten_ID = Convert.ToInt32(dr[PATIENTEN_SPALTE1]);
                this.Name = dr[PATIENTEN_SPALTE2].ToString();
                this.Vorname = dr[PATIENTEN_SPALTE3].ToString();
                this.OP_ID = Convert.ToInt32(dr[PATIENTEN_SPALTE4]);
            }
        }

        public int getPatienten_ID()
        {
            return Patienten_ID;
        }
        public String getName()
        {
            return Name;
        }
        public String getVorname()
        {
            return Vorname;
        }
        public int getOP_ID()
        {
            return OP_ID;
        }
    }
}
