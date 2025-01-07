using System;
using UnityEngine;

[Serializable]
public class CableCurve
{
	[SerializeField]
	private Vector3 m_start;

	[SerializeField]
	private Vector3 m_end;

	[SerializeField]
	private float m_slack;

	[SerializeField]
	private int m_steps;

	[SerializeField]
	private bool m_regen;

	[SerializeField]
	private bool m_handles;

	private static Vector3[] emptyCurve;

	[SerializeField]
	private Vector3[] points;

	public bool drawHandles
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool regenPoints
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Vector3 start
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 end
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public float slack
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public int steps
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Vector3 midPoint => default(Vector3);

	public CableCurve()
	{
	}

	public CableCurve(CableCurve QPNIRNRNJON)
	{
	}

	public Vector3[] IMNFQSHHEMJ()
	{
		return null;
	}
}
