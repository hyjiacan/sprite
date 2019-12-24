using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace CssSprite
{
    [XmlRoot("SpriteFile", Namespace = "CssSprite")]
    public class SpriteFile
    {
        [XmlAttribute]
        public string SrcPath { get; set; }

        [XmlAttribute]
        public string ClassPrefix { get; set; }

        [XmlAttribute]
        public string OrderBy { get; set; }

        [XmlAttribute]
        public string Align { get; set; }

        [XmlAttribute]
        public bool AutoAlign { get; set; }

        [XmlAttribute]
        public string ImageName { get; set; }

        [XmlAttribute]
        public bool IsPhone { get; set; }

        [XmlAttribute]
        public string PhoneFigure { get; set; }

        [XmlAttribute]
        public string PhoneUnit { get; set; }

        [XmlAttribute("SpriteImgFileType")]
        public string FileType { get; set; }

        [XmlArray("SpriteList")]
        [XmlArrayItem("Sprite", Type = typeof(SpriteImage))]
        public List<SpriteImage> Images { get; set; }

        public static SpriteFile Load(string filename)
        {
            try
            {
                return Json.Decode<SpriteFile>(File.ReadAllText(filename));
            }
            catch
            {
                // 老版本 xml 格式
                var stream = new MemoryStream(File.ReadAllBytes(filename));
                var serializer = new XmlSerializer(typeof(SpriteFile));
                object temp = serializer.Deserialize(stream);
                var sprite = (SpriteFile)temp;
                stream.Close();
                return sprite;
            }
        }
    }
}
