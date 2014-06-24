using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OP_Management
{
    public partial class OPverwalten : Form
    {
        private OP_Daten[] op_data = new OP_Daten[96];
        private DateTime dDate;
        private string sDate;
        
        public OPverwalten()
        {
            InitializeComponent();
            Init_Listviews();

        }

        private void Init_Listviews()
        {
            //Listen initialisieren
            Raum_1.Clear();
            Raum_1.Items.Clear();
            Raum_1.View = View.Details;
            Raum_1.Columns.Add("Uhrzeit", 176);
            Raum_1.Columns.Add("Patienten_ID", 176);
            Raum_1.Columns.Add("OP_ID", 176);
            Raum_1.Columns.Add("OP_Art", 176);

            Raum_2.Clear();
            Raum_2.Items.Clear();
            Raum_2.View = View.Details;
            Raum_2.Columns.Add("Uhrzeit", 176);
            Raum_2.Columns.Add("Patienten_ID", 176);
            Raum_2.Columns.Add("OP_ID", 176);
            Raum_2.Columns.Add("OP_Art", 176);

            Raum_3.Clear();
            Raum_3.Items.Clear();
            Raum_3.View = View.Details;
            Raum_3.Columns.Add("Uhrzeit", 176);
            Raum_3.Columns.Add("Patienten_ID", 176);
            Raum_3.Columns.Add("OP_ID", 176);
            Raum_3.Columns.Add("OP_Art", 176);

            Raum_4.Clear();
            Raum_4.Items.Clear();
            Raum_4.View = View.Details;
            Raum_4.Columns.Add("Uhrzeit", 176);
            Raum_4.Columns.Add("Patienten_ID", 176);
            Raum_4.Columns.Add("OP_ID", 176);
            Raum_4.Columns.Add("OP_Art", 176);

            LoadDataLists();

        }

        private void LoadDataLists()
        {
            // Daten reinladen... 

            string temp = dateTimePicker1.Value.Date.ToString();
            dDate = dateTimePicker1.Value.Date;
            sDate = temp.Remove(10,9);
            DB db = new DB();
            DataTable dt = db.getAll_OpData(sDate);

            

            db.close();

            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    if (dr != null)
                    op_data[i] = new OP_Daten(dr);


                    // hole Raumnummer
                    string raumn = dr["Raumnummer"].ToString();

                    // speichere Abfrage in Itemliste
                    ListViewItem listitem = new ListViewItem(dr["Zeit"].ToString());
                    listitem.SubItems.Add(dr["Patienten_ID"].ToString());

                    // hole OP_ID aus Patientendaten und speichere in listitem
                    string op_id = db.get_OP_ID(dr["Patienten_ID"].ToString());
                    listitem.SubItems.Add(op_id);

                    // hole OP_Art anhand der OP_ID und speichere in listitem
                    string op_art = db.get_OP_Art(op_id);
                    listitem.SubItems.Add(op_art);

                    switch (raumn)
                    {
                        case "1":
                            Raum_1.Items.Add(listitem);
                            break;
                        case "2":
                            Raum_2.Items.Add(listitem);
                            break;
                        case "3":
                            Raum_3.Items.Add(listitem);
                            break;
                        case "4":
                            Raum_4.Items.Add(listitem);
                            break;

                    }
                    
                }

            }

        }

        private int getSelectedItem()
        {
            if (Raum_1.SelectedItems.Count != 0)  
                return 1;
            else if (Raum_2.SelectedItems.Count != 0)
                return 2;
            else if (Raum_3.SelectedItems.Count != 0)
                return 3;
            else if (Raum_4.SelectedItems.Count != 0)
                return 4;
            else
                return 0;


        }

        

        private void button__Bearb_Click(object sender, EventArgs e)
        {
            
            int iRoom = getSelectedItem();
                        if (iRoom == 0)
                MessageBox.Show("Bitte OP zum bearbeiten wählen", "Achtung");
            else
            {
                DB db = new DB();
                string sTime = null;
                OP_Daten op_data2 = new OP_Daten();

                

                if (iRoom == 1)
                {
                    sTime = Raum_1.SelectedItems[0].Text;
                }
                else if (iRoom == 2)
                {
                    sTime = Raum_2.SelectedItems[0].Text;
                }
                else if (iRoom == 3)
                {
                    sTime = Raum_3.SelectedItems[0].Text;
                }
                else if (iRoom == 4)
                {
                    sTime = Raum_4.SelectedItems[0].Text;
                }

                op_data2.setRaumnummer(iRoom);
                op_data2.setDatum(sDate);
                op_data2.setZeit(sTime);

                DataRow dr = db.getOp_Data(op_data2);

                Form frm = new OPBearbeiten(dr);
                frm.Show(this);
                Init_Listviews();
            }
        }

        private void button_Loesch_Click(object sender, EventArgs e)
        {
            int iRoom = getSelectedItem();
            
            if (iRoom == 0)
                MessageBox.Show("Bitte OP zum löschen wählen", "Achtung");
            else{
                DB db = new DB();
                string sTime = null;

                OP_Daten op_data2 = new OP_Daten();

            
            if (iRoom == 1)
            {


                sTime = Raum_1.SelectedItems[0].Text;
                Raum_1.Items.Remove(Raum_1.SelectedItems[0]);
            }
            else if (iRoom == 2)
            {
                sTime = Raum_2.SelectedItems[0].Text;
                Raum_2.Items.Remove(Raum_2.SelectedItems[0]);
            }
            else if (iRoom == 3)
            {
                sTime = Raum_3.SelectedItems[0].Text;
                Raum_3.Items.Remove(Raum_3.SelectedItems[0]);
            }
            else if (iRoom == 4)
            {
                sTime = Raum_4.SelectedItems[0].Text;
                Raum_4.Items.Remove(Raum_4.SelectedItems[0]);
            }

            op_data2.setRaumnummer(iRoom);
            op_data2.setDatum(sDate);
            op_data2.setZeit(sTime);
            db.deleteOP_Daten(op_data2);


            }
        }

        private void button_schliess_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       



        private void operationAnlegenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form frm = new OPeingabe();
            frm.Show(this);
        }

        private void personalverwaltungToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form frm = new Personalverwaltung();
            frm.Show(this);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Init_Listviews();
            

        }

        private void OPverwalten_Load(object sender, EventArgs e)
        {

        }


    }
}
