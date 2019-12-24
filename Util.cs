using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CssSprite
{
    static class Util
    {
        public static void MakePictureOffset(PictureBox picture, Keys key)
        {
            var keyDownPoint = new Point(picture.Location.X, picture.Location.Y);
            switch (key)
            {
                case Keys.Left:
                    if (keyDownPoint.X > 0)
                    {
                        keyDownPoint.X -= 1;
                    }
                    break;
                case Keys.Up:
                    if (keyDownPoint.Y > 0)
                    {
                        keyDownPoint.Y -= 1;
                    }
                    break;
                case Keys.Down:
                    keyDownPoint.Y += 1;
                    break;
                case Keys.Right:
                    keyDownPoint.X += 1;
                    break;
            }
            picture.Location = keyDownPoint;
        }

        /// <summary>
        /// 得到sass代码
        /// </summary>
        /// <param name="img">图片</param>
        /// <param name="left">左边距离</param>
        /// <param name="top">右边距离</param>
        /// <returns></returns>
        public static string GetSassCss(Image img, int left, int top, bool isSass, bool isPhone, string prefix)
        {
            ImageInfo imgInfo = (ImageInfo)img.Tag;
            var unit = "px";
            var sassPrefix = string.Empty;
            var lessPrefix = string.Empty;
            if (isPhone)
            {
                unit = "";
                lessPrefix = "@_";
                sassPrefix = "$_";
            }
            var _left = string.Empty;
            var _top = string.Empty;

            if (isSass || isPhone)
            {
                _left = left == 0 ? "0" : "0 " + "-{2}" + left.ToString() + unit;
                _top = top == 0 ? "0" : "0 " + "-{2}" + top.ToString() + unit;
            }
            else
            {
                _left = left == 0 ? "0" : (0 - left).ToString() + unit;
                _top = top == 0 ? "0" : (0 - top).ToString() + unit;
            }
            var imgHeight = isPhone ? img.Height.ToString() : img.Height.ToString() + unit;
            var imgWidth = isPhone ? img.Width.ToString() : img.Width.ToString() + unit;
            var str = "{0}" + prefix + GetCssName(imgInfo.Name) + "[height:{1}" + imgHeight + ";width:{1}" + imgWidth + ";" + "background-position:" + _left + " " + _top + ";]" + Environment.NewLine;
            if (isSass)
            {
                return string.Format(str, "@mixin ", sassPrefix, sassPrefix).Replace("[", "{").Replace("]", "}");
            }
            else
            {
                return string.Format(str, ".", lessPrefix, lessPrefix).Replace("[", "{").Replace("]", "}");
            }
        }

        public static string GetCssName(string imgName)
        {
            if (char.IsNumber(imgName[0]))
            {
                return "_" + imgName;
            }
            return imgName;
        }
    }
}
