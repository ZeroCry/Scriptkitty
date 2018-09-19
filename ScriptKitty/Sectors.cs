using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using YamlDotNet.Serialization;


namespace ScriptKitty
{
    class SectorsYaml
    {
        public static Root Retrieve(String filePath)
        {
            var input = File.OpenText(filePath);
            var deserializer = new DeserializerBuilder()
                .IgnoreUnmatchedProperties()
                .Build();
            var Output = deserializer.Deserialize<Root>(input);
            return Output;
        }

        public class Root
        {
            public string Build { get; set; }
            public List<Sector> Sectors { get; set; }
        }
        public class Sector
        {
            public List<string> Coordinates { get; set; }
            public string Color { get; set; }
            public string Icon { get; set; }
            public string OrbitLine { get; set; }
            public string SectorMapType { get; set; }
            public List<string> Allow { get; set; }
            public List<string> Deny { get; set; }
            public List<List<string>> Playfields { get; set; }
        }

        public static void WriteYaml(string Path, Root ConfigData)
        {
            File.WriteAllText(Path, "---\r\n");
            Serializer serializer = new SerializerBuilder()
                .EmitDefaults()
                .Build();
            string WriteThis = serializer.Serialize(ConfigData);
            File.AppendAllText(Path, WriteThis);

        }
    }
}
