using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_lapseDesktopCapturer
{
    class DesktopCapturer
    {
        private ImageProcessor _processor;

        public DesktopCapturer (ImageProcessor processor)
        {
            _processor = processor;
        }
        public void CaptureAndSaveDesktop (string path, ImageFormat format)
        {
            Bitmap image = Capture();
            image = _processor.Process(image);
            image.Save(path, format);
        }

        private Bitmap Capture ()
        {
            Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(new Point(0, 0), new Point(0, 0), bmp.Size);
            g.Dispose();
            return bmp;
        }

    }
}
