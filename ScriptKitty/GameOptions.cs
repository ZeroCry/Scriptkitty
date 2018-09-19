using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace ScriptKitty
{
    class GameOptionsYaml
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
            public List<types> Options { get; set; }
        }
        public class types
        {
            public List<string> ValidFor { get; set; }
            public string DecayTime { get; set; }
            public string ProtectTime { get; set; }
            public string WipeTime { get; set; }
            public string ProtectDelay { get; set; }
            public string MaxStructures { get; set; }
            public string AntiGriefDistancePvE { get; set; }
            public string AntiGriefDistancePvP { get; set; }
            public string AntiGriefOresDistance { get; set; }
            public string AntiGriefOresZone { get; set; }
            public string EnableTrading { get; set; }
            public string EnableMaxBlockCount { get; set; }
            public string GroundedStructureSpawn { get; set; }
            public string AutoMinerDepletion { get; set; }
            public string TurretUndergroundCheck { get; set; }
            public string OriginAccessOthers { get; set; }
            public string DespawnEscapePod { get; set; }
            public string RegeneratePOIs { get; set; }
            public string DiffAmountOfOre { get; set; }
            public string DiffNumberOfDeposits { get; set; }
        }

        public static void WriteYaml(string Path, Root ConfigData)
        {
            File.WriteAllText(Path, "---\r\n");
            Serializer serializer = new SerializerBuilder()
                .Build();
            string WriteThis = serializer.Serialize(ConfigData);
            File.AppendAllText(Path, WriteThis);

        }
    }
}
