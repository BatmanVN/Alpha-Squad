using System;

namespace EasyButtons
{
	public sealed class ButtonAttribute : Attribute
	{
		private string name;

		private ButtonMode mode;

		public string Name => null;

		public ButtonMode Mode => default(ButtonMode);

		public ButtonAttribute()
		{
		}

		public ButtonAttribute(string name)
		{
		}

		public ButtonAttribute(string name, ButtonMode mode)
		{
		}

		public ButtonAttribute(ButtonMode mode)
		{
		}
	}
}
