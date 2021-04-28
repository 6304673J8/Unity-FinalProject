using System.Collections;
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
//SoundManager.PlaySound(SoundManager.Sound.Earthquake);