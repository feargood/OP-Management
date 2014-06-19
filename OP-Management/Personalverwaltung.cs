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
        // Objekt der Personaldaten
        private Personaldaten pd = null;

        // Initialisierung
        public Personalverwaltung()
        {
            InitializeComponent();
            buttonAendern.Enabled = false;
            buttonLoeschen.Enabled = false;
            refreshLVPersonalverwaltung();
        }

        /*
         * Löscht die Eingabefelder
         */
        private void clearFields()
        {
            textBoxPersonalName.Text = "";
            textBoxPersonalVorname.Text = "";
            comboBoxPersonalFunktion.Text = "";
            textBoxPersonalArbeitszeit.Text = "";
        }

        /*
         * Aktualisiert die Anzeige (ListView)
         */
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

        /*
         * Prüft den Namen
         */
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

        /*
         * Prüft den Vornamen
         */
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

        /*
         * Prüft die Funktion
         */
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


        /*
         *  prüft die Arbeitszeit
         */

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

        /*
         * Legt das Personal in der DB an
         */

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

        /*
         * Beim Klick in die ListView wird der gewählte Eintrag selektiert
         */
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

                comboBoxPersonalFunktion.Text = pd.getFunktion();
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

        /*
         * Verhindert ungültige zeichen bei der Eingabe der Arbeitszeit
         */

        private void textBoxPersonalArbeitszeit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }


        /*
         * F5 aktualisiert die Obefläche
         */

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

        /*
         * löscht den gewählten Eintrag
         */

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

        /*
         * Speichert die Änderungen am aktuellen Eintrag
         */
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

        private void Personalverwaltung_Load(object sender, EventArgs e)
        {

        }

    }
}
