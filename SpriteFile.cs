using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CssSprite
{
    [XmlRoot("SpriteFile", Namespace = "CssSprite", IsNullable = false)]
    public class SpriteFile
    {
        [XmlAttribute("SrcPath")]
        public string SrcPath { get; set; }

        [XmlAttribute("ClassPrefix")]
        public string ClassPrefix { get; set; }

        [XmlAttribute("OrderBy")]
        public string OrderBy { get; set; }

        [XmlAttribute("Align")]
        public string Align { get; set; }

        [XmlAttribute("AutoAlign")]
        public bool AutoAlign { get; set; }

        [XmlAttribute("ImageName")]
        public string ImageName { get; set; }

        [XmlAttribute("IsPhone")]
        public bool IsPhone { get; set; }

        [XmlAttribute("PhoneFigure")]
        public string PhoneFigure { get; set; }

        [XmlAttribute("PhoneUnit")]
        public string PhoneUnit { get; set; }

        [XmlAttribute("SpriteImgFileType")]
        public string SpriteImgFileType { get; set; }

        [XmlArray("SpriteList")]
        public List<Sprite> SpriteList { get; set; }
    }
}
