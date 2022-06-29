﻿using System;
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
    public partial class FrmUpravljanjePosudbama : FrmOpcenita
    {
        public FrmUpravljanjePosudbama()
        {
            InitializeComponent();
            ucSkener1.PostaviUCSkener(this, cmbPrimjerak, cmbKorisnik);
        }

        private void FrmUpravljanjePosudbama_Load(object sender, EventArgs e)
        {

        }

        private void btnPosudi_Click(object sender, EventArgs e)
        {
            if (cmbPrimjerak.Text == "" || cmbKorisnik.Text == "")
            {
                MessageBox.Show("Potrebno je skrenirati korisnika i knjigu prilikom posudbe!");
            }
        }
    }
}
