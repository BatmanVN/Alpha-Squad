using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BossBehaviour : StateMachineBehaviour
{
	[Serializable]
	public struct ParameterActivation
	{
		public QLIPERELMEP type;

		public RETTSSRJJEF time;

		public string name;

		public int intValue;

		public float floatValue;

		public bool boolValue;

		public void JOGTEKPITLS(Animator HHRGQEQGGIS)
		{
		}
	}

	public enum QLIPERELMEP
	{
		TRIGGER = 0,
		BOOL = 1,
		INT = 2,
		FLOAT = 3
	}

	public enum RETTSSRJJEF
	{
		START = 0,
		END = 1
	}

	[CompilerGenerated]
	private sealed class SKGLIRLNTKS
	{
		public RETTSSRJJEF t;

		public BossBehaviour _003C_003E4__this;

		internal void _003CActivateParameters_003Eb__0(ParameterActivation activation)
		{
		}
	}

	protected Boss boss;

	protected Player player;

	protected Animator stateMachine;

	[SerializeField]
	private List<ParameterActivation> activations;

	protected virtual void GNEOPKJKRQM()
	{
	}

	protected virtual void PRLMELJHSHL()
	{
	}

	protected virtual void KTLQHNTNLFH()
	{
	}

	public override void OnStateEnter(Animator JFKTSHNOIKP, AnimatorStateInfo PEROTOFJNIQ, int JHHMTSJLTTF)
	{
	}

	public override void OnStateExit(Animator JFKTSHNOIKP, AnimatorStateInfo PEROTOFJNIQ, int JHHMTSJLTTF)
	{
	}

	public override void OnStateUpdate(Animator JFKTSHNOIKP, AnimatorStateInfo PEROTOFJNIQ, int JHHMTSJLTTF)
	{
	}

	private void NJPELJRLJSQ(Animator HHRGQEQGGIS)
	{
	}

	protected void FFFPPPQOEJI(RETTSSRJJEF OGFKHSKTHHR)
	{
	}
}
