using System;
using System.Windows.Forms;
using DirectX.Capture;
using System.Drawing;
using System.IO;

namespace SnapShot
{
    public partial class f_pstryk : Form
    {
        private Konfiguracja oknoKonfiguracji;
        private AboutBox1 oknoOprogramie;

        Properties.Settings konf = new Properties.Settings();

        private Kamera Cam;
        private Filters filters = new Filters();

        public f_pstryk()
        {
            InitializeComponent();
            for (int i = 0; i < filters.VideoInputDevices.Count; i++)
            {
                cb_listaKamer.Items.Add(filters.VideoInputDevices[i].Name);
                cb_listaKamer.SelectedIndex = i;
            }
            if (filters.VideoInputDevices.Count != 0)
            {
                Cam = new Kamera(cb_listaKamer.SelectedIndex);
                Cam.Start(pb_obrazZkamery);
            }
            tx_imieInazwisko.Text = konf.imieInazwisko;
            tx_notatka.Text = konf.notatka;
        }

        private void konfiguracjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oknoKonfiguracji == null)
            {
                oknoKonfiguracji = new Konfiguracja();
                oknoKonfiguracji.Parent = this.Parent;
                oknoKonfiguracji.FormClosed += (s, ee) => { oknoKonfiguracji = null; };
                oknoKonfiguracji.ShowDialog();
            }
            else
            {
                oknoKonfiguracji.Activate();
                oknoKonfiguracji.WindowState = FormWindowState.Normal;
            }

        }

        private void b_pstryk_Click(object sender, EventArgs e)
        {
            if (Cam != null && string.IsNullOrWhiteSpace(tx_imieInazwisko.Text))
                Cam.ZrobPstryk();
            else if (Cam != null)
                Cam.ZrobPstryk(tx_imieInazwisko.Text);
        }

        private void cb_listaKamer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cam != null)
            {
                Cam.Stop();
                Cam = new Kamera(cb_listaKamer.SelectedIndex);
                Cam.Start(pb_obrazZkamery);
            }
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oknoOprogramie == null)
            {
                oknoOprogramie = new AboutBox1();
                oknoOprogramie.Parent = this.Parent;
                oknoOprogramie.FormClosed += (s, ee) => { oknoOprogramie = null; };
                oknoOprogramie.Show();
            }
            else
            {
                oknoOprogramie.Activate();
                oknoOprogramie.WindowState = FormWindowState.Normal;
            }

        }

        private void f_pstryk_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(tx_imieInazwisko.Text) && string.IsNullOrWhiteSpace(tx_notatka.Text)))
            {
                konf.imieInazwisko = tx_imieInazwisko.Text;
                konf.notatka = tx_notatka.Text;
                konf.Save();
            }
        }

        private void b_zapiszNotatke_Click(object sender, EventArgs e)
        {
            Properties.Settings konf = new Properties.Settings();
            try
            {
                StreamWriter sw = new StreamWriter(konf.PathNotatki + "\\" + tx_imieInazwisko.Text + ".txt");
                sw.WriteLine(tx_imieInazwisko.Text + " " + DateTime.Now);
                sw.WriteLine(tx_notatka.Text);
                sw.Close();
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Nastąpiła próba zapisu do folderu bez uprawnień. Zmień folder albo uruchom aplikację z prawami administratora.", "Nieprawdiłowa lokalizacja", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
