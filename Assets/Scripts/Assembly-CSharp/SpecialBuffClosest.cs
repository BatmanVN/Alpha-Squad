using UnityEngine;

public abstract class SpecialBuffClosest : SpecialActiveBase
{
	[SerializeField]
	protected int targets;

	[SerializeField]
	protected int maxRange;

	[SerializeField]
	protected bool immediate;

	protected bool IRRTNMSJSOQ;

	public override bool ShouldActivate()
	{
		return false;
	}

	protected override bool OFJHEIHEGIN()
	{
		return false;
	}

	protected override void MLHRFERJRGK()
	{
	}

	protected abstract void GLPOKMLOEJO(Enemy ETGMMEJFEOP);

	protected override void Awake()
	{
	}

	protected virtual bool OMHPMHSPEQS(Enemy QHSMPFPKNMM)
	{
		return false;
	}

	protected virtual float ONGSOTRPINS(Vector3 IRQKNOMQSKP)
	{
		return 0f;
	}
}
