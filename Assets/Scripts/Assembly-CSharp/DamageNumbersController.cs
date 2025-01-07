using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class DamageNumbersController : MonoBehaviour
{
	public enum QQOJILRKGLI
	{
		DEFAULT = 0,
		CRITICAL = 1,
		HEAL = 2,
		POISON = 3,
		MOD_DOT = 4
	}

	[Serializable]
	public struct HealthbarPrefab
	{
		public Healthbar.QMTLIKFKKSS type;

		public GameObject prefab;
	}

	public interface MGQKGPERQMN
	{
		void NGHFQRREIJN(Transform EESTGTGKLJG, string HETQTIKJGNI);

		void ROOROHMLQEM();

		bool PQTLMEOPQTH();

		QQOJILRKGLI MERLFLSSSSR();
	}

	private struct POSJGQNOTTS : MGQKGPERQMN
	{
		private const float TILORGLGTHQ = 0.125f;

		public QQOJILRKGLI EOOEIROQJOE;

		public Text HETQTIKJGNI;

		public RectTransform IERIISNIJFH;

		public float GOTJPHGLRKK;

		public Quaternion LTLRLJRMPER;

		public Quaternion QQRPNPTFJSH;

		public POSJGQNOTTS(QQOJILRKGLI ISLISTMNHST, GameObject GRMOIOOPGSL, DamageNumbersController QOHJJPRGGQP)
		{
			EOOEIROQJOE = default(QQOJILRKGLI);
			HETQTIKJGNI = null;
			IERIISNIJFH = null;
			GOTJPHGLRKK = 0f;
			LTLRLJRMPER = default(Quaternion);
			QQRPNPTFJSH = default(Quaternion);
		}

		public void NGHFQRREIJN(Transform EESTGTGKLJG, string GOLMTQHGEOJ)
		{
		}

		public void ROOROHMLQEM()
		{
		}

		public bool PQTLMEOPQTH()
		{
			return false;
		}

		public QQOJILRKGLI MERLFLSSSSR()
		{
			return default(QQOJILRKGLI);
		}
	}

	private struct NJJEMHJGTRG : MGQKGPERQMN
	{
		private const float TILORGLGTHQ = 0.7f;

		public QQOJILRKGLI EOOEIROQJOE;

		public Text HETQTIKJGNI;

		public RectTransform IERIISNIJFH;

		public float GOTJPHGLRKK;

		public NJJEMHJGTRG(QQOJILRKGLI ISLISTMNHST, GameObject GRMOIOOPGSL, DamageNumbersController QOHJJPRGGQP)
		{
			EOOEIROQJOE = default(QQOJILRKGLI);
			HETQTIKJGNI = null;
			IERIISNIJFH = null;
			GOTJPHGLRKK = 0f;
		}

		public void NGHFQRREIJN(Transform EESTGTGKLJG, string GOLMTQHGEOJ)
		{
		}

		public void ROOROHMLQEM()
		{
		}

		public bool PQTLMEOPQTH()
		{
			return false;
		}

		public QQOJILRKGLI MERLFLSSSSR()
		{
			return default(QQOJILRKGLI);
		}
	}

	private struct ORHTKRQTJEE : MGQKGPERQMN
	{
		private const float TILORGLGTHQ = 0.7f;

		public QQOJILRKGLI EOOEIROQJOE;

		public Text HETQTIKJGNI;

		public RectTransform IERIISNIJFH;

		public float GOTJPHGLRKK;

		public int GLGRLNQLHJL;

		public ORHTKRQTJEE(QQOJILRKGLI ISLISTMNHST, GameObject GRMOIOOPGSL, DamageNumbersController QOHJJPRGGQP)
		{
			EOOEIROQJOE = default(QQOJILRKGLI);
			HETQTIKJGNI = null;
			IERIISNIJFH = null;
			GOTJPHGLRKK = 0f;
			GLGRLNQLHJL = 0;
		}

		public void NGHFQRREIJN(Transform EESTGTGKLJG, string GOLMTQHGEOJ)
		{
		}

		public void ROOROHMLQEM()
		{
		}

		public bool PQTLMEOPQTH()
		{
			return false;
		}

		public QQOJILRKGLI MERLFLSSSSR()
		{
			return default(QQOJILRKGLI);
		}
	}

	private struct QSOLPNRTGES : MGQKGPERQMN
	{
		private const float TILORGLGTHQ = 0.7f;

		public QQOJILRKGLI EOOEIROQJOE;

		public Text HETQTIKJGNI;

		public RectTransform IERIISNIJFH;

		public Vector3 JSPTQJKOEPK;

		public float GOTJPHGLRKK;

		public QSOLPNRTGES(QQOJILRKGLI ISLISTMNHST, GameObject GRMOIOOPGSL, DamageNumbersController QOHJJPRGGQP)
		{
			EOOEIROQJOE = default(QQOJILRKGLI);
			HETQTIKJGNI = null;
			IERIISNIJFH = null;
			JSPTQJKOEPK = default(Vector3);
			GOTJPHGLRKK = 0f;
		}

		public void NGHFQRREIJN(Transform EESTGTGKLJG, string GOLMTQHGEOJ)
		{
		}

		public void ROOROHMLQEM()
		{
		}

		public bool PQTLMEOPQTH()
		{
			return false;
		}

		public QQOJILRKGLI MERLFLSSSSR()
		{
			return default(QQOJILRKGLI);
		}
	}

	[CompilerGenerated]
	private sealed class ENNITKGNLRS
	{
		public Transform t;

		internal void _003CSpawnHeadshotLabel_003Eb__0()
		{
		}
	}

	[SerializeField]
	private GameObject headshotPrefab;

	[SerializeField]
	private GameObject textPrefab;

	[SerializeField]
	private Color colorRegular;

	[SerializeField]
	private Color colorCritical;

	[SerializeField]
	private Color colorHeal;

	[SerializeField]
	private Color colorPoison;

	[SerializeField]
	private Color colorDot;

	[SerializeField]
	private List<HealthbarPrefab> healthbarPrefabs;

	public List<MGQKGPERQMN> animators;

	public void TestText(bool SPGQLQNQHEE, int NSQGRQMGOJS = 50, Transform ETGMMEJFEOP = null, ITKSRPQLPQN SKFPQTJLEGI = ITKSRPQLPQN.Poison)
	{
	}

	public void ShowDamageNumbers(Transform EESTGTGKLJG, LQJTRNFQISM EMERMLLSHSL, Actor NIHPIGRSJMO, bool QJPJRQMETPQ = true)
	{
	}

	private MGQKGPERQMN LRNPSNKIFSM(QQOJILRKGLI OGFKHSKTHHR)
	{
		return null;
	}

	public void SpawnText(Transform EESTGTGKLJG, string HETQTIKJGNI, QQOJILRKGLI OGFKHSKTHHR)
	{
	}

	private void Update()
	{
	}

	public void SpawnHeadshotLabel(Transform EESTGTGKLJG)
	{
	}

	public GameObject GetHealthbarPrefab(Healthbar.QMTLIKFKKSS EOOEIROQJOE)
	{
		return null;
	}
}
