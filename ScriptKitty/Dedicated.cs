using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using YamlDotNet.Serialization;


namespace ScriptKitty
{
    class DedicatedYaml
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
            public Server ServerConfig { get; set; }
            public Game GameConfig { get; set; }
        }
        public class Server
        {
            public string Srv_Port { get; set; }
            public string Srv_Name { get; set; }
            public string Srv_Password { get; set; }
            public string Srv_MaxPlayers { get; set; }
            public string Srv_ReservePlayfields { get; set; }
            public string Srv_Description { get; set; }
            public string Srv_Public { get; set; }
            public string Srv_Visible { get; set; }
            public string Srv_OfficialPw { get; set; }
            public string AdminConfigFile { get; set; }
            public string Srv_StopPeriod { get; set; }
            public string Tel_Enabled { get; set; }
            public string Tel_Port { get; set; }
            public string Tel_Pwd { get; set; }
            public string EACActive { get; set; }
            public string SaveDirectory { get; set; }
            public string MaxAllowedSizeClass { get; set; }
            public string AllowedBlueprints { get; set; }
            public string HeartbeatServer { get; set; }
            public string HeartbeatClient { get; set; }
            public string LogFlags { get; set; }
            public string DisableSteamFamilySharing { get; set; }
            public string KickPlayerWithPing { get; set; }
            public string TimeoutBootingPfServer { get; set; }
        }
        public class Game
        {
            public string GameName { get; set; }
            public string Mode { get; set; }
            public string Seed { get; set; }
            public string CustomScenario { get; set; }
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
