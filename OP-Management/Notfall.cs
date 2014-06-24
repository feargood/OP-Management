using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace OP_Management
{
    public partial class Notfall : Form
    {
        public Notfall()
        {
            InitializeComponent();
        }

        private void clearFields()
        {
            tbzeit.Text = "";
            lantwort.Text = "Antwort";
            lantwort.ForeColor = Color.Black;
            lantwort.Visible = false;
            

        }

        public bool check_zeit()
        {
            bool bval = true;
            
            String time = tbzeit.Text;
            if (time.Length == 0)
            {
                MessageBox.Show("Bitte die Zeit bis zur Ankunft eingeben.", "Zeit fehlt!");
                tbzeit.Focus();
                bval = false;
            }
            else if (Convert.ToInt32(time) < 0 || Convert.ToInt32(time) > 40)
            {
                MessageBox.Show("Die Zeit bis zur Ankunft befindet sich nicht im erlaubten Bereich.", "Zeit bis zur Ankunft überprüfen!");
                tbzeit.Focus();
                bval = false;
            }
            return bval;
        }

        public bool check_opfree()
        {
            bool bval = false;
            DB db = new DB();
            TimeSpan zeit;
            int minutes = 0;
            int endzeit = 0;
            int startzeit;
            DateTime arrival_time = DateTime.Now;
            arrival_time = arrival_time.AddMinutes(Convert.ToDouble(tbzeit.Text));
            DateTime finished_time = arrival_time;
            finished_time = finished_time.AddHours(Convert.ToDouble(cbart.SelectedValue));
            DataTable dt = null;
            int raum = 1;
            for (raum = 1; raum < 5; raum++)
            {
                switch (raum)
                {
                    case 1:
                        dt = db.getRaum1();
                        break;
                    case 2:
                        dt = db.getRaum2();
                        break;
                    case 3:
                        dt = db.getRaum3();
                        break;
                    case 4:
                        dt = db.getRaum4();
                        break;
                    default:
                        Console.WriteLine("Raum existiert nicht !");
                        break;
                }

                if (dt != null)
                {
                    //letzte op auswählen
                    DataRow dr = dt.Rows[dt.Rows.Count - 1];
                    zeit = (TimeSpan)dr["Zeit"];
                    startzeit = ((int)zeit.TotalHours);
                    minutes = ((int)zeit.TotalMinutes);
                    endzeit = startzeit + Convert.ToInt32(dr["OP_Dauer"]) - 1;

                    if (arrival_time.Hour > startzeit)
                    {
                        if (arrival_time.Hour >= endzeit)
                        {
                            if (finished_time.Hour < 20)
                            {
                                if (minutes > 0 && arrival_time.Hour == endzeit)
                                {
                                    if (minutes < (arrival_time.Minute + 5))
                                    {
                                        bval = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    bval = true;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            Debug.Write("raumend:" + raum);

            return bval;
        }

        public void change_antwort()
        {
            
            if (check_opfree())
            {
                lantwort.Text = "Annahme möglich";
                lantwort.ForeColor = Color.Green;
                bannehmen.Enabled = true;
                
            }
            else
            {
                lantwort.Text = "Annahme nicht möglich";
                lantwort.ForeColor = Color.Red;
            }
            lantwort.Visible = true;
        }


        private void Notfall_Load(object sender, EventArgs e)
        {
           
            // TODO: Diese Codezeile lädt Daten in die Tabelle "projekt1DataSet.OP_Kategorien". Sie können sie bei Bedarf verschieben oder entfernen.
            this.oP_KategorienTableAdapter.Fill(this.projekt1DataSet.OP_Kategorien);
            

        }

        private void babschicken_Click(object sender, EventArgs e)
        {
            
            if(check_zeit())
            {
                change_antwort();
            }
        }

        private void bannehmen_Click(object sender, EventArgs e)
        {
            OPeingabe OE = new OPeingabe();
            OE.Show();
        }

        private void bverwerfen_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void cbart_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Debug.Write(cbart.SelectedValue);
        }

     

    }
}
