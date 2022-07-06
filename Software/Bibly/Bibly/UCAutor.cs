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
        }

        private void UCAutor_Load(object sender, EventArgs e)
        {

        }

        public void Postavi(List<Autor> autori)
        {
            PopuniComboBox(autori);
        }

        public Autor VratiVrijednost()
        {
            return this.cmbAutor.SelectedItem as Autor;
        }

        public void PopuniComboBox(List<Autor> autori)
        {
            foreach (Autor autor in autori)
            {
                cmbAutor.Items.Add(autor);
            }
        }

    }
}
