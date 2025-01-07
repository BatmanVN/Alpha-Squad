using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace SayKitInternal
{
	public class UISayKitToast : MonoBehaviour
	{
		[SerializeField]
		private CanvasGroup uiCanvasGroup;

		[SerializeField]
		private VerticalLayoutGroup uiContentVerticalLayoutGroup;

		[SerializeField]
		private Image uiImage;

		[SerializeField]
		private Text uiText;

		[SerializeField]
		private float fadeDuration;

		private const int MaxTextLength = 300;

		private void Awake()
		{
		}

		public void Show(string text, float duration, Color color, ToastPosition position)
		{
		}

		private IEnumerator FadeInOut(float toastDuration, float fadeDuration)
		{
			return null;
		}

		private IEnumerator Fade(CanvasGroup cGroup, float startAlpha, float endAlpha, float fadeDuration)
		{
			return null;
		}

		public void Dismiss()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
