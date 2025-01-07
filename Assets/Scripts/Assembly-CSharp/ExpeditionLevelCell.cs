using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Expedition;
using UnityEngine;
using UnityEngine.UI;

public class ExpeditionLevelCell : MonoBehaviour
{
	public enum NFEPKPJRTFK
	{
		COMPLETED = 0,
		LOCKED = 1,
		CURRENT = 2,
		BOSS = 3,
		CLAIMING = 4
	}

	[Serializable]
	public struct ImageSet
	{
		public NFEPKPJRTFK state;

		public Sprite floor0;

		public Sprite floor1;

		public Sprite background;

		public Sprite lift0;

		public Sprite lift1;

		public Color levelBlock;
	}

	[CompilerGenerated]
	private sealed class FKNGLIPQKRF
	{
		public NFEPKPJRTFK tstate;

		internal bool _003CInitVisual_003Eb__0(ImageSet x)
		{
			return false;
		}
	}

	public Transform standLocation;

	[Space]
	[SerializeField]
	private RectTransform internalBlock;

	[SerializeField]
	private GameObject lockElement;

	[SerializeField]
	private GameObject top;

	[SerializeField]
	private Text labelLevel;

	[SerializeField]
	private Text labelCompleted;

	[SerializeField]
	private ExpeditionLevelRewardList rewardsList;

	[SerializeField]
	private Image reflection;

	[SerializeField]
	private Animator lockAnimator;

	[Space]
	[SerializeField]
	private GameObject viewRegular;

	[SerializeField]
	private GameObject viewCompleted;

	[Space]
	[SerializeField]
	private GameObject roof;

	[SerializeField]
	private Image roofRewardIcon;

	[SerializeField]
	private Image roofBeamLeft;

	[SerializeField]
	private Image roofBeamRight;

	[SerializeField]
	private Image floor0;

	[SerializeField]
	private Image floor1;

	[SerializeField]
	private Image background;

	[SerializeField]
	private Image lift0;

	[SerializeField]
	private Image lift1;

	[SerializeField]
	private Image levelBlock;

	[Space]
	[SerializeField]
	private GameObject lockRegular;

	[SerializeField]
	private GameObject lockBoss;

	[SerializeField]
	private GameObject lockBossFinal;

	[Space]
	[SerializeField]
	private GameObject effectRegular;

	[SerializeField]
	private GameObject effectBoss;

	[SerializeField]
	private GameObject effectBossFinal;

	[SerializeField]
	private GameObject blockXp;

	[SerializeField]
	private GameObject blockPassXp;

	[SerializeField]
	private Text labelXp;

	[SerializeField]
	private Text labelPassXp;

	[SerializeField]
	private GameObject blockXpClaimed;

	[SerializeField]
	private GameObject blockPassXpClaimed;

	[SerializeField]
	private GameObject blockAllXp;

	[NonSerialized]
	public int levelIndex;

	[SerializeField]
	public List<ImageSet> images;

	[NonSerialized]
	public int level;

	private NFEPKPJRTFK MJPJLPIKQFE;

	private bool SPELFKQJMIJ;

	private bool LIQGLGKPMPE;

	private ExpeditionPanel TGSOSNJRHGI;

	public void Setup(int IQLQQNIPTPQ, NFEPKPJRTFK MHNOIFFONJM, bool SPELFKQJMIJ, bool LIQGLGKPMPE, ExpeditionPanel FNJLLHKNGOR, bool OILQFNNMNKE = true, bool EJTJSNIIGMH = true)
	{
	}

	public void InitRoof(Sprite ITRKNMFTGIG)
	{
	}

	private void KSKOOOKSEIO(bool OILQFNNMNKE)
	{
	}

	private void NPMTRSPRLNL()
	{
	}

	public void PrepareAnimationUnlock()
	{
	}

	public void AnimateUnlock()
	{
	}

	public Sequence AnimateClaim()
	{
		return null;
	}

	public void OnLockAnimatorDone()
	{
	}

	public static NFEPKPJRTFK DetermineState(int EERLMHFHHTN, int MOMMNSSRRTJ, int RHEJTJTESTS, int JKPIHSJETIN, ExpeditionData.ExpeditionLevel EORKIGQSHKF)
	{
		return default(NFEPKPJRTFK);
	}

	public NFEPKPJRTFK GetState()
	{
		return default(NFEPKPJRTFK);
	}

	public Tween PlayAppearAnim(float OGFKHSKTHHR, float PRRKGRQILFR)
	{
		return null;
	}
}
