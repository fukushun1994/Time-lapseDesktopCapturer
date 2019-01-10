using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_lapseDesktopCapturer
{
    class ImageProcessor
    {
        public class ProcessInfo
        {
            public double scale;
            public Size size;
            public bool useAbsoluteSize;
        }

        private ProcessInfo _info;

        public ImageProcessor (ProcessInfo info)
        {
            _info = info;
        }
        public Bitmap Process (Bitmap image)
        {
            Size newSize;
            if (_info.useAbsoluteSize)
            {
                newSize = _info.size;
            } else
            {
                newSize = new Size(
                    (int)(image.Size.Width  * _info.scale),
                    (int)(image.Size.Height * _info.scale));
            }
            image = new Bitmap(image, newSize);
            return image;
        }
    }
}
