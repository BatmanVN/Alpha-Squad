using UnityEngine;

namespace EasyButtons
{
	public class ButtonsExample : MonoBehaviour
	{
		[Button]
		public void SayMyName()
		{
		}

		[Button]
		protected void SayHelloEditor()
		{
		}

		[Button]
		private void SayHelloInRuntime()
		{
		}

		[Button]
		private void TestButtonName()
		{
		}

		[Button]
		private void TestButtonNameEditorOnly()
		{
		}

		[Button]
		private static void TestStaticMethod()
		{
		}
	}
}
