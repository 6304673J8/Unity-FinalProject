using UnityEngine.Audio;
using System;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //Para usar: Aumentar el tamaño de "size" de sonidos en el objeto de sound manager en el inspector y arrastrar el sonido.
    //FindObjectOfType<SoundManager>().Play("NOMBRESONIDO"); Para reproducir un sonido desde otro script
    public Sound[] sounds;
    public static SoundManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
        }
    }

    
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }
}


/*
 * SOUND MANAGER ANTIGUO
 * using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Reflection;

public static class SoundManager {

    public enum Sound
    {
        Earthquake,
        Lunge,
        BrokenBarrel
    }

    public static void PlaySound(Sound sound)
    {
        GameObject soundGameObject = new GameObject("Sound");
        AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
        audioSource.PlayOneShot(GetAudioClip(sound));
    }

    private static AudioClip GetAudioClip (Sound sound)
    {
        foreach (GameAssets.SoundAudioClip soundAudioClip in GameAssets.i.soundAudioClipArray)
        {
            if(soundAudioClip.sound == sound)
            {
                return soundAudioClip.audioClip;
            }
        }
        Debug.LogError("No se encuentra el sonido " + sound);
        return null;
    }
}

//GameAssets.cs
public class GameAssets : MonoBehaviour {
    private static GameAssets _i;
    public static GameAssets i
    {
        get
        {
            if (_i == null) _i = Instantiate(Resources.Load<GameAssets>("GameAssets"));
            return _i;
        }
    }

    public SoundAudioClip[] soundAudioClipArray;

    [System.Serializable]
    public class SoundAudioClip
    {
        public SoundManager.Sound sound;
        public AudioClip audioClip;
    }

}
 
//En el script del sonido que se quiere reproducir:
//SoundManager.PlaySound(SoundManager.Sound.Earthquake);*/
