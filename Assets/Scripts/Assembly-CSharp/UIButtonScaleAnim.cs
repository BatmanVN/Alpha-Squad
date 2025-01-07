using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIButtonScaleAnim : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerExitHandler, IPointerEnterHandler, IPointerClickHandler
{
	[SerializeField]
	public float scaleFrom;

	[SerializeField]
	public float scaleTo;

	[SerializeField]
	public float scaleTime;

	[SerializeField]
	private Ease ease;

	[SerializeField]
	private bool ignoreTimeScale;

	[SerializeField]
	private Transform target;

	[NonSerialized]
	public bool restartAnimation;

	private Tween OHMGIIEILOK;

	private bool EGENFOQSFMS;

	private Selectable GEFTMFNMRGR;

	public Selectable QFNQPJOKJFH => null;

	private void Awake()
	{
	}

	public void SetTarget(Transform OGFKHSKTHHR)
	{
	}

	public void OnPointerDown(PointerEventData QSSIJRMPEQF)
	{
	}

	public void OnPointerExit(PointerEventData QSSIJRMPEQF)
	{
	}

	public void OnPointerUp(PointerEventData QSSIJRMPEQF)
	{
	}

	public void OnPointerEnter(PointerEventData QSSIJRMPEQF)
	{
	}

	public void OnPointerClick(PointerEventData QSSIJRMPEQF)
	{
	}

	private void KTGOJOIHJGF(bool NRLORILTSJR = false)
	{
	}

	private void OnDisable()
	{
	}
}
