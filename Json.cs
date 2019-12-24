using System.Web.Script.Serialization;

namespace CssSprite
{
    public static class Json
    {
        private static readonly JavaScriptSerializer serializer;
        static Json()
        {
            serializer = new JavaScriptSerializer();
        }

        public static string Encode(object obj)
        {
            return serializer.Serialize(obj);
        }

        public static T Decode<T>(string json)
        {
            return serializer.Deserialize<T>(json);
        }
    }
}
