using LinqToDB;
using LinqToDB.Data;
using Newtonsoft.Json;
using System.Reflection;
using Terraria;
using TerrariaApi.Server;
using TerrariaServerPacketMonitor.Attr;
using TerrariaServerPacketMonitor.Database.Model;
using TShockAPI;

namespace TerrariaServerPacketMonitor
{
    [ApiVersion(2, 1)]
    public class MainPlugin : TerrariaPlugin
    {
        public override string Author => "Leader";
        public override string Description => "数据包监控";
        public override string Name => "TerrariaServerPacketMonitor";
        public override Version Version => new Version(1, 0, 0, 0);
        internal List<Packet> Receive { get; set; } = new List<Packet>();
        internal List<Packet> Send { get; set; } = new List<Packet>();
        internal static DataConnection DB { get; set; }
        public MainPlugin(Main game) : base(game)
        {
        }

        public override void Initialize()
        {
            ServerApi.Hooks.GameInitialize.Register(this, OnGameInitialize);
            ServerApi.Hooks.NetSendBytes.Register(this, OnNetSendBytes);
            ServerApi.Hooks.NetGetData.Register(this, OnNetGetData);
            Commands.ChatCommands.Add(new Command("", analyze, "ana"));
        }

        private void OnGameInitialize(EventArgs args)
        {
            // Database Initialize
            DB = new DataConnection(
                LinqToDB.DataProvider.SQLite.SQLiteTools.GetDataProvider(),
                new System.Data.SQLite.SQLiteConnectionStringBuilder()
                {
                    DataSource = Path.Combine(TShock.SavePath, "packet_analyze.sqlite"),
                    Pooling = true,
                    FailIfMissing = false
                }.ConnectionString);

            // Packet Table Initialize
            PacketModelHelper.InitializePacketTables();
        }

        private void analyze(CommandArgs args)
        {
            {
                Receive.Sort((x, y) => y.Count.CompareTo(x.Count));
                Send.Sort((x, y) => y.Count.CompareTo(x.Count));
                var text = JsonConvert.SerializeObject(new Analyze()
                {
                    TotalPackets = Receive.Select(x => x.Count).Sum() + Send.Select(x => x.Count).Sum(),
                    TotalBytes = Receive.Select(x => x.TotalBytes).Sum() + Send.Select(x => x.TotalBytes).Sum(),
                    Send = Send.ToArray(),
                    SendBytes = Send.Select(x => x.TotalBytes).Sum(),
                    SendPackets = Send.Select(x => x.Count).Sum(),
                    Receive = Receive.ToArray(),
                    ReceiveBytes = Receive.Select(x => x.TotalBytes).Sum(),
                    ReceivePackets = Receive.Select(x => x.Count).Sum()
                }, Formatting.Indented);
                File.WriteAllText("analyze_c.txt", text);
            }
            {
                Receive.Sort((x, y) => y.TotalBytes.CompareTo(x.TotalBytes));
                Send.Sort((x, y) => y.TotalBytes.CompareTo(x.TotalBytes));
                var text = JsonConvert.SerializeObject(new Analyze()
                {
                    TotalPackets = Receive.Select(x => x.Count).Sum() + Send.Select(x => x.Count).Sum(),
                    TotalBytes = Receive.Select(x => x.TotalBytes).Sum() + Send.Select(x => x.TotalBytes).Sum(),
                    Send = Send.ToArray(),
                    SendBytes = Send.Select(x => x.TotalBytes).Sum(),
                    SendPackets = Send.Select(x => x.Count).Sum(),
                    Receive = Receive.ToArray(),
                    ReceiveBytes = Receive.Select(x => x.TotalBytes).Sum(),
                    ReceivePackets = Receive.Select(x => x.Count).Sum()
                }, Formatting.Indented);
                File.WriteAllText("analyze_b.txt", text);
            }
            args.Player.SendSuccessMessage("数据包收发分析表已生成");
        }

        private void OnNetGetData(GetDataEventArgs args)
        {
            PacketModelHelper.InsertPacket(args.Msg.readBuffer.Skip(args.Index-3).Take(args.Length+2).ToArray(), true, args.Msg.whoAmI);

            #region Old Stuffs
            var data = Receive.Find(x => x.Type == args.MsgID);
            if (data == null)
            {
                Receive.Add(new Packet() { Type = args.MsgID, Count = 1, TotalBytes = args.Msg.totalData, Name = args.MsgID.ToString() });
            }
            else
            {
                data.Count++;
                data.TotalBytes += args.Msg.totalData;
            }
            #endregion
        }

        private void OnNetSendBytes(SendBytesEventArgs args)
        {
            // Assume Offset is 0 for better performance (X)
            // TODO: Switch to Span<byte> to avoid memory copy
            PacketModelHelper.InsertPacket(args.Buffer.Take(args.Count).ToArray(), false, args.Socket.Id);

            #region Old Stuffs
            var type = (PacketTypes)args.Buffer[2];
            var data = Send.Find(x => x.Type == type);
            if (data == null)
            {
                Send.Add(new Packet() { Type = type, Count = 1, TotalBytes = args.Count, Name = type.ToString() }); 
            }
            else
            {
                data.Count++;
                data.TotalBytes += args.Count;
            }
            #endregion
        }
    }
}