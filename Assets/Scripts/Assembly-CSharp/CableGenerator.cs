using System;
using System.Collections.Generic;
using UnityEngine;

public class CableGenerator : MonoBehaviour
{
	[Serializable]
	public struct Settings
	{
		public Vector2 slack;

		public Vector2 distance;

		public Vector2 yDistance;

		public Vector2 angleLimit;

		public Vector2 yAxisLimit;

		public float minYToCrossX;

		public int maxConnections;

		public float chance;

		public bool dontGoThroughGround;

		public bool ignoreWithSameParent;

		public CableRenderer rendererPrefab;
	}

	[SerializeField]
	private Settings[] settings;

	private List<CableRenderer> QMTOGETKJTN;

	public void SetSettings(Settings[] IOPHTQGFKNP)
	{
	}

	public void Generate(Transform TGMQQEEIPJF)
	{
	}

	private void EEKENETHNSR(Settings IOPHTQGFKNP, CableConnection[] EKEKGEFQRET)
	{
	}

	private void GJNMMEJHOKI(CableConnection HHRGQEQGGIS, CableConnection ELEIPINNGGJ, Settings IOPHTQGFKNP)
	{
	}

	private bool PIROJIMMRHF(CableConnection HHRGQEQGGIS, CableConnection ELEIPINNGGJ, Settings IOPHTQGFKNP)
	{
		return false;
	}

	private bool MHIKTGRTREQ(CableConnection HHRGQEQGGIS, CableConnection ELEIPINNGGJ, Settings IOPHTQGFKNP)
	{
		return false;
	}

	private Vector2 NOSMMGNGISO(Vector3 HHRGQEQGGIS, Vector3 ELEIPINNGGJ, Settings IOPHTQGFKNP)
	{
		return default(Vector2);
	}

	private void EIISROMNIQT()
	{
	}
}
