using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OP_Management
{
    class DB
    {

        private const String user = "sa";
        private const String pwd = "123Pass123";
        private const String ip = "torstenb.no-ip.biz";
        private const String port = "3456";
        private const String instance = "Projekt1";

        private SqlConnection con = null;

        public DB()
        {
            this.open();
        }

        public void open()
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=" + ip + "," + port + ";Network Library=DBMSSOCN;Initial Catalog=" + instance + ";User ID=" + user + ";Password=" + pwd + ";";
            try
            {
                con.Open();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public DataTable getAllPersonal()
        {
            if (con != null)
            {
                string strSQL = "Select * from Personaldaten";
                SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            return null;
        }

        public Personaldaten getPersonalById(int ID)
        {
            if (con != null)
            {
                string strSQL = "Select * from " + Personaldaten.TABELLEN_NAME + " where " + Personaldaten.PERSONAL_SPALTE1 + " = " + ID;
                SqlDataAdapter da = new SqlDataAdapter(strSQL, con);

                DataTable dt = new DataTable();

                if (da.Fill(dt) == 1)
                {

                    DataRow dr = dt.Rows[0];
                    return new Personaldaten(dr);

                }
            }
            return null;
        }

        public void insertPersonaldaten(Personaldaten pd)
        {

            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT into " + Personaldaten.TABELLEN_NAME + " (" + Personaldaten.PERSONAL_SPALTE2 + ", " + Personaldaten.PERSONAL_SPALTE3 + ", " + Personaldaten.PERSONAL_SPALTE4 + ", " + Personaldaten.PERSONAL_SPALTE5 + ") VALUES (@" + Personaldaten.PERSONAL_SPALTE2 + ", @" + Personaldaten.PERSONAL_SPALTE3 + ", @" + Personaldaten.PERSONAL_SPALTE4 + ", @" + Personaldaten.PERSONAL_SPALTE5 + ")";
                command.Parameters.AddWithValue("@" + Personaldaten.PERSONAL_SPALTE2, pd.getName());
                command.Parameters.AddWithValue("@" + Personaldaten.PERSONAL_SPALTE3, pd.getVorname());
                command.Parameters.AddWithValue("@" + Personaldaten.PERSONAL_SPALTE4, pd.getFunktion());
                command.Parameters.AddWithValue("@" + Personaldaten.PERSONAL_SPALTE5, pd.getArbeitszeit());

                try
                {
                    int recordsAffected = command.ExecuteNonQuery();
                }
                catch (SqlException sqle)
                {
                    MessageBox.Show(sqle.Message, "Fehlermeldung");
                    //throw new Exception(sqle.Message, sqle);
                }
            }
        }

        public void updateOP_Daten(OP_Daten op_alt, OP_Daten op_neu)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = "update " + OP_Daten.TABELLEN_NAME +
                    " SET " + OP_Daten.OP_DATEN_SPALTE1 + " = '" + op_neu.getDatum() + "'" +
                    " , " + OP_Daten.OP_DATEN_SPALTE2 + " = '" + op_neu.getZeit() + "'" +
                    " , " + OP_Daten.OP_DATEN_SPALTE3 + " = '" + op_neu.getRaumnummer() + "'" +
                    " , " + OP_Daten.OP_DATEN_SPALTE4 + " = '" + op_neu.getNarkose_Arzt() + "'" +
                    " , " + OP_Daten.OP_DATEN_SPALTE5 + " = '" + op_neu.getChirurg1() + "'" +
                    " , " + OP_Daten.OP_DATEN_SPALTE6 + " = '" + op_neu.getChirurg2() + "'" +
                    " , " + OP_Daten.OP_DATEN_SPALTE7 + " = '" + op_neu.getSchwester1() + "'" +
                    " , " + OP_Daten.OP_DATEN_SPALTE8 + " = '" + op_neu.getSchwester2() + "'" +
                    " , " + OP_Daten.OP_DATEN_SPALTE9 + " = '" + op_neu.getPatienten_ID() + "'" +
                    " where " + OP_Daten.OP_DATEN_SPALTE1 + " = '" + op_alt.getDatum() + "'" +
                    " AND " + OP_Daten.OP_DATEN_SPALTE2 + " = '" + op_alt.getZeit() + "'" +
                    " AND " + OP_Daten.OP_DATEN_SPALTE3 + " = '" + op_alt.getRaumnummer() + "'";

                /*command.Parameters.AddWithValue("@" + OP_Daten.OP_DATEN_SPALTE1, op_neu.getDatum());
                command.Parameters.AddWithValue("@" + OP_Daten.OP_DATEN_SPALTE2, op_neu.getZeit());
                command.Parameters.AddWithValue("@" + OP_Daten.OP_DATEN_SPALTE3, op_neu.getRaumnummer());
                command.Parameters.AddWithValue("@" + OP_Daten.OP_DATEN_SPALTE4, op_neu.getNarkose_Arzt());
                command.Parameters.AddWithValue("@" + OP_Daten.OP_DATEN_SPALTE5, op_neu.getChirurg1());
                command.Parameters.AddWithValue("@" + OP_Daten.OP_DATEN_SPALTE6, op_neu.getChirurg2());
                command.Parameters.AddWithValue("@" + OP_Daten.OP_DATEN_SPALTE7, op_neu.getSchwester1());
                command.Parameters.AddWithValue("@" + OP_Daten.OP_DATEN_SPALTE8, op_neu.getSchwester2());
                command.Parameters.AddWithValue("@" + OP_Daten.OP_DATEN_SPALTE9, op_neu.getPatienten_ID());
                */
                try
                {
                    int recordsAffected = command.ExecuteNonQuery();
                }
                catch (SqlException sqle)
                {
                    MessageBox.Show(sqle.Message, "Fehlermeldung");
                    //throw new Exception(sqle.Message, sqle);
                }
            }
        }

        public DataRow getOp_Data(OP_Daten op)
        {
            if (con != null)
            {
                string strSQL = "Select * from OP_Daten where Datum = " + "'" + op.getDatum() + "'" + " AND " + OP_Daten.OP_DATEN_SPALTE2 + " = " + "'" + op.getZeit() + "'" + " AND " + OP_Daten.OP_DATEN_SPALTE3 + " = " + "'" + op.getRaumnummer() + "'";
                SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
                DataTable dt = new DataTable();
                if (da.Fill(dt) == 1)
                {

                    DataRow dr = dt.Rows[0];
                    return dr;

                }
            }
            return null;



        }

        public void deleteOP_Daten(OP_Daten op)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = "delete " + OP_Daten.TABELLEN_NAME +
                    " where " + OP_Daten.OP_DATEN_SPALTE1 + " = " + "'" + op.getDatum() + "'" + " AND " + OP_Daten.OP_DATEN_SPALTE2 + " = " + "'" + op.getZeit() + "'" +
                    " AND " + OP_Daten.OP_DATEN_SPALTE3 + " = " + "'" + op.getRaumnummer() + "'";

                try
                {
                    int recordsAffected = command.ExecuteNonQuery();
                }
                catch (SqlException sqle)
                {
                    MessageBox.Show(sqle.Message, "Fehlermeldung");
                    //throw new Exception(sqle.Message, sqle);
                }

            }



        }

        public void updatePersonaldaten(Personaldaten pd)
        {

            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = "update " + Personaldaten.TABELLEN_NAME +
                    " SET " + Personaldaten.PERSONAL_SPALTE2 + " = @" + Personaldaten.PERSONAL_SPALTE2 +
                    " , " + Personaldaten.PERSONAL_SPALTE3 + " = @" + Personaldaten.PERSONAL_SPALTE3 +
                    " , " + Personaldaten.PERSONAL_SPALTE4 + " = @" + Personaldaten.PERSONAL_SPALTE4 +
                    " , " + Personaldaten.PERSONAL_SPALTE5 + " = @" + Personaldaten.PERSONAL_SPALTE5 +
                    " where " + Personaldaten.PERSONAL_SPALTE1 + " = @" + Personaldaten.PERSONAL_SPALTE1;

                command.Parameters.AddWithValue("@" + Personaldaten.PERSONAL_SPALTE1, pd.getID());
                command.Parameters.AddWithValue("@" + Personaldaten.PERSONAL_SPALTE2, pd.getName());
                command.Parameters.AddWithValue("@" + Personaldaten.PERSONAL_SPALTE3, pd.getVorname());
                command.Parameters.AddWithValue("@" + Personaldaten.PERSONAL_SPALTE4, pd.getFunktion());
                command.Parameters.AddWithValue("@" + Personaldaten.PERSONAL_SPALTE5, pd.getArbeitszeit());

                try
                {
                    int recordsAffected = command.ExecuteNonQuery();
                }
                catch (SqlException sqle)
                {
                    MessageBox.Show(sqle.Message, "Fehlermeldung");
                    //throw new Exception(sqle.Message, sqle);
                }
            }
        }

        public void deletePersonaldaten(Personaldaten pd)
        {

            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = "delete " + Personaldaten.TABELLEN_NAME +
                    " where " + Personaldaten.PERSONAL_SPALTE1 + " = @" + Personaldaten.PERSONAL_SPALTE1;

                command.Parameters.AddWithValue("@" + Personaldaten.PERSONAL_SPALTE1, pd.getID());

                try
                {
                    int recordsAffected = command.ExecuteNonQuery();
                }
                catch (SqlException sqle)
                {
                    MessageBox.Show(sqle.Message, "Fehlermeldung");
                    //throw new Exception(sqle.Message, sqle);
                }
            }
        }

        public void close()
        {
            con.Close();
        }

        public DataTable getChirurgs()
        {
            if (con != null)
            {
                string strSQL = "Select * from " + Personaldaten.TABELLEN_NAME + " where " + Personaldaten.PERSONAL_SPALTE4 + " = '" + Personaldaten.PERSONAL_FUNKTION_CHIRURG + "'";
                SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            return null;
        }

        public int getChirurgsByName(string name, string vname)
        {
            if (con != null)
            {
                string strSQL = "Select " + Personaldaten.PERSONAL_SPALTE1 + " from " + Personaldaten.TABELLEN_NAME + " where " + Personaldaten.PERSONAL_SPALTE4 + " = '" + Personaldaten.PERSONAL_FUNKTION_CHIRURG + "' AND " + Personaldaten.PERSONAL_SPALTE2 + " = '" + name + "' AND " + Personaldaten.PERSONAL_SPALTE3 + " = '" + vname + "'";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string s = dr["Personal_ID"].ToString();
                    return Convert.ToInt32(s);
                }

            }
            return -1;
        }

        public DataTable getAnaes()
        {
            if (con != null)
            {
                string strSQL = "Select * from " + Personaldaten.TABELLEN_NAME + " where " + Personaldaten.PERSONAL_SPALTE4 + " = '" + Personaldaten.PERSONAL_FUNKTION_ANAESTHESIST + "'";
                SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            return null;
        }

        public int getAnaesByName(string name, string vname)
        {
            if (con != null)
            {
                string strSQL = "Select " + Personaldaten.PERSONAL_SPALTE1 + " from " + Personaldaten.TABELLEN_NAME + " where " + Personaldaten.PERSONAL_SPALTE4 + " = '" + Personaldaten.PERSONAL_FUNKTION_ANAESTHESIST + "' AND " + Personaldaten.PERSONAL_SPALTE2 + " = '" + name + "' AND " + Personaldaten.PERSONAL_SPALTE3 + " = '" + vname + "'";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string s = dr["Personal_ID"].ToString();
                    return Convert.ToInt32(s);
                }

            }
            return -1;
        }

        public DataTable getKrankens()
        {
            if (con != null)
            {
                string strSQL = "Select * from " + Personaldaten.TABELLEN_NAME + " where " + Personaldaten.PERSONAL_SPALTE4 + " = '" + Personaldaten.PERSONAL_FUNKTION_KRANKENSCHWESTER + "'";
                SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            return null;
        }

        public int getKrankensByName(string name, string vname)
        {
            if (con != null)
            {
                string strSQL = "Select " + Personaldaten.PERSONAL_SPALTE1 + " from " + Personaldaten.TABELLEN_NAME + " where " + Personaldaten.PERSONAL_SPALTE4 + " = '" + Personaldaten.PERSONAL_FUNKTION_KRANKENSCHWESTER + "' AND " + Personaldaten.PERSONAL_SPALTE2 + " = '" + name + "' AND " + Personaldaten.PERSONAL_SPALTE3 + " = '" + vname + "'";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string s = dr["Personal_ID"].ToString();
                    return Convert.ToInt32(s);
                }

            }
            return -1;
        }
        internal DataTable getPatient()
        {
            if (con != null)
            {
                string strSQL = "Select * from " + Patientendaten.TABELLEN_NAME + "";
                SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            return null;
        }

        public DataTable getPatientByName(string name, string vname)
        {
            if (con != null)
            {
                string strSQL = "Select * from " + Patientendaten.TABELLEN_NAME + " where " + Patientendaten.PATIENTEN_SPALTE2 + " = '" + name + "' AND " + Patientendaten.PATIENTEN_SPALTE3 + " = '" + vname + "'";
                SqlDataAdapter da = new SqlDataAdapter(strSQL, con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            return null;
        }

        public string getOPArtById(int id)
        {
            if (con != null)
            {
                string strSQL = "Select " + OP_Kategorien.KATEGORIE_SPALTE2 + " from " + OP_Kategorien.TABELLEN_NAME + " where " + OP_Kategorien.KATEGORIE_SPALTE1 + " = '" + id + "'";

                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string s = dr["OP_Art"].ToString();
                    return s;
                }
            }
            return null;
        }

        internal void instertOPDaten(OP_Daten opd)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT into " + OP_Daten.TABELLEN_NAME + " (" + OP_Daten.OP_DATEN_SPALTE1 + ", " + OP_Daten.OP_DATEN_SPALTE2 + ", " + OP_Daten.OP_DATEN_SPALTE3 + ", " + OP_Daten.OP_DATEN_SPALTE4 + ", " + OP_Daten.OP_DATEN_SPALTE5 + ", " + OP_Daten.OP_DATEN_SPALTE6 + ", " + OP_Daten.OP_DATEN_SPALTE7 + ", " + OP_Daten.OP_DATEN_SPALTE8 + ", " + OP_Daten.OP_DATEN_SPALTE9 + ") VALUES (@" + OP_Daten.OP_DATEN_SPALTE1 + ", @" + OP_Daten.OP_DATEN_SPALTE2 + ", @" + OP_Daten.OP_DATEN_SPALTE3 + ", @" + OP_Daten.OP_DATEN_SPALTE4 + ", @" + OP_Daten.OP_DATEN_SPALTE5 + ", @" + OP_Daten.OP_DATEN_SPALTE6 + ", @" + OP_Daten.OP_DATEN_SPALTE7 + ", @" + OP_Daten.OP_DATEN_SPALTE8 + ", @" + OP_Daten.OP_DATEN_SPALTE9 + ")";
                command.Parameters.AddWithValue("@" + OP_Daten.OP_DATEN_SPALTE1, opd.getDatum());
                command.Parameters.AddWithValue("@" + OP_Daten.OP_DATEN_SPALTE2, opd.getZeit());
                command.Parameters.AddWithValue("@" + OP_Daten.OP_DATEN_SPALTE3, opd.getRaumnummer());
                command.Parameters.AddWithValue("@" + OP_Daten.OP_DATEN_SPALTE4, opd.getNarkose_Arzt());
                command.Parameters.AddWithValue("@" + OP_Daten.OP_DATEN_SPALTE5, opd.getChirurg1());
                command.Parameters.AddWithValue("@" + OP_Daten.OP_DATEN_SPALTE6, opd.getChirurg2());
                command.Parameters.AddWithValue("@" + OP_Daten.OP_DATEN_SPALTE7, opd.getSchwester1());
                command.Parameters.AddWithValue("@" + OP_Daten.OP_DATEN_SPALTE8, opd.getSchwester2());
                command.Parameters.AddWithValue("@" + OP_Daten.OP_DATEN_SPALTE9, opd.getPatienten_ID());

                Debug.Print(command.CommandText);
                try
                {
                    int recordsAffected = command.ExecuteNonQuery();
                }
                catch (SqlException sqle)
                {
                    MessageBox.Show(sqle.Message, "Fehlermeldung");
                    //throw new Exception(sqle.Message, sqle);
                }
            }
        }

        public DataTable getOPById(int id)
        {
            if (con != null)
            {
                string strSQL = "Select * from " + OP_Kategorien.TABELLEN_NAME + " where " + OP_Kategorien.KATEGORIE_SPALTE1 + " = '" + id + "'";
                SqlDataAdapter da = new SqlDataAdapter(strSQL, con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            return null;
        }

        internal DataTable getPatientById(int p_id)
        {
            if (con != null)
            {
                string strSQL = "Select * from " + Patientendaten.TABELLEN_NAME + " WHERE " + Patientendaten.PATIENTEN_SPALTE1 + " = '" + p_id + "'";
                SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            return null;
        }

        public string get_OP_ID(string pat_id)
        {
            if (con != null)
            {
                string strSQL = "Select OP_ID from " + Patientendaten.TABELLEN_NAME + " where " + Patientendaten.PATIENTEN_SPALTE1 + " = " + "'" + pat_id + "'";
                SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
                DataTable dt = new DataTable();
                if (da.Fill(dt) == 1)
                {

                    DataRow dr = dt.Rows[0];
                    string temp = dr["OP_ID"].ToString();
                    return temp;

                }
            }
            return null;
        }
        public DataTable getAll_OP_Art()
        {
            if (con != null)
            {
                string strSQL = "Select * from " + OP_Kategorien.TABELLEN_NAME;
                SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            return null;

        }

        public string get_OP_Art(string op_id)
        {
            if (con != null)
            {
                string strSQL = "Select OP_Art from " + OP_Kategorien.TABELLEN_NAME + " where " + OP_Kategorien.KATEGORIE_SPALTE1 + " = " + "'" + op_id + "'";
                SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
                DataTable dt = new DataTable();
                if (da.Fill(dt) == 1)
                {
                    DataRow dr = dt.Rows[0];
                    string temp = dr["OP_Art"].ToString();

                    return temp;

                }
            }
            return null;
        }

        public string get_OP_Dauer(string op_id)
        {
            if (con != null)
            {
                string strSQL = "Select OP_Dauer from " + OP_Kategorien.TABELLEN_NAME + " where " + OP_Kategorien.KATEGORIE_SPALTE1 + " = " + "'" + op_id + "'";
                SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
                DataTable dt = new DataTable();
                if (da.Fill(dt) == 1)
                {
                    DataRow dr = dt.Rows[0];
                    string temp = dr["OP_Dauer"].ToString();

                    return temp;

                }
            }
            return null;
        }

        public DataTable getAll_OpData(string sDate)
        {
            if (con != null)
            {
                string strSQL = "Select * from OP_Daten where Datum = " + "'" + sDate + "'";
                SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            return null;
        }

        internal int[] getLastTimeByRaumnr(int raum_id, string dTime)
        {
            if (con != null)
            {
                int[] arr = new int[2];
                //ops abfragen an einem bestimmten tag und bestimmten raum
                string strSQL = "Select * from " + OP_Daten.TABELLEN_NAME + " where " + OP_Daten.OP_DATEN_SPALTE3 + " = '" + raum_id + "' AND " + OP_Daten.OP_DATEN_SPALTE1 + " = '" + dTime + "'";
                SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt != null)
                {
                    if (dt.Rows.Count != 0)
                    {
                        //letzter gespeicherter eintrag und dessen zeit
                        DataRow dr = dt.Rows[dt.Rows.Count - 1];

                        //Minuten und stunden erhalten
                        string time = dr["Zeit"].ToString();
                        string[] split = time.Split(new Char[] { ':' });
                        int stunden = Convert.ToInt32(split[0]);
                        int minuten = Convert.ToInt32(split[2]);

                        //Patientendaten 
                        dt = getPatientById((Convert.ToInt32(dr["Patienten_ID"].ToString())));

                        if (dt != null)
                        {
                            dr = dt.Rows[0];
                            //abfrage nach op daten für die dauer
                            int op_id = Convert.ToInt32(dr["OP_ID"].ToString());
                            dt = getOPById(op_id);
                            dr = dt.Rows[0];
                            int op_dauer = Convert.ToInt32(dr["OP_Dauer"].ToString());

                            arr[0] = stunden + op_dauer;
                            //+30 für reinigungszeit
                            if (minuten == 30)
                            {
                                arr[1] = 00;
                            }
                            else
                            {
                                arr[1] = 30;
                            }

                            return arr;

                        }
                    }
                    else
                    {
                        arr[0] = 7;
                        arr[1] = 0;
                        return arr;
                    }
                }

            }
            return null;
        }

        public bool checkArbeitszeit(int ID, DateTime week)
        {

            DateTime Monday;
            DateTime Sunday;

            double sumArbeitszeit = 0;


            if (con != null)
            {

                if (week == null)
                {
                    Monday = GetFirstDayOfWeek(DateTime.Now);
                    Sunday = GetLastDayOfWeek(DateTime.Now);
                }
                else
                {
                    Monday = GetFirstDayOfWeek(week);
                    Sunday = GetLastDayOfWeek(week);
                }

                string strSQL =

                "Select OP_Dauer from OP_Daten" +
                " left join Patientendaten on op_daten.Patienten_ID = Patientendaten.Patienten_ID" +
                " left join OP_Kategorien on Patientendaten.OP_ID = OP_Kategorien.OP_ID" +
                " where (Narkose_Arzt = '" + ID + "' or Chirurg1 = '" + ID + "' or Chirurg2 = '" + ID + "' or Schwester1 = '" + ID + "' or Schwester2 = '" + ID + "')" +
                " and (Datum <= '" + Sunday.ToString("dd-MM-yyyy") + "' or Datum >= '" + Monday.ToString("dd-MM-yyyy") + "')";

                SqlDataAdapter da = new SqlDataAdapter(strSQL, con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt != null)
                {
                    if (dt.Rows.Count != 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            DataRow dr;
                            dr = dt.Rows[i];
                            sumArbeitszeit = sumArbeitszeit + Convert.ToDouble(dr[0]);
                        }


                        Personaldaten myPers = getPersonalById(ID);

                        //  Arbeitszeit größer als 
                        if (sumArbeitszeit > myPers.getArbeitszeit())
                        {
                            // länger gearbeitet
                            return false;

                        }
                        else
                        {
                            //kürzer gearbeitet
                            return true;

                        }

                    }
                }
            }

            return true;
        }

        public static DateTime GetFirstDayOfWeek(DateTime dateTime)
        {
            while (dateTime.DayOfWeek != DayOfWeek.Monday)
                dateTime = dateTime.Subtract(new TimeSpan(1, 0, 0, 0));
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
        }

        public static DateTime GetLastDayOfWeek(DateTime dateTime)
        {
            while (dateTime.DayOfWeek != DayOfWeek.Sunday)
                dateTime = dateTime.AddDays(1);
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
        }

    }
}
