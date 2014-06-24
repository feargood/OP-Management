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
    public partial class OPeingabe : Form
    {
        int id_chirurg1;
        int id_chirurg2;
        int id_krankens1;
        int id_krankens2;
        int id_anaest;
        int id_patient;
        int id_op_p;
        int raum_nr;
        int p_set;
        string datum_op;
        string zeit_op;

        public OPeingabe()
        {
            InitializeComponent();
        }
        
        private void OPeingabe_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "projekt1DataSet.Patientendaten". Sie können sie bei Bedarf verschieben oder entfernen.
            this.patientendatenTableAdapter.Fill(this.projekt1DataSet.Patientendaten);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "projekt1DataSet.OP_Kategorien". Sie können sie bei Bedarf verschieben oder entfernen.
            this.oP_KategorienTableAdapter.Fill(this.projekt1DataSet.OP_Kategorien);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "projekt1DataSet.OP_Daten". Sie können sie bei Bedarf verschieben oder entfernen.
            this.oP_DatenTableAdapter.Fill(this.projekt1DataSet.OP_Daten);

            DB db = new DB();
            DataTable dt = db.getChirurgs();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    string cur = dr["Vorname"].ToString() + " " + dr["Name"].ToString();
                    ListeChirurg.Items.Add(cur);
                    ListeChirurg2.Items.Add(cur);
                }
            }

            dt = db.getAnaes();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    string cur = dr["Vorname"].ToString() + " " + dr["Name"].ToString();
                    ListeAnaes.Items.Add(cur);
                }
            }

            dt = db.getKrankens();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    string cur = dr["Vorname"].ToString() + " " + dr["Name"].ToString();
                    ListeKrankens.Items.Add(cur);
                    ListeKrankens2.Items.Add(cur);
                }
            }

            dt = db.getPatient();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    string cur = dr["Vorname"].ToString() + " " + dr["Name"].ToString();
                    ListePatient.Items.Add(cur);
                }
            }

            db.close();
        }
              
        private void Patient_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DB Abfrage für ID            
            string name, vname;
            string cur_ks = ListePatient.Text;
            if (cur_ks != "")
            {
                string[] split = cur_ks.Split(new Char[] { ' ' });
                DB db = new DB();

                if (split.Length > 0)
                {
                    vname = split[0];
                    name = split[split.Length - 1];

                    DataTable dt = db.getPatientByName(name, vname);

                    if (dt != null)
                    {
                        DataRow dr = dt.Rows[0];

                        id_patient = Convert.ToInt32(dr["Patienten_ID"].ToString());
                        id_op_p = Convert.ToInt32(dr["OP_ID"].ToString());

                        string op_art = db.getOPArtById(id_op_p);
                        lbOpArt.Text = op_art;
                    }

                }
                db.close();
                p_set = 1;
            }
            else
            {
                DialogResult result = MessageBox.Show("Es wurde kein Patient ausgewählt!",
               "Fehlermeldung",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error,
               MessageBoxDefaultButton.Button1);
                p_set = 0;
            }
        }

        private void button_Anlegen_Click(object sender, EventArgs e)
        {
            OP_Daten opd = new OP_Daten();
            DB db = new DB();

            if (checkAnaes() == false)
            {
                return;
            }else if (p_set == 0)
            {
                return;
            }else if (checkChirurg() == false)
            {
                return;
            }else if (checkKrankens() == false)
            {
                return;
            }else if(checkDate())
            {

                if (setOpRaum())
                {
                    opd.setNarkose_Arzt(id_anaest);
                    opd.setPatienten_ID(id_patient);
                    opd.setChirurg1(id_chirurg1);
                    opd.setChirurg2(id_chirurg2);
                    opd.setSchwester1(id_krankens1);
                    opd.setSchwester2(id_krankens2);
                    Debug.Print(""+raum_nr);
                    opd.setRaumnummer(raum_nr);
                    opd.setDatum(datum_op);
                    opd.setZeit(zeit_op);
                }
                else { return; }
            }
            else
            {
                return;
            }

            db.instertOPDaten(opd);
            db.close();
            this.Close();

        }

        private bool setOpRaum()
        {
            DB db = new DB();
            string date = Convert.ToString(dateTimePicker1.Value);
            date = date.Remove(10, 9);

            //falls eine Herz-op
            if (id_op_p == 2)
            {
                int[] time = db.getLastTimeByRaumnr(1, date);

                if ((time[0] + 12) <= 19)
                {
                    raum_nr = 1;
                    datum_op = date;
                    zeit_op = time[0]+":"+time[1]+":00";
                    return true;
                }
                else
                {
                    //kein platz nächster tag
                    DialogResult result = MessageBox.Show("Für diesen Tag kann keine weitere Herz-OP angelegt werden! Bitte wählen Sie einen anderen Tag.",
                "Fehlermeldung",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
                    return false;
                }
            }
            else
            {
                int[] time_s = new int[4];
                int[] time_m = new int[4];
                int[] time_curr = new int[2];

                bool check_flag = true;
                raum_nr = 2;


                DataTable dt = db.getOPById(id_op_p);

                if (dt != null)
                {
                    DataRow dr = dt.Rows[dt.Rows.Count - 1];

                    int op_dauer = Convert.ToInt32(dr["OP_Dauer"]);

                    //holen aller endzeiten der letzten ops pro raum
                    for (int i = 3; i >= 0; i--)
                    {
                        time_curr = db.getLastTimeByRaumnr((i + 2), date);

                        time_s[i] = time_curr[0];
                        time_m[i] = time_curr[1];
                    }


                    for (int i = 0; i < 4; i++)
                    {
                        //vergleichen ob aktuelle zeit hinter der anderen liegt
                        if (time_curr[0] > time_s[i])
                        {
                            time_curr[0] = time_s[i];
                            time_curr[1] = time_m[i];


                            //falls ja überprüfen ob dauer + akt zeit arbeitszeit überschreitet
                            if (time_curr[0] + op_dauer <= 19)
                            {                                
                                raum_nr = i + 2;
                                check_flag = true;
                            }
                            else
                            {
                                check_flag = false;
                            }
                        }
                        else if (time_curr[0] == time_s[i] && time_curr[1] > time_m[i])
                        {
                            time_curr[0] = time_s[i];
                            time_curr[1] = time_m[i];

                            if (time_curr[0] + op_dauer <= 19)
                            {
                                raum_nr = i + 2;
                                check_flag = true;
                            }
                            else
                            {
                                check_flag = false;
                            }
                        }
                    }

                    if(check_flag == false)
                    {
                        //kein platz nächster tag
                        DialogResult result = MessageBox.Show("Für diese OP ist an dem gewählten Tag kein Platz mehr! Bitte wählen Sie einen anderen Tag.",
                    "Fehlermeldung",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                        return false;
                    }
                    else
                    {
                        datum_op = date;
                        zeit_op = time_curr[0] + ":" + time_curr[1] + ":00";
                        return true;
                    }
                }

            }
            return false;
        }

        private bool checkDate()
        {
            DateTime akt_date = DateTime.Now.Date;
            DateTime cmp_date = dateTimePicker1.Value.Date;

            int res = DateTime.Compare(cmp_date, akt_date);

            if (res <= 0)
            {
                DialogResult result = MessageBox.Show("Das OP-Datum muss in der Zukunft liegen!",
               "Fehlermeldung",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error,
               MessageBoxDefaultButton.Button1);
                return false;
            }
            return true;
        }
                
        private bool checkAnaes()
        {
            string cur_ana = ListeAnaes.Text;
            string name, vname;
            //DB Abfrage für ID

            if (cur_ana != "")
            {
                DB db = new DB();
                string[] split = cur_ana.Split(new Char[] { ' ' });

                if (split.Length > 0)
                {
                    vname = split[0];
                    name = split[split.Length - 1];

                    id_anaest = db.getAnaesByName(name, vname);
                }
                db.close();
                return true;
            }
            else
            {
                DialogResult result = MessageBox.Show("Der Anästhesist wurde nicht ausgewählt!",
               "Fehlermeldung",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error,
               MessageBoxDefaultButton.Button1);
                return false;
            }
            //überprüfen ob genügend arbeitszeit frei
            
        }
        
        private bool checkKrankens()
        {
            int check1 = KrankSchw1Check();
            int check2 = KrankSchw2Check();
            //überprüfen ob genügend arbeitszeit frei
            if (check1 == 0 && check2 == 0)
            {
                if (id_krankens1 != id_krankens2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            

        }

        private int KrankSchw2Check()
        {
            string name, vname;
            string cur_ks = ListeKrankens2.Text;
            //DB Abfrage für ID

            if (cur_ks != "")
            {
                DB db = new DB();
                string[] split = cur_ks.Split(new Char[] { ' ' });

                if (split.Length > 0)
                {
                    vname = split[0];
                    name = split[split.Length - 1];

                    id_krankens2 = db.getKrankensByName(name, vname);
                }
                db.close();
                return 0;
            }
            else
            {
                DialogResult result = MessageBox.Show("Die zweite Krankenschwester wurde nicht ausgewählt!",
               "Fehlermeldung",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error,
               MessageBoxDefaultButton.Button1);
                return -1;
            }
        }

        private int KrankSchw1Check()
        {
            string name, vname;
            string cur_ks = ListeKrankens.Text;
            //DB Abfrage für ID

            if (cur_ks != "")
            {
                DB db = new DB();
                string[] split = cur_ks.Split(new Char[] { ' ' });

                if (split.Length > 0)
                {
                    vname = split[0];
                    name = split[split.Length - 1];

                    id_krankens1 = db.getKrankensByName(name, vname);
                }
                db.close();
                return 0;
            }
            else
            {
                DialogResult result = MessageBox.Show("Die erste Krankenschwester wurde nicht ausgewählt!",
                "Fehlermeldung",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
                return -1;
            }
        }

        private bool checkChirurg()
        {
            int check1 = Chirurg1Check();
            int check2 = Chirurg2Check();
            //überprüfen ob genügend arbeitszeit frei
            if (check1 == 0 && check2 == 0)
            {
                if (id_chirurg1 != id_chirurg2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
           
        }

        private int Chirurg2Check()
        {
            string name, vname;
            string cur_ks = ListeChirurg2.Text;
            //DB Abfrage für ID

            if (cur_ks != "")
            {
                DB db = new DB();
                string[] split = cur_ks.Split(new Char[] { ' ' });

                if (split.Length > 0)
                {
                    vname = split[0];
                    name = split[split.Length - 1];

                    id_chirurg2 = db.getChirurgsByName(name, vname);
                }
                db.close();
                return 0;
            }
            else
            {
                DialogResult result = MessageBox.Show("Der zweite Chirurg wurde nicht ausgewählt!",
               "Fehlermeldung",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error,
               MessageBoxDefaultButton.Button1);
                return -1;
            }
        }

        private int Chirurg1Check()
        {
            string name, vname;
            string cur_ks = ListeChirurg.Text;
            //DB Abfrage für ID

            if (cur_ks != "")
            {
                DB db = new DB();
                string[] split = cur_ks.Split(new Char[] { ' ' });

                if (split.Length > 0)
                {
                    vname = split[0];
                    name = split[split.Length - 1];

                    id_chirurg1 = db.getChirurgsByName(name, vname);
                }
                db.close();
                return 0;
            }
            else
            {
                DialogResult result = MessageBox.Show("Der erste Chirurg wurde nicht ausgewählt!",
               "Fehlermeldung",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error,
               MessageBoxDefaultButton.Button1);
                return -1;
            }       
        }
        
        private void button_anlegen_u_weit_Click(object sender, EventArgs e)
        {
            OP_Daten opd = new OP_Daten();
            DB db = new DB();

            if (checkAnaes() == false)
            {
                return;
            }
            else if (p_set == 0)
            {
                return;
            }
            else if (checkChirurg() == false)
            {
                return;
            }
            else if (checkKrankens() == false)
            {
                return;
            }
            else if (checkDate())
            {

                if (setOpRaum())
                {
                    opd.setNarkose_Arzt(id_anaest);
                    opd.setPatienten_ID(id_patient);
                    opd.setChirurg1(id_chirurg1);
                    opd.setChirurg2(id_chirurg2);
                    opd.setSchwester1(id_krankens1);
                    opd.setSchwester2(id_krankens2);
                    Debug.Print("" + raum_nr);
                    opd.setRaumnummer(raum_nr);
                    opd.setDatum(datum_op);
                    opd.setZeit(zeit_op);
                }
                else { return; }
            }
            else
            {
                return;
            }

            db.instertOPDaten(opd);
            db.close();
            DialogResult result = MessageBox.Show("Die OP wurde erfolgreich gespeichert.",
                "Meldung",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button2);
            resetAll();
        }

        private void resetAll()
        {
            ListePatient.ResetText();
            lbOpArt.Text = "-";
            ListeChirurg.ResetText();
            ListeChirurg2.ResetText();
            ListeKrankens.ResetText();
            ListeKrankens2.ResetText();
            ListeAnaes.ResetText();
        }

        private void button_verwerf_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Möchten Sie das Erfassung beenden?",
                "Meldung",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        
    }
}
