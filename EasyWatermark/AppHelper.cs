using DevExpress.XtraGrid.Views.Grid;
using EasyResize.App.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace EasyWatermark
{
    public static class AppHelper
    {
        public static async Task<Bitmap> ResizeBitmapAsync(Bitmap bmp, int newWidth, int newHeight)
        {
            await Task.Delay(10);
            //1000x3000 => 4500/45000

            var actuallW = newWidth;
            var actualH = newHeight;

            if (bmp.Width < bmp.Height)
            {
                var percentW = (double)newWidth / bmp.Width;
                percentW = Math.Round(percentW, 2);
                actualH = Convert.ToInt32(bmp.Height * percentW);
            }
            else
            {
                var percentH = (double)newHeight / bmp.Height;
                percentH = Math.Round(percentH, 2);

                actuallW = Convert.ToInt32(bmp.Width * percentH);
            }
            Bitmap result = new Bitmap(actuallW, actualH);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp, 0, 0, actuallW, actualH);
            }

            return result;
        }

        public static Bitmap GetBitmapFromFile(string fileName)
        {
            Bitmap img;
            using (var bmpTemp = new Bitmap(fileName))
            {
                img = new Bitmap(bmpTemp);
            }
            return img;
        }
        public static void ConfigureGlobalSettings(this GridView gridView)
        {
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView.OptionsSelection.MultiSelect = true;
            gridView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;
        }

        public static IEnumerable<T> GetSelectedItems<T>(this GridView gv) where T : class
        {
            var selectedRowHandles = gv.GetSelectedRows();
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                var selectedItem = gv.GetRow(selectedRowHandles[i]) as T;
                yield return selectedItem;
            }
        }

        public static readonly object SynchronizeObject = new object();
        public static Rectangle GetRectangle(AreaInfo cropInfo, Size targetSize)
        {
            int x = cropInfo.Area.X;
            int y = cropInfo.Area.Y;
            int width = cropInfo.Area.Width;
            int height = cropInfo.Area.Height;

            var viewSize = new Size(cropInfo.OriginalSize.Width, cropInfo.OriginalSize.Height);
            var tileWith = (double)targetSize.Width / viewSize.Width;
            var tileHeight = (double)targetSize.Height / viewSize.Height;

            x = (int)(x * tileWith);
            y = (int)(y * tileHeight);
            width = (int)(width * tileWith);
            height = (int)(height * tileHeight);

            Rectangle rect = new Rectangle(x, y, width, height);

            return rect;
        }
    }
}
