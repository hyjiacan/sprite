using System.Xml.Serialization;

namespace CssSprite
{
    public class SpriteImage
    {
        /// <summary>
        /// 图片路径
        /// </summary>
        [XmlAttribute("Path")]
        public string File { get; set; }

        /// <summary>
        /// 距离x轴
        /// </summary>
        [XmlAttribute("LocationX")]
        public int X { get; set; }

        /// <summary>
        /// 距离y轴
        /// </summary>
        [XmlAttribute("LocationY")]
        public int Y { get; set; }
    }
}
