using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_Management
{
    class OP_Kategorien
    {

        public const String KATEGORIE_ART_HERZ = "Herz OP";
        public const String KATEGORIE_ART_GASTRO = "Gastro";
        public const String KATEGORIE_ART_ORTHOPEDIE = "Orthopedie";
        public const String KATEGORIE_ART_GYNAEKOLOGIE = "Gynäkologie";

        public const String TABELLEN_NAME = "OP_Kategorien";

        public const String KATEGORIE_SPALTE1 = "OP_ID";
        public const String KATEGORIE_SPALTE2 = "OP_Art";
        public const String KATEGORIE_SPALTE3 = "OP_Dauer";
        

        private int OP_ID; 
        private String OP_Art;
        private double OP_Dauer;
       

        public OP_Kategorien()
        {

        }

        public OP_Kategorien(DataRow dr)
        {
            if (dr != null)
            {
                this.OP_ID = Convert.ToInt32(dr[KATEGORIE_SPALTE1]);
                this.OP_Art = dr[KATEGORIE_SPALTE2].ToString();
                this.OP_Dauer = Convert.ToDouble(dr[KATEGORIE_SPALTE3]);
            }
        }

        public int getOP_ID()
        {
            return OP_ID;
        }
        public String getOP_Art()
        {
            return OP_Art;
        }
        public double getOP_Dauer()
        {
            return OP_Dauer;
        }

        public void setOP_ID(int OP_ID)
        {
            this.OP_ID = OP_ID;
        }
        public void setOP_Art(String OP_Art)
        {
            this.OP_Art = OP_Art;
        }
        public void setOP_Dauer(double OP_Dauer)
        {
            this.OP_Dauer = OP_Dauer;
        }

    }
}
