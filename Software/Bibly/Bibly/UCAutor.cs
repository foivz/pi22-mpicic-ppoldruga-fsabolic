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
        private List<Autor> autori = null;
        public UCAutor()
        {
            InitializeComponent();
            PopuniComboBox();
        }

        public void PopuniComboBox()
        {
            autori = AutorRepozitorij.DohvatiSveAutore();
            cmbAutor.Items.Clear();
            foreach (Autor autor in autori)
            {
                cmbAutor.Items.Add(autor);
            }
            cmbAutor.SelectedIndex = 0;
        }


        public Autor VratiVrijednost()
        {
            return this.cmbAutor.SelectedItem as Autor;
        }

        public void PostaviAutora(Autor autor)
        {
            cmbAutor.SelectedIndex = autori.IndexOf(autori.Find(x => x.Id == autor.Id));
        }
    }
}
