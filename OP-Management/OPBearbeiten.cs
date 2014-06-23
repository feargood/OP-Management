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
            this.op_data = new OP_Daten(dr);
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
                    DataRow dr = chirurg.Rows[i];
                    string cur = dr["Vorname"].ToString() + " " + dr["Name"].ToString();
                    ListeChirurg.Items.Add(cur);
                    ListeChirurg2.Items.Add(cur);
                    if(dr[0].Equals(op_data.getChirurg1()))
                    {
                        ListeChirurg.Text = cur;
                    }
                    else if(dr[0].Equals(op_data.getChirurg2()))
                    {
                        ListeChirurg2.Text = cur;
                    }
                }
            }

            anaest = db.getAnaes();
            if (anaest != null)
            {
                for (int i = 0; i < anaest.Rows.Count; i++)
                {
                    DataRow dr = anaest.Rows[i];
                    string cur = dr["Vorname"].ToString() + " " + dr["Name"].ToString();
                    ListeAnaes.Items.Add(cur);
                    if (dr[0].Equals(op_data.getNarkose_Arzt()))
                    {
                        ListeAnaes.Text = cur;
                    }
                   
                }
            }

            krankens = db.getKrankens();
            if (krankens != null)
            {
                for (int i = 0; i < krankens.Rows.Count; i++)
                {
                    DataRow dr = krankens.Rows[i];
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


            string[] temp = op_data.getZeit().Split(new Char[] {':'});
            cbStunden.Text = temp[0];
            cbMinuten.Text = temp[1];

            

            Raum_Combo.Text = op_data.getRaumnummer().ToString();
                   

            dateTimePicker1.Text = op_data.getDatum();


        }


        // Die ganzen Checks..:

        // Checke ob das Feld Patient Ok ist
        private bool checkPatient()
        {
            if (ListePatient.Text.Length == 0)
            {
                MessageBox.Show("Achtung das Patienten-Feld ist leer", "Achtung");
                return false;
            }
            else
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
                }
                return true;
            }
        }

        // Checke ob das Feld Anaes Ok ist
        private bool checkAnaes()
        {
            
            if (ListeAnaes.Text.Length == 0)
            {
                MessageBox.Show("Achtung das Anästhesist-Feld ist leer", "Achtung");
                return false;
            }
            else
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
                }
                return true;
            }
        }

        // Checke ob die Felder der Krankenschwestern ok sind
        private bool checkKrankens()
        {

            if (ListeKrankens.Text == ListeKrankens2.Text)
            {
                MessageBox.Show("Sie haben zweimal die selbe Krankenschwester ausgewählt", "Achtung");
                return false;
            }
            else if (ListeKrankens.Text.Length == 0 || ListeKrankens2.Text.Length == 0)
            {
                MessageBox.Show("Achtung ein Krankenschwester-Feld ist leer", "Achtung");
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
            else if (ListeChirurg2.Text.Length == 0 || ListeChirurg.Text.Length == 0)
            {
                MessageBox.Show("Achtung ein Chirurg-Feld ist leer", "Achtung");
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
            if (Raum_Combo.Text.Length == 0)
            {
                MessageBox.Show("Das Raum-Feld ist leer", "Achtung");
                return false;
            }
            else if (Raum_Combo.Text.Equals("1")==false && op_id.Equals("2"))
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
            if (cbStunden.Text.Length == 0 || cbMinuten.Text.Length == 0)
            {
                MessageBox.Show("Das Raum-Feld ist leer", "Achtung");
                return false;
            }
            else
            {
                stunden = cbStunden.Text;
                Minuten = cbMinuten.Text;
                op_data.setZeit(stunden + ":" + Minuten + ":00");
                return true;

            }
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
            
            int ZeitInDB;
            int OpDauerinDB;
            int iOp_id;

            int geplZeit = Convert.ToInt32(stunden)*10 + Convert.ToInt32(Minuten) + op_dauer*10;
            
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    string cur = dr["Vorname"].ToString() + " " + dr["Name"].ToString();



                    if (dr[0].ToString().Equals(op_data.getDatum()) && dr[2].Equals(op_data.getRaumnummer()))
                    {
                        iOp_id = Convert.ToInt32(db.get_OP_ID(dr[8].ToString()));
                        for (int j = 0;j < dOp_art.Rows.Count; j++)
                        {
                            DataRow dOP = dOp_art.Rows[j];

                            if (dr[0].Equals(iOp_id))
                            {
                                OpDauerinDB = Convert.ToInt32(dr[2]);
                                ZeitInDB = 
                            }
                        }


                    }
                }
            }

            return true;
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
        }
        
    }
}
