using UnityEngine;

public class HeaderLevelStageCell : MonoBehaviour
{
	public enum QOHJGQNMEHS
	{
		CURRENT = 0,
		PREVIOUS = 1,
		NEXT = 2,
		FAILED = 3,
		UNSET = 4
	}

	public QOHJGQNMEHS state;

	[SerializeField]
	private GameObject previousState;

	[SerializeField]
	private GameObject currentState;

	[SerializeField]
	private GameObject nextState;

	[SerializeField]
	private GameObject failedState;

	public void SetState(QOHJGQNMEHS MHNOIFFONJM, bool KQGHGPEKKTJ = true)
	{
	}
}
