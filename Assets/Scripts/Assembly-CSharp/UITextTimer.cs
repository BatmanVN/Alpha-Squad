using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UITextTimer : MonoBehaviour
{
	public enum JFNLHHQINNM
	{
		SECONDS = 0,
		MINUTES = 1,
		HOURS = 2,
		DAYS = 3,
		MAJOR_MINOR = 4,
		CUSTOM = 5
	}

	[Serializable]
	public struct ColorStyle
	{
		public int secondsLeft;

		public Color color;
	}

	public List<ColorStyle> colorStyles;

	public JFNLHHQINNM format;

	[SerializeField]
	private int notationCount;

	public string formattingString;

	private string GHHPGFOFEMG;

	public UnityEvent OnTimerUp;

	public UnityEvent OnTimerUpdate;

	public Text label;

	private double KTHQKRMHPST;

	private int PPEQOSTHHOF;

	private bool OHSTNNRPQKE;

	private bool KNORFFGOHMJ;

	public string colorCustomDaysNumber;

	private bool GERTMJNQOIH;

	private float LOTTPTILFFM;

	private void Start()
	{
	}

	private void OKILHMKKETP()
	{
	}

	public void InitTimer(int HNMPLNRTRHH)
	{
	}

	public void InitTimer(long HNMPLNRTRHH)
	{
	}

	public void SetTimeMultiplier(float OGFKHSKTHHR)
	{
	}

	public void StopUpdating()
	{
	}

	public void SetDontChangeSize()
	{
	}

	private void Update()
	{
	}

	private void IHIENOSQRSO()
	{
	}

	private void EMQQIPHGLRL()
	{
	}

	public int GetSubSize()
	{
		return 0;
	}

	private void TTTKHLHPLHL()
	{
	}

	public int GetTimeLeft()
	{
		return 0;
	}
}
