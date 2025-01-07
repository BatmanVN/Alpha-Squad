using System;
using System.Collections.Generic;
using UnityEngine;

public class GlobalAnnouncementPopup : UIPopup
{
	[Serializable]
	public struct NewsEntry
	{
		public string title;

		public string message;

		public int id;
	}

	[Serializable]
	public class Data
	{
		public List<int> seenIndexes;
	}

	[SerializeField]
	private Transform popup;

	[SerializeField]
	private CanvasGroup background;

	[SerializeField]
	private Transform layout;

	[SerializeField]
	private NewsItem newsItemPrefab;

	private static bool RSQRJNJLQLO;

	private static NewsEntry[] SOSLGOOOIPG;

	private static Data TSRPFHOJKSG;

	private static bool QOOPLGKOOLG;

	private static string JKPNPHQEOKN;

	public override void Show(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void SHOFGKIPPMR(bool KQGHGPEKKTJ = true)
	{
	}

	protected override void EMTTJFILJRJ(bool KQGHGPEKKTJ = true)
	{
	}

	private void NGHFQRREIJN()
	{
	}

	public void OnCloseButton()
	{
	}

	private static void PMITOIOJNOT()
	{
	}

	private static void MLNESSGJRME()
	{
	}

	public static bool ShouldShow()
	{
		return false;
	}
}
