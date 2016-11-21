using System;
using System.Windows.Forms;

namespace SnapShot
{
    public partial class Konfiguracja : Form
    {
        Properties.Settings konf = new Properties.Settings();
        public Konfiguracja()
        {
            InitializeComponent();
            tb_sciezka.Text = konf.Path;
            tb_sciezkaNotatki.Text = konf.PathNotatki;
            checkBox1.Checked = konf.Checkbox;
        }

        private void b_przegladaj_Click(object sender, EventArgs e)
        {
            if (fbd_szukajKatalogu.ShowDialog() == DialogResult.OK)
            {
                tb_sciezka.Text = fbd_szukajKatalogu.SelectedPath;
                konf.Path = fbd_szukajKatalogu.SelectedPath;
                if (checkBox1.Checked)
                {
                    tb_sciezkaNotatki.Text = tb_sciezka.Text;
                    konf.PathNotatki = fbd_szukajKatalogu.SelectedPath;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            konf.Save();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                b_przegladajNotatki.Enabled = false;
                tb_sciezkaNotatki.Text = tb_sciezka.Text;
                konf.PathNotatki = tb_sciezka.Text;
                konf.Checkbox = true;
            }
            else
            {
                b_przegladajNotatki.Enabled = true;
                konf.Checkbox = false;
            }
        }

        private void b_przegladajNotatki_Click(object sender, EventArgs e)
        {
            if (fbd_szukajKatalogu.ShowDialog() == DialogResult.OK)
            {
                tb_sciezkaNotatki.Text = fbd_szukajKatalogu.SelectedPath;
                konf.PathNotatki = fbd_szukajKatalogu.SelectedPath;
            }

        }
    }
}
