using UnityEngine;
using System;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
	public Sound[] sounds;
	
	//On awake, set the properties to the sounds table
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

	//Play the specificated sound
	public void Play(string name)
	{
		Sound snd = Array.Find(sounds, sound => sound.name == name);
		snd.source.Play();
	}
}
