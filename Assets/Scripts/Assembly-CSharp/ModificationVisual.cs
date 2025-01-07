using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ModificationVisual : MonoBehaviour
{
	[Serializable]
	private class ModVisual
	{
		public NNFTTJERLEM type;

		public GameObject gameObject;

		public GameObject endFX;

		public Transform addTo;

		public bool useBones;

		public GameObject negativeVisual;

		public HumanBodyBones bone;

		public bool spawnForAll;

		public int maxCount;

		public bool onlyOneDisableEffect;
	}

	[CompilerGenerated]
	private sealed class MGIGIESSNTN
	{
		public NNFTTJERLEM mod;

		internal bool _003CGetModVisual_003Eb__0(ModVisual x)
		{
			return false;
		}

		internal bool _003CGetModVisual_003Eb__1(ModVisual x)
		{
			return false;
		}

		internal bool _003CGetModVisual_003Eb__2(ModVisual x)
		{
			return false;
		}

		internal bool _003CGetModVisual_003Eb__3(ModVisual x)
		{
			return false;
		}

		internal bool _003CGetModVisual_003Eb__4(ModVisual x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class KQLFPITTFHR
	{
		public NNFTTJERLEM mod;

		internal bool _003CTryGetActiveModVisual_003Eb__0(ModVisual x)
		{
			return false;
		}

		internal bool _003CTryGetActiveModVisual_003Eb__1(ModVisual x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class LEJSSSPSRRG
	{
		public NNFTTJERLEM mod;

		internal bool _003COnEffectVisualDespawn_003Eb__0(ModVisual x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class HJJQQTEKMOP
	{
		public Modifications.ModificationData moddata;

		internal bool _003CTryActivateCustomVisual_003Eb__0(ModVisual x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class MILFNLIIEFR
	{
		public ModificationVisual _003C_003E4__this;

		public int i;

		public Predicate<ModVisual> _003C_003E9__0;

		internal bool _003CKillAllCustomVisuals_003Eb__0(ModVisual x)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class PRJOFPFONOE
	{
		public Transform target;

		public ModificationVisual _003C_003E4__this;

		internal void _003CBlinkPlayer_003Eb__2()
		{
		}
	}

	[SerializeField]
	private List<ModVisual> modVisuals;

	[SerializeField]
	private float scale;

	private List<ModVisual> QIGOTOGRTII;

	private List<ModVisual> NIPGMGJTHQK;

	private List<NNFTTJERLEM> NLSNINSTJEK;

	private bool TPJLKSTPGTP;

	private ModVisual QEORRHRHFJK;

	private Modifications JKLQLMNJJJR;

	private Actor FNJLLHKNGOR;

	private Ragdoll KEOQJTFRHGJ;

	public void Setup(Modifications IOTHIKIHHLI, Actor FNJLLHKNGOR)
	{
	}

	private void OnDestroy()
	{
	}

	private void GIPHMHRSING(LQJTRNFQISM EMERMLLSHSL, Actor NIHPIGRSJMO)
	{
	}

	private void HESMIOLQQQI()
	{
	}

	private void NRNOFEPJQFO(Modifications.ModificationData TSSTJOIOFEF, bool PEJJOSEKFPK)
	{
	}

	private void ETLSTPFJSJR(Modifications.ModificationData TSSTJOIOFEF)
	{
	}

	private void ENJHMEHIEOI()
	{
	}

	private void Update()
	{
	}

	private void EPFKMKFGRMM(NNFTTJERLEM PFPFNLQONOG)
	{
	}

	private void LQLLTHPRKOT(NNFTTJERLEM PFPFNLQONOG, bool SPQFENISGHE = false)
	{
	}

	private void LQLLTHPRKOT(ModVisual QORNERSEGPL, NNFTTJERLEM PFPFNLQONOG, bool SPQFENISGHE, int PSPJIJNTMOI = 0)
	{
	}

	private ModVisual JSEISFGIGML(NNFTTJERLEM PFPFNLQONOG, bool SPQFENISGHE = false)
	{
		return null;
	}

	private bool JKKILSRIGOS(NNFTTJERLEM PFPFNLQONOG, bool SPQFENISGHE)
	{
		return false;
	}

	private ModVisual JGNFMSKMMOP(NNFTTJERLEM PFPFNLQONOG)
	{
		return null;
	}

	private ModVisual IGKQOPJIRKR(NNFTTJERLEM PFPFNLQONOG, bool SPQFENISGHE = false)
	{
		return null;
	}

	private void EFMFEEORQIG(NNFTTJERLEM PFPFNLQONOG, bool SPQFENISGHE = false)
	{
	}

	private void PPPGJTGPMJP(NNFTTJERLEM PFPFNLQONOG, bool SPQFENISGHE = false)
	{
	}

	private void FMSNFFROOLR(Modifications.ModificationData TSSTJOIOFEF)
	{
	}

	private void RFSTRMKHQGP()
	{
	}

	private void SJTTKKGTKGL(Transform ETGMMEJFEOP, float MKLLHHINHJP)
	{
	}
}
