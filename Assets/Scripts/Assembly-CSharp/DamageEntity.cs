using UnityEngine;

public abstract class DamageEntity : MonoBehaviour
{
	public virtual Vector3 GetPushForce()
	{
		return default(Vector3);
	}

	public virtual Vector3 GetRagdollPushForce()
	{
		return default(Vector3);
	}

	public virtual Ragdoll.FKHQTISHHSK GetRagdollArea()
	{
		return default(Ragdoll.FKHQTISHHSK);
	}

	public virtual LQJTRNFQISM GenerateHit()
	{
		return null;
	}
}
