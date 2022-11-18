using System.Drawing;

namespace EasyResize.App.Model
{
    public class AreaInfo
    {
        public AreaInfo(Rectangle area, Size originalSize)
        {
            Area = area;
            OriginalSize = originalSize;
        }
        public AreaInfo()
        {

        }

        public Rectangle Area { get; set; }

        public Size OriginalSize { get; set; }

        public bool IsExactSize { get; set; }
    }
}
