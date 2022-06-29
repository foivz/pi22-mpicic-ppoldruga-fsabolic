        private void btnPosudi_Click(object sender, EventArgs e)
        {
            if (cmbPrimjerak.Text == "" || cmbKorisnik.Text == "")
            {
                MessageBox.Show("Potrebno je skrenirati korisnika i knjigu prilikom posudbe!");
            }
        }
