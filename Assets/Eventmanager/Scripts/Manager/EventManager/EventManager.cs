using System;
using System.Collections.Generic;
using _Game.Scripts.Manager.EventManager;
using _Game.Scripts.Manager.EventManager.DelegateObject;
//using _Game.THU.UI.Arsenal.Script.Arsenal_Cell_Item;
//using _Game.THU.UI.Arsenal.Script.FancyScrollView;
//using BulletStrike.API.SharedData.Models.Core;
//using BulletStrike.API.SharedData.Models.RequestData;
//using BulletStrike.API.SharedData.Models.ResponseData;
//using BulletStrike.ConfigData.Models;
using UnityEngine;
using UnityEngine.Serialization;
//using CharacterInfo = BulletStrike.ConfigData.Models.CharacterInfo;

[DefaultExecutionOrder(-100)]
public class EventManager : MonoSingleton<EventManager>
{

    //public DelegateObject<Func<Dictionary<int, List<EventData>>>> OnGetEventDataOnWeapons = new();
    public DelegateObject<Func<Dictionary<int, (string, string)>>> OnGetLocalizeOnWeapons = new();
    //public DelegateObject<Func<Dictionary<int, LocalizeData>>> OnGetLocalizeDatasWeapons = new();
    public DelegateObject<Action> GetWeaponLocalizePrice = new();

    //public DelegateObject<Func<List<WeaponInfo>>> GetWeaponInfosOwned = new();
    //public DelegateObject<Func<List<TurretInfo>>> GetTurretInfosOwned = new();
    //public DelegateObject<Func<List<SupporterInfo>>> GetSupporterInfosOwned = new();
    //public DelegateObject<Func<List<CharacterInfo>>> GetCharacterInfosOwned = new();
    //public DelegateObject<Func<List<TicketInfo>>> GetTicketInfosOwned = new();

    //public DelegateObject<Action<PopupBuyData>> ShowPopupBuyEquipmentDone = new();
    public DelegateCollection<Action> OnInitIAPDone = new();
    public DelegateObject<Action<bool>> OnActiveLoading = new();


    #region Arsenal

    public DelegateObject<Action> OnShowArsenalItemDetail = new();
    public DelegateObject<Action<int>> OnJumpToArsenalItem = new();
    public DelegateCollection<Action> OnPlayerPowerChange = new();
    public DelegateObject<Action<string, bool, Action>> ShowDownloadAssetBundleStatus = new();

    public DelegateObject<Action> OnReloadArsenalItem = new();

    public DelegateObject<Action> OnHidePopupEquipTicket = new();

    #endregion

    #region Arsenal Detail

    //public DelegateObject<Action<WeaponInfo>> OnLoadWeaponItemDetail = new();
    //public DelegateObject<Action<TurretInfo>> OnLoadTurretItemDetail = new();
    //public DelegateObject<Action<SupporterInfo>> OnLoadSupportItemDetail = new();
    public DelegateObject<Action<CharacterInfo>> OnLoadCharacterItemDetail = new();

    #endregion

    //public DelegateObject<Action<ArsenalTabType>> ChangeArsenalTabType = new();
    //public DelegateCollection<Action<ArsenalTabType>> ArsenalTabChanged = new();

    public DelegateObject<Action> OnCheckClosePopup = new();
    public DelegateObject<Action<bool[], bool[], bool[], int[], int>> SetDataOnPopupListMap = new();
    public DelegateCollection<Action<int>> OnTeleportMap = new();
    public DelegateCollection<Action> OnHidePopupListMap = new();
    public DelegateCollection<Action> OnShowPopupListMap = new();
    public DelegateCollection<Action<int>> CheckToggleIndexOn = new();
    public DelegateCollection<Action<int>> CheckToggleIndexOn2 = new();

    public DelegateCollection<Action> OnEquipCharacter = new();

    #region EventShop

    //public DelegateObject<Func<UpdateCashRequestData, HttpResponse<ClaimRewardsResponseData>>> OnExchangeEventReward = new();
    //public DelegateObject<Action<EventShopExchange>> OnExchangeReward = new();

    #endregion

    #region DailyQuestEvent

    //public DelegateObject<Action<QuestTabType>> ChangeQuestTabType = new();
    //public DelegateObject<Action> changeSprite = new();
    public DelegateCollection<Action> changes = new();


    #endregion

    #region ChirstmasEvent

    public DelegateCollection<Action> OnShowPopupGetGinger = new();
    public DelegateCollection<Action> OnHidePopupGetGinger = new();

    #endregion

    #region Leaderboard


    // public DelegateObject<Func<int, UniTask<HttpResponse<GetLeaderboardResponseData>>>> OnGetLeaderboardWorldAsync = new();
    // public DelegateObject<Action> OnShowPopupRankRewardDetail = new();
    // public DelegateObject<Action> OnHidePopupRankRewardDetail = new();

    public Action OnShowPopupRankRewardDetailDone;
    public Action OnHidePopupRankRewardDetailDone;

    #endregion
}