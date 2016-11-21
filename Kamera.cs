using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using DirectX.Capture;
using SnapShot.Properties;

namespace SnapShot
{
    class Kamera
    {
        private int nrCam;
        private Capture capture;
        private Filters filters = new Filters();
        private PictureBox pic;
        private Settings konf;
        private uint nrZdjecia;
        private string poprzednieImie;

        public Kamera(int p_2)
        {
            this.nrCam = p_2;
        }

        internal void Start(PictureBox picPreview)
        {
            this.pic = picPreview;
            capture = new Capture(filters.VideoInputDevices[nrCam], filters.AudioInputDevices[0]);
            capture.PreviewWindow = picPreview;
            capture.FrameEvent2 += new Capture.HeFrame(CaptureOK);
            capture.GrapImg();
        }

        internal void Stop()
        {
            capture.PreviewWindow = null;
        }

        internal void ZrobPstryk()
        {
            konf = new Settings();
            if (!string.IsNullOrEmpty(konf.Path))
            {
                try
                {
                    pic.Image.Save(konf.Path + "\\" + DateTime.Now.ToString().Replace(":", "") + ".jpg", ImageFormat.Jpeg);
                }
                catch
                {
                    MessageBox.Show("Nastąpiła próba zapisu do folderu bez uprawnień. Zmień folder albo uruchom aplikację z prawami administratora.", "Nieprawdiłowa lokalizacja", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void CaptureOK(Bitmap e)
        {
            pic.Image = e;
        }

        internal void ZrobPstryk(string p)
        {
            konf = new Settings();
            if (!string.IsNullOrEmpty(konf.Path))
            {
                if (p != poprzednieImie || poprzednieImie == null)
                {
                    try
                    {
                        pic.Image.Save(konf.Path + "\\" + p + ".jpg", ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Nastąpiła próba zapisu do folderu bez uprawnień. Zmień folder albo uruchom aplikację z prawami administratora.", "Nieprawdiłowa lokalizacja", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    poprzednieImie = p;
                    nrZdjecia = 0;
                }
                else
                {
                    try
                    {
                        pic.Image.Save(konf.Path + "\\" + p + "_" + nrZdjecia.ToString() + ".jpg", ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Nastąpiła próba zapisu do folderu bez uprawnień. Zmień folder albo uruchom aplikację z prawami administratora.", "Nieprawdiłowa lokalizacja", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    nrZdjecia++;
                }
            }
        }
    }
}