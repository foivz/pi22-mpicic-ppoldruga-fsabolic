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
    public partial class FrmInventarPregledKnjige : FrmOpcenita
    {
        public FrmInventarPregledKnjige()
        {
            InitializeComponent();
            PostaviGlavniMenu(1);
        }

        private void FrmInventarPregledKnjige_Load(object sender, EventArgs e)
        {

        }
    }
}
