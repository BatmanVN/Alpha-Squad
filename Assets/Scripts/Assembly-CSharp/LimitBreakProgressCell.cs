using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class LimitBreakProgressCell : MonoBehaviour
{
	public enum KHRPJTKRLTI
	{
		UPCOMMING = 0,
		CURRENT = 1,
		PREVIOUS = 2
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct PSGTOORRNER
	{
		public bool with_animation;
	}

	[SerializeField]
	private GameObject viewUpcomming;

	[SerializeField]
	private GameObject viewCurrent;

	[SerializeField]
	private GameObject viewPrevious;

	public KHRPJTKRLTI currentState;

	public void SetState(KHRPJTKRLTI MHNOIFFONJM, bool KQGHGPEKKTJ = false)
	{
	}

	public void SetCorner(bool SPIOGTNMPMG, bool SJFITENJTTP)
	{
	}

	private void KJTTLQSRKFN(GameObject FMGEHJFFJIS, bool SPIOGTNMPMG, bool SJFITENJTTP)
	{
	}

	[CompilerGenerated]
	internal static void SSLJTSNRMSN(GameObject FMGEHJFFJIS, ref PSGTOORRNER P_1)
	{
	}
}
