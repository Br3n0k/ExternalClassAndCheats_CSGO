using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbudon.Euphoric
{
    internal static class Offsets
    {
        public static Int32 dwClientState;
        public static Int32 dwClientState_GetLocalPlayer;
        public static Int32 dwClientState_IsHLTV;
        public static Int32 dwClientState_Map;
        public static Int32 dwClientState_MapDirectory;
        public static Int32 dwClientState_MaxPlayer;
        public static Int32 dwClientState_PlayerInfo;
        public static Int32 dwClientState_State;
        public static Int32 dwClientState_ViewAngles;
        public static Int32 m_dwClientState_LastOutgoingCommand = 0x4CA8;
        public static Int32 dwEntityList = 0x4C3C454;
        public static Int32 dwForceAttack = 0x307DB6C;
        public static Int32 dwForceAttack2 = 0x307DB78;
        public static Int32 dwGameDir;
        public static Int32 dwGameRulesProxy;
        public static Int32 dwGlobalVars;
        public static Int32 dwGlowObjectManager;
        public static Int32 dwInput;
        public static Int32 dwLocalPlayer = 0xC5F89C;
        public static Int32 dwPlayerResource;
        public static Int32 dwRadarBase = 0x507113C;
        public static Int32 dwSetClanTag;
        public static Int32 dw_SetConVar;
        public static Int32 dwViewMatrix = 0x4C2DE84;
        public static Int32 dwWeaponTable;
        public static Int32 dwWeaponTableIndex;
        public static Int32 dw_RevealRankFn;
        public static Int32 dwSendPackets;
        public static Int32 dwForceJump = 0x50DF118;
        public static Int32 LastOutGoingCommand;
        public static int dwEntityListLength;

        // Br3n0k
        public static int teste;
        public const Int32 m_dwInGame = 0x108;
        public const Int32 RadarBaseOffset = 0x507113C;
        public const Int32 m_iPlayerC4 = 0x165C;
        public const Int32 Flags = 0x100;
        public const Int32 bsendpacket = 0xD0B0A;
        public const Int32 SensivityAddressptr = 0xC650D8;
        public const Int32 SensivityAddress = 0xC65104;
        public const Int32 Callout = 0x3588;
        public const Int32 MoneySaved = 0xB238;
        public const Int32 DefuseC = 0x2998;
        public const Int32 DefuseL = 0x2994;
        public const Int32 TimerC = 0x2980;
        public const Int32 TimerL = 0x2984;
        public const Int32 Ticking = 0x2970;
        public const Int32 DefusingB = 0x299C;
        public const Int32 inBombZone = 0x38C8;
        public const Int32 Arming = 0x3390;
        public const Int32 Glow = 0x517B650;
        public const Int32 iGameResources = 0x307BECC;
        public const Int32 Punch = 0x301C;
        public const Int32 EngineAngles = 0x4D10;
        public const Int32 Left = 0x307DB48;
        public const Int32 Right = 0x307DB3C;
        public const Int32 Forward = 0x307DB30;
        public const Int32 Backward = 0x307DB24;
        public const Int32 ActiveWeapon = 0x2EE8;
        public const Int32 FlashMaxAlpha = 0xA304;
        public const Int32 EnginePointer = 0x588A2C;
        public const Int32 Flashed = 0xA308;
        public const Int32 Clip1 = 0x3234;
        public const Int32 Clip2 = 0x3238;
        public const Int32 ShotsFired = 0xA2C0;
        public const Int32 Jump = 0x50DF118;
        public const Int32 ArmsModel = 0x38EB;
        public const Int32 m_iItemDefinitionIndex = 0x2F9A;
        public const Int32 InReload = 0x3275;
        public const Int32 ReloadVC = 0x32FC;
        public const Int32 Invincible = 0x38A4;
        public const Int32 CompRank = 0x1A84;
        public const Int32 CompWins = 0x1B88;
        public const Int32 Scoped = 0x388E;
        public const Int32 BoneList = 0x2698;
        public const Int32 HasKit = 0xB25C;
        public const Int32 Arm = 0xB24C;
        public const Int32 Walking = 0x388F;
        public const Int32 Observer = 0x334C;

        public static Int32 dw_clientCmd;
        public static Int32 s_bOverridePostProcessingDisable;

        public static Int32 noarms;
        public static Int32 dw_CLobbyScreen;
        public static Int32 dw_AcceptMatch;
        public static Int32 dw_MatchAccepted;
        public static Int32 dw_MatchFound;

        public const Int32 m_bDormant = 0xE9;

             
        public const Int32 m_szArmsModel = 0x38D7;
        public const Int32 m_iHideHUD = 0x2FF4;
        public const Int32 m_viewFOV = 0x330C;
        public static Int32 CL_Move = 0x0D7E1000;


        public static Int32 m_hViewModel = 0x32DC;
        public static Int32 m_nModelIndex = 0x254;
        public static Int32 m_iViewModelIndex = 0x31E0;
        public static Int32 m_iWorldModelIndex = 0x31E4;
        public static Int32 m_iWorldDroppedModelIndex = 0x31E8;
        
    }

    public static class Netvars
    {
        public static Int32 m_ArmorValue;
        public static Int32 m_OriginalOwnerXuidHigh;
        public static Int32 m_OriginalOwnerXuidLow;
        public static Int32 m_aimPunchAngle;
        public static Int32 m_aimPunchAngleVel;
        public static Int32 m_bHasDefuser;
        public static Int32 m_bHasHelmet;
        public static Int32 m_bIsDefusing = 0x3898;
        public static Int32 m_bIsScoped;
        public static Int32 m_bSpotted = 0x939;
        public static Int32 m_bSpottedByMask = 0x97C;
        public static Int32 m_dwBoneMatrix;
        public static Int32 m_fFlags = 0x100;
        public static Int32 m_flFallbackWear;
        public static Int32 m_flFlashMaxAlpha;
        public static Int32 m_flNextPrimaryAttack;
        public static Int32 m_hActiveWeapon;
        public static Int32 m_hMyWeapons;
        public static Int32 m_hObserverTarget = 0x334C;
        public static Int32 m_hOwner;
        public static Int32 m_hOwnerEntity = 0x148;
        public static Int32 m_iAccountID;
        public static Int32 m_iClip1;
        public static Int32 m_iCompetitiveRanking;
        public static Int32 m_iCompetitiveWins;
        public static Int32 m_iCrosshairId = 0xB2B8;;
        public static Int32 m_iEntityQuality;
        public static Int32 m_iGlowIndex = 0xA320;
        public static Int32 m_iHealth = 0xFC;
        public static Int32 m_iItemDefinitionIndex;
        public static Int32 m_iItemIDHigh;
        public static Int32 m_iItemIDLow;
        public static Int32 m_iObserverMode;
        public static Int32 m_iShotsFired;
        public static Int32 m_iState;
        public static Int32 m_iTeamNum = 0xF0;
        public static Int32 m_lifeState = 0x25B;
        public static Int32 m_nFallbackPaintKit;
        public static Int32 m_nFallbackSeed;
        public static Int32 m_nFallbackStatTrak;
        public static Int32 m_nForceBone;
        public static Int32 m_nTickBase;
        public static Int32 m_szCustomName;
        public static Int32 m_szLastPlaceName;
        public static Int32 m_vecOrigin = 0x134;
        public static Int32 m_vecVelocity = 0x110;
        public static Int32 m_vecViewOffset = 0x104;
        public static Int32 m_viewPunchAngle;
        public static Int32 m_thirdPersonViewAngles;
        public static Int32 m_clrRender;
        public static Int32 m_zoomLevel;
        public static Int32 m_bDrawViewmodel;
        public static Int32 m_iFOVStart;
        public static Int32 m_iFOV = 0x31D4;
        public static Int32 m_flC4Blow = 0x31D8;
    }
}
