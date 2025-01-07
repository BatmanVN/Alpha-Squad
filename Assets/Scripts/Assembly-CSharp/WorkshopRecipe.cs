using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu]
public class WorkshopRecipe : ScriptableObject
{
	public enum NOMPPKKTNOF
	{
		GEAR = 0,
		RESOURCES = 1
	}

	public enum TROEOHQQSPR
	{
		CREATE = 0,
		UPGRADE = 1,
		TRANSFORM = 2,
		FUSE = 3
	}

	[CompilerGenerated]
	private sealed class HQJEJSQSHGK
	{
		public LootElement le;

		internal bool _003CIsOptional_003Eb__0(WorkshopRecipeRequirement x)
		{
			return false;
		}
	}

	public PJLTIFIPFSM id;

	public NOMPPKKTNOF category;

	public TROEOHQQSPR subCategory;

	public int unlockLevel;

	public int xpReward;

	[SerializeField]
	private int cashPrice;

	public bool dynamicRequirement;

	public bool autoMaxToggle;

	public bool mergeAllowed;

	[Space]
	public List<WorkshopRecipeRequirement> requirements;

	[Space]
	public List<WorkshopRecipeRequirement> optionalRequirements;

	[Space]
	public List<WorkshopRecipeReward> rewards;

	public int HMPHTLSQQLG(out bool KMQQJMRNOEN)
	{
		KMQQJMRNOEN = default(bool);
		return 0;
	}

	public int SFTOFTMMHQR()
	{
		return 0;
	}

	public bool QFKRKGKRPPP()
	{
		return false;
	}

	public bool RJPEKRPOMRT()
	{
		return false;
	}

	public bool LHTHKTERJNT()
	{
		return false;
	}

	public bool ORTEJHIRLLH()
	{
		return false;
	}

	public bool PQFFPPFGPPL(LootElement INNLJIGRFOG)
	{
		return false;
	}

	public int LLNRKKERINF(LootElement INNLJIGRFOG)
	{
		return 0;
	}
}
