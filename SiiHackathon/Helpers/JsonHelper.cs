using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiiHackathon.Helpers
{
    internal class JsonHelper
    {
        public static string SerializeToJson(JsonSerializer serializer, object payload)
        {
            StringBuilder stringBuilder = new StringBuilder();
            using (var stringWriter = new StringWriter(stringBuilder))
            {
                serializer.Serialize(stringWriter, payload);
            }
            var jsonStr = stringBuilder.ToString();
            return jsonStr;
        }
    }
}
