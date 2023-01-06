using LinqToDB;
using System.Reflection;
using TerrariaServerPacketMonitor.Attr;
using TerrariaServerPacketMonitor.Database.Model.Packet;

namespace TerrariaServerPacketMonitor.Database.Model
{
    internal static class PacketModelHelper
    {
        private static readonly Lazy<Dictionary<int, Type>> MsgIDToModelMap = new(() =>
        {
            return Assembly.GetExecutingAssembly().GetTypes()
                .Where(x => x.GetCustomAttribute<PacketModelAttribute>() != null)
                .ToDictionary(x => x.GetCustomAttribute<PacketModelAttribute>()!.PacketID);
        });

        public static void InitializePacketTables()
        {
            var db = MainPlugin.DB;

            var map = MsgIDToModelMap.Value;

            foreach (var p in map)
            {
                // The below code actually is...
                // db.CreateTable<modelType>(tableOptions: TableOptions.CreateIfNotExists);
                typeof(DataExtensions).GetMethod("CreateTable")!
                    .MakeGenericMethod(p.Value)
                    .Invoke(null, new[]
                    {
                        db,                            // dataContext
                        Type.Missing,                  // tableName
                        Type.Missing,                  // databaseName
                        Type.Missing,                  // schemaName
                        Type.Missing,                  // statementHeader
                        Type.Missing,                  // statementFooter
                        Type.Missing,                  // defaultNullable
                        Type.Missing,                  // serverName
                        TableOptions.CreateIfNotExists // tableOptions
                    });
            }
        }

        public static void InsertPacket(byte[] data, bool isFromClient, int clientIndex = -1)
        {
            var db = MainPlugin.DB;
            var msgID = (PacketTypes)data[2];
            // Why did I write this sh*t? ofc for speed :P
            // Or is it necessary? ;-; I mean I have already used linq2db
            // TODO: Switch to Reflection in PacketModelAdapter.ParsePacket function
            switch (msgID)
            {
                case PacketTypes.ConnectRequest:
                    db.Insert(PacketConnectRequest.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.Disconnect:
                    db.Insert(PacketDisconnect.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.ContinueConnecting:
                    db.Insert(PacketContinueConnecting.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.PlayerInfo:
                    db.Insert(PacketPlayerInfo.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.PlayerSlot:
                    db.Insert(PacketPlayerSlot.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.ContinueConnecting2:
                    db.Insert(PacketContinueConnecting2.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.WorldInfo:
                    db.Insert(PacketWorldInfo.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.TileGetSection:
                    db.Insert(PacketTileGetSection.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.Status:
                    db.Insert(PacketStatus.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.TileSendSection:
                    db.Insert(PacketTileSendSection.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.TileFrameSection:
                    db.Insert(PacketTileFrameSection.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.PlayerSpawn:
                    db.Insert(PacketPlayerSpawn.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.PlayerUpdate:
                    db.Insert(PacketPlayerUpdate.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.PlayerActive:
                    db.Insert(PacketPlayerActive.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.PlayerHp:
                    db.Insert(PacketPlayerHp.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.Tile:
                    db.Insert(PacketTile.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.TimeSet:
                    db.Insert(PacketTimeSet.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.DoorUse:
                    db.Insert(PacketDoorUse.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.TileSendSquare:
                    db.Insert(PacketTileSendSquare.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.ItemDrop:
                    db.Insert(PacketItemDrop.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.ItemOwner:
                    db.Insert(PacketItemOwner.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.NpcUpdate:
                    db.Insert(PacketNpcUpdate.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.NpcItemStrike:
                    db.Insert(PacketNpcItemStrike.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.ProjectileNew:
                    db.Insert(PacketProjectileNew.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.NpcStrike:
                    db.Insert(PacketNpcStrike.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.ProjectileDestroy:
                    db.Insert(PacketProjectileDestroy.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.TogglePvp:
                    db.Insert(PacketTogglePvp.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.ChestGetContents:
                    db.Insert(PacketChestGetContents.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.ChestItem:
                    db.Insert(PacketChestItem.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.ChestOpen:
                    db.Insert(PacketChestOpen.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.PlaceChest:
                    db.Insert(PacketPlaceChest.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.EffectHeal:
                    db.Insert(PacketEffectHeal.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.Zones:
                    db.Insert(PacketZones.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.PasswordRequired:
                    db.Insert(PacketPasswordRequired.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.PasswordSend:
                    db.Insert(PacketPasswordSend.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.RemoveItemOwner:
                    db.Insert(PacketRemoveItemOwner.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.NpcTalk:
                    db.Insert(PacketNpcTalk.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.PlayerAnimation:
                    db.Insert(PacketPlayerAnimation.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.PlayerMana:
                    db.Insert(PacketPlayerMana.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.EffectMana:
                    db.Insert(PacketEffectMana.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.PlayerTeam:
                    db.Insert(PacketPlayerTeam.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.SignRead:
                    db.Insert(PacketSignRead.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.SignNew:
                    db.Insert(PacketSignNew.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.LiquidSet:
                    db.Insert(PacketLiquidSet.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.PlayerSpawnSelf:
                    db.Insert(PacketPlayerSpawnSelf.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.PlayerBuff:
                    db.Insert(PacketPlayerBuff.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.NpcSpecial:
                    db.Insert(PacketNpcSpecial.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.ChestUnlock:
                    db.Insert(PacketChestUnlock.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.NpcAddBuff:
                    db.Insert(PacketNpcAddBuff.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.NpcUpdateBuff:
                    db.Insert(PacketNpcUpdateBuff.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.PlayerAddBuff:
                    db.Insert(PacketPlayerAddBuff.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.UpdateNPCName:
                    db.Insert(PacketUpdateNPCName.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.UpdateGoodEvil:
                    db.Insert(PacketUpdateGoodEvil.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.PlayHarp:
                    db.Insert(PacketPlayHarp.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.HitSwitch:
                    db.Insert(PacketHitSwitch.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.UpdateNPCHome:
                    db.Insert(PacketUpdateNPCHome.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.SpawnBossorInvasion:
                    db.Insert(PacketSpawnBossorInvasion.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.PlayerDodge:
                    db.Insert(PacketPlayerDodge.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.PaintTile:
                    db.Insert(PacketPaintTile.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.PaintWall:
                    db.Insert(PacketPaintWall.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.Teleport:
                    db.Insert(PacketTeleport.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.PlayerHealOther:
                    db.Insert(PacketPlayerHealOther.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.Placeholder:
                    db.Insert(PacketPlaceholder.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.ClientUUID:
                    db.Insert(PacketClientUUID.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.ChestName:
                    db.Insert(PacketChestName.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.CatchNPC:
                    db.Insert(PacketCatchNPC.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.ReleaseNPC:
                    db.Insert(PacketReleaseNPC.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.TravellingMerchantInventory:
                    db.Insert(PacketTravellingMerchantInventory.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.TeleportationPotion:
                    db.Insert(PacketTeleportationPotion.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.AnglerQuest:
                    db.Insert(PacketAnglerQuest.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.CompleteAnglerQuest:
                    db.Insert(PacketCompleteAnglerQuest.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.NumberOfAnglerQuestsCompleted:
                    db.Insert(PacketNumberOfAnglerQuestsCompleted.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.CreateTemporaryAnimation:
                    db.Insert(PacketCreateTemporaryAnimation.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.ReportInvasionProgress:
                    db.Insert(PacketReportInvasionProgress.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.PlaceObject:
                    db.Insert(PacketPlaceObject.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.SyncPlayerChestIndex:
                    db.Insert(PacketSyncPlayerChestIndex.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.CreateCombatText:
                    db.Insert(PacketCreateCombatText.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.LoadNetModule:
                    db.Insert(PacketLoadNetModule.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.NpcKillCount:
                    db.Insert(PacketNpcKillCount.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.PlayerStealth:
                    db.Insert(PacketPlayerStealth.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.ForceItemIntoNearestChest:
                    db.Insert(PacketForceItemIntoNearestChest.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.UpdateTileEntity:
                    db.Insert(PacketUpdateTileEntity.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.PlaceTileEntity:
                    db.Insert(PacketPlaceTileEntity.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.TweakItem:
                    db.Insert(PacketTweakItem.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.PlaceItemFrame:
                    db.Insert(PacketPlaceItemFrame.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.UpdateItemDrop:
                    db.Insert(PacketUpdateItemDrop.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.EmoteBubble:
                    db.Insert(PacketEmoteBubble.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.SyncExtraValue:
                    db.Insert(PacketSyncExtraValue.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.SocialHandshake:
                    db.Insert(PacketSocialHandshake.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.Deprecated:
                    db.Insert(PacketDeprecated.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.KillPortal:
                    db.Insert(PacketKillPortal.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.PlayerTeleportPortal:
                    db.Insert(PacketPlayerTeleportPortal.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.NotifyPlayerNpcKilled:
                    db.Insert(PacketNotifyPlayerNpcKilled.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.NotifyPlayerOfEvent:
                    db.Insert(PacketNotifyPlayerOfEvent.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.UpdateMinionTarget:
                    db.Insert(PacketUpdateMinionTarget.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.NpcTeleportPortal:
                    db.Insert(PacketNpcTeleportPortal.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.UpdateShieldStrengths:
                    db.Insert(PacketUpdateShieldStrengths.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.NebulaLevelUp:
                    db.Insert(PacketNebulaLevelUp.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.MoonLordCountdown:
                    db.Insert(PacketMoonLordCountdown.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.NpcShopItem:
                    db.Insert(PacketNpcShopItem.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.GemLockToggle:
                    db.Insert(PacketGemLockToggle.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.PoofOfSmoke:
                    db.Insert(PacketPoofOfSmoke.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.SmartTextMessage:
                    db.Insert(PacketSmartTextMessage.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.WiredCannonShot:
                    db.Insert(PacketWiredCannonShot.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.MassWireOperation:
                    db.Insert(PacketMassWireOperation.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.MassWireOperationPay:
                    db.Insert(PacketMassWireOperationPay.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.ToggleParty:
                    db.Insert(PacketToggleParty.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.TreeGrowFX:
                    db.Insert(PacketTreeGrowFX.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.CrystalInvasionStart:
                    db.Insert(PacketCrystalInvasionStart.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.CrystalInvasionWipeAll:
                    db.Insert(PacketCrystalInvasionWipeAll.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.MinionAttackTargetUpdate:
                    db.Insert(PacketMinionAttackTargetUpdate.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.CrystalInvasionSendWaitTime:
                    db.Insert(PacketCrystalInvasionSendWaitTime.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.PlayerHurtV2:
                    db.Insert(PacketPlayerHurtV2.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.PlayerDeathV2:
                    db.Insert(PacketPlayerDeathV2.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.CreateCombatTextExtended:
                    db.Insert(PacketCreateCombatTextExtended.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.Emoji:
                    db.Insert(PacketEmoji.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.TileEntityDisplayDollItemSync:
                    db.Insert(PacketTileEntityDisplayDollItemSync.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.RequestTileEntityInteraction:
                    db.Insert(PacketRequestTileEntityInteraction.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.WeaponsRackTryPlacing:
                    db.Insert(PacketWeaponsRackTryPlacing.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.TileEntityHatRackItemSync:
                    db.Insert(PacketTileEntityHatRackItemSync.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.SyncTilePicking:
                    db.Insert(PacketSyncTilePicking.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.SyncRevengeMarker:
                    db.Insert(PacketSyncRevengeMarker.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.RemoveRevengeMarker:
                    db.Insert(PacketRemoveRevengeMarker.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.LandGolfBallInCup:
                    db.Insert(PacketLandGolfBallInCup.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.FinishedConnectingToServer:
                    db.Insert(PacketFinishedConnectingToServer.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.FishOutNPC:
                    db.Insert(PacketFishOutNPC.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.TamperWithNPC:
                    db.Insert(PacketTamperWithNPC.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.PlayLegacySound:
                    db.Insert(PacketPlayLegacySound.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.FoodPlatterTryPlacing:
                    db.Insert(PacketFoodPlatterTryPlacing.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.UpdatePlayerLuckFactors:
                    db.Insert(PacketUpdatePlayerLuckFactors.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.DeadPlayer:
                    db.Insert(PacketDeadPlayer.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.SyncCavernMonsterType:
                    db.Insert(PacketSyncCavernMonsterType.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.RequestNPCBuffRemoval:
                    db.Insert(PacketRequestNPCBuffRemoval.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.ClientSyncedInventory:
                    db.Insert(PacketClientSyncedInventory.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.SetCountsAsHostForGameplay:
                    db.Insert(PacketSetCountsAsHostForGameplay.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.SetMiscEventValues:
                    db.Insert(PacketSetMiscEventValues.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.RequestLucyPopup:
                    db.Insert(PacketRequestLucyPopup.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.SyncProjectileTrackers:
                    db.Insert(PacketSyncProjectileTrackers.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.CrystalInvasionRequestedToSkipWaitTime:
                    db.Insert(PacketCrystalInvasionRequestedToSkipWaitTime.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.RequestQuestEffect:
                    db.Insert(PacketRequestQuestEffect.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.SyncItemsWithShimmer:
                    db.Insert(PacketSyncItemsWithShimmer.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.ShimmerActions:
                    db.Insert(PacketShimmerActions.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.SyncLoadout:
                    db.Insert(PacketSyncLoadout.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                case PacketTypes.SyncItemCannotBeTakenByEnemies:
                    db.Insert(PacketSyncItemCannotBeTakenByEnemies.Parse(data).FillPacketInfo(data, isFromClient, clientIndex));
                    break;

                // TODO: PacketIDNotFoundException
            }
        }

        private static T FillPacketInfo<T>(this T packet, byte[] data, bool isFromClient, int clientIndex = -1) where T : PacketModelBase
        {
            packet.IsFromClient = isFromClient;
            packet.ClientIndex = clientIndex;
            packet.Data = data;
            packet.Size = data.Length;
            packet.TimeStamp = DateTime.Now;
            return packet;
        }
    }
}