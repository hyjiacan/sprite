using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace CssSprite
{
    class Option
    {
        public string RecentSprite { get; set; }

        private readonly static string optionFile;

        static Option()
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "sprite");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            optionFile = Path.Combine(path, "sprite-option.json");
        }

        public static Option Load()
        {
            if (!File.Exists(optionFile))
            {
                return new Option();
            }
            var content = File.ReadAllText(optionFile);
            return new JavaScriptSerializer().Deserialize<Option>(content);
        }

        public void Save()
        {
            File.WriteAllText(optionFile, new JavaScriptSerializer().Serialize(this));
        }
    }
}
