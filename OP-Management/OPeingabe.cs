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
        static int id_chirurg1;
        static int id_chirurg2;
        static int id_krankens1;
        static int id_krankens2;
        static int id_anaest;
        static int id_patient;
        static int id_op;
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


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void OP_Art_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cur_op = OP_Art_Combo.SelectedItem.ToString();
            //DB Abfrage für ID
        }

        private void KrankSchw1_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable dt = db.getKrankens();

            string cur_ks = ListeKrankens.SelectedItem.ToString();
            //DB Abfrage für ID
            Debug.Print(cur_ks);
            ListeKrankens2.Items.Clear();

            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    string cur = dr["Vorname"].ToString() + " " + dr["Name"].ToString();

                    if(!cur_ks.Equals(cur))
                    {
                        ListeKrankens2.Items.Add(cur);
                    }
                }
            }

            db.close();
        }

        private void KrankSchw2_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable dt = db.getKrankens();

            string cur_ks = ListeKrankens2.Text;
            //DB Abfrage für ID
            ListeKrankens.Items.Clear();

            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    string cur = dr["Vorname"].ToString() + " " + dr["Name"].ToString();

                    if (!cur_ks.Equals(cur))
                    {
                        ListeKrankens.Items.Add(cur);
                    }
                }
            }

            db.close();
        }

        private void Anaesth_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cur_ana = ListeAnaes.SelectedItem.ToString();
            //DB Abfrage für ID
        }

        private void Chirurg2_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable dt = db.getChirurgs();

            string cur_ks = ListeChirurg2.Text;
            //DB Abfrage für ID
            ListeChirurg.Items.Clear();

            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    string cur = dr["Vorname"].ToString() + " " + dr["Name"].ToString();

                    if (!cur_ks.Equals(cur))
                    {
                        ListeChirurg.Items.Add(cur);
                    }
                }
            }

            db.close();
        }

        private void Chirurg1_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable dt = db.getChirurgs();

            string cur_ks = ListeChirurg.Text;
            //DB Abfrage für ID
            ListeChirurg2.Items.Clear();

            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    string cur = dr["Vorname"].ToString() + " " + dr["Name"].ToString();

                    if (!cur_ks.Equals(cur))
                    {
                        ListeChirurg2.Items.Add(cur);
                    }
                }
            }

            db.close();
        }

        private void Patient_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cur_pat = ListePatient.SelectedItem.ToString();
            //DB Abfrage für ID
        }

        private void button_Anlegen_Click(object sender, EventArgs e)
        {
            OP_Daten opd = new OP_Daten();

            if (checkChirurg1())
            {
                opd.setChirurg1(id_chirurg1);
            }
            else
            {
                return;
            }

            if (checkChirurg2())
            {
                opd.setChirurg2(id_chirurg2);
            }
            else
            {
                return;
            }

            if (checkKrankens1())
            {
                opd.setSchwester1(id_krankens1);
            }
            else
            {
                return;
            }

            if (checkKrankens2())
            {
                opd.setSchwester2(id_krankens2);
            }
            else
            {
                return;
            }

            if (checkAnaes())
            {
                opd.setNarkose_Arzt(id_anaest);
            }
            else
            {
                return;
            }

            if (checkPatient())
            {
                opd.setPatienten_ID(id_patient);
            }
            else
            {
                return;
            }

            DB db = new DB();
            db.instertOPDaten(opd);
            db.close();
        }

        private bool checkPatient()
        {
            throw new NotImplementedException();
        }

        private bool checkAnaes()
        {
            throw new NotImplementedException();
        }

        private bool checkKrankens2()
        {
            throw new NotImplementedException();
        }

        private bool checkKrankens1()
        {
            throw new NotImplementedException();
        }

        private bool checkChirurg2()
        {
            throw new NotImplementedException();
        }

        private bool checkChirurg1()
        {
            throw new NotImplementedException();
        }


        private void button_anlegen_u_weit_Click(object sender, EventArgs e)
        {
            button_Anlegen_Click(sender, e);
        }

        private void button_verwerf_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
