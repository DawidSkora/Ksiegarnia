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
    public partial class formLogowanie : Form
    {
        public formLogowanie()
        {
            InitializeComponent();
        }

        private void bZalogujSie_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text != "" && tbHaslo.Text != "")
            {
                if (Uzytkownik.Logowanie(tbLogin.Text, tbHaslo.Text)) ZmienneGlobalne.czy_zalogowany_get_set = true;
                else ZmienneGlobalne.czy_zalogowany_get_set = false;
            }
        }

    }
}
