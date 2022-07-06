using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PodaciKnjige;

namespace Bibly
{
    public partial class UCAutor : UserControl
    {
        public UCAutor()
        {
            InitializeComponent();
            PopuniComboBox(AutorRepozitorij.DohvatiSveAutore());
        }

        public void Postavi(List<Autor> autori, int lijevo, int gore)
        {
            this.Top = gore;
            this.Left = lijevo;
            PopuniComboBox(autori);
        }

        public void PopuniComboBox(List<Autor> autori)
        {
            cmbAutor.Items.Clear();
            foreach (Autor autor in autori)
            {
                cmbAutor.Items.Add(autor);
            }
            cmbAutor.SelectedIndex = 0;
        }

    }
}
