using UnityEngine;
using System;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
	public Sound[] sounds;
	void Awake()
	{
		foreach(Sound snd in sounds)
        {
			snd.source = gameObject.AddComponent<AudioSource>();
			snd.source.clip = snd.clip;
			snd.source.volume = snd.volume;
			snd.source.pitch = snd.pitch;
        }
	}

	public void Play(string name)
	{
		Sound snd = Array.Find(sounds, sound => sound.name == name);
		snd.source.Play();
	}
}
