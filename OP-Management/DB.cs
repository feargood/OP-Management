﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        internal DataTable getPatient()
        {
            if (con != null)
            {
                string strSQL = "Select * from " + Patientendaten.TABELLEN_NAME +"";
                SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            return null;
        }
        internal void instertOPDaten(OP_Daten opd)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = con;
                command.CommandType = CommandType.Text;
                //command.CommandText = "INSERT into " + Personaldaten.TABELLEN_NAME + " (" + Personaldaten.PERSONAL_SPALTE2 + ", " + Personaldaten.PERSONAL_SPALTE3 + ", " + Personaldaten.PERSONAL_SPALTE4 + ", " + Personaldaten.PERSONAL_SPALTE5 + ") VALUES (@" + Personaldaten.PERSONAL_SPALTE2 + ", @" + Personaldaten.PERSONAL_SPALTE3 + ", @" + Personaldaten.PERSONAL_SPALTE4 + ", @" + Personaldaten.PERSONAL_SPALTE5 + ")";
                //command.Parameters.AddWithValue("@" + Personaldaten.PERSONAL_SPALTE2, opd.getName());
                //command.Parameters.AddWithValue("@" + Personaldaten.PERSONAL_SPALTE3, opd.getVorname());
                //command.Parameters.AddWithValue("@" + Personaldaten.PERSONAL_SPALTE4, opd.getFunktion());
                //command.Parameters.AddWithValue("@" + Personaldaten.PERSONAL_SPALTE5, opd.getArbeitszeit());

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

        
    }
}
