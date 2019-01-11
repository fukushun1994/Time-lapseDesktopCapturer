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
            Bitmap processedImage = _processor.Process(image);
            processedImage.Save(path, format);
            image.Dispose();
            processedImage.Dispose();
        }

        private Bitmap Capture ()
        {
            Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(new Point(0, 0), new Point(0, 0), bmp.Size);
            }
            return bmp;
        }

    }
}
