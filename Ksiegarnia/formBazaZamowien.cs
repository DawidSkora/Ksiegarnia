using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksiegarnia
{
    public partial class formBazaZamowien : Form
    {
        public formBazaZamowien()
        {
            InitializeComponent();
        }

        private void formBazaZamowien_Load(object sender, EventArgs e)
        {
            

            
            
        }

        private void stronaGlownaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ZmienneGlobalne.formaStronaGlowna_get_set.Visible = true;
        }

        private void przegladanieOfertyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ZmienneGlobalne.formaPrzegladanieOferty_get_set.Visible = true;
        }

        private void koszykToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ZmienneGlobalne.formaKoszyk_get_set.Visible = true;
        }

        private void helpTimerBazaZamowien_Tick(object sender, EventArgs e)
        {

        }
    }
}
