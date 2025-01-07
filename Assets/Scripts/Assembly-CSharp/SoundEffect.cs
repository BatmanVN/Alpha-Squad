using UnityEngine;
using UnityEngine.Audio;

[CreateAssetMenu]
public class SoundEffect : ScriptableObject
{
	public enum GQKTROPGPJP
	{
		Random = 0,
		RandomNonLast = 1,
		SequentialAutoReset = 2,
		Cycle = 3
	}

	public enum FQEEKTTHOSO
	{
		None = 0,
		DontPlay = 1,
		RestartOldest = 2
	}

	[Space]
	[SerializeField]
	private bool muted;

	[Space]
	public AudioMixerGroup mixerAttach;

	[Space]
	public float volume;

	[Space]
	public float minDelay;

	public FQEEKTTHOSO concurrentLimit;

	public int maxConcurrentSounds;

	public float sequentialResetTime;

	public GQKTROPGPJP mode;

	[Space]
	[Space]
	public AudioClip[] clips;

	[Space]
	[Space]
	public bool looping;

	public bool pitchRange;

	public float pitch;

	public Vector2 pitchSlider;

	public bool playDelayed;

	public Vector2 playDelayedSlider;

	public int priority;

	[Space]
	public SoundSettings3D soundSettings3D;

	private int lastIndex;

	private float nextResetTime;

	private float lastPlayTime;

	[TextArea]
	[Space]
	public string importantNotes;

	private void OnEnable()
	{
	}

	public virtual AudioSource GQRGLOQHSES(float IFSHGQFFPGO = 1f)
	{
		return null;
	}

	public AudioSource GQRGLOQHSES(int PSPJIJNTMOI, float IFSHGQFFPGO = 1f)
	{
		return null;
	}

	public virtual void LGLKLLGENIP(Vector3 JSMLIQPPPQS, float IFSHGQFFPGO = 1f)
	{
	}

	private int LFNPFTNEJFE()
	{
		return 0;
	}

	public void KNNEKHJQGSP()
	{
	}
}
