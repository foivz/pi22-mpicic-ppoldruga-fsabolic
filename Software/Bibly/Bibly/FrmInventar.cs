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
        public FrmInventar()
        {
            InitializeComponent();
            dgvInventar.DataSource = PodaciKnjige.KnjigaRepozitorij.DohvatiSveKnjige();
            dgvInventar.Columns[6].Visible = false;
            dgvInventar.Columns[7].Visible = false;
        }
    }
}
