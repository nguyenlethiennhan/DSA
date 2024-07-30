using Newtonsoft.Json;
using System.IO;
using System.Reflection;

namespace DSA.Tests.Unit.Helpers
{
    /// <summary>
    /// Json extensions
    /// </summary>
    public static class JsonHelpers
    {
        /// <summary>
        /// Loads data from a JSON file located at the specified relative path and deserializes it into an object of type <typeparamref name="T"/>.
        /// </summary>
        public static T LoadData<T>(string path)
        {
            string exePath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string filePath = exePath + path;
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
