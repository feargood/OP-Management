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
    public partial class MainFrame : Form
    {
        private const int NUMBER_OF_ROWS = 17;
        public string name;
        public string op;
        public int[] minutes = new int[28];
        public MainFrame()
        {
            InitializeComponent();
            draw_lvmain();
            draw_lvsingle();
        }

        void draw_lvmain()
        {
            //überschriften definieren
            this.lvmain.Columns.Add("Uhrzeit", 100);
            this.lvmain.Columns.Add("7:00", 70);
            this.lvmain.Columns.Add("8:00", 70);
            this.lvmain.Columns.Add("9:00", 70);
            this.lvmain.Columns.Add("10:00", 70);
            this.lvmain.Columns.Add("11:00", 70);
            this.lvmain.Columns.Add("12:00", 70);
            this.lvmain.Columns.Add("13:00", 70);
            this.lvmain.Columns.Add("14:00", 70);
            this.lvmain.Columns.Add("15:00", 70);
            this.lvmain.Columns.Add("16:00", 70);
            this.lvmain.Columns.Add("17:00", 70);
            this.lvmain.Columns.Add("18:00", 70);
            this.lvmain.Columns.Add("19:00", 70);
            this.lvmain.Columns.Add("20:00", 70);
            this.lvmain.Columns.Add("21:00", 70);
            this.lvmain.Columns.Add("22:00", 70);
            //Zeilennamen vergeben
            string[] arr = new string[NUMBER_OF_ROWS];
            int[] azeit = new int[28];
            ListViewItem itm1;
            ListViewItem itm2;
            ListViewItem itm3;
            ListViewItem itm4;
            arr[0] = "Saal1";
            int i = 1;
            for (i = 1; i < NUMBER_OF_ROWS; i++)
            {
                arr[i] = " ";
            }

            
            itm1 = new ListViewItem(arr);
            
            //Item1 hinzufügen
            lvmain.Items.Add(itm1);
            lvmain.Items[0].UseItemStyleForSubItems = false;
            // Item 2 Vorbereiten
            arr[0] = "Saal2";
            itm2 = new ListViewItem(arr);
            //Item hinzufügen
            lvmain.Items.Add(itm2);
            lvmain.Items[1].UseItemStyleForSubItems = false;
            // Item 3 Vorbereiten
            arr[0] = "Saal3";
            itm3 = new ListViewItem(arr);
            //Item hinzufügen
            lvmain.Items.Add(itm3);
            lvmain.Items[2].UseItemStyleForSubItems = false;
            // Item 4 Vorbereiten
            arr[0] = "Saal4";
            itm4 = new ListViewItem(arr);
            //Item hinzufügen
            lvmain.Items.Add(itm4);
            lvmain.Items[3].UseItemStyleForSubItems = false;
            // Item 5 Vorbereiten
           
            
            for (int k = 1; k < 5;k++ )
            { 
                azeit = gettime(k);
                for (int j = 0; j < azeit.Length; j++)
                {
                    if (azeit[j] > 0)
                    {
                        lvmain.Items[k-1].SubItems[azeit[j]].BackColor = Color.Red;

                    }
                    else
                    {
                        break;
                    }
                }
            }     

        }
        void fill_lvsingle(int raumnr)
        {
            int[] azeit = new int[28];
            azeit = gettime(raumnr);
            for (int j = 0; j < azeit.Length; j++)
            {
                if (azeit[j] > 0)
                {
                    
                    lvsingle.Items[azeit[j]-1].SubItems[1].BackColor = Color.Red;
                    lvsingle.Items[azeit[j]-1].SubItems[2].BackColor = Color.Red;
                }
                else
                {
                    if(j>0)
                    {
                        lvsingle.Items[azeit[j / 2]].SubItems[1].Text = name;
                        lvsingle.Items[azeit[j / 2]].SubItems[2].Text = op;
                    }
                    break;
                }
            }

        }

        void reset_content()
        {
            for(int i = 0;i < NUMBER_OF_ROWS;i++)
            {
                lvsingle.Items[i].SubItems[1].Text = "";
                lvsingle.Items[i].SubItems[2].Text = "";
                lvsingle.Items[i].SubItems[1].BackColor = Color.White;
                lvsingle.Items[i].SubItems[2].BackColor = Color.White;
            }
        }
        void draw_lvsingle()
        {
            
            lvsingle.Columns.Add("Uhrzeit", 80);
            lvsingle.Columns.Add("00", 180);
            lvsingle.Columns.Add("30", 180);
            lvsingle.Columns[1].TextAlign = HorizontalAlignment.Center;
            lvsingle.Columns[2].TextAlign = HorizontalAlignment.Center;
            lvsingle.Columns[0].TextAlign = HorizontalAlignment.Center;
            string[] arr = new string[NUMBER_OF_ROWS];
            ListViewItem itm1;

            for (int j = 7; j < 25;j++)
            {
                if(j<10)
                {
                    arr[0] = "0"+ j.ToString() + ":";
                }
                else
                {
                    arr[0] = j.ToString() + ":";
                }
                
                for (int i = 1; i < 3; i++)
                {
                    arr[i] = " ";
                }
                itm1 = new ListViewItem(arr);
                lvsingle.Items.Add(itm1);
                lvsingle.Items[j - 7].UseItemStyleForSubItems = false;
            }
            
                
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "projekt1DataSet.OP_Kategorien". Sie können sie bei Bedarf verschieben oder entfernen.
            this.oP_KategorienTableAdapter.Fill(this.projekt1DataSet.OP_Kategorien);

        }

        int[] gettime(int raum)
        {
            DB db = new DB();
            TimeSpan zeit;
            int dauer = 0 ;
            int j = 0;
            int[] azeit = new int[28];
            DataTable dt = null; 
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
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    name = dr["Vorname"].ToString() + " " + dr["Name"].ToString();
                    op = dr["OP_Art"].ToString() + " " + dr["OP_Dauer"].ToString();
                    zeit = (TimeSpan)dr["Zeit"];
                    azeit[j] = ((int)zeit.TotalHours)-6;
                    if(((int)zeit.TotalMinutes) / ((int)zeit.TotalHours) != 60)
                    {
                        Debug.WriteLine(j);
                    }
                    
                    dauer = Convert.ToInt32(dr["OP_Dauer"]);
                    for (int k = j+1; k < dauer; k++)
                    {
                        azeit[k] = azeit[j] + k;
                    }
                    j = j + dauer;  
                }
            }
            return azeit;
        }

        private void button_Notfall_Click(object sender, EventArgs e)
        {
            Form frm = new Notfall();
            frm.Show(this);
        }

        private void FensterAusw_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(FensterAusw_Combo.SelectedIndex >0)
            {
                reset_content();
                fill_lvsingle(FensterAusw_Combo.SelectedIndex);
                lvmain.Visible = false;
                lvsingle.Visible = true;
            }
            else
            {
                lvmain.Visible = true;
                lvsingle.Visible = false;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void operationAnlegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new OPeingabe();
            frm.Show(this);
        }

        private void personalverwaltungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Personalverwaltung();
            frm.Show(this);
        }

        private void opertionenVerwaltenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new OPverwalten();
            frm.Show(this);
        }

    }
}
