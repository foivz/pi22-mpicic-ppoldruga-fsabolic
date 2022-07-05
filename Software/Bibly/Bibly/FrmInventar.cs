using PodaciKnjige;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibly
{
    public partial class FrmInventar : FrmOpcenita
    {
        private Knjiga trenutniRed = null;

        public FrmInventar()
        {
            InitializeComponent();
            dgvInventar.DataSource = PodaciKnjige.KnjigaRepozitorij.DohvatiSveKnjige();
            dgvInventar.Columns[6].Visible = false;
            dgvInventar.Columns[7].Visible = false;
        }

        private void dgvInventar_SelectionChanged(object sender, EventArgs e)
        {
            trenutniRed = dgvInventar.CurrentRow.DataBoundItem as Knjiga;
        }

        private void btnPregledajKnjigu_Click(object sender, EventArgs e)
        {

            FrmInventarPregledKnjige frm = new FrmInventarPregledKnjige(trenutniRed);
            frm.ShowDialog();
        }
    }
}
