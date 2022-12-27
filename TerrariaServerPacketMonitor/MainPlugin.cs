using Newtonsoft.Json;
using Terraria;
using TerrariaApi.Server;
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
        public MainPlugin(Main game) : base(game)
        {
        }

        public override void Initialize()
        {
            ServerApi.Hooks.NetSendBytes.Register(this, OnNetSendBytes);
            ServerApi.Hooks.NetGetData.Register(this, OnNetGetData);
            Commands.ChatCommands.Add(new Command("", analyze, "ana"));
        }

        private void analyze(CommandArgs args)
        {
            //c
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
            {//
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
            var data = Receive.Find(x => x.Type == args.MsgID);
            if ( data== null)
            {
                Receive.Add(new Packet() { Type = args.MsgID, Count = 1, TotalBytes = args.Msg.totalData, Name = args.MsgID.ToString() });
            }
            else
            {
                data.Count++;
                data.TotalBytes += args.Msg.totalData;
            }
        }

        private void OnNetSendBytes(SendBytesEventArgs args)
        {
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
        }
    }
}