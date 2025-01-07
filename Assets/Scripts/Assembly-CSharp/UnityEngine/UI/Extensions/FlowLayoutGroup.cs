using System.Collections.Generic;

namespace UnityEngine.UI.Extensions
{
	public class FlowLayoutGroup : LayoutGroup
	{
		public enum POIEJPMRLNT
		{
			Horizontal = 0,
			Vertical = 1
		}

		public float SpacingX;

		public float SpacingY;

		public bool ExpandHorizontalSpacing;

		public bool ChildForceExpandWidth;

		public bool ChildForceExpandHeight;

		public bool invertOrder;

		private float MKKISMEETTS;

		private float RPEJRQPMEQP;

		[SerializeField]
		protected POIEJPMRLNT m_StartAxis;

		private readonly IList<RectTransform> EFMIFMRIQGT;

		public POIEJPMRLNT RPHFHRTIHIP
		{
			get
			{
				return default(POIEJPMRLNT);
			}
			set
			{
			}
		}

		protected bool PGSJORNHLOS => false;

		protected bool KJIKJHMIGME => false;

		protected bool PTKLJLLSEOQ => false;

		protected bool IGGQHQONOFF => false;

		public override void CalculateLayoutInputHorizontal()
		{
		}

		public override void SetLayoutHorizontal()
		{
		}

		public override void SetLayoutVertical()
		{
		}

		public override void CalculateLayoutInputVertical()
		{
		}

		public float SetLayout(int ITLRFOTENSF, bool SMMHKFHKJGH)
		{
			return 0f;
		}

		private float PMJMLEQHJKK(float SSHKPRHFTFS, float TRFSHORGMLK, float KLGJOPGOGGQ)
		{
			return 0f;
		}

		private float KEJKENOHQPG(float GNQIIORFSNL, float RQRGROSKHRK, float IHPLHGFJTSS)
		{
			return 0f;
		}

		protected void HISLRHOLPMQ(IList<RectTransform> NOTLJQMMOTT, float MKNQFJKOTJQ, float QJOIPISJFNN, float KROEFKOSHQJ, float RQRGROSKHRK, float TRFSHORGMLK, int ITLRFOTENSF)
		{
		}

		protected void HSHJMFJMFSN(IList<RectTransform> NOTLJQMMOTT, float KPQPRIGPHJP, float JGTIPSPQQGG, float HJKKLITMKQK, float RQRGROSKHRK, float TRFSHORGMLK, int ITLRFOTENSF)
		{
		}

		public float GetGreatestMinimumChildWidth()
		{
			return 0f;
		}

		public float GetGreatestMinimumChildHeigth()
		{
			return 0f;
		}
	}
}
