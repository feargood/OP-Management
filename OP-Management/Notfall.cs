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
            return bval;
        }

        public bool check_opfree()
        {
            bool bval = false;
            DateTime arrival_time = DateTime.Now;
            arrival_time.AddMinutes(Convert.ToDouble(tbzeit));
            // Funktion kann erst implementiert werden wenn OP_Daten vorhanden sind
            //überprüfen ob zur arrival_time ein OP_Saal frei ist
            Debug.Write("checkop");

            return bval;
        }

        public void change_antwort()
        {
            Debug.Write("change");
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
            //Was soll beim annehmen passieren ?
        }

        private void bverwerfen_Click(object sender, EventArgs e)
        {
            clearFields();
        }

     

    }
}
