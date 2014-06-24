using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OP_Management
{
    public partial class OPBearbeiten : Form
    {
        private DB db = new DB();
        private OP_Daten op_data = null;
        private OP_Daten op_data_alt = null;
        string pat_id;
        string op_id;
        string op_art;
        int op_dauer;
        string sDate;
        bool bNotEmpty = true;

        string stunden;
        string Minuten;
        string chirurg1;
        string chirurg2;
        string krankens1;
        string krankens2;
        string anest;
        string patient;
        string sOp_art;
        //string raum;

        DataTable chirurg;
        DataTable krankens;
        DataTable dPatient;
        DataTable anaest;
        DataTable dOp_art;


        public OPBearbeiten()
        {

        }
        // Init:
        public OPBearbeiten(DataRow dr)
        {
            InitializeComponent();
            this.op_data_alt = new OP_Daten(dr);
            op_data = op_data_alt.clone();
            this.pat_id = op_data.getPatienten_ID().ToString();
            this.op_id = db.get_OP_ID(pat_id);
            this.op_art = db.get_OP_Art(op_id);
            OPBearbeiten_Load();


        }

        private void OPBearbeiten_Load()
        {


            chirurg = db.getChirurgs();
            if (chirurg != null)
            {
                for (int i = 0; i < chirurg.Rows.Count; i++)
                {

                    // Die Arbeitszeit der Chirurgen prüfen

                 


                    DataRow dr = chirurg.Rows[i];

                    DateTime d = DateTime.Now;


                    if (db.checkArbeitszeit(Convert.ToInt32(dr["Personal_ID"]),d)) { 


                    string cur = dr["Vorname"].ToString() + " " + dr["Name"].ToString();
                    ListeChirurg.Items.Add(cur);
                    ListeChirurg2.Items.Add(cur);
                    if (dr[0].Equals(op_data.getChirurg1()))
                    {
                        ListeChirurg.Text = cur;
                    }
                    else if (dr[0].Equals(op_data.getChirurg2()))
                    {
                        ListeChirurg2.Text = cur;
                    }
                }
                }
            }

            anaest = db.getAnaes();
            if (anaest != null)
            {
                for (int i = 0; i < anaest.Rows.Count; i++)
                {
                    DataRow dr = anaest.Rows[i];

                    DateTime d = DateTime.Now;


                    if (db.checkArbeitszeit(Convert.ToInt32(dr["Personal_ID"]), d))
                    {

                        string cur = dr["Vorname"].ToString() + " " + dr["Name"].ToString();
                        ListeAnaes.Items.Add(cur);
                        if (dr[0].Equals(op_data.getNarkose_Arzt()))
                        {
                            ListeAnaes.Text = cur;
                        }
                    }
                }
            }

            krankens = db.getKrankens();
            if (krankens != null)
            {
                for (int i = 0; i < krankens.Rows.Count; i++)
                {
                    DataRow dr = krankens.Rows[i];

                    DateTime d = DateTime.Now;


                    if (db.checkArbeitszeit(Convert.ToInt32(dr["Personal_ID"]), d))
                    {

                        string cur = dr["Vorname"].ToString() + " " + dr["Name"].ToString();
                        ListeKrankens.Items.Add(cur);
                        ListeKrankens2.Items.Add(cur);
                        if (dr[0].Equals(op_data.getSchwester1()))
                        {
                            ListeKrankens.Text = cur;
                        }
                        else if (dr[0].Equals(op_data.getSchwester2()))
                        {
                            ListeKrankens2.Text = cur;
                        }

                    }
                }
            }

            dPatient = db.getPatient();
            if (dPatient != null)
            {
                for (int i = 0; i < dPatient.Rows.Count; i++)
                {
                    DataRow dr = dPatient.Rows[i];
                    string cur = dr["Vorname"].ToString() + " " + dr["Name"].ToString();
                    ListePatient.Items.Add(cur);
                    if (dr[0].Equals(op_data.getPatienten_ID()))
                    {
                        ListePatient.Text = cur;
                    }

                }
            }
            string[] temp = op_data.getZeit().Split(new Char[] { ':' });
            cbStunden.Text = temp[0];
            cbMinuten.Text = temp[1];
            Raum_Combo.Text = op_data.getRaumnummer().ToString();
            dateTimePicker1.Text = op_data.getDatum();
        }


        // Die ganzen Checks..:

        // Checke ob das Feld Patient Ok ist
        private bool checkPatient()
        {

            if (dPatient != null)
            {
                for (int i = 0; i < dPatient.Rows.Count; i++)
                {
                    DataRow dr = dPatient.Rows[i];
                    string cur = dr["Vorname"].ToString() + " " + dr["Name"].ToString();

                    // wenn die Felder OK sind, dann setze die IDs in der OP_Data Klasse
                    if (ListePatient.Text.Equals(cur) == true && op_data.getPatienten_ID() != Convert.ToInt32(dr[0]))
                    {
                        op_data.setPatienten_ID(Convert.ToInt32(dr[0]));
                    }

                }
                return true;
            }
            else
                return false;


        }

        // Checke ob das Feld Anaes Ok ist
        private bool checkAnaes()
        {


            if (anaest != null)
            {
                for (int i = 0; i < anaest.Rows.Count; i++)
                {
                    DataRow dr = anaest.Rows[i];
                    string cur = dr["Vorname"].ToString() + " " + dr["Name"].ToString();

                    // wenn die Felder OK sind, dann setze die IDs in der OP_Data Klasse
                    if (ListeAnaes.Text.Equals(cur) == true && op_data.getNarkose_Arzt() != Convert.ToInt32(dr[0]))
                    {
                        op_data.setNarkose_Arzt(Convert.ToInt32(dr[0]));
                    }

                }
                return true;
            }
            else
                return false;


        }

        // Checke ob die Felder der Krankenschwestern ok sind

        private bool checkKrankens()
        {

            if (ListeKrankens.Text == ListeKrankens2.Text)
            {
                MessageBox.Show("Sie haben zweimal die selbe Krankenschwester ausgewählt", "Achtung");
                return false;
            }

            else
            {
                if (krankens != null)
                {
                    for (int i = 0; i < krankens.Rows.Count; i++)
                    {
                        DataRow dr = krankens.Rows[i];
                        string cur = dr["Vorname"].ToString() + " " + dr["Name"].ToString();

                        // wenn die Felder OK sind, dann setze die IDs in der OP_Data Klasse
                        if (ListeKrankens.Text.Equals(cur) == true && op_data.getSchwester1() != Convert.ToInt32(dr[0]))
                        {
                            op_data.setSchwester1(Convert.ToInt32(dr[0]));
                        }
                        else if (ListeKrankens2.Text.Equals(cur) == true && op_data.getSchwester2() != Convert.ToInt32(dr[0]))
                        {
                            op_data.setSchwester2(Convert.ToInt32(dr[0]));
                        }
                    }
                }
                return true;
            }

        }

        // Checke ob die Chirurgen Felder OK sind
        private bool checkChirurg()
        {

            if (ListeChirurg.Text == ListeChirurg2.Text)
            {
                MessageBox.Show("Sie haben zweimal den selben Chirurgen ausgewählt", "Achtung");
                return false;
            }

            else
            {
                if (chirurg != null)
                {
                    for (int i = 0; i < chirurg.Rows.Count; i++)
                    {
                        DataRow dr = chirurg.Rows[i];
                        string cur = dr["Vorname"].ToString() + " " + dr["Name"].ToString();

                        // wenn die Felder OK sind, dann setze die IDs in der OP_Data Klasse
                        if (ListeChirurg.Text.Equals(cur) == true && op_data.getChirurg1() != Convert.ToInt32(dr[0]))
                        {
                            op_data.setChirurg1(Convert.ToInt32(dr[0]));
                        }
                        else if (ListeChirurg2.Text.Equals(cur) == true && op_data.getChirurg2() != Convert.ToInt32(dr[0]))
                        {
                            op_data.setChirurg2(Convert.ToInt32(dr[0]));
                        }
                    }
                }
                return true;
            }

        }

        private bool CheckRaum()
        {
            if (Raum_Combo.Text.Equals("1") == false && op_id.Equals("2"))
            {
                MessageBox.Show("Die Herz-OP kann nur in Raum 1 durchgeführt werden", "Achtung");
                return false;

            }
            else
            {
                if (Raum_Combo.Text.Equals(op_data.getRaumnummer().ToString()) == false)
                {
                    op_data.setRaumnummer(Convert.ToInt32(Raum_Combo.Text));

                }
                return true;

            }
        }

        private bool CheckZeit()
        {

            stunden = cbStunden.Text;
            Minuten = cbMinuten.Text;
            op_data.setZeit(stunden + ":" + Minuten + ":00");
            return true;

        }

        private bool CheckDatumZeit()
        {


            DateTime aktuell = System.DateTime.Now;
            aktuell = aktuell.Date + new TimeSpan(aktuell.Hour + 1, aktuell.Minute, aktuell.Second);
            DateTime geplant = dateTimePicker1.Value;
            geplant = geplant.Date + new TimeSpan(Convert.ToInt32(stunden), Convert.ToInt32(Minuten), 00);

            if ((DateTime.Compare(geplant, aktuell) <= 0))
            {
                MessageBox.Show("Der geplante Zeitpunkt muss mindestens 1 Stunde in der Zukunft liegen ", "Achtung");
                return false;
            }
            return true;

        }

        private bool CheckPlanung()
        {

            DataTable dt = db.getAll_OpData(sDate);
            // Variablen um herauszufinden ob von beginn bis ende der geplanten OP bereits andere angelegt sind
            int op_beginn = Convert.ToInt32(stunden);
            int geplZeit = op_beginn + op_dauer;
            int DB_Uhrzeit = 0;
            bool verpl = true;
            bool arzt = true;
            bool schwester = true;
            bool narkosee = true;

            // Variablen um herauszufinden ob eine OP davor inkl. der Dauer den Zeitraum sperrt
            int DB_patienten_id;
            int DB_op_id = 0;
            int DB_OPDauer = 0;
            int DB_OPEnde;

            if (geplZeit <= 19)
            {

                if (dt != null)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = dt.Rows[i];

                        if (dr[0].ToString().Remove(10, 9).Equals(op_data.getDatum()) && dr[2].Equals(op_data.getRaumnummer()))
                        {
                            if (dr[1].ToString().Equals(op_data_alt.getZeit()) == false)
                            {
                                string temp = dr[1].ToString().Substring(0, 2);
                                DB_Uhrzeit = Convert.ToInt32(temp);

                                // Innerhalb des Zeitraums

                                if (DB_Uhrzeit >= op_beginn && DB_Uhrzeit <= geplZeit)
                                {
                                    verpl = false;
                                    break;
                                }

                                // Davor

                                if (DB_Uhrzeit < op_beginn)
                                {
                                    DB_patienten_id = Convert.ToInt32(dr[8]);
                                    for (int j = 0; j < dPatient.Rows.Count; j++)
                                    {
                                        DataRow DrP = dPatient.Rows[j];
                                        if (DrP[0].Equals(DB_patienten_id))
                                        {
                                            DB_op_id = Convert.ToInt32(DrP[3]);
                                            break;
                                        }

                                    }

                                    for (int h = 0; h < dOp_art.Rows.Count; h++)
                                    {
                                        DataRow DrOP_Kat = dOp_art.Rows[h];
                                        if (DrOP_Kat[0].Equals(DB_op_id))
                                        {
                                            DB_OPDauer = Convert.ToInt32(DrOP_Kat[2]);
                                            break;
                                        }
                                    }

                                    DB_OPEnde = DB_Uhrzeit + DB_OPDauer;

                                    if (DB_OPEnde >= op_beginn)
                                    {
                                        verpl = false;
                                        break;
                                    }
                                }
                            }

                        }

                        // Prüfe ob die Mitarbeiter in dem Zeitraum woanders arbeiten
                        if (dr[0].ToString().Remove(10, 9).Equals(op_data.getDatum()) &&
                           (dr[3].Equals(op_data.getNarkose_Arzt()) || dr[4].Equals(op_data.getChirurg1()) || dr[5].Equals(op_data.getChirurg2()) || dr[6].Equals(op_data.getSchwester1()) || dr[7].Equals(op_data.getSchwester2())))
                        {
                            if (dr[1].ToString().Equals(op_data_alt.getZeit()) == false)
                            {
                                // Innerhalb des Zeitraums
                                string temp = dr[1].ToString().Substring(0, 2);
                                DB_Uhrzeit = Convert.ToInt32(temp);

                                if (DB_Uhrzeit >= op_beginn && DB_Uhrzeit <= geplZeit)
                                {
                                    if (dr[3].Equals(op_data.getNarkose_Arzt()))
                                        narkosee = false;
                                    else if (dr[4].Equals(op_data.getChirurg1()))
                                        arzt = false;
                                    else if (dr[5].Equals(op_data.getChirurg2()))
                                        arzt = false;
                                    else if (dr[6].Equals(op_data.getSchwester1()))
                                        schwester = false;
                                    else if (dr[7].Equals(op_data.getSchwester2()))
                                        schwester = false;
                                    break;
                                }

                                // Davor

                                if (DB_Uhrzeit < op_beginn)
                                {
                                    DB_patienten_id = Convert.ToInt32(dr[8]);
                                    for (int j = 0; j < dPatient.Rows.Count; j++)
                                    {
                                        DataRow DrP = dPatient.Rows[j];
                                        if (DrP[0].Equals(DB_patienten_id))
                                        {
                                            DB_op_id = Convert.ToInt32(DrP[3]);
                                            break;
                                        }

                                    }

                                    for (int h = 0; h < dOp_art.Rows.Count; h++)
                                    {
                                        DataRow DrOP_Kat = dOp_art.Rows[h];
                                        if (DrOP_Kat[0].Equals(DB_op_id))
                                        {
                                            DB_OPDauer = Convert.ToInt32(DrOP_Kat[2]);
                                            break;
                                        }
                                    }

                                    DB_OPEnde = DB_Uhrzeit + DB_OPDauer;

                                    if (DB_OPEnde >= op_beginn)
                                    {
                                        if (dr[3].Equals(op_data.getNarkose_Arzt()))
                                            narkosee = false;
                                        else if (dr[4].Equals(op_data.getChirurg1()))
                                            arzt = false;
                                        else if (dr[5].Equals(op_data.getChirurg2()))
                                            arzt = false;
                                        else if (dr[6].Equals(op_data.getSchwester1()))
                                            schwester = false;
                                        else if (dr[7].Equals(op_data.getSchwester2()))
                                            schwester = false;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    if (narkosee == false)
                    {
                        MessageBox.Show("In dem Zeitraum ist der Narkose-Arzt beschäftigt", "Achtung");
                        return narkosee;
                    }
                    else if (arzt == false)
                    {
                        MessageBox.Show("In dem Zeitraum ist einer der Ärzte beschäftigt", "Achtung");
                        return arzt;
                    }
                    else if (schwester == false)
                    {
                        MessageBox.Show("In dem Zeitraum ist einer der Schwerstern beschäftigt", "Achtung");
                        return schwester;
                    }

                    if (verpl == false)
                    {
                        MessageBox.Show("In dem Zeitraum ist der Raum belegt", "Achtung");
                        return verpl;
                    }
                }
                else
                {
                    MessageBox.Show("Datenbank Verbindung verloren", "Achtung");
                    return false;
                }
                return verpl;
            }
            else
            {
                MessageBox.Show("Planung überschreitet späteste Uhrzeit", "Achtung");
                return false;
            }
        }


        // TODO: private bool checkArbeitszeit() { return true; }



        // Buttons:

        private void button_verwerf_Click_1(object sender, EventArgs e)
        {
            db.close();
            this.Close();
        }


        private void button_Anlegen_Click(object sender, EventArgs e)
        {

            if (checkChirurg() == false)
                return;
            else if (checkKrankens() == false)
                return;
            else if (checkPatient() == false)
                return;
            else if (checkAnaes() == false)
                return;
            else if (CheckRaum() == false)
                return;
            else if (CheckZeit() == false)
                return;
            else if (CheckDatumZeit() == false)
                return;
            else if (op_data_alt.equalz(op_data) == true)
            {
                MessageBox.Show("Sie haben nichts geändert! \nSie können über \"Verwerfen\" das Fenster schließen", "Achtung");
                return;
            }
            else if (CheckPlanung() == false)
                return;

            db.updateOP_Daten(op_data_alt, op_data);


            db.close();
            this.Close();
        }



        //EventHandler:

        // Wenn sich der Patient ändert passt sich die OP-Art an
        private void ListePatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            dOp_art = db.getAll_OP_Art();

            if (dOp_art != null)
            {   //Vergleiche den Patienten mit der Datenbank
                for (int i = 0; i < dPatient.Rows.Count; i++)
                {

                    DataRow drP = dPatient.Rows[i];

                    string patient = drP["Vorname"].ToString() + " " + drP["Name"].ToString();

                    // Wenn der Patient passt, passe die OP-Art an
                    if (ListePatient.Text.Equals(patient))
                    {
                        for (int j = 0; j < dOp_art.Rows.Count; j++)
                        {
                            DataRow dr = dOp_art.Rows[j];
                            string cur = dr["OP_Art"].ToString();

                            if (dr[0].ToString().Equals(drP["OP_ID"].ToString()))
                            {
                                op_dauer = Convert.ToInt32(dr[2]);
                                OP_Art_TextBox.Text = cur;
                                break;
                            }
                        }
                        break;
                    }

                }
            }

        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string temp = dateTimePicker1.Value.Date.ToString();
            // lösche die Zeitangabe die immer 00:00:00 ist
            sDate = temp.Remove(10, 9);
            op_data.setDatum(sDate);
        }

        

    }
}
