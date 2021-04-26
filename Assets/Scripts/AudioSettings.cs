using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSettings : MonoBehaviour {

    private static readonly string bgmPref = "bgmPref";
    private static readonly string sfxPref = "sfxPref";
    private float bgmFloat, sfxFloat;
    public AudioSource bgmAudio;
    public AudioSource[] sfxAudio;

    void Awake()
    {
        ContinueSettings();
    }

    private void ContinueSettings() {
        Debug.Log(bgmFloat + ": BGM");
        bgmFloat = PlayerPrefs.GetFloat(bgmPref);
        sfxFloat = PlayerPrefs.GetFloat(sfxPref);
        bgmAudio.volume = bgmFloat;
        for (int i = 0; i < sfxAudio.Length; i++)
        {
            Debug.Log(sfxFloat + ": SFX");
            sfxAudio[i].volume = sfxFloat;
        }
    }
}
