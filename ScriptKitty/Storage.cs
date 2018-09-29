using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Eleon.Modding;

namespace ScriptKitty
{
    class Storage
    {
        public class RequestData
        {
            public ChatInfo ChatInfo;
            public PlayerInfo TriggerPlayerInfo;
            public PlayerInfo TargetPlayerInfo;
            public StatisticsParam EventStatistics;
            public TraderNPCItemSoldInfo TraderSell;
            public Inventory ItemExchangeInventory;
            public DialogBoxData DialogBoxData;
            public GlobalStructureList GlobalStructsList;
            public IdStructureBlockInfo StructureBlockInfo;
            public PlayfieldEntityList PlayfieldEntities;
            public Id PlayerConnected;
            public Id PlayerDisconnected;
            public IdPlayfield PlayerChangePlayfield;
            public PlayfieldLoad PlayfieldLoaded;
            public PlayfieldLoad PlayfieldUnloaded;
            public FactionChangeInfo FactionChange;
            public StatisticsParam StatisticsParameters;
            public Id PlayerDisconnectedWaiting;
            public IdList PlayerList;
            public Inventory PlayerInventory;
            public ItemExchangeInfo ItemexchangeOnClose;
            public DialogBoxData DialogBoxOnClose;
            public IdCredits PlayerCredits;
            public Inventory GetRemoveInventory;
            public PlayfieldList PlayfieldList;
            public PlayfieldStats PlayfieldStats;
            public PlayfieldEntityList PlayfieldEntityList;
            public DediStats DediStats;
            public IdPositionRotation IdPosRot;
            public FactionInfoList FactionInfoList;
            public Id NewEntityId;
            public IdStructureBlockInfo IdStructBlockInfo;
            public AlliancesTable AlliancesTable;
            public AlliancesFaction AlliancesFaction;
            public BannedPlayerData BannedPlayerdata;
            public GameEventData PDAEventData;
            public ErrorInfo ErrorInfo;
            public PdaStateChange PDAStateChange;
            public ConsoleCommandInfo ConsoleCommandInfo;

        }
        public class Players
        {
            public string Playfield;
            public string EmpyrionID;
            public string Since;
        }
        public class Entities
        {
            public string EntityID;
            public string Name;
            public string Type;
            public bool AI;
            public string Playfield;
            public PString Coords;
            public int ticks;
        }

    }
}
