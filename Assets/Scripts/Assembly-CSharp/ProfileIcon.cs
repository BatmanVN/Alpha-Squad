using System;
using System.Runtime.CompilerServices;

[Serializable]
public class ProfileIcon
{
	public enum LOQMGTKOSMM
	{
		Default = 0,
		Unknown = 1,
		Char1 = 2,
		Char2 = 3,
		Char3 = 4,
		Char4 = 5,
		Char5 = 6,
		Char6 = 7,
		Enemy1 = 8,
		Enemy2 = 9,
		Enemy4 = 10,
		Enemy5 = 11,
		Enemy6 = 12,
		Enemy7 = 13,
		Enemy9 = 14,
		Enemy16 = 15,
		Enemy19 = 16,
		Enemy20 = 17,
		Enemy22 = 18,
		Enemy23 = 19,
		Enemy24 = 20,
		CompleteCasinoWorld = 21,
		CompleteEpisode5 = 22,
		ReachMyBaseLevel10 = 23,
		BeatCommando10 = 24,
		BeatVeteran10 = 25,
		BeatChief10 = 26,
		AcquireEpicGear = 27,
		AcquireLegendaryWeapon = 28,
		Buy200Gems = 29,
		Buy50kCash = 30,
		Buy1000Gems = 31,
		Buy250kCash = 32,
		Frog = 33,
		VIP = 34
	}

	public enum PNQEKROLFPK
	{
		Default = 0,
		Unknown = 1,
		BeatFloor20 = 2,
		BeatFloor35 = 3,
		BeatFloor50 = 4,
		BeatFloor65 = 5,
		BeatFloor85 = 6,
		PurchaseElitePass = 7,
		PurchaseElitePassPlus = 8,
		VIP = 9,
		Buy2kGems = 10,
		Buy500kCash = 11,
		Frostbite = 12
	}

	[CompilerGenerated]
	private sealed class NSSTRMLFPFH
	{
		public LOQMGTKOSMM _id;

		internal bool _003CGetIcon_003Eb__0(ProfileIconSelectPopup.IconAvatar x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class NEJEMLTFSIP
	{
		public PNQEKROLFPK _frame;

		internal bool _003CGetFrame_003Eb__0(ProfileIconSelectPopup.FrameAvatar x)
		{
			return false;
		}
	}

	public LOQMGTKOSMM id;

	public PNQEKROLFPK frame;

	public static ProfileIconSelectPopup.IconAvatar EKIHLJFMQNM(LOQMGTKOSMM JOLIOOIMMQM)
	{
		return default(ProfileIconSelectPopup.IconAvatar);
	}

	public static ProfileIconSelectPopup.FrameAvatar QENPKOTOQGH(PNQEKROLFPK TEQIFGTMGRN)
	{
		return default(ProfileIconSelectPopup.FrameAvatar);
	}
}
