using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_Management
{
    class Personaldaten
    {

        public const String PERSONAL_FUNKTION_CHIRURG = "Chirurg";
        public const String PERSONAL_FUNKTION_KRANKENSCHWESTER = "Krankenschwester";
        public const String PERSONAL_FUNKTION_ANAESTHESIST = "Anästhesist";

        public const String TABELLEN_NAME = "Personaldaten";

        public const String PERSONAL_SPALTE1 = "Personal_ID";
        public const String PERSONAL_SPALTE2 = "Name";
        public const String PERSONAL_SPALTE3 = "Vorname";
        public const String PERSONAL_SPALTE4 = "Funktion";
        public const String PERSONAL_SPALTE5 = "Arbeitszeit";

        private String Name; 
        private String Vorname;
        private double Arbeitszeit;
        private String Funktion;
        private double ID;

        public Personaldaten()
        {

        }

        public Personaldaten(DataRow dr)
        {
            if (dr != null)
            {
                this.ID = Convert.ToDouble(dr[PERSONAL_SPALTE1].ToString());
                this.Name = dr[PERSONAL_SPALTE2].ToString();
                this.Vorname = dr[PERSONAL_SPALTE3].ToString();
                this.Funktion = dr[PERSONAL_SPALTE4].ToString();
                this.Arbeitszeit = Convert.ToDouble(dr[PERSONAL_SPALTE5].ToString());
            }
        }

        public String getName(){
            return Name;
        }

        public String getVorname()
        {
            return Vorname;
        }

        public double getArbeitszeit()
        {
            return Arbeitszeit;
        }

        public String getFunktion()
        {
            return Funktion;
        }

        public double getID()
        {
            return ID;
        }

        public void setName(String Name)
        {
            this.Name = Name;
        }

        public void setVorname(String Vorname)
        {
            this.Vorname = Vorname;
        }

        public void setArbeitszeit(double Arbeitszeit)
        {
            this.Arbeitszeit = Arbeitszeit;
        }

        public void setFunktion(String Funktion)
        {
            this.Funktion = Funktion;
        }

        private void setID(double ID)
        {
            this.ID = ID;
        }



    }
}
