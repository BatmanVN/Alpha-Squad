namespace UnityEngine.UI.Extensions
{
	public class ScrollRectLinker : MonoBehaviour
	{
		public bool clamp;

		[SerializeField]
		private ScrollRect controllingScrollRect;

		private ScrollRect scrollRect;

		private void Awake()
		{
		}

		private void MirrorPos(Vector2 scrollPos)
		{
		}
	}
}
