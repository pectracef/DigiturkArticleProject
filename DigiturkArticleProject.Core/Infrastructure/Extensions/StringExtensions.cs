using DigiturkArticleProject.Core.Infrastructure.Encryption;
using Newtonsoft.Json;
using System;

namespace DigiturkArticleProject.Core.Infrastructure.Extensions
{
    public static class StringExtensions
    {
        public static string ToSHA256(this string rawData)
        {
            return Enigma.ComputeSHA256(rawData);
        }
        public static string ToSHA512(this string rawData)
        {
            return Enigma.ComputeSHA512(rawData);
        }
        public static string ToMD5(this string rawData)
        {
            return Enigma.ComputeMD5(rawData);
        }
        private static JsonSerializerSettings set = new JsonSerializerSettings()
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
        };
        public static string ToJson(this object model)
        {
            if (model != null)
                return JsonConvert.SerializeObject(model, set);
            else
                return null;
        }
        public static Model FromJson<Model>(this string jsonModel) where Model : class
        {
            if (!string.IsNullOrEmpty(jsonModel))
                return JsonConvert.DeserializeObject<Model>(jsonModel, set);
            else
                return Activator.CreateInstance<Model>();
        }
    }
}
