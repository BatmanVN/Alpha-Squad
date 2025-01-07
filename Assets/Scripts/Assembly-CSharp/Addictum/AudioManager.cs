using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace Addictum
{
	public class AudioManager : Singleton<AudioManager>
	{
		[Serializable]
		public class Data
		{
			public float soundVolume;

			public float musicVolume;
		}

		private const bool JLNOFEONPGF = false;

		public bool LogSfx;

		public Data data;

		public AudioSource[] music;

		public AudioMixer mixer;

		private GameObject RKHNHENGMLR;

		private List<AudioSource> GQFFJFGERLS;

		private List<AudioSource> OJHTNTKFHHR;

		private Dictionary<AudioSource, SoundEffect> ETFSSMLNISN;

		private Tween TOKORSHKQKI;

		private Tween GPKTHJMRJIL;

		private Tween EEJMHIKTELF;

		public float musicFadeVolume;

		public static string DATA_KEY;

		public float HGGOQGHTNRL => 0f;

		private void Awake()
		{
		}

		public void Summon()
		{
		}

		private void MLNESSGJRME()
		{
		}

		public void PostInit()
		{
		}

		private void KLJEPKORMLM()
		{
		}

		public void SaveData()
		{
		}

		public void SetSoundVolume(float PINIJSSSHFH)
		{
		}

		public void SetMusicVolume(float PINIJSSSHFH)
		{
		}

		private void PJKFMSKGIJJ()
		{
		}

		private void QOOSHRPSFJH()
		{
		}

		public float GetSoundVolume()
		{
			return 0f;
		}

		public AudioSource GetFreeAudioSource(SoundEffect TKJNMONEESI)
		{
			return null;
		}

		public bool IsBelowConcurrentLimit(SoundEffect TKJNMONEESI)
		{
			return false;
		}

		public AudioSource GetOldestSource(SoundEffect TKJNMONEESI)
		{
			return null;
		}

		public AudioSource GetFreeAudioSource3D(SoundEffect TKJNMONEESI)
		{
			return null;
		}

		public void StopAllSourcesOfEffect(SoundEffect TKJNMONEESI)
		{
		}

		private void MMMPKJOOLPJ(Scene SLRMLOOSEGG, LoadSceneMode ORGIERIGFRL)
		{
		}

		private void GMSNTJNILPM()
		{
		}

		public void FadeOutMusicTemporarily(float MKLLHHINHJP)
		{
		}

		public void FadeOutMusic(float MKLLHHINHJP)
		{
		}

		[CompilerGenerated]
		private void RLIPJLKIPKI(AudioSource JKRQSLILLQK)
		{
		}

		[CompilerGenerated]
		private float MRQLRPFFLRE()
		{
			return 0f;
		}

		[CompilerGenerated]
		private void MRQNKKSQFIQ(float HNLHQPIFJNS)
		{
		}

		[CompilerGenerated]
		private void MFQQRRFRHFR()
		{
		}

		[CompilerGenerated]
		private float RJSFNMNTLHM()
		{
			return 0f;
		}

		[CompilerGenerated]
		private void GKJQHRQHFMG(float HNLHQPIFJNS)
		{
		}

		[CompilerGenerated]
		private float ORKEMGORSEF()
		{
			return 0f;
		}

		[CompilerGenerated]
		private void JTFSGFHFSFT(float HNLHQPIFJNS)
		{
		}
	}
}
