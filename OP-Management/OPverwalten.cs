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
        public OPverwalten()
        {
            InitializeComponent();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button__Bearb_Click(object sender, EventArgs e)
        {
            Form frm = new OPBearbeiten();
            frm.Show(this);
        }

        private void button_Loesch_Click(object sender, EventArgs e)
        {

        }

        private void button_schliess_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
