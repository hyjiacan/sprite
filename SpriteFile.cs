using System.Collections.Generic;

namespace CssSprite
{
    public class SpriteFile
    {
        public string SrcPath { get; set; }

        public string ClassPrefix { get; set; }

        public string OrderBy { get; set; }

        public string Align { get; set; }

        public bool AutoAlign { get; set; }

        public string ImageName { get; set; }

        public bool IsPhone { get; set; }

        public string PhoneFigure { get; set; }

        public string PhoneUnit { get; set; }

        public string FileType { get; set; }

        public List<SpriteImage> Images { get; set; }
    }
}
