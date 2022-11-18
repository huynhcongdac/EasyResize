using System.Drawing;

namespace EasyResize.App.Model
{
    public class AppConfig
    {
        public string ImageFolder { get; set; }
        public string OutputFolder { get; set; }
        public Size NewSize { get; set; }
        public static AppConfig Default
        {
            get
            {
                return new AppConfig()
                {
                    OutputFolder = "",
                    ImageFolder = "",
                    NewSize = Size.Empty
                };
            }
        }
    }
}
