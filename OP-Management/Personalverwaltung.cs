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
    public partial class Personalverwaltung : Form
    {

        private Personaldaten pd = null;


        public Personalverwaltung()
        {
            InitializeComponent();
            buttonAendern.Enabled = false;
            buttonLoeschen.Enabled = false;
            refreshLVPersonalverwaltung();
        }

        private void clearFields()
        {
            textBoxPersonalName.Text = "";
            textBoxPersonalVorname.Text = "";
            comboBoxPersonalFunktion.Text = "";
            textBoxPersonalArbeitszeit.Text = "";
        }

        private void refreshLVPersonalverwaltung()
        {
            DB db = new DB();
            DataTable dt = db.getAllPersonal();
            db.close();
            listViewPersonal.Clear();
            listViewPersonal.View = View.Details;
            listViewPersonal.Columns.Add("ID", 50);
            listViewPersonal.Columns.Add("Vorname", 90);
            listViewPersonal.Columns.Add("Nachname", 90);
            listViewPersonal.Columns.Add("Funktion", 90);
            listViewPersonal.Columns.Add("Arbeitszeit", 90);

            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["Personal_ID"].ToString());
                    listitem.SubItems.Add(dr["Vorname"].ToString());
                    listitem.SubItems.Add(dr["Name"].ToString());
                    listitem.SubItems.Add(dr["Funktion"].ToString());
                    listitem.SubItems.Add(dr["Arbeitszeit"].ToString());
                    listViewPersonal.Items.Add(listitem);
                }
            }
        }


        public bool checkName()
        {
            bool bval = false;
            String name = textBoxPersonalName.Text;
            if (name.Length != 0)
            {
                bval = true;
            }
            else
            {
                MessageBox.Show("Bitte den Namen eingeben.", "Name fehlt!");
                textBoxPersonalName.Focus();
            }
            return bval;
        }

        public bool checkVorname()
        {
            bool bval = false;
            String vorname = textBoxPersonalVorname.Text;
            if (vorname.Length != 0)
            {
                bval = true;
            }
            else
            {
                MessageBox.Show("Bitte den Vorname eingeben.", "Vorname fehlt!");
                textBoxPersonalVorname.Focus();
            }
            return bval;
        }


        public bool checkFunktion()
        {
            bool bval = false;
            String s = comboBoxPersonalFunktion.Text;
            if (s.Length != 0)
            {
                bval = true;
            }
            else
            {
                MessageBox.Show("Bitte die Funktion auswählen.", "Funktion fehlt!");
                comboBoxPersonalFunktion.Focus();
            }
            return bval;
        }

        public bool checkArbeitszeit()
        {
            bool bval = false;
            String arbeitszeit = textBoxPersonalArbeitszeit.Text;
            if (arbeitszeit.Length != 0)
            {
                try
                {
                    double az = Convert.ToDouble(arbeitszeit);
                    if (az > 0 && az <= 100)
                    {
                        bval = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Die Arbeitszeit ist ungültig!", "Arbeitszeit falsch!");
                    textBoxPersonalArbeitszeit.Focus();
                }
            }
            else
            {
                MessageBox.Show("Bitte die Arbeitszeit eingeben.", "Arbeitszeit fehlt!");
                textBoxPersonalArbeitszeit.Focus();
            }
            return bval;
        }

        private void buttonAnlegen_Click(object sender, EventArgs e)
        {

            // prüfen und so...
            Personaldaten pd = new Personaldaten();

            if (checkName())
            {
                pd.setName(textBoxPersonalName.Text);
            }
            else
            {
                return;
            }

            if (checkVorname())
            {
                pd.setVorname(textBoxPersonalVorname.Text);
            }
            else
            {
                return;
            }

            if (checkFunktion())
            {
                pd.setFunktion(comboBoxPersonalFunktion.Text);
            }
            else
            {
                return;
            }

            if (checkFunktion())
            {
                pd.setArbeitszeit(Convert.ToDouble(textBoxPersonalArbeitszeit.Text));
            }
            else
            {
                return;
            }


            // Und jetzt ab in die DB...
            DB db = new DB();
            db.insertPersonaldaten(pd);
            db.close();

            // Anzeige aktualiesieren...
            clearFields();
            refreshLVPersonalverwaltung();
            pd = null;
            buttonAendern.Enabled = false;
            buttonLoeschen.Enabled = false;

        }



        private void listViewPersonal_Click(object sender, EventArgs e)
        {
            var firstSelectedItem = listViewPersonal.SelectedItems[0];
            if (firstSelectedItem != null)
            {
                ListViewItem.ListViewSubItem subItem0 = firstSelectedItem.SubItems[0];
                DB db = new DB();
                pd = db.getPersonalById(Convert.ToInt32(subItem0.Text));
                textBoxPersonalName.Text = pd.getName();
                textBoxPersonalVorname.Text = pd.getVorname();
                comboBoxPersonalFunktion.SelectedItem = pd.getFunktion();
                textBoxPersonalArbeitszeit.Text = Convert.ToString(pd.getArbeitszeit());

                buttonAendern.Enabled = true;
                buttonLoeschen.Enabled = true;

            }
            else
            {
                pd = null;
                clearFields();
                buttonAendern.Enabled = false;
                buttonLoeschen.Enabled = false;
            }
        }


        private void textBoxPersonalArbeitszeit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void Personalverwaltung_KeyPress(object sender, KeyPressEventArgs e)
        { }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool bHandled = false;
            switch (keyData)
            {
                case Keys.F5:

                    refreshLVPersonalverwaltung();
                    bHandled = true;
                    break;
            }
            return bHandled;
        }

        private void buttonLoeschen_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.deletePersonaldaten(pd);
            db.close();

            pd = null;
            buttonAendern.Enabled = false;
            buttonLoeschen.Enabled = false;

            clearFields();
            refreshLVPersonalverwaltung();

        }

        private void buttonAendern_Click(object sender, EventArgs e)
        {

            DB db = new DB();

            if (checkName())
            {
                pd.setName(textBoxPersonalName.Text);
            }
            else
            {
                return;
            }

            if (checkVorname())
            {
                pd.setVorname(textBoxPersonalVorname.Text);
            }
            else
            {
                return;
            }

            if (checkFunktion())
            {
                pd.setFunktion(comboBoxPersonalFunktion.Text);
            }
            else
            {
                return;
            }

            if (checkArbeitszeit())
            {
                pd.setArbeitszeit(Convert.ToDouble(textBoxPersonalArbeitszeit.Text));
            }
            else
            {
                return;
            }

            db.updatePersonaldaten(pd);
            db.close();
            refreshLVPersonalverwaltung();

        }

        private void textBoxPersonalName_TextChanged(object sender, EventArgs e)
        {
            String sdummy = textBoxPersonalName.Text;
            textBoxPersonalName.Text = sdummy.Replace(" ", "");

        }

        private void textBoxPersonalVorname_TextChanged(object sender, EventArgs e)
        {
            String sdummy = textBoxPersonalVorname.Text;
            textBoxPersonalVorname.Text = sdummy.Replace(" ", "");
        }




    }
}
