using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OP_Management
{
    class OP_Daten
    {
        public const String TABELLEN_NAME = "OP_DATEN";

        public const String OP_DATEN_SPALTE1 = "Datum";
        public const String OP_DATEN_SPALTE2 = "Zeit";
        public const String OP_DATEN_SPALTE3 = "Raumnummer";
        public const String OP_DATEN_SPALTE4 = "Narkose_Arzt";
        public const String OP_DATEN_SPALTE5 = "Chirurg1";
        public const String OP_DATEN_SPALTE6 = "Chirurg2";
        public const String OP_DATEN_SPALTE7 = "Schwester1";
        public const String OP_DATEN_SPALTE8 = "Schwester2";
        public const String OP_DATEN_SPALTE9 = "Patienten_ID";

        private string Datum;
        private string Zeit;
        private int Raumnummer;
        private int Narkose_Arzt;
        private int Chirurg1;
        private int Chirurg2;
        private int Schwester1;
        private int Schwester2;
        private int Patienten_ID;




        public OP_Daten(DataRow dr)
        {
            if (dr != null)
            {
                /*DateTime tempdate;
                DateTime.TryParse(((dr[OP_DATEN_SPALTE1]).ToString()),out tempdate);
                DateTime.TryParse(((dr[OP_DATEN_SPALTE2]).ToString()),out this.Zeit);
                this.Datum = tempdate.Date;*/
                // Zeit nochmal nachschauen, wie am besten speichern

                this.Datum = dr[OP_DATEN_SPALTE1].ToString().Remove(10,9);
                this.Zeit = dr[OP_DATEN_SPALTE2].ToString();
                this.Raumnummer = Convert.ToInt32(dr[OP_DATEN_SPALTE3]);
                this.Narkose_Arzt = Convert.ToInt32(dr[OP_DATEN_SPALTE4]);
                this.Chirurg1 = Convert.ToInt32(dr[OP_DATEN_SPALTE5]);
                this.Chirurg2 = Convert.ToInt32(dr[OP_DATEN_SPALTE6]);
                this.Schwester1 = Convert.ToInt32(dr[OP_DATEN_SPALTE7]);
                this.Schwester2 = Convert.ToInt32(dr[OP_DATEN_SPALTE8]);
                this.Patienten_ID = Convert.ToInt32(dr[OP_DATEN_SPALTE9]);
            }

        }

        public OP_Daten()
        {
            // TODO: Complete member initialization
        }

        public OP_Daten clone()
        {
            OP_Daten op = new OP_Daten();
            op.setDatum(Datum);
            op.setZeit(Zeit);
            op.setRaumnummer(Raumnummer);
            op.setNarkose_Arzt(Narkose_Arzt);
            op.setChirurg1(Chirurg1);
            op.setChirurg2(Chirurg2);
            op.setSchwester1(Schwester1);
            op.setSchwester2(Schwester2);
            op.setPatienten_ID(Patienten_ID);


            return op;
        }

        public bool equalz (OP_Daten op)
        {
            if (this.Datum.Equals(op.getDatum())==false)
                return false;
            else if (this.Zeit.Equals(op.getZeit()))
                return false;
            else if (this.Raumnummer.Equals(op.getRaumnummer()) == false)
                return false;
            else if (this.Narkose_Arzt.Equals(op.getNarkose_Arzt()) == false)
                return false;
            else if (this.Chirurg1.Equals(op.getChirurg1()) == false)
                return false;
            else if (this.Chirurg2.Equals(op.getChirurg2()) == false)
                return false;
            else if (this.Schwester1.Equals(op.getSchwester1()) == false)
                return false;
            else if (this.Schwester2.Equals(op.getSchwester2()) == false)
                return false;
            else if (this.Patienten_ID.Equals(op.getPatienten_ID()) == false)
                return false;
            else
                return true;

        }

        public string getDatum()
        {
            return Datum;
        }
        public string getZeit()
        {
            return Zeit;
        }
        public int getRaumnummer()
        {
            return Raumnummer;
        }
        public int getNarkose_Arzt()
        {
            return Narkose_Arzt;
        }
        public int getChirurg1()
        {
            return Chirurg1;
        }
        public int getChirurg2()
        {
            return Chirurg2;
        }

        public int getSchwester1()
        {
            return Schwester1;
        }
        public int getSchwester2()
        {
            return Schwester2;
        }
        public int getPatienten_ID()
        {
            return Patienten_ID;
        }

        public void setDatum(string Datum)
        {
            this.Datum = Datum;
        }
        public void setZeit(string Zeit)
        {
            this.Zeit = Zeit;
        }
        public void setRaumnummer(int Raumnummer)
        {
            this.Raumnummer = Raumnummer;
        }
        public void setNarkose_Arzt(int Narkose_Arzt)
        {
            this.Narkose_Arzt = Narkose_Arzt;
        }
        public void setChirurg1(int Chirurg1)
        {
            this.Chirurg1 = Chirurg1;
        }
        public void setChirurg2(int Chirurg2)
        {
            this.Chirurg2 = Chirurg2;
        }

        public void setSchwester1(int Schwester1)
        {
            this.Schwester1 = Schwester1;
        }
        public void setSchwester2(int Schwester2)
        {
            this.Schwester2 = Schwester2;
        }
        public void setPatienten_ID(int Patienten_ID)
        {
            this.Patienten_ID = Patienten_ID;
        }


    }
}
