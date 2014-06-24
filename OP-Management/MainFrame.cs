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
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "projekt1DataSet.OP_Kategorien". Sie können sie bei Bedarf verschieben oder entfernen.
            this.oP_KategorienTableAdapter.Fill(this.projekt1DataSet.OP_Kategorien);

        }

        private void button_Notfall_Click(object sender, EventArgs e)
        {
            Form frm = new Notfall();
            frm.Show(this);
        }

        private void FensterAusw_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {

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
