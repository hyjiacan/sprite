using System.Drawing;

namespace CssSprite
{
    class ImageInfo
    {
        internal ImageInfo(Image img, string name, string fileName)
        {
            Image = img;
            Name = name;
            FileName = fileName;
        }

        internal readonly Image Image;
        internal readonly string Name;
        internal readonly string FileName;
    }
}
