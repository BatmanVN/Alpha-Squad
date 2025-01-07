using UnityEngine;

namespace EasyButtons
{
	[CreateAssetMenu]
	public class ScriptableObjectExample : ScriptableObject
	{
		[Button]
		public void SayHello()
		{
		}

		[Button]
		public void SayHelloEditor()
		{
		}

		[Button]
		public void SayHelloPlayMode()
		{
		}
	}
}
